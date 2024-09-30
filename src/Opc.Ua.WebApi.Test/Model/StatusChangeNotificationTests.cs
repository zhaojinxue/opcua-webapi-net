/*
 * OPC UA Web API
 *
 * This API provides simple HTTPS based access to an OPC UA server.
 *
 * The version of the OpenAPI document: 1.05.4
 * Contact: office@opcfoundation.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Opc.Ua.WebApi.Model;
using Opc.Ua.WebApi.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Opc.Ua.WebApi.Test.Model
{
    /// <summary>
    ///  Class for testing StatusChangeNotification
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class StatusChangeNotificationTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for StatusChangeNotification
        //private StatusChangeNotification instance;

        public StatusChangeNotificationTests()
        {
            // TODO uncomment below to create an instance of StatusChangeNotification
            //instance = new StatusChangeNotification();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of StatusChangeNotification
        /// </summary>
        [Fact]
        public void StatusChangeNotificationInstanceTest()
        {
            // TODO uncomment below to test "IsType" StatusChangeNotification
            //Assert.IsType<StatusChangeNotification>(instance);
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }

        /// <summary>
        /// Test the property 'DiagnosticInfo'
        /// </summary>
        [Fact]
        public void DiagnosticInfoTest()
        {
            // TODO unit test for the property 'DiagnosticInfo'
        }
    }
}