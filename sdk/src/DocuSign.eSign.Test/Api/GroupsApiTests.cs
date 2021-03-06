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
    ///  Class for testing GroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [NUnit.Framework.TestFixtureAttribute]
    public class GroupsApiTests
    {
        private GroupsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [NUnit.Framework.SetUpAttribute]
        public void Init()
        {
            instance = new GroupsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GroupsApi
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GroupsApi
            //NUnit.Framework.Assert.IsInstanceOf(typeof(GroupsApi), instance, "instance is a GroupsApi");
        }

        
        /// <summary>
        /// Test CreateGroups
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void CreateGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GroupInformation groupInformation = null;
            //string accountId = null;
            //var response = instance.CreateGroups(groupInformation, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<GroupInformation> (response, "response is GroupInformation");
        }
        
        /// <summary>
        /// Test DeleteBrands
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void DeleteBrandsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BrandsRequest brandsRequest = null;
            //string accountId = null;
            //string groupId = null;
            //var response = instance.DeleteBrands(brandsRequest, accountId, groupId);
            //NUnit.Framework.Assert.IsInstanceOf<BrandsResponse> (response, "response is BrandsResponse");
        }
        
        /// <summary>
        /// Test DeleteGroupUsers
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void DeleteGroupUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserInfoList userInfoList = null;
            //string accountId = null;
            //string groupId = null;
            //var response = instance.DeleteGroupUsers(userInfoList, accountId, groupId);
            //NUnit.Framework.Assert.IsInstanceOf<UsersResponse> (response, "response is UsersResponse");
        }
        
        /// <summary>
        /// Test DeleteGroups
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void DeleteGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GroupInformation groupInformation = null;
            //string accountId = null;
            //var response = instance.DeleteGroups(groupInformation, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<GroupInformation> (response, "response is GroupInformation");
        }
        
        /// <summary>
        /// Test GetBrands
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetBrandsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string groupId = null;
            //var response = instance.GetBrands(accountId, groupId);
            //NUnit.Framework.Assert.IsInstanceOf<BrandsResponse> (response, "response is BrandsResponse");
        }
        
        /// <summary>
        /// Test ListGroupUsers
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListGroupUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string count = null;
            //string startPosition = null;
            //string accountId = null;
            //string groupId = null;
            //var response = instance.ListGroupUsers(count, startPosition, accountId, groupId);
            //NUnit.Framework.Assert.IsInstanceOf<UsersResponse> (response, "response is UsersResponse");
        }
        
        /// <summary>
        /// Test ListGroups
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string count = null;
            //string groupName = null;
            //string groupType = null;
            //string searchText = null;
            //string startPosition = null;
            //string accountId = null;
            //var response = instance.ListGroups(count, groupName, groupType, searchText, startPosition, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<GroupInformation> (response, "response is GroupInformation");
        }
        
        /// <summary>
        /// Test UpdateBrands
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void UpdateBrandsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BrandsRequest brandsRequest = null;
            //string accountId = null;
            //string groupId = null;
            //var response = instance.UpdateBrands(brandsRequest, accountId, groupId);
            //NUnit.Framework.Assert.IsInstanceOf<BrandsResponse> (response, "response is BrandsResponse");
        }
        
        /// <summary>
        /// Test UpdateGroupUsers
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void UpdateGroupUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserInfoList userInfoList = null;
            //string accountId = null;
            //string groupId = null;
            //var response = instance.UpdateGroupUsers(userInfoList, accountId, groupId);
            //NUnit.Framework.Assert.IsInstanceOf<UsersResponse> (response, "response is UsersResponse");
        }
        
        /// <summary>
        /// Test UpdateGroups
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void UpdateGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GroupInformation groupInformation = null;
            //string accountId = null;
            //var response = instance.UpdateGroups(groupInformation, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<GroupInformation> (response, "response is GroupInformation");
        }
        
    }

}
