# Generated by Django 2.2.13 on 2020-12-16 14:37

from django.db import migrations, models


def migrate(apps, schema_editor):
    DocumentType = apps.get_model('document', 'DocumentType')
    DocumentType.objects \
        .filter(editor_type__isnull=True) \
        .update(editor_type='save_by_field')


class Migration(migrations.Migration):

    dependencies = [
        ('document', '0220_merge_20201119_1037'),
    ]

    operations = [
        migrations.AlterModelOptions(
            name='documentfield',
            options={'ordering': ('long_code',), 'permissions': (('view_documentfield_stats', 'View document field stats'), ('clone_documentfield', 'Clone document field'))},
        ),
        migrations.AlterField(
            model_name='documenttype',
            name='editor_type',
            field=models.CharField(choices=[('save_by_field', 'Save Fields Individually'), ('save_all_fields_at_once', 'Save All Fields At Once'), ('no_text', 'No Text')], default='save_by_field', max_length=100),
        ),
        migrations.RunPython(
            migrate, reverse_code=migrations.RunPython.noop
        )

    ]