# Generated by Django 2.2.13 on 2021-02-22 08:51

from django.conf import settings
from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        ('document', '0232_document_pdf_presentation_binary'),
    ]

    operations = [
        migrations.AlterField(
            model_name='document',
            name='created_by',
            field=models.ForeignKey(blank=True, null=True, on_delete=django.db.models.deletion.SET_NULL, related_name='created_document_set', to=settings.AUTH_USER_MODEL),
        ),
        migrations.AlterField(
            model_name='document',
            name='created_date',
            field=models.DateTimeField(blank=True, db_index=True, null=True),
        ),
        migrations.AlterField(
            model_name='document',
            name='modified_by',
            field=models.ForeignKey(blank=True, null=True, on_delete=django.db.models.deletion.SET_NULL, related_name='modified_document_set', to=settings.AUTH_USER_MODEL),
        ),
        migrations.AlterField(
            model_name='document',
            name='modified_date',
            field=models.DateTimeField(blank=True, db_index=True, null=True),
        ),
        migrations.AlterField(
            model_name='historicaldocument',
            name='created_date',
            field=models.DateTimeField(blank=True, db_index=True, null=True),
        ),
        migrations.AlterField(
            model_name='historicaldocument',
            name='modified_date',
            field=models.DateTimeField(blank=True, db_index=True, null=True),
        ),
    ]
