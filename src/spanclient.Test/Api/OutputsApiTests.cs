/* 
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.0.12 reported-davon
 * Contact: dev@lab5e.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using spanclient.Client;
using spanclient.Api;
using spanclient.Model;

namespace spanclient.Test
{
    /// <summary>
    ///  Class for testing OutputsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OutputsApiTests : IDisposable
    {
        private OutputsApi instance;

        public OutputsApiTests()
        {
            instance = new OutputsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OutputsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OutputsApi
            //Assert.IsType(typeof(OutputsApi), instance, "instance is a OutputsApi");
        }

        
        /// <summary>
        /// Test CreateOutput
        /// </summary>
        [Fact]
        public void CreateOutputTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //Output body = null;
            //var response = instance.CreateOutput(collectionId, body);
            //Assert.IsType<Output> (response, "response is Output");
        }
        
        /// <summary>
        /// Test DeleteOutput
        /// </summary>
        [Fact]
        public void DeleteOutputTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string outputId = null;
            //var response = instance.DeleteOutput(collectionId, outputId);
            //Assert.IsType<Output> (response, "response is Output");
        }
        
        /// <summary>
        /// Test ListOutputs
        /// </summary>
        [Fact]
        public void ListOutputsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //var response = instance.ListOutputs(collectionId);
            //Assert.IsType<ListOutputResponse> (response, "response is ListOutputResponse");
        }
        
        /// <summary>
        /// Test Logs
        /// </summary>
        [Fact]
        public void LogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string outputId = null;
            //var response = instance.Logs(collectionId, outputId);
            //Assert.IsType<OutputLogs> (response, "response is OutputLogs");
        }
        
        /// <summary>
        /// Test RetrieveOutput
        /// </summary>
        [Fact]
        public void RetrieveOutputTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string outputId = null;
            //var response = instance.RetrieveOutput(collectionId, outputId);
            //Assert.IsType<Output> (response, "response is Output");
        }
        
        /// <summary>
        /// Test Status
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string outputId = null;
            //var response = instance.Status(collectionId, outputId);
            //Assert.IsType<OutputStatus> (response, "response is OutputStatus");
        }
        
        /// <summary>
        /// Test UpdateOutput
        /// </summary>
        [Fact]
        public void UpdateOutputTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string outputId = null;
            //Output body = null;
            //var response = instance.UpdateOutput(collectionId, outputId, body);
            //Assert.IsType<Output> (response, "response is Output");
        }
        
    }

}
