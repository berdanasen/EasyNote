### Projeyi GitHub'dan Klonladýktan Sonra

1. Solution klasörü içerisinde AppSettingsSecrets.config adýnda bir dosya oluþturun ve içeriði þu þekilde olsun:

```xml
<appSettings>
	<add key="SmtpUserName" value="user@example.com" />
	<add key="SmtpPassword" value="***********" />
	<add key="GoogleClientId" value="**********" />
	<add key="GoogleClientSecret" value="**********" />
</appSettings>
```

2. Proje klasörü içerisinde ConnectionStrings.config adýnda bir dosya oluþturun ve içeriði þu þekilde olsun:

```xml
<connectionStrings>
	<add name="DefaultConnection" connectionString="server=***;database=***;user id=***;password=***" providerName="System.Data.SqlClient" />
</connectionStrings>
```