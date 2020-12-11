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


class UserStats(object):
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
        'id': 'int',
        'user_name': 'str',
        'role_name': 'str',
        'group_name': 'str',
        'total_projects': 'int',
        'documents_assigned': 'int',
        'documents_completed': 'int',
        'documents_todo': 'int',
        'documents_completed_pcnt': 'float',
        'documents_todo_pcnt': 'float',
        'clauses_assigned': 'int',
        'clauses_completed': 'int',
        'clauses_todo': 'int',
        'clauses_completed_pcnt': 'float',
        'clauses_todo_pcnt': 'float'
    }

    attribute_map = {
        'id': 'id',
        'user_name': 'user_name',
        'role_name': 'role_name',
        'group_name': 'group_name',
        'total_projects': 'total_projects',
        'documents_assigned': 'documents_assigned',
        'documents_completed': 'documents_completed',
        'documents_todo': 'documents_todo',
        'documents_completed_pcnt': 'documents_completed_pcnt',
        'documents_todo_pcnt': 'documents_todo_pcnt',
        'clauses_assigned': 'clauses_assigned',
        'clauses_completed': 'clauses_completed',
        'clauses_todo': 'clauses_todo',
        'clauses_completed_pcnt': 'clauses_completed_pcnt',
        'clauses_todo_pcnt': 'clauses_todo_pcnt'
    }

    def __init__(self, id=None, user_name=None, role_name=None, group_name=None, total_projects=None, documents_assigned=None, documents_completed=None, documents_todo=None, documents_completed_pcnt=None, documents_todo_pcnt=None, clauses_assigned=None, clauses_completed=None, clauses_todo=None, clauses_completed_pcnt=None, clauses_todo_pcnt=None, local_vars_configuration=None):  # noqa: E501
        """UserStats - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._id = None
        self._user_name = None
        self._role_name = None
        self._group_name = None
        self._total_projects = None
        self._documents_assigned = None
        self._documents_completed = None
        self._documents_todo = None
        self._documents_completed_pcnt = None
        self._documents_todo_pcnt = None
        self._clauses_assigned = None
        self._clauses_completed = None
        self._clauses_todo = None
        self._clauses_completed_pcnt = None
        self._clauses_todo_pcnt = None
        self.discriminator = None

        self.id = id
        self.user_name = user_name
        self.role_name = role_name
        self.group_name = group_name
        self.total_projects = total_projects
        self.documents_assigned = documents_assigned
        self.documents_completed = documents_completed
        self.documents_todo = documents_todo
        self.documents_completed_pcnt = documents_completed_pcnt
        self.documents_todo_pcnt = documents_todo_pcnt
        self.clauses_assigned = clauses_assigned
        self.clauses_completed = clauses_completed
        self.clauses_todo = clauses_todo
        self.clauses_completed_pcnt = clauses_completed_pcnt
        self.clauses_todo_pcnt = clauses_todo_pcnt

    @property
    def id(self):
        """Gets the id of this UserStats.  # noqa: E501


        :return: The id of this UserStats.  # noqa: E501
        :rtype: int
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this UserStats.


        :param id: The id of this UserStats.  # noqa: E501
        :type id: int
        """
        if self.local_vars_configuration.client_side_validation and id is None:  # noqa: E501
            raise ValueError("Invalid value for `id`, must not be `None`")  # noqa: E501

        self._id = id

    @property
    def user_name(self):
        """Gets the user_name of this UserStats.  # noqa: E501


        :return: The user_name of this UserStats.  # noqa: E501
        :rtype: str
        """
        return self._user_name

    @user_name.setter
    def user_name(self, user_name):
        """Sets the user_name of this UserStats.


        :param user_name: The user_name of this UserStats.  # noqa: E501
        :type user_name: str
        """
        if self.local_vars_configuration.client_side_validation and user_name is None:  # noqa: E501
            raise ValueError("Invalid value for `user_name`, must not be `None`")  # noqa: E501

        self._user_name = user_name

    @property
    def role_name(self):
        """Gets the role_name of this UserStats.  # noqa: E501


        :return: The role_name of this UserStats.  # noqa: E501
        :rtype: str
        """
        return self._role_name

    @role_name.setter
    def role_name(self, role_name):
        """Sets the role_name of this UserStats.


        :param role_name: The role_name of this UserStats.  # noqa: E501
        :type role_name: str
        """

        self._role_name = role_name

    @property
    def group_name(self):
        """Gets the group_name of this UserStats.  # noqa: E501


        :return: The group_name of this UserStats.  # noqa: E501
        :rtype: str
        """
        return self._group_name

    @group_name.setter
    def group_name(self, group_name):
        """Sets the group_name of this UserStats.


        :param group_name: The group_name of this UserStats.  # noqa: E501
        :type group_name: str
        """

        self._group_name = group_name

    @property
    def total_projects(self):
        """Gets the total_projects of this UserStats.  # noqa: E501


        :return: The total_projects of this UserStats.  # noqa: E501
        :rtype: int
        """
        return self._total_projects

    @total_projects.setter
    def total_projects(self, total_projects):
        """Sets the total_projects of this UserStats.


        :param total_projects: The total_projects of this UserStats.  # noqa: E501
        :type total_projects: int
        """
        if self.local_vars_configuration.client_side_validation and total_projects is None:  # noqa: E501
            raise ValueError("Invalid value for `total_projects`, must not be `None`")  # noqa: E501

        self._total_projects = total_projects

    @property
    def documents_assigned(self):
        """Gets the documents_assigned of this UserStats.  # noqa: E501


        :return: The documents_assigned of this UserStats.  # noqa: E501
        :rtype: int
        """
        return self._documents_assigned

    @documents_assigned.setter
    def documents_assigned(self, documents_assigned):
        """Sets the documents_assigned of this UserStats.


        :param documents_assigned: The documents_assigned of this UserStats.  # noqa: E501
        :type documents_assigned: int
        """
        if self.local_vars_configuration.client_side_validation and documents_assigned is None:  # noqa: E501
            raise ValueError("Invalid value for `documents_assigned`, must not be `None`")  # noqa: E501

        self._documents_assigned = documents_assigned

    @property
    def documents_completed(self):
        """Gets the documents_completed of this UserStats.  # noqa: E501


        :return: The documents_completed of this UserStats.  # noqa: E501
        :rtype: int
        """
        return self._documents_completed

    @documents_completed.setter
    def documents_completed(self, documents_completed):
        """Sets the documents_completed of this UserStats.


        :param documents_completed: The documents_completed of this UserStats.  # noqa: E501
        :type documents_completed: int
        """
        if self.local_vars_configuration.client_side_validation and documents_completed is None:  # noqa: E501
            raise ValueError("Invalid value for `documents_completed`, must not be `None`")  # noqa: E501

        self._documents_completed = documents_completed

    @property
    def documents_todo(self):
        """Gets the documents_todo of this UserStats.  # noqa: E501


        :return: The documents_todo of this UserStats.  # noqa: E501
        :rtype: int
        """
        return self._documents_todo

    @documents_todo.setter
    def documents_todo(self, documents_todo):
        """Sets the documents_todo of this UserStats.


        :param documents_todo: The documents_todo of this UserStats.  # noqa: E501
        :type documents_todo: int
        """
        if self.local_vars_configuration.client_side_validation and documents_todo is None:  # noqa: E501
            raise ValueError("Invalid value for `documents_todo`, must not be `None`")  # noqa: E501

        self._documents_todo = documents_todo

    @property
    def documents_completed_pcnt(self):
        """Gets the documents_completed_pcnt of this UserStats.  # noqa: E501


        :return: The documents_completed_pcnt of this UserStats.  # noqa: E501
        :rtype: float
        """
        return self._documents_completed_pcnt

    @documents_completed_pcnt.setter
    def documents_completed_pcnt(self, documents_completed_pcnt):
        """Sets the documents_completed_pcnt of this UserStats.


        :param documents_completed_pcnt: The documents_completed_pcnt of this UserStats.  # noqa: E501
        :type documents_completed_pcnt: float
        """
        if self.local_vars_configuration.client_side_validation and documents_completed_pcnt is None:  # noqa: E501
            raise ValueError("Invalid value for `documents_completed_pcnt`, must not be `None`")  # noqa: E501

        self._documents_completed_pcnt = documents_completed_pcnt

    @property
    def documents_todo_pcnt(self):
        """Gets the documents_todo_pcnt of this UserStats.  # noqa: E501


        :return: The documents_todo_pcnt of this UserStats.  # noqa: E501
        :rtype: float
        """
        return self._documents_todo_pcnt

    @documents_todo_pcnt.setter
    def documents_todo_pcnt(self, documents_todo_pcnt):
        """Sets the documents_todo_pcnt of this UserStats.


        :param documents_todo_pcnt: The documents_todo_pcnt of this UserStats.  # noqa: E501
        :type documents_todo_pcnt: float
        """
        if self.local_vars_configuration.client_side_validation and documents_todo_pcnt is None:  # noqa: E501
            raise ValueError("Invalid value for `documents_todo_pcnt`, must not be `None`")  # noqa: E501

        self._documents_todo_pcnt = documents_todo_pcnt

    @property
    def clauses_assigned(self):
        """Gets the clauses_assigned of this UserStats.  # noqa: E501


        :return: The clauses_assigned of this UserStats.  # noqa: E501
        :rtype: int
        """
        return self._clauses_assigned

    @clauses_assigned.setter
    def clauses_assigned(self, clauses_assigned):
        """Sets the clauses_assigned of this UserStats.


        :param clauses_assigned: The clauses_assigned of this UserStats.  # noqa: E501
        :type clauses_assigned: int
        """
        if self.local_vars_configuration.client_side_validation and clauses_assigned is None:  # noqa: E501
            raise ValueError("Invalid value for `clauses_assigned`, must not be `None`")  # noqa: E501

        self._clauses_assigned = clauses_assigned

    @property
    def clauses_completed(self):
        """Gets the clauses_completed of this UserStats.  # noqa: E501


        :return: The clauses_completed of this UserStats.  # noqa: E501
        :rtype: int
        """
        return self._clauses_completed

    @clauses_completed.setter
    def clauses_completed(self, clauses_completed):
        """Sets the clauses_completed of this UserStats.


        :param clauses_completed: The clauses_completed of this UserStats.  # noqa: E501
        :type clauses_completed: int
        """
        if self.local_vars_configuration.client_side_validation and clauses_completed is None:  # noqa: E501
            raise ValueError("Invalid value for `clauses_completed`, must not be `None`")  # noqa: E501

        self._clauses_completed = clauses_completed

    @property
    def clauses_todo(self):
        """Gets the clauses_todo of this UserStats.  # noqa: E501


        :return: The clauses_todo of this UserStats.  # noqa: E501
        :rtype: int
        """
        return self._clauses_todo

    @clauses_todo.setter
    def clauses_todo(self, clauses_todo):
        """Sets the clauses_todo of this UserStats.


        :param clauses_todo: The clauses_todo of this UserStats.  # noqa: E501
        :type clauses_todo: int
        """
        if self.local_vars_configuration.client_side_validation and clauses_todo is None:  # noqa: E501
            raise ValueError("Invalid value for `clauses_todo`, must not be `None`")  # noqa: E501

        self._clauses_todo = clauses_todo

    @property
    def clauses_completed_pcnt(self):
        """Gets the clauses_completed_pcnt of this UserStats.  # noqa: E501


        :return: The clauses_completed_pcnt of this UserStats.  # noqa: E501
        :rtype: float
        """
        return self._clauses_completed_pcnt

    @clauses_completed_pcnt.setter
    def clauses_completed_pcnt(self, clauses_completed_pcnt):
        """Sets the clauses_completed_pcnt of this UserStats.


        :param clauses_completed_pcnt: The clauses_completed_pcnt of this UserStats.  # noqa: E501
        :type clauses_completed_pcnt: float
        """
        if self.local_vars_configuration.client_side_validation and clauses_completed_pcnt is None:  # noqa: E501
            raise ValueError("Invalid value for `clauses_completed_pcnt`, must not be `None`")  # noqa: E501

        self._clauses_completed_pcnt = clauses_completed_pcnt

    @property
    def clauses_todo_pcnt(self):
        """Gets the clauses_todo_pcnt of this UserStats.  # noqa: E501


        :return: The clauses_todo_pcnt of this UserStats.  # noqa: E501
        :rtype: float
        """
        return self._clauses_todo_pcnt

    @clauses_todo_pcnt.setter
    def clauses_todo_pcnt(self, clauses_todo_pcnt):
        """Sets the clauses_todo_pcnt of this UserStats.


        :param clauses_todo_pcnt: The clauses_todo_pcnt of this UserStats.  # noqa: E501
        :type clauses_todo_pcnt: float
        """
        if self.local_vars_configuration.client_side_validation and clauses_todo_pcnt is None:  # noqa: E501
            raise ValueError("Invalid value for `clauses_todo_pcnt`, must not be `None`")  # noqa: E501

        self._clauses_todo_pcnt = clauses_todo_pcnt

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
        if not isinstance(other, UserStats):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, UserStats):
            return True

        return self.to_dict() != other.to_dict()