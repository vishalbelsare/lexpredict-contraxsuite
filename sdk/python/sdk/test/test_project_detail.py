"""
    Contraxsuite API

    Contraxsuite API  # noqa: E501

    The version of the OpenAPI document: 2.0.0
    Generated by: https://openapi-generator.tech
"""


import sys
import unittest

import openapi_client
from openapi_client.model.project_detail_owners_data import ProjectDetailOwnersData
from openapi_client.model.project_list_status_data import ProjectListStatusData
from openapi_client.model.project_list_type_data import ProjectListTypeData
globals()['ProjectDetailOwnersData'] = ProjectDetailOwnersData
globals()['ProjectListStatusData'] = ProjectListStatusData
globals()['ProjectListTypeData'] = ProjectListTypeData
from openapi_client.model.project_detail import ProjectDetail


class TestProjectDetail(unittest.TestCase):
    """ProjectDetail unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testProjectDetail(self):
        """Test ProjectDetail"""
        # FIXME: construct object with mandatory attributes with example values
        # model = ProjectDetail()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()
