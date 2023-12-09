using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {

        TimeSpan fivePM = new TimeSpan(17, 0, 0);
        TimeSpan tenAM = new TimeSpan(10, 0, 0);
        TimeSpan twelvePM = new TimeSpan(12, 0, 0);

        Address lecturesAddress = new Address("257 General beyers Street", "Pretoria North", "South Africa");
        Address receptionAddress = new Address("127 Mooikloof Road", "Vallery ", "Denmark");
        Address outdoorGatheringAddress = new Address("9 Cobalt", "Ocean View", "Ghana");

        Event lectureEvent = new Lectures("How To Make Money Online", "This lecture teaches students how to make money in the comfort of their own homes.", DateTime.Now, fivePM, lecturesAddress, "Fezile Mbatha", 50);
        Event receptionEvent = new Receptions("Mike Weds Sandra", "Join Mike and Sandra as they celebrate their Union.", DateTime.Now, tenAM, receptionAddress, "SandraM@gmail.com");
        Event outdoorGatheringEvent = new OutdoorGatherings("Beach Party", "All employees are invited to the year end function of Dream Markerting team. ", DateTime.Now, twelvePM, outdoorGatheringAddress, "Sunny");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(outdoorGatheringEvent.GetStandardDetails());

        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(outdoorGatheringEvent.GetFullDetails());

        Console.WriteLine("\nShort Descriptions:");
        Console.WriteLine(lectureEvent.GetShortDetails());
        Console.WriteLine(receptionEvent.GetShortDetails());
        Console.WriteLine(outdoorGatheringEvent.GetShortDetails());
    }

}








