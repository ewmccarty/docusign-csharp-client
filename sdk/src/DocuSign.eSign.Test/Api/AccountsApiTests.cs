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
    ///  Class for testing AccountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [NUnit.Framework.TestFixtureAttribute]
    public class AccountsApiTests
    {
        private AccountsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [NUnit.Framework.SetUpAttribute]
        public void Init()
        {
            instance = new AccountsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [NUnit.Framework.TearDownAttribute]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AccountsApi 
        /// test 'IsInstanceOfType' AccountsApi
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void InstanceTest()
        {
            NUnit.Framework.Assert.IsInstanceOf(typeof(AccountsApi), instance, "instance is a AccountsApi");
        }

        
        /// <summary>
        /// test the method and replace null with proper value
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void CreateTest()
        {
            var previewBillingPlan = new AccountsApi.CreateOptions(){ previewBillingPlan = "true"};
            var newAccountDefinition = new NewAccountDefinition();
            var response = instance.Create(newAccountDefinition, previewBillingPlan);
            NUnit.Framework.Assert.IsInstanceOf<NewAccountSummary>(response, "response is NewAccountSummary");
        }
        
        /// <summary>
        /// Test CreateBrand 
        /// test the method and replace null with proper value
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void CreateBrandTest()
        {
            Brand brand = new Brand();
            brand.BrandCompany = "Walker Engineering, Inc.";
            brand.BrandName = "WEI";
            string accountId = "8290264" /* developer */;
            var response = instance.CreateBrand(accountId, brand);
            NUnit.Framework.Assert.IsInstanceOf<BrandsResponse>(response, "response is BrandsResponse");
        }
        
        /// <summary>
        /// Test CreateEMortgageTransaction
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void CreateEMortgageTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostTransactionsRequest postTransactionsRequest = null;
            //string accountId = null;
            //var response = instance.CreateEMortgageTransaction(postTransactionsRequest, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<PostTransactionsResponse> (response, "response is PostTransactionsResponse");
        }
        
        /// <summary>
        /// Test CreatePermissionProfile
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void CreatePermissionProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string include = null;
            //PermissionProfile permissionProfile = null;
            //string accountId = null;
            //var response = instance.CreatePermissionProfile(include, permissionProfile, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<PermissionProfile> (response, "response is PermissionProfile");
        }
        
        /// <summary>
        /// Test Delete
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //instance.Delete(accountId);
            
        }
        
        /// <summary>
        /// Test DeleteBrand
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void DeleteBrandTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //instance.DeleteBrand(accountId, brandId);
            
        }
        
        /// <summary>
        /// Test DeleteBrandLogoByType
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void DeleteBrandLogoByTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //string logoType = null;
            //instance.DeleteBrandLogoByType(accountId, brandId, logoType);
            
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
            //var response = instance.DeleteBrands(brandsRequest, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<BrandsResponse> (response, "response is BrandsResponse");
        }
        
        /// <summary>
        /// Test DeleteCaptiveRecipient
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void DeleteCaptiveRecipientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CaptiveRecipientInformation captiveRecipientInformation = null;
            //string accountId = null;
            //string recipientPart = null;
            //var response = instance.DeleteCaptiveRecipient(captiveRecipientInformation, accountId, recipientPart);
            //NUnit.Framework.Assert.IsInstanceOf<CaptiveRecipientInformation> (response, "response is CaptiveRecipientInformation");
        }
        
        /// <summary>
        /// Test DeleteENoteConfiguration
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void DeleteENoteConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //instance.DeleteENoteConfiguration(accountId);
            
        }
        
        /// <summary>
        /// Test DeletePermissionProfile
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void DeletePermissionProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string permissionProfileId = null;
            //instance.DeletePermissionProfile(accountId, permissionProfileId);
            
        }
        
        /// <summary>
        /// Test GetAccountInformation
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetAccountInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string includeAccountSettings = null;
            //string accountId = null;
            //var response = instance.GetAccountInformation(includeAccountSettings, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<AccountInformation> (response, "response is AccountInformation");
        }
        
        /// <summary>
        /// Test GetAccountTabSettings
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetAccountTabSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //var response = instance.GetAccountTabSettings(accountId);
            //NUnit.Framework.Assert.IsInstanceOf<TabAccountSettings> (response, "response is TabAccountSettings");
        }
        
        /// <summary>
        /// Test GetBillingCharges
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetBillingChargesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string includeCharges = null;
            //string accountId = null;
            //var response = instance.GetBillingCharges(includeCharges, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<BillingChargeResponse> (response, "response is BillingChargeResponse");
        }
        
        /// <summary>
        /// Test GetBrand
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetBrandTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string includeExternalReferences = null;
            //string includeLogos = null;
            //string accountId = null;
            //string brandId = null;
            //var response = instance.GetBrand(includeExternalReferences, includeLogos, accountId, brandId);
            //NUnit.Framework.Assert.IsInstanceOf<Brand> (response, "response is Brand");
        }
        
        /// <summary>
        /// Test GetBrandLogoByType
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetBrandLogoByTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //string logoType = null;
            //instance.GetBrandLogoByType(accountId, brandId, logoType);
            
        }
        
        /// <summary>
        /// Test GetBrandResources
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetBrandResourcesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //var response = instance.GetBrandResources(accountId, brandId);
            //NUnit.Framework.Assert.IsInstanceOf<BrandResourcesList> (response, "response is BrandResourcesList");
        }
        
        /// <summary>
        /// Test GetBrandResourcesByContentType
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetBrandResourcesByContentTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string langcode = null;
            //string returnMaster = null;
            //string accountId = null;
            //string brandId = null;
            //string resourceContentType = null;
            //instance.GetBrandResourcesByContentType(langcode, returnMaster, accountId, brandId, resourceContentType);
            
        }
        
        /// <summary>
        /// Test GetConsumerDisclosure
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetConsumerDisclosureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string langCode = null;
            //var response = instance.GetConsumerDisclosure(accountId, langCode);
            //NUnit.Framework.Assert.IsInstanceOf<ConsumerDisclosure> (response, "response is ConsumerDisclosure");
        }
        
        /// <summary>
        /// Test GetConsumerDisclosureDefault
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetConsumerDisclosureDefaultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string langCode = null;
            //string accountId = null;
            //var response = instance.GetConsumerDisclosureDefault(langCode, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<ConsumerDisclosure> (response, "response is ConsumerDisclosure");
        }
        
        /// <summary>
        /// Test GetENoteConfiguration
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetENoteConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //var response = instance.GetENoteConfiguration(accountId);
            //NUnit.Framework.Assert.IsInstanceOf<ENoteConfiguration> (response, "response is ENoteConfiguration");
        }
        
        /// <summary>
        /// Test GetPermissionProfile
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetPermissionProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string include = null;
            //string accountId = null;
            //string permissionProfileId = null;
            //var response = instance.GetPermissionProfile(include, accountId, permissionProfileId);
            //NUnit.Framework.Assert.IsInstanceOf<PermissionProfile> (response, "response is PermissionProfile");
        }
        
        /// <summary>
        /// Test GetProvisioning
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void GetProvisioningTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetProvisioning();
            //NUnit.Framework.Assert.IsInstanceOf<ProvisioningInformation> (response, "response is ProvisioningInformation");
        }
        
        /// <summary>
        /// Test ListBrands
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListBrandsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string excludeDistributorBrand = null;
            //string includeLogos = null;
            //string accountId = null;
            //var response = instance.ListBrands(excludeDistributorBrand, includeLogos, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<BrandsResponse> (response, "response is BrandsResponse");
        }
        
        /// <summary>
        /// Test ListCustomFields
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //var response = instance.ListCustomFields(accountId);
            //NUnit.Framework.Assert.IsInstanceOf<CustomFields> (response, "response is CustomFields");
        }
        
        /// <summary>
        /// Test ListPermissions
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string include = null;
            //string accountId = null;
            //var response = instance.ListPermissions(include, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<PermissionProfileInformation> (response, "response is PermissionProfileInformation");
        }
        
        /// <summary>
        /// Test ListRecipientNamesByEmail
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListRecipientNamesByEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string email = null;
            //string accountId = null;
            //var response = instance.ListRecipientNamesByEmail(email, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<RecipientNamesResponse> (response, "response is RecipientNamesResponse");
        }
        
        /// <summary>
        /// Test ListSettings
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //var response = instance.ListSettings(accountId);
            //NUnit.Framework.Assert.IsInstanceOf<AccountSettingsInformation> (response, "response is AccountSettingsInformation");
        }
        
        /// <summary>
        /// Test ListSharedAccess
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListSharedAccessTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string count = null;
            //string envelopesNotSharedUserStatus = null;
            //string folderIds = null;
            //string itemType = null;
            //string searchText = null;
            //string shared = null;
            //string startPosition = null;
            //string userIds = null;
            //string accountId = null;
            //var response = instance.ListSharedAccess(count, envelopesNotSharedUserStatus, folderIds, itemType, searchText, shared, startPosition, userIds, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<AccountSharedAccess> (response, "response is AccountSharedAccess");
        }
        
        /// <summary>
        /// Test ListSignatureProviders
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListSignatureProvidersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //var response = instance.ListSignatureProviders(accountId);
            //NUnit.Framework.Assert.IsInstanceOf<AccountSignatureProviders> (response, "response is AccountSignatureProviders");
        }
        
        /// <summary>
        /// Test ListUnsupportedFileTypes
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ListUnsupportedFileTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //var response = instance.ListUnsupportedFileTypes(accountId);
            //NUnit.Framework.Assert.IsInstanceOf<FileTypeList> (response, "response is FileTypeList");
        }
        
        /// <summary>
        /// Test UpdateAccountTabSettings
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void UpdateAccountTabSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TabAccountSettings tabAccountSettings = null;
            //string accountId = null;
            //var response = instance.UpdateAccountTabSettings(tabAccountSettings, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<TabAccountSettings> (response, "response is TabAccountSettings");
        }
        
        /// <summary>
        /// Test UpdateBrand
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void UpdateBrandTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Brand brand = null;
            //string accountId = null;
            //string brandId = null;
            //var response = instance.UpdateBrand(brand, accountId, brandId);
            //NUnit.Framework.Assert.IsInstanceOf<Brand> (response, "response is Brand");
        }
        
        /// <summary>
        /// Test UpdateBrandLogoByType
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void UpdateBrandLogoByTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //string logoType = null;
            //instance.UpdateBrandLogoByType(accountId, brandId, logoType);
            
        }
        
        /// <summary>
        /// Test UpdateBrandResourcesByContentType
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void UpdateBrandResourcesByContentTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //string resourceContentType = null;
            //var response = instance.UpdateBrandResourcesByContentType(accountId, brandId, resourceContentType);
            //NUnit.Framework.Assert.IsInstanceOf<BrandResources> (response, "response is BrandResources");
        }
        
        /// <summary>
        /// Test UpdateENoteConfiguration
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void UpdateENoteConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ENoteConfiguration eNoteConfiguration = null;
            //string accountId = null;
            //var response = instance.UpdateENoteConfiguration(eNoteConfiguration, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<ENoteConfiguration> (response, "response is ENoteConfiguration");
        }
        
        /// <summary>
        /// Test UpdatePermissionProfile
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void UpdatePermissionProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string include = null;
            //PermissionProfile permissionProfile = null;
            //string accountId = null;
            //string permissionProfileId = null;
            //var response = instance.UpdatePermissionProfile(include, permissionProfile, accountId, permissionProfileId);
            //NUnit.Framework.Assert.IsInstanceOf<PermissionProfile> (response, "response is PermissionProfile");
        }
        
        /// <summary>
        /// Test UpdateSettings
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void UpdateSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AccountSettingsInformation accountSettingsInformation = null;
            //string accountId = null;
            //instance.UpdateSettings(accountSettingsInformation, accountId);
            
        }
        
        /// <summary>
        /// Test UpdateSharedAccess
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void UpdateSharedAccessTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string itemType = null;
            //string userIds = null;
            //AccountSharedAccess accountSharedAccess = null;
            //string accountId = null;
            //var response = instance.UpdateSharedAccess(itemType, userIds, accountSharedAccess, accountId);
            //NUnit.Framework.Assert.IsInstanceOf<AccountSharedAccess> (response, "response is AccountSharedAccess");
        }
        
    }

}
