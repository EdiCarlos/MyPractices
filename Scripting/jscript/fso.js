function GetFreeSpace(drvPath) {
   var fs, d, s;
   fs = new ActiveXObject("Scripting.FileSystemObject");
   d = fs.GetDrive(fs.GetDriveName(drvPath));
   s = "Drive " + drvPath + " - " ;
   s += d.VolumeName;
   s += " Free Space: " + d.FreeSpace/1024 + " Kbytes";
   return s;
}

var username = new ActiveXObject("WScript.Network");

print(username);
 