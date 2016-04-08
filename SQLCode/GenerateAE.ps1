# Generated by SQL Server Management Studio at 7:11 PM on 4/7/2016
$extensionsApplicationLocation = 'C:\Program Files (x86)\Microsoft SQL Server\130\Tools\Binn\ManagementStudio\Extensions\Application\'
$dacLocation = 'C:\Program Files (x86)\Microsoft SQL Server\130\DAC\bin\'

# Load reflected assemblies

[reflection.assembly]::LoadwithPartialName('System.Data.SqlClient') | Out-Null
[reflection.assembly]::LoadwithPartialName('Microsoft.SQLServer.SMO') | Out-Null
[reflection.assembly]::LoadwithPartialName('System.Security.Cryptography.X509Certificates') | Out-Null
[reflection.assembly]::LoadFile($dacLocation + 'Microsoft.SqlServer.Dac.dll')
[reflection.assembly]::LoadFile($dacLocation + 'Microsoft.SqlServer.Dac.Extensions.dll')
[reflection.assembly]::LoadFile($dacLocation + 'Microsoft.Data.Tools.Utilities.dll')
[reflection.assembly]::LoadFile($dacLocation + 'Microsoft.Data.Tools.Schema.Sql.dll')
[reflection.assembly]::LoadFile($extensionsApplicationLocation + 'Microsoft.IdentityModel.Clients.ActiveDirectory.dll')
[reflection.assembly]::LoadFile($extensionsApplicationLocation + 'Microsoft.IdentityModel.Clients.ActiveDirectory.WindowsForms.dll')
[reflection.assembly]::LoadFile($extensionsApplicationLocation + 'Microsoft.SqlServer.Management.AzureAuthenticationManagement.dll')
[reflection.assembly]::LoadFile($extensionsApplicationLocation + 'Microsoft.Azure.KeyVault')
[reflection.assembly]::LoadFile($extensionsApplicationLocation + 'Microsoft.SqlServer.Management.AlwaysEncrypted.Management.dll')
[reflection.assembly]::LoadFile($extensionsApplicationLocation + 'Microsoft.SqlServer.Management.AlwaysEncrypted.AzureKeyVaultProvider.dll')
[reflection.assembly]::LoadFile($extensionsApplicationLocation + 'Microsoft.SqlServer.Management.AlwaysEncrypted.Types.dll')

# Set up connection and database SMO objects

$sqlConnectionString = 'Data Source=JOLLYGREENGIANT\SQL2016;Integrated Security=True;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;Packet Size=4096;Application Name="Microsoft SQL Server Management Studio";Column Encryption Setting = Enabled'
$smoServerConnection = New-Object 'Microsoft.SqlServer.Management.Common.ServerConnection' $sqlConnection
$smoServer = New-Object 'Microsoft.SqlServer.Management.Smo.Server' 'JOLLYGREENGIANT\SQL2016'
$smoDatabase = $smoServer.Databases['AlwaysEncryptedDemo']

# Change encryption schema

$AEAD_AES_256_CBC_HMAC_SHA_256 = 'AEAD_AES_256_CBC_HMAC_SHA_256'

# Change table [dbo].[EncryptTest]
$smoTable = $smoDatabase.Tables['EncryptTest', 'dbo']
$encryptionChanges = New-Object 'Collections.Generic.List[Microsoft.SqlServer.Management.AlwaysEncrypted.Types.ColumnInfo]'
$encryptionChanges.Add($(New-Object 'Microsoft.SqlServer.Management.AlwaysEncrypted.Types.ColumnInfo' 'email', $(New-Object 'Microsoft.SqlServer.Management.AlwaysEncrypted.Types.EncryptionInfo' 'CEK_Auto1', ([Microsoft.SqlServer.Management.AlwaysEncrypted.Types.EncryptionType]::Deterministic), $AEAD_AES_256_CBC_HMAC_SHA_256)))
[Microsoft.SqlServer.Management.AlwaysEncrypted.Management.AlwaysEncryptedManagement]::SetColumnEncryptionSchema($sqlConnectionString, $smoDatabase, $smoTable, $encryptionChanges, $null)

