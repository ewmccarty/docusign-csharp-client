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
    ///  Class for testing CloudStorageApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [NUnit.Framework.TestFixtureAttribute]
    public class CloudStorageApiTests
    {
        private CloudStorageApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [NUnit.Framework.SetUpAttribute]
        public void Init()
        {
            instance = new CloudStorageApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CloudStorageApi
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CloudStorageApi
            //NUnit.Framework.Assert.IsInstanceOf(typeof(CloudStorageApi), instance, "instance is a CloudStorageApi");
        }

        
        /// <summary>
        /// Test CreateProvider
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void CreateProviderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CloudStorageProviders cloudStorageProviders = null;
            //string accountId = null;
            //string userId = null;
            //var response = instance.CreateProvider(cloudStorageProviders, accountId, userId);
            //NUnit.Framework.Assert.IsInstanceOf<CloudStorageProviders> (response, "response is CloudStorageProviders");
        }
        
        /// <summary>
        /// Test DeleteProvider
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void DeleteProviderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string userId = null;
            //string serviceId = null;
            //var response = instance.DeleteProvider(accountId, userId, serviceId);
            //NUnit.Framework.Assert.IsInstanceOf<CloudStorageProviders> (response, "response is CloudStorageProviders");
        }
        
        /// <summary>
        /// Test DeleteProviders
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void DeleteProvidersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CloudStorageProviders cloudStorageProviders = null;
            //string accountId = null;
            //string userId = null;
            //var response = instance.DeleteProviders(cloudStorageProviders, accountId, userId);
            //NUnit.Framework.Assert.IsInstanceOf<CloudStorageProviders> (response, "response is CloudStorageProviders");
        }
        
        /// <summary>
        /// Test GetProvider
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetProviderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string redirectUrl = null;
            //string accountId = null;
            //string userId = null;
            //string serviceId = null;
            //var response = instance.GetProvider(redirectUrl, accountId, userId, serviceId);
            //NUnit.Framework.Assert.IsInstanceOf<CloudStorageProviders> (response, "response is CloudStorageProviders");
        }
        
        /// <summary>
        /// Test List
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cloudStorageFolderPath = null;
            //string count = null;
            //string order = null;
            //string orderBy = null;
            //string searchText = null;
            //string startPosition = null;
            //string accountId = null;
            //string userId = null;
            //string serviceId = null;
            //string folderId = null;
            //var response = instance.List(cloudStorageFolderPath, count, order, orderBy, searchText, startPosition, accountId, userId, serviceId, folderId);
            //NUnit.Framework.Assert.IsInstanceOf<ExternalFolder> (response, "response is ExternalFolder");
        }
        
        /// <summary>
        /// Test ListFolders
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListFoldersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cloudStorageFolderPath = null;
            //string count = null;
            //string order = null;
            //string orderBy = null;
            //string searchText = null;
            //string startPosition = null;
            //string accountId = null;
            //string userId = null;
            //string serviceId = null;
            //var response = instance.ListFolders(cloudStorageFolderPath, count, order, orderBy, searchText, startPosition, accountId, userId, serviceId);
            //NUnit.Framework.Assert.IsInstanceOf<ExternalFolder> (response, "response is ExternalFolder");
        }
        
        /// <summary>
        /// Test ListProviders
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListProvidersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string redirectUrl = null;
            //string accountId = null;
            //string userId = null;
            //var response = instance.ListProviders(redirectUrl, accountId, userId);
            //NUnit.Framework.Assert.IsInstanceOf<CloudStorageProviders> (response, "response is CloudStorageProviders");
        }
        
    }

}