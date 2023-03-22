File.Create("D:\\data.txt");
if (File.Exists("D:\\data.txt")) Console.WriteLine("Exists");
Console.ReadKey();
try
{
    File.Delete("D:\\data.txt");
}
catch
{
    Console.WriteLine("Bum");
}
var f =  File.GetAttributes("D:\\Moderní písmo.pptx").ToString();
Console.WriteLine(f);
string soubor = @"D:\\Moderní písmo.pptx";
Console.WriteLine("Čas vytvoření souboru je: " + File.GetCreationTime(soubor));
Console.WriteLine("Čas posledního přístupu k souboru je: " + File.GetLastAccessTime(soubor));
Console.WriteLine("Čas posledního zápisu do souboru je: " + File.GetLastWriteTime(soubor));
FileInfo fi = new FileInfo(soubor);
long velikostSouboru = fi.Length;
Console.WriteLine(velikostSouboru);
Console.ReadKey();
string rodicovskaSlozka = @"D:\IKT-E1A";
var d = Directory.GetDirectories(rodicovskaSlozka, "*", SearchOption.AllDirectories);
foreach (var x in d)
{
    Console.WriteLine(x);
};
string[] s = Directory.GetFiles(rodicovskaSlozka);
foreach (var x in s)
{
    Console.WriteLine(x);
}

DriveInfo[] allDrives = DriveInfo.GetDrives();
foreach (DriveInfo dr in allDrives)
{
    Console.WriteLine("Drive {0}", dr.Name);
    Console.WriteLine("  Drive type: {0}", dr.DriveType);
    if (dr.IsReady == true)
    {
        Console.WriteLine("  Volume label: {0}", dr.VolumeLabel);
        Console.WriteLine("  File system: {0}", dr.DriveFormat);
        Console.WriteLine("  Available space to current user:{0, 15} bytes", dr.AvailableFreeSpace);
        Console.WriteLine("  Total available space:          {0, 15} bytes", dr.TotalFreeSpace);
        Console.WriteLine("  Total size of drive:            {0, 15} bytes ", dr.TotalSize);
    }
}