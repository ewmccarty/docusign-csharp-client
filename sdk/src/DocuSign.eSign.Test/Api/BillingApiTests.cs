/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using DocuSign.eSign.Client;
using DocuSign.eSign.Api;
using DocuSign.eSign.Model;

namespace DocuSign.eSign.Test
{
    /// <summary>
    ///  Class for testing BillingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [NUnit.Framework.TestFixtureAttribute]
    public class BillingApiTests
    {
        private BillingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [NUnit.Framework.SetUpAttribute]
        public void Init()
        {
            instance = new BillingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BillingApi
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BillingApi
            //NUnit.Framework.Assert.IsInstanceOf(typeof(BillingApi), instance, "instance is a BillingApi");
        }

        
        /// <summary>
        /// Test GetBillingPlan
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetBillingPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string billingPlanId = null;
            //var response = instance.GetBillingPlan(billingPlanId);
            //NUnit.Framework.Assert.IsInstanceOf<BillingPlanResponse> (response, "response is BillingPlanResponse");
        }
        
        /// <summary>
        /// Test GetInvoice
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string invoiceId = null;
            //var response = instance.GetInvoice(accountId, invoiceId);
            //NUnit.Framework.Assert.IsInstanceOf<BillingInvoice> (response, "response is BillingInvoice");
        }
        
        /// <summary>
        /// Test GetPayment
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetPaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string paymentId = null;
            //var response = instance.GetPayment(accountId, paymentId);
            //NUnit.Framework.Assert.IsInstanceOf<BillingPaymentItem> (response, "response is BillingPaymentItem");
        }
        
        /// <summary>
        /// Test GetPlan
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string includeCreditCardInformation = null;
            //string includeMetadata = null;
            //string includeSuccessorPlans = null;
            //string accountId = null;
            //var response = instance.GetPlan(includeCreditCardInformation, includeMetadata, includeSuccessorPlans, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<AccountBillingPlanResponse> (response, "response is AccountBillingPlanResponse");
        }
        
        /// <summary>
        /// Test ListBillingPlans
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListBillingPlansTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListBillingPlans();
            //NUnit.Framework.Assert.IsInstanceOf<BillingPlansResponse> (response, "response is BillingPlansResponse");
        }
        
        /// <summary>
        /// Test ListInvoices
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListInvoicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fromDate = null;
            //string toDate = null;
            //string accountId = null;
            //var response = instance.ListInvoices(fromDate, toDate, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<BillingInvoicesResponse> (response, "response is BillingInvoicesResponse");
        }
        
        /// <summary>
        /// Test ListInvoicesPastDue
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListInvoicesPastDueTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //var response = instance.ListInvoicesPastDue(accountId);
            //NUnit.Framework.Assert.IsInstanceOf<BillingInvoicesSummary> (response, "response is BillingInvoicesSummary");
        }
        
        /// <summary>
        /// Test ListPayments
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListPaymentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fromDate = null;
            //string toDate = null;
            //string accountId = null;
            //var response = instance.ListPayments(fromDate, toDate, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<BillingPaymentsResponse> (response, "response is BillingPaymentsResponse");
        }
        
        /// <summary>
        /// Test MakePayment
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void MakePaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BillingPaymentRequest billingPaymentRequest = null;
            //string accountId = null;
            //var response = instance.MakePayment(billingPaymentRequest, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<BillingPaymentResponse> (response, "response is BillingPaymentResponse");
        }
        
        /// <summary>
        /// Test PurchaseEnvelopes
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void PurchaseEnvelopesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PurchasedEnvelopesInformation purchasedEnvelopesInformation = null;
            //string accountId = null;
            //instance.PurchaseEnvelopes(purchasedEnvelopesInformation, accountId);
            
        }
        
        /// <summary>
        /// Test UpdatePlan
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void UpdatePlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string previewBillingPlan = null;
            //BillingPlanInformation billingPlanInformation = null;
            //string accountId = null;
            //var response = instance.UpdatePlan(previewBillingPlan, billingPlanInformation, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<BillingPlanUpdateResponse> (response, "response is BillingPlanUpdateResponse");
        }
        
    }

}
