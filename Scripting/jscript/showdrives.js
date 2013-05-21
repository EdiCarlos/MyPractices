// JScript source code

function ShowFreeSpace(drvPath)
{

var fso,d,s;
fso = new ActiveXObject("Scripting.FileSystemOjbect");
d = fso.GetDrive(fso.GetDriveName(drvPath));
s = "Drive " + drvPath + "-";
s += "Free Space : "  + d/1024 +" kilobyte";
}

var v = ShowFreeSpace("d:\");
print(v);