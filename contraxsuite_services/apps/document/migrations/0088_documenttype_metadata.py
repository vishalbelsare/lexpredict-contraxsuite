# -*- coding: utf-8 -*-
# Generated by Django 1.11.7 on 2018-10-06 13:15
from __future__ import unicode_literals

import apps.common.fields
import django.core.serializers.json
from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('document', '0087_documentfield_text_unit_type'),
    ]

    operations = [
        migrations.AddField(
            model_name='documenttype',
            name='metadata',
            field=apps.common.fields.CustomJSONField(blank=True, encoder=django.core.serializers.json.DjangoJSONEncoder, null=True),
        ),
    ]