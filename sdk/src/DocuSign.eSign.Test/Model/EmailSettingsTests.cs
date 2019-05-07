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
    ///  Class for testing EmailSettings
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [NUnit.Framework.TestFixtureAttribute]
    public class EmailSettingsTests
    {
        // TODO uncomment below to declare an instance variable for EmailSettings
        //private EmailSettings instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [NUnit.Framework.SetUpAttribute]
        public void Init()
        {
            // TODO uncomment below to create an instance of EmailSettings
            //instance = new EmailSettings();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EmailSettings
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void EmailSettingsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" EmailSettings
            //NUnit.Framework.Assert.IsInstanceOf<EmailSettings> (instance, "variable 'instance' is a EmailSettings");
        }

        /// <summary>
        /// Test the property 'BccEmailAddresses'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void BccEmailAddressesTest()
        {
            // TODO unit test for the property 'BccEmailAddresses'
        }
        /// <summary>
        /// Test the property 'ReplyEmailAddressOverride'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ReplyEmailAddressOverrideTest()
        {
            // TODO unit test for the property 'ReplyEmailAddressOverride'
        }
        /// <summary>
        /// Test the property 'ReplyEmailNameOverride'
        /// </summary>
        [NUnit.Framework.TestAttribute]
        public void ReplyEmailNameOverrideTest()
        {
            // TODO unit test for the property 'ReplyEmailNameOverride'
        }

    }

}