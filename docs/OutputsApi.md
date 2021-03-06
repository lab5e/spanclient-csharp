# spanclient.Api.OutputsApi

All URIs are relative to *https://api.lab5e.com/span*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOutput**](OutputsApi.md#createoutput) | **POST** /collections/{collectionId}/outputs | Create output
[**DeleteOutput**](OutputsApi.md#deleteoutput) | **DELETE** /collections/{collectionId}/outputs/{outputId} | Delete output
[**ListOutputs**](OutputsApi.md#listoutputs) | **GET** /collections/{collectionId}/outputs | List outputs
[**Logs**](OutputsApi.md#logs) | **GET** /collections/{collectionId}/outputs/{outputId}/logs | Output logs
[**RetrieveOutput**](OutputsApi.md#retrieveoutput) | **GET** /collections/{collectionId}/outputs/{outputId} | Retrieve output
[**Status**](OutputsApi.md#status) | **GET** /collections/{collectionId}/outputs/{outputId}/status | Output status
[**UpdateOutput**](OutputsApi.md#updateoutput) | **PATCH** /collections/{collectionId}/outputs/{outputId} | Update output


<a name="createoutput"></a>
# **CreateOutput**
> Output CreateOutput (string collectionId, Output body)

Create output

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using spanclient.Api;
using spanclient.Client;
using spanclient.Model;

namespace Example
{
    public class CreateOutputExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com/span";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new OutputsApi(config);
            var collectionId = collectionId_example;  // string | 
            var body = new Output(); // Output | 

            try
            {
                // Create output
                Output result = apiInstance.CreateOutput(collectionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutputsApi.CreateOutput: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**|  | 
 **body** | [**Output**](Output.md)|  | 

### Return type

[**Output**](Output.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteoutput"></a>
# **DeleteOutput**
> Output DeleteOutput (string collectionId, string outputId)

Delete output

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using spanclient.Api;
using spanclient.Client;
using spanclient.Model;

namespace Example
{
    public class DeleteOutputExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com/span";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new OutputsApi(config);
            var collectionId = collectionId_example;  // string | 
            var outputId = outputId_example;  // string | 

            try
            {
                // Delete output
                Output result = apiInstance.DeleteOutput(collectionId, outputId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutputsApi.DeleteOutput: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**|  | 
 **outputId** | **string**|  | 

### Return type

[**Output**](Output.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listoutputs"></a>
# **ListOutputs**
> ListOutputResponse ListOutputs (string collectionId)

List outputs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using spanclient.Api;
using spanclient.Client;
using spanclient.Model;

namespace Example
{
    public class ListOutputsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com/span";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new OutputsApi(config);
            var collectionId = collectionId_example;  // string | 

            try
            {
                // List outputs
                ListOutputResponse result = apiInstance.ListOutputs(collectionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutputsApi.ListOutputs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**|  | 

### Return type

[**ListOutputResponse**](ListOutputResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logs"></a>
# **Logs**
> OutputLogs Logs (string collectionId, string outputId)

Output logs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using spanclient.Api;
using spanclient.Client;
using spanclient.Model;

namespace Example
{
    public class LogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com/span";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new OutputsApi(config);
            var collectionId = collectionId_example;  // string | 
            var outputId = outputId_example;  // string | 

            try
            {
                // Output logs
                OutputLogs result = apiInstance.Logs(collectionId, outputId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutputsApi.Logs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**|  | 
 **outputId** | **string**|  | 

### Return type

[**OutputLogs**](OutputLogs.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieveoutput"></a>
# **RetrieveOutput**
> Output RetrieveOutput (string collectionId, string outputId)

Retrieve output

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using spanclient.Api;
using spanclient.Client;
using spanclient.Model;

namespace Example
{
    public class RetrieveOutputExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com/span";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new OutputsApi(config);
            var collectionId = collectionId_example;  // string | 
            var outputId = outputId_example;  // string | 

            try
            {
                // Retrieve output
                Output result = apiInstance.RetrieveOutput(collectionId, outputId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutputsApi.RetrieveOutput: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**|  | 
 **outputId** | **string**|  | 

### Return type

[**Output**](Output.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="status"></a>
# **Status**
> OutputStatus Status (string collectionId, string outputId)

Output status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using spanclient.Api;
using spanclient.Client;
using spanclient.Model;

namespace Example
{
    public class StatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com/span";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new OutputsApi(config);
            var collectionId = collectionId_example;  // string | 
            var outputId = outputId_example;  // string | 

            try
            {
                // Output status
                OutputStatus result = apiInstance.Status(collectionId, outputId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutputsApi.Status: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**|  | 
 **outputId** | **string**|  | 

### Return type

[**OutputStatus**](OutputStatus.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateoutput"></a>
# **UpdateOutput**
> Output UpdateOutput (string collectionId, string outputId, Output body)

Update output

Running outputs will be restarted if required. Note that the collection ID can't be changed on an existing output.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using spanclient.Api;
using spanclient.Client;
using spanclient.Model;

namespace Example
{
    public class UpdateOutputExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com/span";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new OutputsApi(config);
            var collectionId = collectionId_example;  // string | 
            var outputId = outputId_example;  // string | 
            var body = new Output(); // Output | 

            try
            {
                // Update output
                Output result = apiInstance.UpdateOutput(collectionId, outputId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutputsApi.UpdateOutput: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**|  | 
 **outputId** | **string**|  | 
 **body** | [**Output**](Output.md)|  | 

### Return type

[**Output**](Output.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

