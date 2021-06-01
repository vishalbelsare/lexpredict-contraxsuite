"""
    Contraxsuite API

    Contraxsuite API  # noqa: E501

    The version of the OpenAPI document: 2.0.0
    Generated by: https://openapi-generator.tech
"""


import re  # noqa: F401
import sys  # noqa: F401

from openapi_client.model_utils import (  # noqa: F401
    ApiTypeError,
    ModelComposed,
    ModelNormal,
    ModelSimple,
    cached_property,
    change_keys_js_to_python,
    convert_js_args_to_python_args,
    date,
    datetime,
    file_type,
    none_type,
    validate_get_composed_info,
)


class DocumentFieldDetectorDetail(ModelNormal):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.

    Attributes:
      allowed_values (dict): The key is the tuple path to the attribute
          and the for var_name this is (var_name,). The value is a dict
          with a capitalized key describing the allowed value and an allowed
          value. These dicts store the allowed enum values.
      attribute_map (dict): The key is attribute name
          and the value is json key in definition.
      discriminator_value_class_map (dict): A dict to go from the discriminator
          variable value to the discriminator class name.
      validations (dict): The key is the tuple path to the attribute
          and the for var_name this is (var_name,). The value is a dict
          that stores validations for max_length, min_length, max_items,
          min_items, exclusive_maximum, inclusive_maximum, exclusive_minimum,
          inclusive_minimum, and regex.
      additional_properties_type (tuple): A tuple of classes accepted
          as additional properties values.
    """

    allowed_values = {
        ('category',): {
            'None': None,
            'SIMPLE_CONFIG': "simple_config",
        },
        ('extraction_hint',): {
            'None': None,
            'FIRST': "TAKE_FIRST",
            'SECOND': "TAKE_SECOND",
            'LAST': "TAKE_LAST",
            'MIN': "TAKE_MIN",
            'MAX': "TAKE_MAX",
        },
        ('text_part',): {
            'FULL': "FULL",
            'BEFORE_REGEXP': "BEFORE_REGEXP",
            'AFTER_REGEXP': "AFTER_REGEXP",
            'INSIDE_REGEXP': "INSIDE_REGEXP",
        },
        ('detect_limit_unit',): {
            'NONE': "NONE",
            'UNIT': "UNIT",
        },
    }

    validations = {
        ('detected_value',): {
            'max_length': 256,
        },
        ('detect_limit_count',): {
            'inclusive_maximum': 2147483647,
            'inclusive_minimum': -2147483648,
        },
    }

    additional_properties_type = None

    _nullable = False

    @cached_property
    def openapi_types():
        """
        This must be a method because a model may have properties that are
        of type self, this must run after the class is loaded

        Returns
            openapi_types (dict): The key is attribute name
                and the value is attribute type.
        """
        return {
            'field': (str,),  # noqa: E501
            'uid': (str,),  # noqa: E501
            'category': (str, none_type,),  # noqa: E501
            'field__code': (str,),  # noqa: E501
            'field__title': (str,),  # noqa: E501
            'field__uid': (str,),  # noqa: E501
            'field__type': (str,),  # noqa: E501
            'field__document_type__title': (str,),  # noqa: E501
            'exclude_regexps': (str, none_type,),  # noqa: E501
            'definition_words': (str, none_type,),  # noqa: E501
            'include_regexps': ([str],),  # noqa: E501
            'regexps_pre_process_lower': (bool,),  # noqa: E501
            'detected_value': (str, none_type,),  # noqa: E501
            'extraction_hint': (str, none_type,),  # noqa: E501
            'text_part': (str,),  # noqa: E501
            'detect_limit_unit': (str,),  # noqa: E501
            'detect_limit_count': (int,),  # noqa: E501
        }

    @cached_property
    def discriminator():
        return None


    attribute_map = {
        'field': 'field',  # noqa: E501
        'uid': 'uid',  # noqa: E501
        'category': 'category',  # noqa: E501
        'field__code': 'field__code',  # noqa: E501
        'field__title': 'field__title',  # noqa: E501
        'field__uid': 'field__uid',  # noqa: E501
        'field__type': 'field__type',  # noqa: E501
        'field__document_type__title': 'field__document_type__title',  # noqa: E501
        'exclude_regexps': 'exclude_regexps',  # noqa: E501
        'definition_words': 'definition_words',  # noqa: E501
        'include_regexps': 'include_regexps',  # noqa: E501
        'regexps_pre_process_lower': 'regexps_pre_process_lower',  # noqa: E501
        'detected_value': 'detected_value',  # noqa: E501
        'extraction_hint': 'extraction_hint',  # noqa: E501
        'text_part': 'text_part',  # noqa: E501
        'detect_limit_unit': 'detect_limit_unit',  # noqa: E501
        'detect_limit_count': 'detect_limit_count',  # noqa: E501
    }

    _composed_schemas = {}

    required_properties = set([
        '_data_store',
        '_check_type',
        '_spec_property_naming',
        '_path_to_item',
        '_configuration',
        '_visited_composed_classes',
    ])

    @convert_js_args_to_python_args
    def __init__(self, field, *args, **kwargs):  # noqa: E501
        """DocumentFieldDetectorDetail - a model defined in OpenAPI

        Args:
            field (str):

        Keyword Args:
            _check_type (bool): if True, values for parameters in openapi_types
                                will be type checked and a TypeError will be
                                raised if the wrong type is input.
                                Defaults to True
            _path_to_item (tuple/list): This is a list of keys or values to
                                drill down to the model in received_data
                                when deserializing a response
            _spec_property_naming (bool): True if the variable names in the input data
                                are serialized names, as specified in the OpenAPI document.
                                False if the variable names in the input data
                                are pythonic names, e.g. snake case (default)
            _configuration (Configuration): the instance to use when
                                deserializing a file_type parameter.
                                If passed, type conversion is attempted
                                If omitted no type conversion is done.
            _visited_composed_classes (tuple): This stores a tuple of
                                classes that we have traveled through so that
                                if we see that class again we will not use its
                                discriminator again.
                                When traveling through a discriminator, the
                                composed schema that is
                                is traveled through is added to this set.
                                For example if Animal has a discriminator
                                petType and we pass in "Dog", and the class Dog
                                allOf includes Animal, we move through Animal
                                once using the discriminator, and pick Dog.
                                Then in Dog, we will make an instance of the
                                Animal class but this time we won't travel
                                through its discriminator because we passed in
                                _visited_composed_classes = (Animal,)
            uid (str): [optional]  # noqa: E501
            category (str, none_type): Field detector category used for technical needs e.g. for determining  which field detectors were created automatically during import process.. [optional] if omitted the server will use the default value of "simple_config"  # noqa: E501
            field__code (str): [optional]  # noqa: E501
            field__title (str): [optional]  # noqa: E501
            field__uid (str): [optional]  # noqa: E501
            field__type (str): [optional]  # noqa: E501
            field__document_type__title (str): [optional]  # noqa: E501
            exclude_regexps (str, none_type): Enter regular expressions, each on a new line, for text patterns  you want EXCLUDED. The Field Detector will attempt to skip any Text Unit that contains any of the patterns written  here, and will move on to the next Text Unit. Avoid using “.*” and similar unlimited multipliers, as they can crash  or slow ContraxSuite. Use bounded multipliers for variable length matching, like “.{0,100}” or similar. Note that  Exclude regexps are checked before Definition words and Include regexps. If a Field Detector has Exclude regexps, but  no Definition words or Include regexps, it will not extract any data.. [optional]  # noqa: E501
            definition_words (str, none_type): Enter words or phrases, each on a new line, that must be present  in the Text Unit. These words must be in the Definitions List. If ContraxSuite fails to recognize these words as  definitions, then the Field Detector skips and moves to the next Text Unit. If there are Include regexps, then the  Field Detector checks against those requirements. The Field Detector marks the entire Text Unit as a match. Note that  the Field Detector checks for definition words after filtering using the Exclude regexps.. [optional]  # noqa: E501
            include_regexps ([str]): [optional]  # noqa: E501
            regexps_pre_process_lower (bool): Set 'ignore case' flag for both 'Include regexps' and 'Exclude regexps' options.. [optional]  # noqa: E501
            detected_value (str, none_type): The string value written here  will be assigned to the field if the Field Detector positively matches a Text Unit. This is only applicable to Choice,  Multichoice, and String fields, as their respective Field Detectors do not extract and display values from the source  text.. [optional]  # noqa: E501
            extraction_hint (str, none_type): Provide additional instruction on which  specific values should be prioritized for extraction, when multiple values of the same type  (e.g., Company, Person, Geography) are found within the relevant detected Text Unit.. [optional]  # noqa: E501
            text_part (str): Defines which part of the matched Text Unit  should be passed to the extraction function. Example: In the string \"2019-01-23 is the start date and 2019-01-24 is the  end date,\" if text part = \"Before matching substring\" and Include regexp is \"is.{0,100}start\" then \"2019-01-23\" will be  parsed correctly as the start date.. [optional]  # noqa: E501
            detect_limit_unit (str): Choose to add an upward limit to the amount of document text                                               ContraxSuite will search for this Document Field. For example, you can choose                                               to only search the first 10 paragraphs of text for the value required (this                                               often works best for values like “Company,” “Execution Date,” or “Parties,”                                              all of which typically appear in the first few paragraphs of a contract).. [optional]  # noqa: E501
            detect_limit_count (int): Specify the maximum      range for a bounded search. Field detection begins at the top of the document and continues until this Nth      \"Detect limit unit\" element.. [optional]  # noqa: E501
        """

        _check_type = kwargs.pop('_check_type', True)
        _spec_property_naming = kwargs.pop('_spec_property_naming', False)
        _path_to_item = kwargs.pop('_path_to_item', ())
        _configuration = kwargs.pop('_configuration', None)
        _visited_composed_classes = kwargs.pop('_visited_composed_classes', ())

        if args:
            raise ApiTypeError(
                "Invalid positional arguments=%s passed to %s. Remove those invalid positional arguments." % (
                    args,
                    self.__class__.__name__,
                ),
                path_to_item=_path_to_item,
                valid_classes=(self.__class__,),
            )

        self._data_store = {}
        self._check_type = _check_type
        self._spec_property_naming = _spec_property_naming
        self._path_to_item = _path_to_item
        self._configuration = _configuration
        self._visited_composed_classes = _visited_composed_classes + (self.__class__,)

        self.field = field
        for var_name, var_value in kwargs.items():
            if var_name not in self.attribute_map and \
                        self._configuration is not None and \
                        self._configuration.discard_unknown_keys and \
                        self.additional_properties_type is None:
                # discard variable.
                continue
            setattr(self, var_name, var_value)