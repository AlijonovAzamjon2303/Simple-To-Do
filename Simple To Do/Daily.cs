
using System.Runtime.CompilerServices;

namespace Simple_To_Do
{
    public class Daily
    {
        public static void SimpleToDo()
        {
            List<string> works = new List<string>();
            bool isWork = true;
            while(isWork)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("1.Ishlar ro'yxatini ko'rish");
                Console.WriteLine("2.Ish qo'shish");
                Console.WriteLine("3.Ish o'zgartirish");
                Console.WriteLine("4.Ish o'chirish");
                Console.WriteLine("5.Dasturdan chiqish");
                Console.WriteLine("----------------------------------------------");
                Console.Write("n = ");
                int n = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("----------------------------------------------");
                switch (n)
                {
                    case 1:
                        {
                            if(works.Count == 0) Console.WriteLine("Ishlar ro'yxati bo'sh!");
                            for (int i = 0; i < works.Count; i++)
                                Console.WriteLine($"{i}. {works[i]}");
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Yangi ishni kiriting : ");
                            works.Add(Console.ReadLine());
                            Console.WriteLine("Ish muvaffaqiyatli qo'shildi!");
                        }
                        break;
                    case 3:
                        {
                            Console.Write($"O'zgartirmoqchi bo'lgan ishingizni id[0 - {works.Count - 1}] sini kiriting : ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Yangi o'rindosh ishni kiriting : "); 
                            works[id] = Console.ReadLine();
                            Console.WriteLine("Ish muvaffaqiyatli o'zgartirildi!");
                        }
                        break;
                    case 4:
                        {
                            Console.Write($"O'chirmoqchi bo'lgan ishingizni id[0 - {works.Count - 1}] sini kiriting : ");
                            int id = int.Parse(Console.ReadLine());
                            works.RemoveAt(id);
                            Console.WriteLine("Ish muvaffaqiyatli o'chirildi!");
                        }
                        break;
                    case 5:
                        {
                            isWork = false;
                            Console.WriteLine("Dastur muvaffaqiyatli tugatildi!");
                        }
                        break;
                }
                Console.WriteLine("----------------------------------------------");
            }
        }
    }
}
