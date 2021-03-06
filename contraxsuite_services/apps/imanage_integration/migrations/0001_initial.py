# -*- coding: utf-8 -*-
# Generated by Django 1.11.3 on 2019-02-05 07:16
from __future__ import unicode_literals

import django.contrib.postgres.fields.jsonb
import django.core.serializers.json
from django.db import migrations, models
import django.db.models.deletion
from apps.common.model_utils.improved_django_json_encoder import ImprovedDjangoJSONEncoder


class Migration(migrations.Migration):

    initial = True

    dependencies = [
        ('project', '0029_auto_20181102_1910'),
        ('document', '0119_auto_20190129_1253'),
    ]

    operations = [
        migrations.CreateModel(
            name='IManageConfig',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('code', models.CharField(db_index=True, max_length=1024, unique=True)),
                ('enabled', models.BooleanField(default=False)),
                ('root_url', models.CharField(help_text='Root of the URL of iManage API \n        from the start and until (not including) "/api/v1" (eg. https://my_imanage.server.com)', max_length=1024)),
                ('auth_user', models.CharField(max_length=100)),
                ('auth_password', models.CharField(blank=True, max_length=100, null=True)),
                ('requests_proxies', django.contrib.postgres.fields.jsonb.JSONField(blank=True, default={'scope': 'US!6511311'}, encoder=ImprovedDjangoJSONEncoder, null=True)),
                ('requests_verify_ssl_certs', models.BooleanField(default=True)),
                ('project_resolver', models.TextField(blank=True, help_text='Python code returning project name \n    based on the provided iManage document data in the form of dict.', null=True)),
                ('last_sync_start', models.DateTimeField(blank=True, null=True)),
                ('sync_frequency_minutes', models.PositiveIntegerField(default=120)),
                ('search_request_params', django.contrib.postgres.fields.jsonb.JSONField(blank=True, default={'scope': 'US!6511311'}, encoder=ImprovedDjangoJSONEncoder, null=True)),
                ('document_type', models.ForeignKey(help_text='Type of documents on \n        Contraxsuite side to be created based on iManage documents.', on_delete=django.db.models.deletion.CASCADE, to='document.DocumentType')),
                ('project', models.ForeignKey(blank=True, help_text='Project into which the imanage documents\n    should be saved.', null=True, on_delete=django.db.models.deletion.CASCADE, to='project.Project')),
            ],
        ),
        migrations.CreateModel(
            name='IManageDocument',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('imanage_doc_id', models.CharField(db_index=True, max_length=1024)),
                ('imanage_doc_data', django.contrib.postgres.fields.jsonb.JSONField(blank=True, encoder=ImprovedDjangoJSONEncoder, null=True)),
                ('last_sync_date', models.DateTimeField(blank=True, null=True)),
                ('document', models.ForeignKey(blank=True, null=True, on_delete=django.db.models.deletion.CASCADE, to='document.Document')),
                ('imanage_config', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='imanage_integration.IManageConfig')),
            ],
            options={
                'verbose_name_plural': 'IManage Documents',
                'ordering': ('imanage_config', 'imanage_doc_id'),
            },
        ),
        migrations.AlterUniqueTogether(
            name='imanagedocument',
            unique_together=set([('imanage_config', 'imanage_doc_id')]),
        ),
    ]
