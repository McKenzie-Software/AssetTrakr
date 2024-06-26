; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "AssetTrakr"
#define MyAppVersion "1.0.7"
#define MyAppPublisher "McKenzie Software"
#define MyAppURL "https://assettrakr.laim.scot"
#define MyAppExeName "AssetTrakr.App.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{F47B11ED-9C45-4AD4-B2F2-B2EB93F8326D}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppPublisher}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
LicenseFile=C:\Development\Source Code\AssetTrakr\AssetTrakr\LICENSE.MD
; Remove the following line to run in administrative install mode (install for all users.)
PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog
OutputBaseFilename=AssetTrakr_{#MyAppVersion}_win64-setup
Compression=lzma
SolidCompression=yes
WizardStyle=modern
SetupIconFile=C:\Development\Source Code\AssetTrakr\AssetTrakr\AssetTrakr.App\ATIcon-256.ico

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Development\Source Code\AssetTrakr\AssetTrakr\AssetTrakr.App\bin\Release\net8.0-windows\win-x64\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Development\Source Code\AssetTrakr\AssetTrakr\AssetTrakr.App\bin\Release\net8.0-windows\win-x64\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Development\Source Code\AssetTrakr\AssetTrakr\AssetTrakr.App.Migrator\bin\Release\net8.0-windows\win-x64\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

