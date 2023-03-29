using System;
using System.IO;
using System.Security.Cryptography;
int a = -1;
DriveInfo[] driv = DriveInfo.GetDrives();
while (a != 5)
{
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1. Просмотр дисков");
    Console.WriteLine("2. Работа с файлами в папке D:/test");
    Console.WriteLine("3.");
    Console.WriteLine("4.");
    Console.WriteLine("5.");

    a = Convert.ToInt32(Console.ReadLine());
    switch (a)
    {
        
        case (1):
            {
                int b = -1;
                while (b != 3)
                {
                    Console.WriteLine("Выберите действие:");
                    Console.WriteLine("1. Все диски");
                    Console.WriteLine("2. Подробная информация про диски");
                    Console.WriteLine("3. Назад");
                    b = Convert.ToInt32(Console.ReadLine());
                    switch (b)
                    {
                        case (1):
                            {
                                Console.WriteLine("Все диски");
                                foreach (DriveInfo d in driv)
                                {
                                    Console.WriteLine("Диск: {0}", d.Name);
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case (2):
                            {
                                foreach (DriveInfo d in driv)
                                {
                                    Console.WriteLine("Диск:              {0}", d.Name);
                                    Console.WriteLine("Тип:               {0}", d.DriveType);
                                    if (d.IsReady)
                                    {
                                        Console.WriteLine("Свободно:          {0}", d.TotalFreeSpace);
                                        Console.WriteLine("Файловая система:  {0}", d.DriveFormat);
                                        Console.WriteLine("Метка:             {0}", d.VolumeLabel);
                                    }
                                    Console.WriteLine();
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case (3):
                            {
                                break;
                            }
                    }
                }
                Console.Clear();
                break;
            }
        case (2):
            {
                int b = -1;
                while (b != 6)
                {
                    Console.WriteLine("Выберите действие:");
                    Console.WriteLine("1. Создание файла");
                    Console.WriteLine("2. Добавление текста в файл");
                    Console.WriteLine("3. Удаление файла");
                    Console.WriteLine("4. Информация о файле");
                    Console.WriteLine("5. Назад");
                    Console.WriteLine("6. Назад");
                    b = Convert.ToInt32(Console.ReadLine());
                    switch (b)
                    {
                        case (1):
                            {
                                
                                Console.Write("Введите название файла: ");
                                string dsas = Console.ReadLine();
                                FileInfo myFile = new FileInfo($@"D:\test\{dsas}");
                                // Создание файла
                                FileStream fs = myFile.Create();
                                fs.Close();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                                
                            }
                        case (2):
                            {
                                Console.Write("Введите название файла в который надо что то написать: ");
                                string f = Console.ReadLine();
                                string myFile = $@"D:\test\{f}";
                                Console.Write("Введите текст который надо добавить в файл: ");
                                string text = Console.ReadLine();
                                // Запись в файл
                                StreamWriter fd = new StreamWriter(myFile, true);
                                fd.WriteLine(text);
                                fd.Close();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case (3):
                            {
                                Console.Write("Введите название файла который надо удалить: ");
                                string dsas = Console.ReadLine();
                                string myFile = $@"D:\test\{dsas}";
                                if (File.Exists(myFile))
                                {
                                    try
                                    {
                                        File.Delete(myFile);
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Удаление завершилось неудачей: {0}", e.Message);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Указанный файл не существует");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case (4):
                            {
                                Console.Write("Введите название файла, что бы узнать информацию про него: ");
                                string dsas = Console.ReadLine();
                                string myFile = $@"D:\test\{dsas}"; ;
                                // Получение информации о файле
                                FileInfo fileInfo = new FileInfo(myFile);
                                Console.WriteLine("Имя файла: {0}", fileInfo.Name);
                                Console.WriteLine("Размер файла: {0}", fileInfo.Length);
                                Console.WriteLine("Дата создания файла: {0}", fileInfo.CreationTime);
                                Console.WriteLine("Дата последнего изменения файла: {0}", fileInfo.LastWriteTime);
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case (5):
                            {


                                break;
                            }
                        case (6):
                            {
                                break;
                            }
                    }
                }
                Console.Clear();
                break;
            }
        case (3):
            {
                break;
            }
        case (4):
            {
                break;
            }
        case (5):
            {
                break;
            }
            Console.Clear();
    }
}
public enum FileMode
{
    CreateNew,
    Create,
    Open,
    OpenOrCreate,
    Truncate,
    Append
}

public enum FileAccess
{
    Read,
    Write,
    ReadWrite
}

public enum FileShare
{
    Delete,
    Inheritable,
    None,
    Read,
    ReadWrite,
    Weite
}










//DirectoryInfo a = new DirectoryInfo(@"D:\test");
//Console.WriteLine("Информация по папке D:test");
//Console.WriteLine("Полное имя: {0}", a.FullName);
//Console.WriteLine("Имя:        {0}", a.Name);
//Console.WriteLine("Родители:   {0}", a.Parent);
//Console.WriteLine("Создание:   {0}", a.CreationTime);
//Console.WriteLine("Атрибуты:   {0}", a.Attributes);
//Console.WriteLine("Root:       {0}", a.Root);

//Console.WriteLine();