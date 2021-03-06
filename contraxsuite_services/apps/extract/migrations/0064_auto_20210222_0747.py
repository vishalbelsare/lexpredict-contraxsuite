# Generated by Django 2.2.13 on 2021-02-22 07:47

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('extract', '0063_companytype_companytypetag'),
    ]

    operations = [
        migrations.AlterField(
            model_name='companytypetag',
            name='name',
            field=models.CharField(db_index=True, default='', max_length=100, unique=True),
        ),
        migrations.AlterField(
            model_name='term',
            name='definition_url',
            field=models.CharField(max_length=1024, null=True, verbose_name='Locale'),
        ),
    ]
