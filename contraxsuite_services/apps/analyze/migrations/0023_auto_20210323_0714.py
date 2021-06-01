# Generated by Django 2.2.18 on 2021-03-23 07:14

import apps.analyze.models
import django.core.validators
from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('analyze', '0022_load_document_transformer'),
    ]

    operations = [
        # the class BaseTransformerManager was deleted
        #migrations.AlterModelManagers(
        #    name='documenttransformer',
        #    managers=[
        #        ('objects', apps.analyze.models.BaseTransformerManager()),
        #    ],
        #),
        #migrations.AlterModelManagers(
        #    name='textunittransformer',
        #    managers=[
        #        ('objects', apps.analyze.models.BaseTransformerManager()),
        #    ],
        #),
        migrations.AddField(
            model_name='similarityrun',
            name='similarity_threshold',
            field=models.PositiveSmallIntegerField(blank=True, db_index=True, default=75, null=True, validators=[django.core.validators.MinValueValidator(50), django.core.validators.MaxValueValidator(100)]),
        ),
        migrations.AddField(
            model_name='similarityrun',
            name='use_tfidf',
            field=models.BooleanField(blank=True, db_index=True, default=False, null=True),
        ),
    ]