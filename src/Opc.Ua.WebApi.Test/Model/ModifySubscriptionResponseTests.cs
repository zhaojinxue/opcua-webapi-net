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
    ///  Class for testing ModifySubscriptionResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ModifySubscriptionResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ModifySubscriptionResponse
        //private ModifySubscriptionResponse instance;

        public ModifySubscriptionResponseTests()
        {
            // TODO uncomment below to create an instance of ModifySubscriptionResponse
            //instance = new ModifySubscriptionResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ModifySubscriptionResponse
        /// </summary>
        [Fact]
        public void ModifySubscriptionResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" ModifySubscriptionResponse
            //Assert.IsType<ModifySubscriptionResponse>(instance);
        }

        /// <summary>
        /// Test the property 'ResponseHeader'
        /// </summary>
        [Fact]
        public void ResponseHeaderTest()
        {
            // TODO unit test for the property 'ResponseHeader'
        }

        /// <summary>
        /// Test the property 'RevisedPublishingInterval'
        /// </summary>
        [Fact]
        public void RevisedPublishingIntervalTest()
        {
            // TODO unit test for the property 'RevisedPublishingInterval'
        }

        /// <summary>
        /// Test the property 'RevisedLifetimeCount'
        /// </summary>
        [Fact]
        public void RevisedLifetimeCountTest()
        {
            // TODO unit test for the property 'RevisedLifetimeCount'
        }

        /// <summary>
        /// Test the property 'RevisedMaxKeepAliveCount'
        /// </summary>
        [Fact]
        public void RevisedMaxKeepAliveCountTest()
        {
            // TODO unit test for the property 'RevisedMaxKeepAliveCount'
        }
    }
}