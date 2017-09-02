// requires Windows 7 Service Pack 1, Windows 8, Windows 8.1, Windows Server 2008 R2 SP1, Windows Server 2008 Service Pack 2, Windows Server 2012, Windows Server 2012 R2, Windows Vista Service Pack 2
// WARNING: express setup (downloads and installs the components depending on your OS) if you want to deploy it on cd or network download the full bootsrapper on website below
// http://www.microsoft.com/en-us/download/details.aspx?id=42642

[CustomMessages]
dotnetfx45_title=.NET Framework 4.5.2

dotnetfx45_size=1 MB - 68 MB

;http://www.microsoft.com/globaldev/reference/lcid-all.mspx
en.dotnetfx45_lcid=
de.dotnetfx45_lcid=/lcid 1031


[Code]
const
	dotnetfx45_url = 'http://download.microsoft.com/download/B/4/1/B4119C11-0423-477B-80EE-7A474314B347/NDP452-KB2901954-Web.exe';

procedure dotnetfx45(MinVersion: integer);
begin
	if (not netfxinstalled(NetFx45, '') or (netfxspversion(NetFx45, '') < MinVersion)) then
		AddProduct('dotnetfx45.exe',
			CustomMessage('dotnetfx45_lcid') + ' /passive /norestart',
			CustomMessage('dotnetfx45_title'),
			CustomMessage('dotnetfx45_size'),
			dotnetfx45_url,
			false, false);
end;