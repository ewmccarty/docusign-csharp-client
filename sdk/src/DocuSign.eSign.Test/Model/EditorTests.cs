/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using DocuSign.eSign.Api;
using DocuSign.eSign.Model;
using DocuSign.eSign.Client;
using System.Reflection;

namespace DocuSign.eSign.Test
{
    /// <summary>
    ///  Class for testing Editor
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [NUnit.Framework.TestFixtureAttribute]
    public class EditorTests
    {
        // TODO uncomment below to declare an instance variable for Editor
        //private Editor instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [NUnit.Framework.SetUpAttribute]
        public void Init()
        {
            // TODO uncomment below to create an instance of Editor
            //instance = new Editor();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Editor
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void EditorInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Editor
            //NUnit.Framework.Assert.IsInstanceOf<Editor> (instance, "variable 'instance' is a Editor");
        }

        /// <summary>
        /// Test the property 'AccessCode'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void AccessCodeTest()
        {
            // TODO unit test for the property 'AccessCode'
        }
        /// <summary>
        /// Test the property 'AddAccessCodeToEmail'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void AddAccessCodeToEmailTest()
        {
            // TODO unit test for the property 'AddAccessCodeToEmail'
        }
        /// <summary>
        /// Test the property 'ClientUserId'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ClientUserIdTest()
        {
            // TODO unit test for the property 'ClientUserId'
        }
        /// <summary>
        /// Test the property 'CustomFields'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void CustomFieldsTest()
        {
            // TODO unit test for the property 'CustomFields'
        }
        /// <summary>
        /// Test the property 'DeclinedDateTime'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void DeclinedDateTimeTest()
        {
            // TODO unit test for the property 'DeclinedDateTime'
        }
        /// <summary>
        /// Test the property 'DeclinedReason'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void DeclinedReasonTest()
        {
            // TODO unit test for the property 'DeclinedReason'
        }
        /// <summary>
        /// Test the property 'DeliveredDateTime'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void DeliveredDateTimeTest()
        {
            // TODO unit test for the property 'DeliveredDateTime'
        }
        /// <summary>
        /// Test the property 'DeliveryMethod'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void DeliveryMethodTest()
        {
            // TODO unit test for the property 'DeliveryMethod'
        }
        /// <summary>
        /// Test the property 'DocumentVisibility'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void DocumentVisibilityTest()
        {
            // TODO unit test for the property 'DocumentVisibility'
        }
        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }
        /// <summary>
        /// Test the property 'EmailNotification'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void EmailNotificationTest()
        {
            // TODO unit test for the property 'EmailNotification'
        }
        /// <summary>
        /// Test the property 'EmailRecipientPostSigningURL'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void EmailRecipientPostSigningURLTest()
        {
            // TODO unit test for the property 'EmailRecipientPostSigningURL'
        }
        /// <summary>
        /// Test the property 'EmbeddedRecipientStartURL'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void EmbeddedRecipientStartURLTest()
        {
            // TODO unit test for the property 'EmbeddedRecipientStartURL'
        }
        /// <summary>
        /// Test the property 'ErrorDetails'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ErrorDetailsTest()
        {
            // TODO unit test for the property 'ErrorDetails'
        }
        /// <summary>
        /// Test the property 'FaxNumber'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void FaxNumberTest()
        {
            // TODO unit test for the property 'FaxNumber'
        }
        /// <summary>
        /// Test the property 'IdCheckConfigurationName'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void IdCheckConfigurationNameTest()
        {
            // TODO unit test for the property 'IdCheckConfigurationName'
        }
        /// <summary>
        /// Test the property 'IdCheckInformationInput'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void IdCheckInformationInputTest()
        {
            // TODO unit test for the property 'IdCheckInformationInput'
        }
        /// <summary>
        /// Test the property 'InheritEmailNotificationConfiguration'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void InheritEmailNotificationConfigurationTest()
        {
            // TODO unit test for the property 'InheritEmailNotificationConfiguration'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Note'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void NoteTest()
        {
            // TODO unit test for the property 'Note'
        }
        /// <summary>
        /// Test the property 'PhoneAuthentication'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void PhoneAuthenticationTest()
        {
            // TODO unit test for the property 'PhoneAuthentication'
        }
        /// <summary>
        /// Test the property 'RecipientAttachments'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void RecipientAttachmentsTest()
        {
            // TODO unit test for the property 'RecipientAttachments'
        }
        /// <summary>
        /// Test the property 'RecipientAuthenticationStatus'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void RecipientAuthenticationStatusTest()
        {
            // TODO unit test for the property 'RecipientAuthenticationStatus'
        }
        /// <summary>
        /// Test the property 'RecipientId'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void RecipientIdTest()
        {
            // TODO unit test for the property 'RecipientId'
        }
        /// <summary>
        /// Test the property 'RecipientIdGuid'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void RecipientIdGuidTest()
        {
            // TODO unit test for the property 'RecipientIdGuid'
        }
        /// <summary>
        /// Test the property 'RequireIdLookup'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void RequireIdLookupTest()
        {
            // TODO unit test for the property 'RequireIdLookup'
        }
        /// <summary>
        /// Test the property 'RoleName'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void RoleNameTest()
        {
            // TODO unit test for the property 'RoleName'
        }
        /// <summary>
        /// Test the property 'RoutingOrder'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void RoutingOrderTest()
        {
            // TODO unit test for the property 'RoutingOrder'
        }
        /// <summary>
        /// Test the property 'SamlAuthentication'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void SamlAuthenticationTest()
        {
            // TODO unit test for the property 'SamlAuthentication'
        }
        /// <summary>
        /// Test the property 'SentDateTime'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void SentDateTimeTest()
        {
            // TODO unit test for the property 'SentDateTime'
        }
        /// <summary>
        /// Test the property 'SignedDateTime'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void SignedDateTimeTest()
        {
            // TODO unit test for the property 'SignedDateTime'
        }
        /// <summary>
        /// Test the property 'SigningGroupId'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void SigningGroupIdTest()
        {
            // TODO unit test for the property 'SigningGroupId'
        }
        /// <summary>
        /// Test the property 'SigningGroupName'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void SigningGroupNameTest()
        {
            // TODO unit test for the property 'SigningGroupName'
        }
        /// <summary>
        /// Test the property 'SigningGroupUsers'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void SigningGroupUsersTest()
        {
            // TODO unit test for the property 'SigningGroupUsers'
        }
        /// <summary>
        /// Test the property 'SmsAuthentication'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void SmsAuthenticationTest()
        {
            // TODO unit test for the property 'SmsAuthentication'
        }
        /// <summary>
        /// Test the property 'SocialAuthentications'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void SocialAuthenticationsTest()
        {
            // TODO unit test for the property 'SocialAuthentications'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'TemplateLocked'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void TemplateLockedTest()
        {
            // TODO unit test for the property 'TemplateLocked'
        }
        /// <summary>
        /// Test the property 'TemplateRequired'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void TemplateRequiredTest()
        {
            // TODO unit test for the property 'TemplateRequired'
        }
        /// <summary>
        /// Test the property 'TotalTabCount'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void TotalTabCountTest()
        {
            // TODO unit test for the property 'TotalTabCount'
        }
        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }

    }

}
