# Generated by Django 2.2.18 on 2021-04-26 12:09

import apps.common.validators
from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('document', '0241_documenttable_bounding_rect'),
    ]

    operations = [
        migrations.AlterField(
            model_name='documentfield',
            name='value_regexp',
            field=models.TextField(blank=True, help_text='This regular expression is run on the sentence \n    found by a Field Detector and extracts a specific string value from a Text Unit. If the regular expression returns multiple matching groups, then the first matching group will be used by the Field. This is only applicable to String Fields.', null=True, validators=[apps.common.validators.RegexPatternValidator()]),
        ),
        migrations.AlterField(
            model_name='documentfielddetector',
            name='exclude_regexps',
            field=models.TextField(blank=True, help_text='Enter regular expressions, each on a new line, for text patterns \nyou want EXCLUDED. The Field Detector will attempt to skip any Text Unit that contains any of the patterns written \nhere, and will move on to the next Text Unit. Avoid using “.*” and similar unlimited multipliers, as they can crash \nor slow ContraxSuite. Use bounded multipliers for variable length matching, like “.{0,100}” or similar. Note that \nExclude regexps are checked before Definition words and Include regexps. If a Field Detector has Exclude regexps, but \nno Definition words or Include regexps, it will not extract any data.', null=True, validators=[apps.common.validators.RegexPatternValidator()]),
        ),
        migrations.AlterField(
            model_name='documentfielddetector',
            name='include_regexps',
            field=models.TextField(blank=True, help_text='Enter regular expressions, each on a new \nline, for text patterns you want INCLUDED. The Field Detector will attempt to match each of these regular expressions \nwithin a given Text Unit. Avoid using “.*” and similar unlimited multipliers, as they can crash or slow ContraxSuite. \nUse bounded multipliers for variable length matching, like “.{0,100}” or similar. Note that Include regexps are checked \nafter both Exclude regexps and Definition words.', null=True, validators=[apps.common.validators.RegexPatternValidator()]),
        ),
    ]
