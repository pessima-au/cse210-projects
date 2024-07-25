using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("121 Wilkinson Rd.", "Freetown", "WA", "00232");
        Lecture lecture = new Lecture("Python Programming", "An in-depth lecture on Python.", "2024-08-01", "10:00 AM", address1, "John Mansaray", 100);

        Address address2 = new Address("59 Independence Avenue", "Accra", "GH", "00253");
        Reception reception = new Reception("Networking Event", "An evening to network with professionals.", "2024-09-15", "6:00 PM", address2, "rsvp@networking.com");

        Address address3 = new Address("Approved School Field", "Freetown", "WU", "00243");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Community Picnic", "A fun picnic for the whole community.", "2024-07-30", "12:00 PM", address3, "Sunny");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (Event eventItem in events)
        {
            Console.WriteLine(eventItem.StandardDetails());
            Console.WriteLine();
            Console.WriteLine(eventItem.FullDetails());
            Console.WriteLine();
            Console.WriteLine(eventItem.ShortDescription());
            Console.WriteLine("--------------------------------------------------\n");
        }
    }
}