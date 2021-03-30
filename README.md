### Projeyi GitHub'dan Klonlad�ktan Sonra

1. Solution klas�r� i�erisinde AppSettingsSecrets.config ad�nda bir dosya olu�turun ve i�eri�i �u �ekilde olsun:

```xml
<appSettings>
	<add key="SmtpUserName" value="user@example.com" />
	<add key="SmtpPassword" value="***********" />
	<add key="GoogleClientId" value="**********" />
	<add key="GoogleClientSecret" value="**********" />
</appSettings>
```

2. Proje klas�r� i�erisinde ConnectionStrings.config ad�nda bir dosya olu�turun ve i�eri�i �u �ekilde olsun:

```xml
<connectionStrings>
	<add name="DefaultConnection" connectionString="server=***;database=***;user id=***;password=***" providerName="System.Data.SqlClient" />
</connectionStrings>
```