# Generated by Django 2.2.13 on 2021-03-11 05:43

from django.db import migrations
from apps.common import redis


def clear_appvar_cache(apps, schema_editor):
    AppVar = apps.get_model('common', 'AppVar')

    from apps.common.app_vars import BUILD_DATE, RELEASE_VERSION, CUSTOM_LOGO_URL, SUPPORT_EMAIL
    qs = AppVar.objects \
        .filter(category=BUILD_DATE.category,
                name__in=[BUILD_DATE.name, RELEASE_VERSION.name, CUSTOM_LOGO_URL.name, SUPPORT_EMAIL.name])
    qs.update(access_type='all')

    from apps.notifications.app_vars import APP_VAR_EMAIL_HOST, APP_VAR_EMAIL_PORT, APP_VAR_EMAIL_USE_TLS, \
        APP_VAR_EMAIL_HOST_USER, APP_VAR_EMAIL_HOST_PASSWORD
    AppVar.objects \
        .filter(category=APP_VAR_EMAIL_HOST.category,
                name__in=[APP_VAR_EMAIL_HOST.name, APP_VAR_EMAIL_PORT.name, APP_VAR_EMAIL_USE_TLS.name,
                          APP_VAR_EMAIL_HOST_USER.name, APP_VAR_EMAIL_HOST_PASSWORD.name]) \
        .update(access_type='admin')

    for key in redis.list_keys('app_var:*'):
        key = key.decode('utf-8')
        redis.popd(key, False)


class Migration(migrations.Migration):

    dependencies = [
        ('common', '0038_auto_20210309_1324'),
    ]

    operations = [
        migrations.RunPython(clear_appvar_cache, reverse_code=migrations.RunPython.noop)
    ]


