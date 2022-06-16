using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        { menu:
            Book book = new Book();
            Worker worker = new Worker();
            Library library = new Library();
            Consolee.WriteLine("Kitabxanaya ishci elave et");
            Consolee.WriteLine("Kitabxanaya kitab elave et");
            Consolee.WriteLine("Kitabxanadan ishci sil ");
            Consolee.WriteLine("Kitabxanadan kitab sil");
            string cavab = Console.ReadLine();
            switch (cavab)
            {
                case "1":
                    Consolee.Write("elave etmek istediyiniz ishchinin adini daxil edin: ");
                    worker.Name = Console.ReadLine();
                    Consolee.Write("elave etmek istediyiniz ishchinin soyadini daxil edin: ");
                    worker.Surname = Console.ReadLine();
                    inputage:
                    Consolee.Write("yashi daxil edin: ");
                    string agestr = Console.ReadLine();
                    bool Isint = int.TryParse(agestr, out int age);
                    worker.Age = age;
                    if (!Isint) { Consolee.WriteLine("duzgun daxil edin!!", ConsoleColor.Red); goto inputage; }
                    inputmaash:
                    Consolee.Write("maashi daxil edin: ");
                    string maashstr = Console.ReadLine();
                    bool isintt = int.TryParse(maashstr, out int maassh);
                    worker.maash = maassh;
                    if (!isintt)
                    {
                        Consolee.WriteLine("Duzgun daxil edin!!", ConsoleColor.Red); goto inputmaash;
                    }
                    library._workers.Add(worker);
                    goto menu;
                case "2":
                    Consolee.Write("elave etmek istediyiniz kitabin adini daxil edin: ");
                    book.Name= Console.ReadLine();
                    break;
            }
        }
    }
}
