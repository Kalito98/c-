using System;

class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        string address = Console.ReadLine();
        string number = Console.ReadLine();
        string faxnumber = Console.ReadLine();
        string webSite = Console.ReadLine();
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        string age = Console.ReadLine();
        string phone = Console.ReadLine();
        if (faxnumber == "")
        {
            faxnumber = "(no fax)";
        }
        Console.WriteLine(name);
        Console.WriteLine("Address: {0}", address);
        Console.WriteLine("Tel. {0}", number);
        Console.WriteLine("Fax: {0}", faxnumber);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {3} (age: {1}, tel. {2})", firstName, age, phone, lastName);
    }
}

