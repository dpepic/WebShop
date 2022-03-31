using WebShop;

List<Person> persons = new();
Person? loggedIn = null;
persons.Add(new Admin { _name = "test", _email = "a@a.a", _password = "asdqwe" });
persons.Add(new Admin { _name = "qwe", _email = "b@b.b", _password = "asdqwe" });
persons.Add(new Admin { _name = "zsxc", _email = "c@c.c", _password = "asdqwe" });
do
{ 
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
    if (loggedIn is not null)
    {
        Console.WriteLine($"~Zdravo {loggedIn._name}!~");
    }
    Console.WriteLine("1. Novi nalog");

    if (loggedIn is null)
    {
        Console.WriteLine("2. Uloguj se");
    } else
    {
        Console.WriteLine("2. Izloguj se");
    }
    
    Console.WriteLine("3. Izlaz");
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");

    var unos = Console.ReadKey();

    switch(unos.Key)
    {
        case ConsoleKey.D1:
            Admin admin = new();
            Console.Write("Unesi mejl: ");
            admin._email = Console.ReadLine();
            Console.Write("Unesi sifru: ");
            admin._password = Console.ReadLine();
            Console.Write("Unesi grad: ");
            admin._address._city = Console.ReadLine();
            persons.Add(admin);
            break;
        case ConsoleKey.D2:
            if (loggedIn is null)
            {
                Console.Write("Unesi mejl: ");
                string email = Console.ReadLine();
                Console.Write("Unesi sifru: ");
                string password = Console.ReadLine();

                /* for(int indeks = 0; indeks < persons.Count; indeks++)
                 {
                     Console.WriteLine($"Imamo {persons[indeks]._email}");
                     if (persons[indeks]._email == email)
                     {
                         Console.WriteLine("Nasao!");
                     }
                 }*/

                /*foreach(Person person in persons)
                {
                    Console.WriteLine($"Imamo {person._email}");
                    if (person._email == email)
                    {
                        Console.WriteLine("Nasao!");
                    }
                }*/

                loggedIn = persons
                    .Where(person => person._email == email && person._password == password)
                    .FirstOrDefault();
                if (loggedIn is not null)
                {
                    Console.WriteLine("Ulogovan si!");
                }
            }else
            {
                loggedIn = null;
                Console.WriteLine("Izlogovan si!");
            }
            break;
        case ConsoleKey.D3:
            Console.WriteLine("\nizlazzz");
            break;
        default:
            Console.WriteLine("\nPogresan unos");
            break;
    }
    if (unos.Key == ConsoleKey.D3)
    {
        break;
    }
    /*if (unos.Key == ConsoleKey.D1)
    {
        Console.WriteLine("\nTreba da pravimo novi nalog");
    }
    else if (unos.Key == ConsoleKey.D2)
    {
        Console.WriteLine("\nTreba da se ulogujemo");
    }
    else if (unos.Key == ConsoleKey.D3)
    {
        Console.WriteLine("\nizlazzz");
        break;
    }
    else
    {
        Console.WriteLine("\nPogresan unos");
    }*/
} while (true);
