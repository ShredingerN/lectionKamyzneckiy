// // путь к папке
// string path = @"C:\Users\jo467\Downloads\Тестировщик\TaskKamyaneckiy\HelloConsole";
// // штука для работы с папками(директорями), выделяем память и кладем туда путь к папке.
// DirectoryInfo di = new DirectoryInfo(path);
// // смотрим дату создания папки
// System.Console.WriteLine(di.CreationTime);

// // Посмотрим файлы, содержащие в папке
// FileInfo [] fi = di.GetFiles(); //<---массив
// for (int i = 0; i < fi.Length; i++)
// {
//     // Получаем имена всех файлов в папке
//     System.Console.WriteLine(fi[i].Name);
// }

// Рекурсия для директорий
void CatalogInfo(string path, string indent = "") //<---отступы для красоты
{
    // Информация о директории
    DirectoryInfo catalog = new DirectoryInfo(path);
    // получаем массив файлов
    DirectoryInfo [] catalogs = catalog.GetDirectories();
    for ( int i = 0; i < catalogs.Length; i++)
    {
        // Выводим инфу о текущем каталоге
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        // Заныриваем с помощью рекурсии
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    // Список файлов
    FileInfo [] files = catalog.GetFiles(); 
     for ( int i = 0; i < files.Length; i++)
    {
        // Вывод файлов
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = @"C:\Users\jo467\Downloads\Тестировщик\TaskKamyaneckiy\L3Task1MethDescr";
CatalogInfo(path);