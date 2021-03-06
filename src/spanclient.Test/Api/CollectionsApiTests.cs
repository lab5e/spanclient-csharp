/* 
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.1.3 factual-kahlil
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
    ///  Class for testing CollectionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CollectionsApiTests : IDisposable
    {
        private CollectionsApi instance;

        public CollectionsApiTests()
        {
            instance = new CollectionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CollectionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CollectionsApi
            //Assert.IsType(typeof(CollectionsApi), instance, "instance is a CollectionsApi");
        }

        
        /// <summary>
        /// Test BroadcastMessage
        /// </summary>
        [Fact]
        public void BroadcastMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //SendMessageRequest body = null;
            //var response = instance.BroadcastMessage(collectionId, body);
            //Assert.IsType<MultiSendMessageResponse> (response, "response is MultiSendMessageResponse");
        }
        
        /// <summary>
        /// Test CreateCollection
        /// </summary>
        [Fact]
        public void CreateCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Collection body = null;
            //var response = instance.CreateCollection(body);
            //Assert.IsType<Collection> (response, "response is Collection");
        }
        
        /// <summary>
        /// Test DeleteCollection
        /// </summary>
        [Fact]
        public void DeleteCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //var response = instance.DeleteCollection(collectionId);
            //Assert.IsType<Collection> (response, "response is Collection");
        }
        
        /// <summary>
        /// Test ListCollectionData
        /// </summary>
        [Fact]
        public void ListCollectionDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //int? limit = null;
            //string start = null;
            //string end = null;
            //string offset = null;
            //var response = instance.ListCollectionData(collectionId, limit, start, end, offset);
            //Assert.IsType<ListDataResponse> (response, "response is ListDataResponse");
        }
        
        /// <summary>
        /// Test ListCollections
        /// </summary>
        [Fact]
        public void ListCollectionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListCollections();
            //Assert.IsType<ListCollectionResponse> (response, "response is ListCollectionResponse");
        }
        
        /// <summary>
        /// Test RetrieveCollection
        /// </summary>
        [Fact]
        public void RetrieveCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //var response = instance.RetrieveCollection(collectionId);
            //Assert.IsType<Collection> (response, "response is Collection");
        }
        
        /// <summary>
        /// Test UpdateCollection
        /// </summary>
        [Fact]
        public void UpdateCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //Collection body = null;
            //var response = instance.UpdateCollection(collectionId, body);
            //Assert.IsType<Collection> (response, "response is Collection");
        }
        
    }

}
