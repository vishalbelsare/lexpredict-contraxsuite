# -*- coding: utf-8 -*-
# Generated by Django 1.11.3 on 2018-03-24 05:03
from __future__ import unicode_literals

import django.contrib.postgres.fields.jsonb
from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('project', '0010_projectclustering'),
    ]

    operations = [
        migrations.AlterField(
            model_name='projectclustering',
            name='metadata',
            field=django.contrib.postgres.fields.jsonb.JSONField(blank=True, default={}, null=True),
        ),
    ]