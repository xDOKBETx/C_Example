/* Поиск папки в директории
*/
/*
string path = "D:/ONE DRIVE/OneDrive/Документы/C#/C_Example/Example001_HelloConsole"; // Строковому значению присваиваем путь к папке
DirectoryInfo di = new DirectoryInfo(path); // DirectoryInfo - тип данных, позволяющий получить информацию о директориях
System.Console.WriteLine(di.CreationTime); // время создания файла
FileInfo[] fi = di.GetFiles(); // - тип данных, позволяющий раскрыть какие содержатся файлы в директории
for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name); // Вывод имени файла
}
*/

 void CatalogInfo(string path, string indent = "") // path - путь к текущей папки, "" - отступы, чтобы видеть структуру папки
{
    DirectoryInfo catalog = new DirectoryInfo(path); // директория, по которой мы зашли по пути path
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++) // цикл, пробегает по всем файлам
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}"); // выводя информацию по каталоги
        CatalogInfo(catalogs[i].FullName, indent + "  ");  // будем рекурсивно заныривать и смотреть все файлы
    }
    FileInfo[] files = catalog.GetFiles(); // получим весь список файлов, текущей директории
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}"); // и покажем их
    }
}
string path = @"D:/ONE DRIVE/OneDrive/Документы/C#/C_Example";
CatalogInfo(path);
