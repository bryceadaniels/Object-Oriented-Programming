using System;

class Program
{
    static void Main(string[] args)
    {
        Address addy = new Address("210 W 4th S", "Rexburg", "ID", "USA");
        
        LectureEvent lectureEvent = new LectureEvent("Bro Comeau",30,"Class","Programming with Classes", "March 21","9:00 AM",addy);
        System.Console.WriteLine("Lecture Event");
        System.Console.WriteLine("Full Message");
        lectureEvent.FullMessage();
        System.Console.WriteLine("Standard Message");
        lectureEvent.StandardMessage();
        System.Console.WriteLine("Short Message");
        lectureEvent.ShortMessage();
        
        ReceptionEvent receptionEvent = new ReceptionEvent("RSVP@email.com","Wedding Reception","Brenden's wedding","April 8","3:00 PM",addy);
        System.Console.WriteLine();
        System.Console.WriteLine("Reception Event");
        System.Console.WriteLine("Full Message");
        receptionEvent.FullMessage();
        System.Console.WriteLine("Standard Message");
        receptionEvent.StandardMessage();
        System.Console.WriteLine("Short Message");
        receptionEvent.ShortMessage();
        
        OutdoorEvent outdoorEvent = new OutdoorEvent("Sunny","Football game","UGA v Alabama","Dec 31","7:00 PM", addy);
        System.Console.WriteLine();
        System.Console.WriteLine("Outdoor Event");
        System.Console.WriteLine("Full Message");
        outdoorEvent.FullMessage();
        System.Console.WriteLine("Standard Message");
        outdoorEvent.StandardMessage();
        System.Console.WriteLine("Short Message");
        outdoorEvent.ShortMessage();

    }
}