using System;

class Address {
    private string street;
    private string city;
    private string state;
    private string zipcode;

    public Address(string street, string city, string state, string zipcode) {
        this.street = street;
        this.city = city;
        this.state = state;
        this.zipcode = zipcode;
    }

    public string GetAddress() {
        return $"{street}, {city}, {state} {zipcode}";
    }
}

class Event {
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
    private Address address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address) {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetStandardDetails() {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToString("D")}\nTime: {time.ToString("h\\:mm tt")}\nAddress: {address.GetAddress()}";
    }

    public virtual string GetFullDetails() {
        return GetStandardDetails();
    }

    public string GetShortDescription() {
        return $"Type: {GetType().Name}\nTitle: {title}\nDate: {date.ToString("D")}";
    }
}

class Lecture : Event {
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity) 
        : base(title, description, date, time, address) {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails() {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}

class Reception : Event {
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail) 
        : base(title, description, date, time, address) {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails() {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }
}

class OutdoorGathering : Event {
    private string weather;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weather) 
        : base(title, description, date, time, address) {
        this.weather = weather;
    }

    public override string GetFullDetails() {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather: {weather}";
    }
}
class Program {
    static void Main(string[] args) {
        Address address1 = new Address("6567 Alm Street", "Mkoba ", "GW", "12345");
        Address address2 = new Address("456 Elm St", "Ascot", "GW", "67890");
        Address address3 = new Address("789 Maple St", "Masvingo", "MT", "54321");

        Lecture lecture = new Lecture("Introduction to C#", "Learn the basics of C# programming", new DateTime(2023, 4, 1), new TimeSpan(14, 0, 0), address1, "John Smith", 50);
        Reception reception = new Reception("Networking Event", "Meet and network with other professionals", new DateTime(2023, 4, 15), new TimeSpan(18, 30, 0), address2, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Family Picnic", "Enjoy a day of outdoor activities and games", new DateTime(2023, 4, 22), new TimeSpan(11, 0, 0), address3, "Sunny and warm");

        Console.WriteLine("--- Standard Details ---");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetStandardDetails());

        Console.WriteLine("--- Full Details ---");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());

        Console.WriteLine("--- Short Descriptions ---");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}

