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
    ///  Class for testing SigningGroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [NUnit.Framework.TestFixtureAttribute]
    public class SigningGroupsApiTests
    {
        private SigningGroupsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [NUnit.Framework.SetUpAttribute]
        public void Init()
        {
            instance = new SigningGroupsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SigningGroupsApi
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SigningGroupsApi
            //NUnit.Framework.Assert.IsInstanceOf(typeof(SigningGroupsApi), instance, "instance is a SigningGroupsApi");
        }

        
        /// <summary>
        /// Test CreateList
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void CreateListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SigningGroupInformation signingGroupInformation = null;
            //string accountId = null;
            //var response = instance.CreateList(signingGroupInformation, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<SigningGroupInformation> (response, "response is SigningGroupInformation");
        }
        
        /// <summary>
        /// Test DeleteList
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void DeleteListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SigningGroupInformation signingGroupInformation = null;
            //string accountId = null;
            //var response = instance.DeleteList(signingGroupInformation, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<SigningGroupInformation> (response, "response is SigningGroupInformation");
        }
        
        /// <summary>
        /// Test DeleteUsers
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void DeleteUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SigningGroupUsers signingGroupUsers = null;
            //string accountId = null;
            //string signingGroupId = null;
            //var response = instance.DeleteUsers(signingGroupUsers, accountId, signingGroupId);
            //NUnit.Framework.Assert.IsInstanceOf<SigningGroupUsers> (response, "response is SigningGroupUsers");
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string signingGroupId = null;
            //var response = instance.Get(accountId, signingGroupId);
            //NUnit.Framework.Assert.IsInstanceOf<SigningGroup> (response, "response is SigningGroup");
        }
        
        /// <summary>
        /// Test List
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupType = null;
            //string includeUsers = null;
            //string accountId = null;
            //var response = instance.List(groupType, includeUsers, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<SigningGroupInformation> (response, "response is SigningGroupInformation");
        }
        
        /// <summary>
        /// Test ListUsers
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string signingGroupId = null;
            //var response = instance.ListUsers(accountId, signingGroupId);
            //NUnit.Framework.Assert.IsInstanceOf<SigningGroupUsers> (response, "response is SigningGroupUsers");
        }
        
        /// <summary>
        /// Test Update
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SigningGroup signingGroup = null;
            //string accountId = null;
            //string signingGroupId = null;
            //var response = instance.Update(signingGroup, accountId, signingGroupId);
            //NUnit.Framework.Assert.IsInstanceOf<SigningGroup> (response, "response is SigningGroup");
        }
        
        /// <summary>
        /// Test UpdateList
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void UpdateListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SigningGroupInformation signingGroupInformation = null;
            //string accountId = null;
            //var response = instance.UpdateList(signingGroupInformation, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<SigningGroupInformation> (response, "response is SigningGroupInformation");
        }
        
        /// <summary>
        /// Test UpdateUsers
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void UpdateUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SigningGroupUsers signingGroupUsers = null;
            //string accountId = null;
            //string signingGroupId = null;
            //var response = instance.UpdateUsers(signingGroupUsers, accountId, signingGroupId);
            //NUnit.Framework.Assert.IsInstanceOf<SigningGroupUsers> (response, "response is SigningGroupUsers");
        }
        
    }

}
