using System.Net;

namespace request
{
    public class Test {

        public static void Main(string[] args) {

            //------------------------CONFIGURE THE API------------------------//

            // Config.license = "Enter your Vantiv license here"; // !!! REQUIRED !!!

            //   - The rest are all optional...

            // Config.baseEndpoint = "apis.cert.vantiv.com"; //this is the default
            // Config.version = 1; //this is the default value

            //   - If your company has a proxy, set the proxy object and if it uses authentication, base64 encode your username and password
            // Config.proxy = new WebProxy("example.example.com", 8080); //sample proxy setting
            // Config.proxyAuth = "dXNlcm5hbWU6cGFzc3dvcmQ="; //Base64Encoded("username:password")

            //   - For debugging
            // Config.printRequest = true;
            // Config.printResponse = true;
            // Config.doNotSend = true; // if set to true, request.send() will return the request string and will not send the transaction

            //^^^^^^^^^^^^^^^^^^^^^^^^CONFIGURE THE API^^^^^^^^^^^^^^^^^^^^^^^^//

            //   Uncomment the sample transaction below that you would like to test

            //  CREDIT
            // sampleCreditAuthorization();
            // sampleCreditAuthorizationCompletion();
            // sampleCreditCaptureGivenAuth();
            // sampleCreditCredit();
            // sampleCreditForce();
            // sampleCreditReturn();
            // sampleCreditReversal();
            // sampleCreditSale();
            // sampleCreditVoid();

            //  DEBIT
            // sampleCheckCredit();
            // sampleCheckReturn();
            // sampleCheckSale();
            // sampleCheckVerification();
            // sampleCheckVoid();

            //  SERVICES
            // sampleCreatePlan();
            // sampleFraudCheck();
            // samplePaymentAccountCreate();
            // sampleScheduledTaskDelete();
            // sampleScheduledTaskUpdate();
            // samplePaymentAccountUpdate();
            // sampleUpdatePlan();

        }

        public static string sampleCreditAuthorization() {
            request.Credit.Authorization authorization = SampleRequests.sampleCreditAuthorization();
            string response = authorization.send();
            return response;
        }

        public static string sampleCreditAuthorizationCompletion() {
            request.Credit.Authorization authorization = SampleRequests.sampleCreditAuthorization();
            string response = authorization.send();
            string transactionID = Utilities.getTransactionID(response);

            if (transactionID != null) {
                request.Credit.AuthorizationCompletion authorizationCompletion = SampleRequests.sampleCreditAuthorizationCompletion(transactionID);
                response = authorizationCompletion.send();
                return response;
            }
            System.Console.WriteLine("Authorization failed. Cannot perform Authorization Completion transaction");
            return null;
        }

        public static string sampleCreditCaptureGivenAuth() {
            request.Credit.CaptureGivenAuth captureGivenAuth = SampleRequests.sampleCreditCaptureGivenAuth();
            string response = captureGivenAuth.send();
            return response;
        }

        public static string sampleCreditCredit() {
            request.Credit.Sale sale = SampleRequests.sampleCreditSale();
            string response = sale.send();
            string transactionID = Utilities.getTransactionID(response);

            if (transactionID != null) {
                request.Credit.Credit credit = SampleRequests.sampleCreditCredit(transactionID);
                response = credit.send();
                return response;
            }
            System.Console.WriteLine("Sale failed. Cannot perform Credit transaction");
            return null;
        }

        public static string sampleCreditForce() {
            request.Credit.Force force = SampleRequests.sampleCreditForce();
            string response = force.send();
            return response;
        }

        public static string sampleCreditReturn() {
            request.Credit.Return return_ = SampleRequests.sampleCreditReturn();
            string response = return_.send();
            return response;
        }

        public static string sampleCreditReversal() {
            request.Credit.Authorization authorization = SampleRequests.sampleCreditAuthorization();
            string response = authorization.send();
            string transactionID = Utilities.getTransactionID(response);

            if (transactionID != null) {
                request.Credit.Reversal reversal = SampleRequests.sampleCreditReversal(transactionID);
                response = reversal.send();
                return response;
            }
            System.Console.WriteLine("Authorization failed. Cannot perform Reversal transaction");
            return null;
        }

        public static string sampleCreditSale() {
            request.Credit.Sale sale = SampleRequests.sampleCreditSale();
            string response = sale.send();
            return response;
        }

        public static string sampleCreditVoid() {
            request.Credit.Sale sale = SampleRequests.sampleCreditSale();
            string response = sale.send();
            string transactionID = Utilities.getTransactionID(response);

            if (transactionID != null) {
                request.Credit.Void void_ = SampleRequests.sampleCreditVoid(transactionID);
                response = void_.send();
                return response;
            }
            System.Console.WriteLine("Sale failed. Cannot perform Void transaction");
            return null;
        }


        public static string sampleCheckCredit() {
            request.Check.Sale sale = SampleRequests.sampleCheckSale();
            string response = sale.send();
            string transactionID = Utilities.getTransactionID(response);

            if (transactionID != null) {
                request.Check.Credit credit = SampleRequests.sampleCheckCredit(transactionID);
                response = credit.send();
                return response;
            }
            System.Console.WriteLine("Sale failed. Cannot perform Credit transaction");
            return null;
        }

        public static string sampleCheckReturn() {
            request.Check.Return return_ = SampleRequests.sampleCheckReturn();
            string response = return_.send();
            return response;
        }

        public static string sampleCheckSale() {
            request.Check.Sale sale = SampleRequests.sampleCheckSale();
            string response = sale.send();
            return response;
        }

        public static string sampleCheckVerification() {
            request.Check.Verification verification = SampleRequests.sampleCheckVerification();
            string response = verification.send();
            return response;
        }

        public static string sampleCheckVoid() {
            request.Check.Sale sale = SampleRequests.sampleCheckSale();
            string response = sale.send();
            string transactionID = Utilities.getTransactionID(response);

            if (transactionID != null) {
                request.Check.Void void_ = SampleRequests.sampleCheckVoid(transactionID);
                response = void_.send();
                return response;
            }
            System.Console.WriteLine("Sale failed. Cannot perform Void transaction");
            return null;
        }


        public static string sampleCreatePlan() {
            request.Services.CreatePlan createPlan = SampleRequests.sampleServicesCreatePlan();
            string response = createPlan.send();
            return response;
        }

        public static string sampleFraudCheck() {
            request.Services.FraudCheck fraudCheck = SampleRequests.sampleServicesFraudCheck();
            string response = fraudCheck.send();
            return response;
        }

        public static string samplePaymentAccountCreate() {
            request.Services.PaymentAccountCreate paymentAccountCreate = SampleRequests.sampleServicesPaymentAccountCreate();
            string response = paymentAccountCreate.send();
            return response;
        }

        public static string sampleScheduledTaskDelete() {
            request.Services.ScheduledTaskDelete scheduledTaskDelete = SampleRequests.sampleServicesScheduledTaskDelete();
            string response = scheduledTaskDelete.send();
            return response;
        }

        public static string sampleScheduledTaskUpdate() {
            request.Services.ScheduledTaskUpdate scheduledTaskUpdate = SampleRequests.sampleServicesScheduledTaskUpdate();
            string response = scheduledTaskUpdate.send();
            return response;
        }

        public static string samplePaymentAccountUpdate() {
            request.Services.PaymentAccountUpdate paymentAccountUpdate = SampleRequests.sampleServicesPaymentAccountUpdate();
            string response = paymentAccountUpdate.send();
            return response;
        }

        public static string sampleUpdatePlan() {
            request.Services.UpdatePlan updatePlan = SampleRequests.sampleServicesUpdatePlan();
            string response = updatePlan.send();
            return response;
        }

    }
}