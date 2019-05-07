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
    ///  Class for testing CustomTabsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [NUnit.Framework.TestFixtureAttribute]
    public class CustomTabsApiTests
    {
        private CustomTabsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [NUnit.Framework.SetUpAttribute]
        public void Init()
        {
            instance = new CustomTabsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CustomTabsApi
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CustomTabsApi
            //NUnit.Framework.Assert.IsInstanceOf(typeof(CustomTabsApi), instance, "instance is a CustomTabsApi");
        }

        
        /// <summary>
        /// Test Create
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TabMetadata tabMetadata = null;
            //string accountId = null;
            //var response = instance.Create(tabMetadata, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<TabMetadata> (response, "response is TabMetadata");
        }
        
        /// <summary>
        /// Test Delete
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string customTabId = null;
            //instance.Delete(accountId, customTabId);
            
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string customTabId = null;
            //var response = instance.Get(accountId, customTabId);
            //NUnit.Framework.Assert.IsInstanceOf<TabMetadata> (response, "response is TabMetadata");
        }
        
        /// <summary>
        /// Test List
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customTabOnly = null;
            //string accountId = null;
            //var response = instance.List(customTabOnly, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<TabMetadataList> (response, "response is TabMetadataList");
        }
        
        /// <summary>
        /// Test Update
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TabMetadata tabMetadata = null;
            //string accountId = null;
            //string customTabId = null;
            //var response = instance.Update(tabMetadata, accountId, customTabId);
            //NUnit.Framework.Assert.IsInstanceOf<TabMetadata> (response, "response is TabMetadata");
        }
        
    }

}
