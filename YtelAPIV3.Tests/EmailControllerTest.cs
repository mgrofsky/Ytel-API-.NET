/*
 * YtelAPIV3.Tests
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using YtelAPIV3.Standard;
using YtelAPIV3.Standard.Utilities; 
using YtelAPIV3.Standard.Http.Client;
using YtelAPIV3.Standard.Http.Response;
using YtelAPIV3.Tests.Helpers;
using NUnit.Framework;
using YtelAPIV3.Standard;
using YtelAPIV3.Standard.Controllers;
using YtelAPIV3.Standard.Exceptions;

namespace YtelAPIV3.Tests
{
    [TestFixture]
    public class EmailControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static EmailController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Email;
        }

        /// <summary>
        /// Retrieve a list of emails that have been blocked. 
        /// </summary>
        [Test]
        public async Task TestTestBlockedEmails() 
        {
            // Parameters for the API call
            string offset = null;
            string limit = null;

            // Perform API call
            string result = null;

            try
            {
                result = await controller.CreateBlockedEmailsAsync(offset, limit);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

        /// <summary>
        /// Retrieve a list of emails that are on the spam list. 
        /// </summary>
        [Test]
        public async Task TestTestSpamEmails() 
        {
            // Parameters for the API call
            string offset = null;
            string limit = null;

            // Perform API call
            string result = null;

            try
            {
                result = await controller.CreateSpamEmailsAsync(offset, limit);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

        /// <summary>
        /// Retrieve a list of emails that have bounced. 
        /// </summary>
        [Test]
        public async Task TestTestBouncedEmails() 
        {
            // Parameters for the API call
            string offset = null;
            string limit = null;

            // Perform API call
            string result = null;

            try
            {
                result = await controller.CreateBouncedEmailsAsync(offset, limit);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

        /// <summary>
        /// Retrieve a list of invalid email addresses. 
        /// </summary>
        [Test]
        public async Task TestTestInvalidEmails() 
        {
            // Parameters for the API call
            string offset = null;
            string limit = null;

            // Perform API call
            string result = null;

            try
            {
                result = await controller.CreateInvalidEmailsAsync(offset, limit);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

        /// <summary>
        /// Retrieve a list of email addresses from the unsubscribe list. 
        /// </summary>
        [Test]
        public async Task TestTestListUnsubscribedEmails() 
        {
            // Parameters for the API call
            string offset = null;
            string limit = null;

            // Perform API call
            string result = null;

            try
            {
                result = await controller.CreateListUnsubscribedEmailsAsync(offset, limit);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

    }
}