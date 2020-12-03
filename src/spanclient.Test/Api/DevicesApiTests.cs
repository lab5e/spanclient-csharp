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
    ///  Class for testing DevicesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DevicesApiTests : IDisposable
    {
        private DevicesApi instance;

        public DevicesApiTests()
        {
            instance = new DevicesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DevicesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DevicesApi
            //Assert.IsType(typeof(DevicesApi), instance, "instance is a DevicesApi");
        }

        
        /// <summary>
        /// Test CreateDevice
        /// </summary>
        [Fact]
        public void CreateDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //Device body = null;
            //var response = instance.CreateDevice(collectionId, body);
            //Assert.IsType<Device> (response, "response is Device");
        }
        
        /// <summary>
        /// Test DeleteDevice
        /// </summary>
        [Fact]
        public void DeleteDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string deviceId = null;
            //var response = instance.DeleteDevice(collectionId, deviceId);
            //Assert.IsType<Device> (response, "response is Device");
        }
        
        /// <summary>
        /// Test ListDeviceData
        /// </summary>
        [Fact]
        public void ListDeviceDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string deviceId = null;
            //int? limit = null;
            //string start = null;
            //string end = null;
            //string offset = null;
            //var response = instance.ListDeviceData(collectionId, deviceId, limit, start, end, offset);
            //Assert.IsType<ListDataResponse> (response, "response is ListDataResponse");
        }
        
        /// <summary>
        /// Test ListDevices
        /// </summary>
        [Fact]
        public void ListDevicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //var response = instance.ListDevices(collectionId);
            //Assert.IsType<ListDevicesResponse> (response, "response is ListDevicesResponse");
        }
        
        /// <summary>
        /// Test RetrieveDevice
        /// </summary>
        [Fact]
        public void RetrieveDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string deviceId = null;
            //var response = instance.RetrieveDevice(collectionId, deviceId);
            //Assert.IsType<Device> (response, "response is Device");
        }
        
        /// <summary>
        /// Test SendMessage
        /// </summary>
        [Fact]
        public void SendMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string deviceId = null;
            //SendMessageRequest body = null;
            //var response = instance.SendMessage(collectionId, deviceId, body);
            //Assert.IsType<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test UpdateDevice
        /// </summary>
        [Fact]
        public void UpdateDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string existingCollectionId = null;
            //string deviceId = null;
            //UpdateDeviceRequest body = null;
            //var response = instance.UpdateDevice(existingCollectionId, deviceId, body);
            //Assert.IsType<Device> (response, "response is Device");
        }
        
    }

}
