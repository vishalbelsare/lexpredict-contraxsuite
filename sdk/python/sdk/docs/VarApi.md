# openapi_client.VarApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**var_get**](VarApi.md#var_get) | **GET** /api/{var} | 


# **var_get**
> bool, date, datetime, dict, float, int, list, str, none_type var_get(var)



### Example

* Api Key Authentication (AuthToken):
```python
import time
import openapi_client
from openapi_client.api import var_api
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "http://localhost"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure API key authorization: AuthToken
configuration.api_key['AuthToken'] = 'YOUR_API_KEY'

# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['AuthToken'] = 'Bearer'

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = var_api.VarApi(api_client)
    var = "var_example" # str | 

    # example passing only required values which don't have defaults set
    try:
        api_response = api_instance.var_get(var)
        pprint(api_response)
    except openapi_client.ApiException as e:
        print("Exception when calling VarApi->var_get: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **var** | **str**|  |

### Return type

**bool, date, datetime, dict, float, int, list, str, none_type**

### Authorization

[AuthToken](../README.md#AuthToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/coreapi+json, application/openapi+json, text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

