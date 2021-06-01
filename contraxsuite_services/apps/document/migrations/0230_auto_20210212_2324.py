# Generated by Django 2.2.13 on 2021-02-12 23:24

from django.conf import settings
from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('document', '0229_add_mod_hist_rawdb_fields'),
    ]

    operations = [
        migrations.AlterField(
            model_name='documenttype',
            name='managers',
            field=models.ManyToManyField(blank=True, help_text='Choose which users can modify this Document Type. Users chosen as Managers can be of any System-Level Permission.', related_name='document_type_managers', to=settings.AUTH_USER_MODEL),
        ),
    ]