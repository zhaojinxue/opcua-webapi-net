/*
 * OPC UA Web API
 *
 * Provides simple HTTPS based access to an OPC UA server.
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
    ///  Class for testing BrowseNextRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class BrowseNextRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for BrowseNextRequest
        //private BrowseNextRequest instance;

        public BrowseNextRequestTests()
        {
            // TODO uncomment below to create an instance of BrowseNextRequest
            //instance = new BrowseNextRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BrowseNextRequest
        /// </summary>
        [Fact]
        public void BrowseNextRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" BrowseNextRequest
            //Assert.IsType<BrowseNextRequest>(instance);
        }

        /// <summary>
        /// Test the property 'RequestHeader'
        /// </summary>
        [Fact]
        public void RequestHeaderTest()
        {
            // TODO unit test for the property 'RequestHeader'
        }

        /// <summary>
        /// Test the property 'ReleaseContinuationPoints'
        /// </summary>
        [Fact]
        public void ReleaseContinuationPointsTest()
        {
            // TODO unit test for the property 'ReleaseContinuationPoints'
        }

        /// <summary>
        /// Test the property 'ContinuationPoints'
        /// </summary>
        [Fact]
        public void ContinuationPointsTest()
        {
            // TODO unit test for the property 'ContinuationPoints'
        }
    }
}
