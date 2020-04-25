using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examin
{
        class Program
        {
            static void Main(string[] args)
            {
                int MassCount = 0;
                Console.Write("Введите размер массива:");
                MassCount = Convert.ToInt32(Console.ReadLine());
                Mass[] newspaper = new Mass[MassCount];
                for (int i = 0; i <= MassCount; i++)
                {
                    Console.WriteLine("Введите количество страниц:");
                    newspaper[i].Page = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите название:");
                    newspaper[i].Name = Console.ReadLine();
                    Console.WriteLine("Введите владельца:");
                    newspaper[i].Owner = Console.ReadLine();
                }

            }
            public static void SaveFile(Mass[] newspaper)
            {
                using (StreamWriter pass = new StreamWriter("Newspaper.txt"))
                {
                    foreach (var i in newspaper)
                    {
                    pass.WriteLine("Название" + i.Name + "Владелец" + i.Owner + "Количество страниц" + i.Page + "\n");
                    }
                }
            }
        }
        
}   
