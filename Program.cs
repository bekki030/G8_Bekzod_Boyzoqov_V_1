using Modul_2.Services;

namespace Modul_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var service = new Katigory();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Mijoz");
                Console.WriteLine("3. Exit");
                Console.Write("Tanlang: ");
                var choise = Console.ReadLine();
                Console.Clear();

                switch (choise)
                {
                    case "1":
                        KatigoryCenter(service);
                        Console.Clear();
                        break;
                    case "2":
                        KatigoryMijoz(service);
                        Console.Clear();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Xato, qaytadan urinib ko`ring");
                        break;
                }
            }
        }
        static void KatigoryCenter(Katigory center)
        {
            bool back = false;
            while (!back)
            {
                Console.WriteLine("Admin");
                Console.WriteLine("1. Katigoriyalar");
                Console.WriteLine("2. Menu");
                Console.WriteLine("3. Buyurtma qabul qilish");
                Console.WriteLine("4. Back");
                Console.Write("Tanlang: ");
                var choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        bool back1 = false;
                        while (!back)
                        {
                            Console.WriteLine("Admin");
                            Console.WriteLine("1. Fastfoodlar");
                            Console.WriteLine("2. Milliy taomlar");
                            Console.WriteLine("3. Ichimliklar");
                            Console.WriteLine("4. Salatlar");
                            Console.WriteLine("5. Back");
                            Console.Write("Tanlang: ");
                            var choice1 = Console.ReadLine();
                            Console.Clear();

                            switch (choice1)
                            {
                                case "1":
                                    bool back2 = false;
                                    while (!back2)
                                    {
                                        Console.WriteLine("Admin");
                                        Console.WriteLine("1. Add Fastfood");
                                        Console.WriteLine("2. Update Fastfood");
                                        Console.WriteLine("3. Delete Fastfood");
                                        Console.WriteLine("4. List Fastfood");
                                        Console.WriteLine("5. Back");
                                        Console.Write("Tanlang: ");
                                        var choice2 = Console.ReadLine();

                                        switch (choice2)
                                        {
                                            case "1":
                                                Console.Write("Fastfood nomini kiriting: ");
                                                var tName = Console.ReadLine();
                                                center.AddFastfood(tName);
                                                Console.WriteLine("Muvaffaqqiyatli qo`shildi");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;
                                            case "2":
                                                Console.Write("Fastfood Id sini kiriting: ");
                                                var tId = int.Parse(Console.ReadLine());
                                                Console.Write("Fastfood nomini kiriting: ");
                                                var newTName = Console.ReadLine();
                                                center.UpdateFastfood(tId, newTName);
                                                Console.Clear();
                                                break;
                                            case "3":
                                                Console.Write("Fastfood Id sini kiriting: ");
                                                var deleteTId = int.Parse(Console.ReadLine());
                                                center.DeleteFastfood(deleteTId);
                                                Console.Clear();
                                                break;
                                            case "4":
                                                center.ListFastfood();
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;
                                            case "5":
                                                back2 = true;
                                                Console.Clear();
                                                break;
                                            default:
                                                Console.WriteLine("Xato,qaytadan urinib ko`ring");
                                                break;
                                        }
                                    }
                                    break;
                                case "2":
                                    bool back3 = false;
                                    while (!back3)
                                    {
                                        Console.WriteLine("Admin");
                                        Console.WriteLine("1. Add Milliy Taomlar");
                                        Console.WriteLine("2. Update Milliy taomlar");
                                        Console.WriteLine("3. Delete Milliy taomlar");
                                        Console.WriteLine("4. List Milliy taomlar");
                                        Console.WriteLine("5. Back");
                                        Console.Write("Tanlang: ");
                                        var choice3 = Console.ReadLine();


                                        switch (choice3)
                                        {
                                            case "1":
                                                Console.Write("Taom nomini kiriting: ");
                                                var tName = Console.ReadLine();
                                                center.AddTaomlar(tName);
                                                Console.WriteLine("Muvaffaqqiyatli qo`shildi");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;
                                            case "2":
                                                Console.Write("Taom Id sini kiriting: ");
                                                var tId = int.Parse(Console.ReadLine());
                                                Console.Write("Taom nomini kiriting: ");
                                                var newTName = Console.ReadLine();
                                                center.UpdateTaomlar(tId, newTName);
                                                Console.Clear();
                                                break;
                                            case "3":
                                                Console.Write("Taom Id sini kiriting: ");
                                                var deleteTId = int.Parse(Console.ReadLine());
                                                center.DeleteTaomlar(deleteTId);
                                                Console.Clear();
                                                break;
                                            case "4":
                                                center.ListTaomlar();
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;
                                            case "5":
                                                back3 = true;
                                                Console.Clear();
                                                break;
                                            default:
                                                Console.WriteLine("Xato,qaytadan urinib ko`ring");
                                                break;
                                        }
                                    }
                                    break;
                                case "3":
                                    bool back4 = false;
                                    while (!back4)
                                    {
                                        Console.WriteLine("Admin");
                                        Console.WriteLine("1. Add Ichimliklar");
                                        Console.WriteLine("2. Update Ichimliklar");
                                        Console.WriteLine("3. Delete Ichimliklar");
                                        Console.WriteLine("4. List Ichimliklar");
                                        Console.WriteLine("5. Back");
                                        Console.Write("Tanlang: ");
                                        var choice4 = Console.ReadLine();


                                        switch (choice4)
                                        {
                                            case "1":
                                                Console.Write("Ichimlik nomini kiriting: ");
                                                var tName = Console.ReadLine();
                                                center.AddIchimlik(tName);
                                                Console.WriteLine("Muvaffaqqiyatli qo`shildi");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;
                                            case "2":
                                                Console.Write("Ichimlik Id sini kiriting: ");
                                                var tId = int.Parse(Console.ReadLine());
                                                Console.Write("Ichimlik nomini kiriting: ");
                                                var newTName = Console.ReadLine();
                                                center.UpdateIchimlik(tId, newTName);
                                                Console.Clear();
                                                break;
                                            case "3":
                                                Console.Write("Ichimlik Id sini kiriting: ");
                                                var deleteTId = int.Parse(Console.ReadLine());
                                                center.DeleteIchimlik(deleteTId);
                                                Console.Clear();
                                                break;
                                            case "4":
                                                center.ListIchimlik();
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;
                                            case "5":
                                                back4 = true;
                                                Console.Clear();
                                                break;
                                            default:
                                                Console.WriteLine("Xato,qaytadan urinib ko`ring");
                                                break;
                                        }
                                    }
                                    break;
                                case "4":
                                    bool back5 = false;
                                    while (!back5)
                                    {
                                        Console.WriteLine("Admin");
                                        Console.WriteLine("1. Add Salatlar");
                                        Console.WriteLine("2. Update Salatlar");
                                        Console.WriteLine("3. Delete Salatlar");
                                        Console.WriteLine("4. List Salatlar");
                                        Console.WriteLine("5. Back");
                                        Console.Write("Tanlang: ");
                                        var choice5 = Console.ReadLine();


                                        switch (choice5)
                                        {
                                            case "1":
                                                Console.Write("Salat nomini kiriting: ");
                                                var tName = Console.ReadLine();
                                                center.AddSalatlar(tName);
                                                Console.WriteLine("Muvaffaqqiyatli qo`shildi");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;
                                            case "2":
                                                Console.Write("Salat Id sini kiriting: ");
                                                var tId = int.Parse(Console.ReadLine());
                                                Console.Write("Salat nomini kiriting: ");
                                                var newTName = Console.ReadLine();
                                                center.UpdateSalatlar(tId, newTName);
                                                Console.Clear();
                                                break;
                                            case "3":
                                                Console.Write("Salat Id sini kiriting: ");
                                                var deleteTId = int.Parse(Console.ReadLine());
                                                center.DeleteSalatlar(deleteTId);
                                                Console.Clear();
                                                break;
                                            case "4":
                                                center.ListSalatlar();
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;
                                            case "5":
                                                back5 = true;
                                                Console.Clear();
                                                break;
                                            default:
                                                Console.WriteLine("Xato,qaytadan urinib ko`ring");
                                                break;
                                        }
                                    }
                                    break;
                                case "5":
                                    back = true;
                                    Console.Clear();
                                    break;
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("Admin");
                        center.GetMenu();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("Buyurtma qabul qilish");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        back = true;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Xato, qaytadan urinib ko`ring");
                        break;


                }
            }
        }
        static void KatigoryMijoz(Katigory center)
        {
            bool back = false;
            while (!back)
            {
                Console.WriteLine("Mijoz");
                Console.WriteLine("1. Katigoriyalar");
                Console.WriteLine("2. Menu");
                Console.WriteLine("3. Buyurtma berish");
                Console.WriteLine("4. Back");
                Console.Write("Tanlang: ");
                var choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        bool back1 = false;
                        while (!back1)
                        {
                            Console.WriteLine("Mijoz");
                            Console.WriteLine("1. Fastfoodlar");
                            Console.WriteLine("2. Milliy taomlar");
                            Console.WriteLine("3. Ichimliklar");
                            Console.WriteLine("4. Salatlar");
                            Console.WriteLine("5. Back");
                            Console.Write("Tanlang: ");
                            var choice1 = Console.ReadLine();
                            Console.Clear();

                            switch (choice1)
                            {
                                case "1":
                                    center.ListFastfood();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "2":
                                    center.ListTaomlar();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "3":
                                    center.ListIchimlik();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "4":
                                    center.ListSalatlar();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "5":
                                    back1 = true;
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Xato,qaytadan urinib ko`ring");
                                    break;
                            }
                        }
                        break;
                    case "2":
                        center.GetMenu();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        break;
                    case "4":
                        back=true; Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Xato,qaytadan urinib ko`ring");
                        break;
                }
            }
        }
    }
}


