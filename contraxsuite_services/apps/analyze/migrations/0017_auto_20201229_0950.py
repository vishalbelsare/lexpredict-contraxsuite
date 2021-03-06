# Generated by Django 2.2.13 on 2020-12-29 09:50

from django.conf import settings
from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        migrations.swappable_dependency(settings.AUTH_USER_MODEL),
        ('analyze', '0016_auto_20201224_0846'),
    ]

    operations = [
        migrations.AddField(
            model_name='documentsimilarity',
            name='created_by',
            field=models.ForeignKey(blank=True, null=True, on_delete=django.db.models.deletion.CASCADE, related_name='created_documentsimilarity_set', to=settings.AUTH_USER_MODEL),
        ),
        migrations.AddField(
            model_name='documentsimilarity',
            name='run_id',
            field=models.CharField(blank=True, db_index=True, max_length=50, null=True),
        ),
        migrations.AddField(
            model_name='partysimilarity',
            name='created_by',
            field=models.ForeignKey(blank=True, null=True, on_delete=django.db.models.deletion.CASCADE, related_name='created_partysimilarity_set', to=settings.AUTH_USER_MODEL),
        ),
        migrations.AddField(
            model_name='partysimilarity',
            name='run_id',
            field=models.CharField(blank=True, db_index=True, max_length=50, null=True),
        ),
        migrations.AddField(
            model_name='textunitsimilarity',
            name='created_by',
            field=models.ForeignKey(blank=True, null=True, on_delete=django.db.models.deletion.CASCADE, related_name='created_textunitsimilarity_set', to=settings.AUTH_USER_MODEL),
        ),
        migrations.AddField(
            model_name='textunitsimilarity',
            name='run_id',
            field=models.CharField(blank=True, db_index=True, max_length=50, null=True),
        ),
    ]
