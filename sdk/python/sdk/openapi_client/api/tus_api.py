"""
    Contraxsuite API

    Contraxsuite API  # noqa: E501

    The version of the OpenAPI document: 2.0.0
    Generated by: https://openapi-generator.tech
"""


import re  # noqa: F401
import sys  # noqa: F401

from openapi_client.api_client import ApiClient, Endpoint as _Endpoint
from openapi_client.model_utils import (  # noqa: F401
    check_allowed_values,
    check_validations,
    date,
    datetime,
    file_type,
    none_type,
    validate_and_convert_types
)
from openapi_client.model.inline_response400 import InlineResponse400


class TusApi(object):
    """NOTE: This class is auto generated by OpenAPI Generator
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client

        def __tus_upload_session_upload_session_id_upload_guid_patch(
            self,
            upload_session_id,
            guid,
            upload_offset,
            tus_resumable,
            **kwargs
        ):
            """tus_upload_session_upload_session_id_upload_guid_patch  # noqa: E501

            Transfer file data  # noqa: E501
            This method makes a synchronous HTTP request by default. To make an
            asynchronous HTTP request, please pass async_req=True

            >>> thread = api.tus_upload_session_upload_session_id_upload_guid_patch(upload_session_id, guid, upload_offset, tus_resumable, async_req=True)
            >>> result = thread.get()

            Args:
                upload_session_id (str):
                guid (str):
                upload_offset (int): Upload offset, bytes.
                tus_resumable (str): 1.0.0

            Keyword Args:
                force (bool): Upload a file even if it exists.. [optional]
                body (file_type): [optional]
                _return_http_data_only (bool): response data without head status
                    code and headers. Default is True.
                _preload_content (bool): if False, the urllib3.HTTPResponse object
                    will be returned without reading/decoding response data.
                    Default is True.
                _request_timeout (float/tuple): timeout setting for this request. If one
                    number provided, it will be total request timeout. It can also
                    be a pair (tuple) of (connection, read) timeouts.
                    Default is None.
                _check_input_type (bool): specifies if type checking
                    should be done one the data sent to the server.
                    Default is True.
                _check_return_type (bool): specifies if type checking
                    should be done one the data received from the server.
                    Default is True.
                _host_index (int/None): specifies the index of the server
                    that we want to use.
                    Default is read from the configuration.
                async_req (bool): execute request asynchronously

            Returns:
                InlineResponse400
                    If the method is called asynchronously, returns the request
                    thread.
            """
            kwargs['async_req'] = kwargs.get(
                'async_req', False
            )
            kwargs['_return_http_data_only'] = kwargs.get(
                '_return_http_data_only', True
            )
            kwargs['_preload_content'] = kwargs.get(
                '_preload_content', True
            )
            kwargs['_request_timeout'] = kwargs.get(
                '_request_timeout', None
            )
            kwargs['_check_input_type'] = kwargs.get(
                '_check_input_type', True
            )
            kwargs['_check_return_type'] = kwargs.get(
                '_check_return_type', True
            )
            kwargs['_host_index'] = kwargs.get('_host_index')
            kwargs['upload_session_id'] = \
                upload_session_id
            kwargs['guid'] = \
                guid
            kwargs['upload_offset'] = \
                upload_offset
            kwargs['tus_resumable'] = \
                tus_resumable
            return self.call_with_http_info(**kwargs)

        self.tus_upload_session_upload_session_id_upload_guid_patch = _Endpoint(
            settings={
                'response_type': (InlineResponse400,),
                'auth': [
                    'AuthToken'
                ],
                'endpoint_path': '/api/v1/tus/upload-session/{upload_session_id}/upload/{guid}/',
                'operation_id': 'tus_upload_session_upload_session_id_upload_guid_patch',
                'http_method': 'PATCH',
                'servers': None,
            },
            params_map={
                'all': [
                    'upload_session_id',
                    'guid',
                    'upload_offset',
                    'tus_resumable',
                    'force',
                    'body',
                ],
                'required': [
                    'upload_session_id',
                    'guid',
                    'upload_offset',
                    'tus_resumable',
                ],
                'nullable': [
                ],
                'enum': [
                ],
                'validation': [
                ]
            },
            root_map={
                'validations': {
                },
                'allowed_values': {
                },
                'openapi_types': {
                    'upload_session_id':
                        (str,),
                    'guid':
                        (str,),
                    'upload_offset':
                        (int,),
                    'tus_resumable':
                        (str,),
                    'force':
                        (bool,),
                    'body':
                        (file_type,),
                },
                'attribute_map': {
                    'upload_session_id': 'upload_session_id',
                    'guid': 'guid',
                    'upload_offset': 'Upload-Offset',
                    'tus_resumable': 'Tus-Resumable',
                    'force': 'force',
                },
                'location_map': {
                    'upload_session_id': 'path',
                    'guid': 'path',
                    'upload_offset': 'header',
                    'tus_resumable': 'header',
                    'force': 'header',
                    'body': 'body',
                },
                'collection_format_map': {
                }
            },
            headers_map={
                'accept': [
                    'application/json'
                ],
                'content_type': [
                    'application/offset+octet-stream'
                ]
            },
            api_client=api_client,
            callable=__tus_upload_session_upload_session_id_upload_guid_patch
        )

        def __tus_upload_session_upload_session_id_upload_post(
            self,
            upload_session_id,
            upload_length,
            upload_metadata,
            tus_resumable,
            **kwargs
        ):
            """tus_upload_session_upload_session_id_upload_post  # noqa: E501

            Create an Upload  # noqa: E501
            This method makes a synchronous HTTP request by default. To make an
            asynchronous HTTP request, please pass async_req=True

            >>> thread = api.tus_upload_session_upload_session_id_upload_post(upload_session_id, upload_length, upload_metadata, tus_resumable, async_req=True)
            >>> result = thread.get()

            Args:
                upload_session_id (str):
                upload_length (int): File length.
                upload_metadata (str): Upload metadata include file name, relative path, etc.
                tus_resumable (str): 1.0.0

            Keyword Args:
                force (bool): Upload a file even if it exists.. [optional]
                request_body ({str: (bool, date, datetime, dict, float, int, list, str, none_type)}): [optional]
                _return_http_data_only (bool): response data without head status
                    code and headers. Default is True.
                _preload_content (bool): if False, the urllib3.HTTPResponse object
                    will be returned without reading/decoding response data.
                    Default is True.
                _request_timeout (float/tuple): timeout setting for this request. If one
                    number provided, it will be total request timeout. It can also
                    be a pair (tuple) of (connection, read) timeouts.
                    Default is None.
                _check_input_type (bool): specifies if type checking
                    should be done one the data sent to the server.
                    Default is True.
                _check_return_type (bool): specifies if type checking
                    should be done one the data received from the server.
                    Default is True.
                _host_index (int/None): specifies the index of the server
                    that we want to use.
                    Default is read from the configuration.
                async_req (bool): execute request asynchronously

            Returns:
                None
                    If the method is called asynchronously, returns the request
                    thread.
            """
            kwargs['async_req'] = kwargs.get(
                'async_req', False
            )
            kwargs['_return_http_data_only'] = kwargs.get(
                '_return_http_data_only', True
            )
            kwargs['_preload_content'] = kwargs.get(
                '_preload_content', True
            )
            kwargs['_request_timeout'] = kwargs.get(
                '_request_timeout', None
            )
            kwargs['_check_input_type'] = kwargs.get(
                '_check_input_type', True
            )
            kwargs['_check_return_type'] = kwargs.get(
                '_check_return_type', True
            )
            kwargs['_host_index'] = kwargs.get('_host_index')
            kwargs['upload_session_id'] = \
                upload_session_id
            kwargs['upload_length'] = \
                upload_length
            kwargs['upload_metadata'] = \
                upload_metadata
            kwargs['tus_resumable'] = \
                tus_resumable
            return self.call_with_http_info(**kwargs)

        self.tus_upload_session_upload_session_id_upload_post = _Endpoint(
            settings={
                'response_type': None,
                'auth': [
                    'AuthToken'
                ],
                'endpoint_path': '/api/v1/tus/upload-session/{upload_session_id}/upload/',
                'operation_id': 'tus_upload_session_upload_session_id_upload_post',
                'http_method': 'POST',
                'servers': None,
            },
            params_map={
                'all': [
                    'upload_session_id',
                    'upload_length',
                    'upload_metadata',
                    'tus_resumable',
                    'force',
                    'request_body',
                ],
                'required': [
                    'upload_session_id',
                    'upload_length',
                    'upload_metadata',
                    'tus_resumable',
                ],
                'nullable': [
                ],
                'enum': [
                ],
                'validation': [
                ]
            },
            root_map={
                'validations': {
                },
                'allowed_values': {
                },
                'openapi_types': {
                    'upload_session_id':
                        (str,),
                    'upload_length':
                        (int,),
                    'upload_metadata':
                        (str,),
                    'tus_resumable':
                        (str,),
                    'force':
                        (bool,),
                    'request_body':
                        ({str: (bool, date, datetime, dict, float, int, list, str, none_type)},),
                },
                'attribute_map': {
                    'upload_session_id': 'upload_session_id',
                    'upload_length': 'Upload-Length',
                    'upload_metadata': 'Upload-Metadata',
                    'tus_resumable': 'Tus-Resumable',
                    'force': 'force',
                },
                'location_map': {
                    'upload_session_id': 'path',
                    'upload_length': 'header',
                    'upload_metadata': 'header',
                    'tus_resumable': 'header',
                    'force': 'header',
                    'request_body': 'body',
                },
                'collection_format_map': {
                }
            },
            headers_map={
                'accept': [
                    'application/json'
                ],
                'content_type': [
                    'application/json'
                ]
            },
            api_client=api_client,
            callable=__tus_upload_session_upload_session_id_upload_post
        )
