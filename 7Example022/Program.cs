// Обход директории

/* string path = "C:/Users/Наталия/Documents/ТЕСТИРОВЩИК/Prog2_etc/1Example001_HelloConsole";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
 */


void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DerectoryInfo(path);

    DirectoryInfo[] catalog = catalog.GetDirectories();
    for (int i = 0; i < catalog.Length; i++)
    {
        Console.WriteLine($"{indent}{catalog[i].Name}");
        CatalogInfo(catalog[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path = @"C:/Users/Наталия/Documents/ТЕСТИРОВЩИК/Prog2_etc/1Example001_HelloConsole";
CatalogInfo(path);