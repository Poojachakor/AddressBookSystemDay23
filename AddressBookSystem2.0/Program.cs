namespace AddressBookSystem2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...Welcome to Address Book...");
            AddressBook Book = new AddressBook();
            Book.CreateContact();
            Console.ReadLine();
        }
    }
}
