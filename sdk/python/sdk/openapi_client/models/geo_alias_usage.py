# coding: utf-8

"""

    No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from openapi_client.configuration import Configuration


class GeoAliasUsage(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'alias__alias': 'str',
        'alias__locale': 'str',
        'alias__type': 'str',
        'count': 'int',
        'alias__entity__name': 'str',
        'alias__entity__category': 'str',
        'pk': 'int',
        'text_unit__pk': 'str',
        'text_unit__unit_type': 'str',
        'text_unit__location_start': 'str',
        'text_unit__location_end': 'str',
        'text_unit__document__pk': 'str',
        'text_unit__document__name': 'str',
        'text_unit__document__description': 'str',
        'text_unit__document__document_type': 'str'
    }

    attribute_map = {
        'alias__alias': 'alias__alias',
        'alias__locale': 'alias__locale',
        'alias__type': 'alias__type',
        'count': 'count',
        'alias__entity__name': 'alias__entity__name',
        'alias__entity__category': 'alias__entity__category',
        'pk': 'pk',
        'text_unit__pk': 'text_unit__pk',
        'text_unit__unit_type': 'text_unit__unit_type',
        'text_unit__location_start': 'text_unit__location_start',
        'text_unit__location_end': 'text_unit__location_end',
        'text_unit__document__pk': 'text_unit__document__pk',
        'text_unit__document__name': 'text_unit__document__name',
        'text_unit__document__description': 'text_unit__document__description',
        'text_unit__document__document_type': 'text_unit__document__document_type'
    }

    def __init__(self, alias__alias=None, alias__locale=None, alias__type=None, count=None, alias__entity__name=None, alias__entity__category=None, pk=None, text_unit__pk=None, text_unit__unit_type=None, text_unit__location_start=None, text_unit__location_end=None, text_unit__document__pk=None, text_unit__document__name=None, text_unit__document__description=None, text_unit__document__document_type=None, local_vars_configuration=None):  # noqa: E501
        """GeoAliasUsage - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._alias__alias = None
        self._alias__locale = None
        self._alias__type = None
        self._count = None
        self._alias__entity__name = None
        self._alias__entity__category = None
        self._pk = None
        self._text_unit__pk = None
        self._text_unit__unit_type = None
        self._text_unit__location_start = None
        self._text_unit__location_end = None
        self._text_unit__document__pk = None
        self._text_unit__document__name = None
        self._text_unit__document__description = None
        self._text_unit__document__document_type = None
        self.discriminator = None

        if alias__alias is not None:
            self.alias__alias = alias__alias
        if alias__locale is not None:
            self.alias__locale = alias__locale
        if alias__type is not None:
            self.alias__type = alias__type
        if count is not None:
            self.count = count
        if alias__entity__name is not None:
            self.alias__entity__name = alias__entity__name
        if alias__entity__category is not None:
            self.alias__entity__category = alias__entity__category
        if pk is not None:
            self.pk = pk
        if text_unit__pk is not None:
            self.text_unit__pk = text_unit__pk
        if text_unit__unit_type is not None:
            self.text_unit__unit_type = text_unit__unit_type
        if text_unit__location_start is not None:
            self.text_unit__location_start = text_unit__location_start
        if text_unit__location_end is not None:
            self.text_unit__location_end = text_unit__location_end
        if text_unit__document__pk is not None:
            self.text_unit__document__pk = text_unit__document__pk
        if text_unit__document__name is not None:
            self.text_unit__document__name = text_unit__document__name
        if text_unit__document__description is not None:
            self.text_unit__document__description = text_unit__document__description
        if text_unit__document__document_type is not None:
            self.text_unit__document__document_type = text_unit__document__document_type

    @property
    def alias__alias(self):
        """Gets the alias__alias of this GeoAliasUsage.  # noqa: E501


        :return: The alias__alias of this GeoAliasUsage.  # noqa: E501
        :rtype: str
        """
        return self._alias__alias

    @alias__alias.setter
    def alias__alias(self, alias__alias):
        """Sets the alias__alias of this GeoAliasUsage.


        :param alias__alias: The alias__alias of this GeoAliasUsage.  # noqa: E501
        :type alias__alias: str
        """

        self._alias__alias = alias__alias

    @property
    def alias__locale(self):
        """Gets the alias__locale of this GeoAliasUsage.  # noqa: E501


        :return: The alias__locale of this GeoAliasUsage.  # noqa: E501
        :rtype: str
        """
        return self._alias__locale

    @alias__locale.setter
    def alias__locale(self, alias__locale):
        """Sets the alias__locale of this GeoAliasUsage.


        :param alias__locale: The alias__locale of this GeoAliasUsage.  # noqa: E501
        :type alias__locale: str
        """

        self._alias__locale = alias__locale

    @property
    def alias__type(self):
        """Gets the alias__type of this GeoAliasUsage.  # noqa: E501


        :return: The alias__type of this GeoAliasUsage.  # noqa: E501
        :rtype: str
        """
        return self._alias__type

    @alias__type.setter
    def alias__type(self, alias__type):
        """Sets the alias__type of this GeoAliasUsage.


        :param alias__type: The alias__type of this GeoAliasUsage.  # noqa: E501
        :type alias__type: str
        """

        self._alias__type = alias__type

    @property
    def count(self):
        """Gets the count of this GeoAliasUsage.  # noqa: E501


        :return: The count of this GeoAliasUsage.  # noqa: E501
        :rtype: int
        """
        return self._count

    @count.setter
    def count(self, count):
        """Sets the count of this GeoAliasUsage.


        :param count: The count of this GeoAliasUsage.  # noqa: E501
        :type count: int
        """
        if (self.local_vars_configuration.client_side_validation and
                count is not None and count > 2147483647):  # noqa: E501
            raise ValueError("Invalid value for `count`, must be a value less than or equal to `2147483647`")  # noqa: E501
        if (self.local_vars_configuration.client_side_validation and
                count is not None and count < -2147483648):  # noqa: E501
            raise ValueError("Invalid value for `count`, must be a value greater than or equal to `-2147483648`")  # noqa: E501

        self._count = count

    @property
    def alias__entity__name(self):
        """Gets the alias__entity__name of this GeoAliasUsage.  # noqa: E501


        :return: The alias__entity__name of this GeoAliasUsage.  # noqa: E501
        :rtype: str
        """
        return self._alias__entity__name

    @alias__entity__name.setter
    def alias__entity__name(self, alias__entity__name):
        """Sets the alias__entity__name of this GeoAliasUsage.


        :param alias__entity__name: The alias__entity__name of this GeoAliasUsage.  # noqa: E501
        :type alias__entity__name: str
        """

        self._alias__entity__name = alias__entity__name

    @property
    def alias__entity__category(self):
        """Gets the alias__entity__category of this GeoAliasUsage.  # noqa: E501


        :return: The alias__entity__category of this GeoAliasUsage.  # noqa: E501
        :rtype: str
        """
        return self._alias__entity__category

    @alias__entity__category.setter
    def alias__entity__category(self, alias__entity__category):
        """Sets the alias__entity__category of this GeoAliasUsage.


        :param alias__entity__category: The alias__entity__category of this GeoAliasUsage.  # noqa: E501
        :type alias__entity__category: str
        """

        self._alias__entity__category = alias__entity__category

    @property
    def pk(self):
        """Gets the pk of this GeoAliasUsage.  # noqa: E501


        :return: The pk of this GeoAliasUsage.  # noqa: E501
        :rtype: int
        """
        return self._pk

    @pk.setter
    def pk(self, pk):
        """Sets the pk of this GeoAliasUsage.


        :param pk: The pk of this GeoAliasUsage.  # noqa: E501
        :type pk: int
        """

        self._pk = pk

    @property
    def text_unit__pk(self):
        """Gets the text_unit__pk of this GeoAliasUsage.  # noqa: E501


        :return: The text_unit__pk of this GeoAliasUsage.  # noqa: E501
        :rtype: str
        """
        return self._text_unit__pk

    @text_unit__pk.setter
    def text_unit__pk(self, text_unit__pk):
        """Sets the text_unit__pk of this GeoAliasUsage.


        :param text_unit__pk: The text_unit__pk of this GeoAliasUsage.  # noqa: E501
        :type text_unit__pk: str
        """

        self._text_unit__pk = text_unit__pk

    @property
    def text_unit__unit_type(self):
        """Gets the text_unit__unit_type of this GeoAliasUsage.  # noqa: E501


        :return: The text_unit__unit_type of this GeoAliasUsage.  # noqa: E501
        :rtype: str
        """
        return self._text_unit__unit_type

    @text_unit__unit_type.setter
    def text_unit__unit_type(self, text_unit__unit_type):
        """Sets the text_unit__unit_type of this GeoAliasUsage.


        :param text_unit__unit_type: The text_unit__unit_type of this GeoAliasUsage.  # noqa: E501
        :type text_unit__unit_type: str
        """

        self._text_unit__unit_type = text_unit__unit_type

    @property
    def text_unit__location_start(self):
        """Gets the text_unit__location_start of this GeoAliasUsage.  # noqa: E501


        :return: The text_unit__location_start of this GeoAliasUsage.  # noqa: E501
        :rtype: str
        """
        return self._text_unit__location_start

    @text_unit__location_start.setter
    def text_unit__location_start(self, text_unit__location_start):
        """Sets the text_unit__location_start of this GeoAliasUsage.


        :param text_unit__location_start: The text_unit__location_start of this GeoAliasUsage.  # noqa: E501
        :type text_unit__location_start: str
        """

        self._text_unit__location_start = text_unit__location_start

    @property
    def text_unit__location_end(self):
        """Gets the text_unit__location_end of this GeoAliasUsage.  # noqa: E501


        :return: The text_unit__location_end of this GeoAliasUsage.  # noqa: E501
        :rtype: str
        """
        return self._text_unit__location_end

    @text_unit__location_end.setter
    def text_unit__location_end(self, text_unit__location_end):
        """Sets the text_unit__location_end of this GeoAliasUsage.


        :param text_unit__location_end: The text_unit__location_end of this GeoAliasUsage.  # noqa: E501
        :type text_unit__location_end: str
        """

        self._text_unit__location_end = text_unit__location_end

    @property
    def text_unit__document__pk(self):
        """Gets the text_unit__document__pk of this GeoAliasUsage.  # noqa: E501


        :return: The text_unit__document__pk of this GeoAliasUsage.  # noqa: E501
        :rtype: str
        """
        return self._text_unit__document__pk

    @text_unit__document__pk.setter
    def text_unit__document__pk(self, text_unit__document__pk):
        """Sets the text_unit__document__pk of this GeoAliasUsage.


        :param text_unit__document__pk: The text_unit__document__pk of this GeoAliasUsage.  # noqa: E501
        :type text_unit__document__pk: str
        """

        self._text_unit__document__pk = text_unit__document__pk

    @property
    def text_unit__document__name(self):
        """Gets the text_unit__document__name of this GeoAliasUsage.  # noqa: E501


        :return: The text_unit__document__name of this GeoAliasUsage.  # noqa: E501
        :rtype: str
        """
        return self._text_unit__document__name

    @text_unit__document__name.setter
    def text_unit__document__name(self, text_unit__document__name):
        """Sets the text_unit__document__name of this GeoAliasUsage.


        :param text_unit__document__name: The text_unit__document__name of this GeoAliasUsage.  # noqa: E501
        :type text_unit__document__name: str
        """

        self._text_unit__document__name = text_unit__document__name

    @property
    def text_unit__document__description(self):
        """Gets the text_unit__document__description of this GeoAliasUsage.  # noqa: E501


        :return: The text_unit__document__description of this GeoAliasUsage.  # noqa: E501
        :rtype: str
        """
        return self._text_unit__document__description

    @text_unit__document__description.setter
    def text_unit__document__description(self, text_unit__document__description):
        """Sets the text_unit__document__description of this GeoAliasUsage.


        :param text_unit__document__description: The text_unit__document__description of this GeoAliasUsage.  # noqa: E501
        :type text_unit__document__description: str
        """

        self._text_unit__document__description = text_unit__document__description

    @property
    def text_unit__document__document_type(self):
        """Gets the text_unit__document__document_type of this GeoAliasUsage.  # noqa: E501


        :return: The text_unit__document__document_type of this GeoAliasUsage.  # noqa: E501
        :rtype: str
        """
        return self._text_unit__document__document_type

    @text_unit__document__document_type.setter
    def text_unit__document__document_type(self, text_unit__document__document_type):
        """Sets the text_unit__document__document_type of this GeoAliasUsage.


        :param text_unit__document__document_type: The text_unit__document__document_type of this GeoAliasUsage.  # noqa: E501
        :type text_unit__document__document_type: str
        """

        self._text_unit__document__document_type = text_unit__document__document_type

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, GeoAliasUsage):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, GeoAliasUsage):
            return True

        return self.to_dict() != other.to_dict()