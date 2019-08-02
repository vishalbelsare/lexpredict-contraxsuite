# Generated by Django 2.2 on 2019-07-25 08:32

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('document', '0143_auto_20190716_1807'),
    ]

    operations = [
        migrations.AlterField(
            model_name='documentfielddetector',
            name='regexps_pre_process_lower',
            field=models.BooleanField(default=True, help_text='Bring sentence/paragraph to lower case before processing with this field detector.'),
        ),
    ]
