# coding: utf-8

"""
    FISSION

    Easily use IPFS from Web 2.0 applications  # noqa: E501

    OpenAPI spec version: 1.0.0
    Contact: support@fission.codes
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from __future__ import absolute_import

import unittest

import swagger_client
from swagger_client.api.ping_api import PingApi  # noqa: E501
from swagger_client.rest import ApiException


class TestPingApi(unittest.TestCase):
    """PingApi unit test stubs"""

    def setUp(self):
        self.api = swagger_client.api.ping_api.PingApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_ping_get(self):
        """Test case for ping_get

        """
        pass


if __name__ == '__main__':
    unittest.main()