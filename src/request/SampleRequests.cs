using request.Model;
namespace request
{
    public class SampleRequests {

        public static request.Credit.Authorization sampleCreditAuthorization() {
        	request.Credit.Authorization authorizationRequest = new request.Credit.Authorization();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	authorizationRequest.Credentials = credentials;

			Reports reports = new Reports();
			reports.ReportGroup = "1243";
        	authorizationRequest.Reports = reports;

			Transaction transaction = new Transaction();
			transaction.ReferenceNumber = "1";
			transaction.TransactionAmount = "10.00";
			transaction.OrderSource = transaction.OrderSourceDict["ECOMMERCE"];
        	authorizationRequest.Transaction = transaction;

			Card card = new Card();
			card.CardNumber = "4457010000000009";
			card.ExpirationMonth = "01";
			card.ExpirationYear = "16";
			card.CVV = "349";
			card.Type = card.TypeDict["VI"];
        	authorizationRequest.Card = card;

			Application application = new Application();
			application.ApplicationID = "1234";
        	authorizationRequest.Application = application;

        	return authorizationRequest;
    	}

		public static request.Credit.Reversal sampleCreditReversal(string transactionID) {
        	request.Credit.Reversal reversalRequest = new request.Credit.Reversal();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	reversalRequest.Credentials = credentials;

			Reports reports = new Reports();
			reports.ReportGroup = "1243";
        	reversalRequest.Reports = reports;

			Transaction transaction = new Transaction();
			transaction.TransactionID = transactionID;
        	reversalRequest.Transaction = transaction;

			Application application = new Application();
			application.ApplicationID = "1234";
        	reversalRequest.Application = application;

        	return reversalRequest;
    	}

		public static request.Credit.AuthorizationCompletion sampleCreditAuthorizationCompletion(string transactionID) {
        	request.Credit.AuthorizationCompletion authorizationCompletionRequest = new request.Credit.AuthorizationCompletion();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	authorizationCompletionRequest.Credentials = credentials;

			Reports reports = new Reports();
			reports.ReportGroup = "1243";
        	authorizationCompletionRequest.Reports = reports;

			Transaction transaction = new Transaction();
			transaction.TransactionID = transactionID;
        	authorizationCompletionRequest.Transaction = transaction;

			Application application = new Application();
			application.ApplicationID = "1234";
        	authorizationCompletionRequest.Application = application;

        	return authorizationCompletionRequest;
    	}

		public static request.Credit.CaptureGivenAuth sampleCreditCaptureGivenAuth() {
        	request.Credit.CaptureGivenAuth captureGivenAuthRequest = new request.Credit.CaptureGivenAuth();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	captureGivenAuthRequest.Credentials = credentials;

			Reports reports = new Reports();
			reports.ReportGroup = "1243";
        	captureGivenAuthRequest.Reports = reports;

			Transaction transaction = new Transaction();
			transaction.ReferenceNumber = "1";
			transaction.TransactionAmount = "100.10";
			transaction.AuthorizationDate = "1111-11-11";
			transaction.ApprovalNumber = "1234";
			transaction.OrderSource = transaction.OrderSourceDict["ECOMMERCE"];
        	captureGivenAuthRequest.Transaction = transaction;

			Card card = new Card();
			card.CardNumber = "4457010000000009";
			card.ExpirationMonth = "01";
			card.ExpirationYear = "16";
			card.CVV = "349";
			card.Type = card.TypeDict["VI"];
        	captureGivenAuthRequest.Card = card;

			Application application = new Application();
			application.ApplicationID = "1234";
        	captureGivenAuthRequest.Application = application;

        	return captureGivenAuthRequest;
    	}

		public static request.Credit.Credit sampleCreditCredit(string transactionID) {
        	request.Credit.Credit creditRequest = new request.Credit.Credit();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	creditRequest.Credentials = credentials;

			Reports reports = new Reports();
			reports.ReportGroup = "1243";
        	creditRequest.Reports = reports;

			Transaction transaction = new Transaction();
			transaction.TransactionID = transactionID;
        	creditRequest.Transaction = transaction;

			Application application = new Application();
			application.ApplicationID = "1234";
        	creditRequest.Application = application;

        	return creditRequest;
    	}

		public static request.Credit.Force sampleCreditForce() {
        	request.Credit.Force forceRequest = new request.Credit.Force();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	forceRequest.Credentials = credentials;

			Reports reports = new Reports();
			reports.ReportGroup = "1243";
        	forceRequest.Reports = reports;

			Transaction transaction = new Transaction();
			transaction.ReferenceNumber = "1";
			transaction.TransactionAmount = "100.10";
			transaction.OrderSource = transaction.OrderSourceDict["ECOMMERCE"];
        	forceRequest.Transaction = transaction;

			Card card = new Card();
			card.CardNumber = "4457010000000009";
			card.ExpirationMonth = "01";
			card.ExpirationYear = "16";
			card.CVV = "349";
			card.Type = card.TypeDict["VI"];
        	forceRequest.Card = card;

			Application application = new Application();
			application.ApplicationID = "1234";
        	forceRequest.Application = application;

        	return forceRequest;
    	}

		public static request.Credit.Return sampleCreditReturn() {
        	request.Credit.Return returnRequest = new request.Credit.Return();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	returnRequest.Credentials = credentials;

			Reports reports = new Reports();
			reports.ReportGroup = "1243";
        	returnRequest.Reports = reports;

			Transaction transaction = new Transaction();
			transaction.ReferenceNumber = "123";
			transaction.TransactionAmount = "10.00";
			transaction.OrderSource = transaction.OrderSourceDict["ECOMMERCE"];
        	returnRequest.Transaction = transaction;

			Card card = new Card();
			card.CardNumber = "4457010000000009";
			card.ExpirationMonth = "01";
			card.ExpirationYear = "16";
			card.CVV = "349";
			card.Type = card.TypeDict["VI"];
        	returnRequest.Card = card;

			Application application = new Application();
			application.ApplicationID = "1234";
        	returnRequest.Application = application;

        	return returnRequest;
    	}

		public static request.Credit.Sale sampleCreditSale() {
        	request.Credit.Sale saleRequest = new request.Credit.Sale();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	saleRequest.Credentials = credentials;

			Reports reports = new Reports();
			reports.ReportGroup = "1243";
        	saleRequest.Reports = reports;

			Transaction transaction = new Transaction();
			transaction.ReferenceNumber = "1";
			transaction.TransactionAmount = "100.10";
			transaction.OrderSource = transaction.OrderSourceDict["ECOMMERCE"];
        	saleRequest.Transaction = transaction;

			Card card = new Card();
			card.CardNumber = "4457010000000009";
			card.ExpirationMonth = "01";
			card.ExpirationYear = "16";
			card.CVV = "349";
			card.Type = card.TypeDict["VI"];
        	saleRequest.Card = card;

			Application application = new Application();
			application.ApplicationID = "1234";
        	saleRequest.Application = application;

        	return saleRequest;
    	}

		public static request.Credit.Void sampleCreditVoid(string transactionID) {
        	request.Credit.Void voidRequest = new request.Credit.Void();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	voidRequest.Credentials = credentials;

			Reports reports = new Reports();
			reports.ReportGroup = "1243";
        	voidRequest.Reports = reports;

			Transaction transaction = new Transaction();
			transaction.TransactionID = transactionID;
        	voidRequest.Transaction = transaction;

			Application application = new Application();
			application.ApplicationID = "1234";
        	voidRequest.Application = application;

        	return voidRequest;
    	}


	public static request.Check.Credit sampleCheckCredit(string transactionID) {
        	request.Check.Credit creditRequest = new request.Check.Credit();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	creditRequest.Credentials = credentials;

			Transaction transaction = new Transaction();
			transaction.TransactionID = transactionID;
        	creditRequest.Transaction = transaction;

			Reports reports = new Reports();
			reports.ReportGroup = "1243";
        	creditRequest.Reports = reports;

			Application application = new Application();
			application.ApplicationID = "1234";
        	creditRequest.Application = application;

        	return creditRequest;
    	}

		public static request.Check.Return sampleCheckReturn() {
        	request.Check.Return returnRequest = new request.Check.Return();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	returnRequest.Credentials = credentials;

			Transaction transaction = new Transaction();
			transaction.ReferenceNumber = "708388073320126000";
			transaction.TransactionAmount = "12.56";
			transaction.OrderSource = transaction.OrderSourceDict["ECOMMERCE"];
        	returnRequest.Transaction = transaction;

			DemandDepositAccount demandDepositAccount = new DemandDepositAccount();
			demandDepositAccount.DDAAccountType = "Checking";
			demandDepositAccount.AccountNumber = "234";
			demandDepositAccount.RoutingNumber = "123234345";
			demandDepositAccount.CheckNumber = "456";
			demandDepositAccount.CCDPaymentInformation = "567";
        	returnRequest.DemandDepositAccount = demandDepositAccount;

			Address address = new Address();
			address.BillingName = "John Smith";
			address.BillingAddress1 = "1 Main St.";
			address.BillingCity = "Burlington";
			address.BillingState = "MA";
			address.BillingZipcode = "01803-3747";
			address.BillingEmail = "jdoe@litle.com";
			address.BillingPhone = "978-551-0040";
			address.BillingCountry = address.BillingCountryDict["USA"];
        	returnRequest.Address = address;

			Reports reports = new Reports();
			reports.ReportGroup = "1243";
        	returnRequest.Reports = reports;

			Application application = new Application();
			application.ApplicationID = "1234";
        	returnRequest.Application = application;

        	return returnRequest;
    	}

		public static request.Check.Sale sampleCheckSale() {
        	request.Check.Sale saleRequest = new request.Check.Sale();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	saleRequest.Credentials = credentials;

			Transaction transaction = new Transaction();
			transaction.ReferenceNumber = "1";
			transaction.TransactionAmount = "100.10";
			transaction.OrderSource = transaction.OrderSourceDict["ECOMMERCE"];
        	saleRequest.Transaction = transaction;

			Address address = new Address();
			address.BillingName = "John Smith";
			address.BillingAddress1 = "1 Main St.";
			address.BillingCity = "Burlington";
			address.BillingState = "MA";
			address.BillingZipcode = "01803-3747";
			address.BillingEmail = "jdoe@litle.com";
			address.BillingPhone = "978-551-0040";
			address.BillingCountry = address.BillingCountryDict["USA"];
        	saleRequest.Address = address;

			DemandDepositAccount demandDepositAccount = new DemandDepositAccount();
			demandDepositAccount.RoutingNumber = "123234345";
			demandDepositAccount.DDAAccountType = "Checking";
			demandDepositAccount.CheckNumber = "456";
        	saleRequest.DemandDepositAccount = demandDepositAccount;

			PaymentAccount paymentAccount = new PaymentAccount();
			paymentAccount.PaymentAccountID = "1232343454565";
        	saleRequest.PaymentAccount = paymentAccount;

			Reports reports = new Reports();
			reports.ReportGroup = "1243";
        	saleRequest.Reports = reports;

			Application application = new Application();
			application.ApplicationID = "1234";
        	saleRequest.Application = application;

        	return saleRequest;
    	}

		public static request.Check.Verification sampleCheckVerification() {
        	request.Check.Verification verificationRequest = new request.Check.Verification();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	verificationRequest.Credentials = credentials;

			Transaction transaction = new Transaction();
			transaction.ReferenceNumber = "1";
			transaction.TransactionAmount = "100.10";
			transaction.OrderSource = transaction.OrderSourceDict["ECOMMERCE"];
        	verificationRequest.Transaction = transaction;

			Address address = new Address();
			address.BillingName = "John Smith";
			address.BillingAddress1 = "1 Main St.";
			address.BillingCity = "Burlington";
			address.BillingState = "MA";
			address.BillingZipcode = "01803-3747";
			address.BillingEmail = "jdoe@litle.com";
			address.BillingPhone = "978-551-0040";
			address.BillingCountry = address.BillingCountryDict["USA"];
        	verificationRequest.Address = address;

			DemandDepositAccount demandDepositAccount = new DemandDepositAccount();
			demandDepositAccount.DDAAccountType = "Checking";
			demandDepositAccount.AccountNumber = "234";
			demandDepositAccount.RoutingNumber = "123234345";
			demandDepositAccount.CheckNumber = "456";
			demandDepositAccount.CCDPaymentInformation = "567";
        	verificationRequest.DemandDepositAccount = demandDepositAccount;

			Reports reports = new Reports();
			reports.ReportGroup = "1243";
        	verificationRequest.Reports = reports;

			Application application = new Application();
			application.ApplicationID = "1234";
        	verificationRequest.Application = application;

        	return verificationRequest;
    	}

		public static request.Check.Void sampleCheckVoid(string transactionID) {
        	request.Check.Void voidRequest = new request.Check.Void();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	voidRequest.Credentials = credentials;

			Transaction transaction = new Transaction();
			transaction.TransactionID = transactionID;
        	voidRequest.Transaction = transaction;

			Reports reports = new Reports();
			reports.ReportGroup = "1243";
        	voidRequest.Reports = reports;

			Application application = new Application();
			application.ApplicationID = "1234";
        	voidRequest.Application = application;

        	return voidRequest;
    	}


	public static request.Services.CreatePlan sampleServicesCreatePlan() {
        	request.Services.CreatePlan createPlanRequest = new request.Services.CreatePlan();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	createPlanRequest.Credentials = credentials;

			ScheduledTask scheduledTask = new ScheduledTask();
			scheduledTask.Active = "true";
			scheduledTask.ScheduledTaskID = "12";
			scheduledTask.Name = "NewPlan";
			scheduledTask.Description = "Created New Plan";
			scheduledTask.RunFrequency = "WEEKLY";
			scheduledTask.Amount = "12.00";
			scheduledTask.RunCycles = "5";
			scheduledTask.TrialRunCycles = "7";
			scheduledTask.TrialRunFrequency = "DAY";
        	createPlanRequest.ScheduledTask = scheduledTask;

        	return createPlanRequest;
    	}

		public static request.Services.FraudCheck sampleServicesFraudCheck() {
        	request.Services.FraudCheck fraudCheckRequest = new request.Services.FraudCheck();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	fraudCheckRequest.Credentials = credentials;

			Reports reports = new Reports();
			reports.ReportGroup = "1243";
        	fraudCheckRequest.Reports = reports;

			AdvancedFraudChecks advancedFraudChecks = new AdvancedFraudChecks();
			advancedFraudChecks.ThreatMetrixSessionID = "123";
        	fraudCheckRequest.AdvancedFraudChecks = advancedFraudChecks;

			Application application = new Application();
			application.ApplicationID = "1234";
        	fraudCheckRequest.Application = application;

        	return fraudCheckRequest;
    	}

		public static request.Services.PaymentAccountCreate sampleServicesPaymentAccountCreate() {
        	request.Services.PaymentAccountCreate paymentAccountCreateRequest = new request.Services.PaymentAccountCreate();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	paymentAccountCreateRequest.Credentials = credentials;

			Reports reports = new Reports();
			reports.ReportGroup = "1243";
        	paymentAccountCreateRequest.Reports = reports;

			Card card = new Card();
			card.AccountNumber = "5454545454545454";
        	paymentAccountCreateRequest.Card = card;

			Application application = new Application();
			application.ApplicationID = "1234";
        	paymentAccountCreateRequest.Application = application;

        	return paymentAccountCreateRequest;
    	}

		public static request.Services.ScheduledTaskDelete sampleServicesScheduledTaskDelete() {
        	request.Services.ScheduledTaskDelete scheduledTaskDeleteRequest = new request.Services.ScheduledTaskDelete();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	scheduledTaskDeleteRequest.Credentials = credentials;

			ScheduledTask scheduledTask = new ScheduledTask();
			scheduledTask.SubscriptionID = "12432463563564";
        	scheduledTaskDeleteRequest.ScheduledTask = scheduledTask;

        	return scheduledTaskDeleteRequest;
    	}

		public static request.Services.ScheduledTaskUpdate sampleServicesScheduledTaskUpdate() {
        	request.Services.ScheduledTaskUpdate scheduledTaskUpdateRequest = new request.Services.ScheduledTaskUpdate();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	scheduledTaskUpdateRequest.Credentials = credentials;

			ScheduledTask scheduledTask = new ScheduledTask();
			scheduledTask.SubscriptionID = "12432463563564";
			scheduledTask.BillingDate = "2019-10-21";
        	scheduledTaskUpdateRequest.ScheduledTask = scheduledTask;

        	return scheduledTaskUpdateRequest;
    	}

		public static request.Services.PaymentAccountUpdate sampleServicesPaymentAccountUpdate() {
        	request.Services.PaymentAccountUpdate paymentAccountUpdateRequest = new request.Services.PaymentAccountUpdate();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	paymentAccountUpdateRequest.Credentials = credentials;

			Reports reports = new Reports();
			reports.ReportGroup = "1243";
        	paymentAccountUpdateRequest.Reports = reports;

			Card card = new Card();
			card.CVV = "123";
        	paymentAccountUpdateRequest.Card = card;

			Application application = new Application();
			application.ApplicationID = "1234";
        	paymentAccountUpdateRequest.Application = application;

			PaymentAccount paymentAccount = new PaymentAccount();
			paymentAccount.PaymentAccountID = "1112000188575454";
        	paymentAccountUpdateRequest.PaymentAccount = paymentAccount;

        	return paymentAccountUpdateRequest;
    	}

		public static request.Services.UpdatePlan sampleServicesUpdatePlan() {
        	request.Services.UpdatePlan updatePlanRequest = new request.Services.UpdatePlan();

        	Credentials credentials = new Credentials();
			credentials.AcceptorID = "1147003";
        	updatePlanRequest.Credentials = credentials;

			ScheduledTask scheduledTask = new ScheduledTask();
			scheduledTask.Active = "false";
			scheduledTask.ScheduledTaskID = "12";
        	updatePlanRequest.ScheduledTask = scheduledTask;

        	return updatePlanRequest;
    	}

    }
}