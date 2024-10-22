using System;

// Base class: Customer
public class Customer
{
    public string CustomerId { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    // Fixed size array for holding reservations
    public Reservation[] Reservations { get; set; }
    public int ReservationCount { get; set; }

    public Customer()
    {
        Reservations = new Reservation[10];  // Assuming a maximum of 10 reservations per customer
        ReservationCount = 0;
    }

    public void MakeReservation(Reservation reservation)
    {
        if (ReservationCount < Reservations.Length)
        {
            Reservations[ReservationCount++] = reservation;
        }
        else
        {
            Console.WriteLine("Reservation limit reached.");
        }
    }
}

// Derived class: RetailCustomer
public class RetailCustomer : Customer
{
    public string CreditCardType { get; set; }
    public string CreditCardNo { get; set; }
}

// Derived class: CorporateCustomer
public class CorporateCustomer : Customer
{
    public string CompanyName { get; set; }
    public int FrequentFlyerPts { get; set; }
    public string BillingAccountNo { get; set; }
}

// Reservation class
public class Reservation
{
    public string ReservationNo { get; set; }
    public DateTime Date { get; set; }

    // Fixed size array for holding seats reserved
    public Seat[] Seats { get; set; }
    public int SeatCount { get; set; }

    public Reservation()
    {
        Seats = new Seat[5];  // Assuming a maximum of 5 seats can be reserved at once
        SeatCount = 0;
    }

    public void AddSeat(Seat seat)
    {
        if (SeatCount < Seats.Length)
        {
            Seats[SeatCount++] = seat;
        }
        else
        {
            Console.WriteLine("Seat limit reached.");
        }
    }
}

// Seat class
public class Seat
{
    public string RowNo { get; set; }
    public string SeatNo { get; set; }
    public decimal Price { get; set; }
    public string Status { get; set; }  // e.g., reserved, available
}

// Flight class
public class Flight
{
    public string FlightId { get; set; }
    public DateTime Date { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public int SeatingCapacity { get; set; }

    // Fixed size array for seats in the flight
    public Seat[] Seats { get; set; }
    public int SeatCount { get; set; }

    public Flight()
    {
        Seats = new Seat[200];  // Assuming a maximum of 200 seats in a flight
        SeatCount = 0;
    }

    public void AddSeat(Seat seat)
    {
        if (SeatCount < Seats.Length)
        {
            Seats[SeatCount++] = seat;
        }
        else
        {
            Console.WriteLine("Seating capacity reached.");
        }
    }
}

// Test the system
class Program
{
    static void Main(string[] args)
    {
        // Create a new flight
        Flight flight = new Flight
        {
            FlightId = "FL123",
            Date = DateTime.Now,
            Origin = "New York",
            Destination = "Los Angeles",
            DepartureTime = DateTime.Now.AddHours(5),
            ArrivalTime = DateTime.Now.AddHours(8),
            SeatingCapacity = 150
        };

        // Add some seats to the flight
        Seat seat1 = new Seat { RowNo = "A", SeatNo = "1", Price = 500, Status = "Available" };
        Seat seat2 = new Seat { RowNo = "A", SeatNo = "2", Price = 500, Status = "Available" };
        flight.AddSeat(seat1);
        flight.AddSeat(seat2);

        // Create a new customer (RetailCustomer)
        RetailCustomer customer = new RetailCustomer
        {
            CustomerId = "C001",
            FirstName = "tooba",
            LastName = "Ghaffar",
            Street = "123 Main St",
            City = "Multan",
            State = "Punjab",
            ZipCode = "10001",
            Phone = "0300-2345767",
            Email = "toobaG@example.com",
            CreditCardType = "Visa",
            CreditCardNo = "4111111111111111"
        };

        // Make a reservation
        Reservation reservation = new Reservation
        {
            ReservationNo = "R001",
            Date = DateTime.Now
        };

        // Reserve a seat
        reservation.AddSeat(seat1);

        // Add the reservation to the customer
        customer.MakeReservation(reservation);

        Console.WriteLine($"Customer {customer.FirstName} {customer.LastName} reserved seat {seat1.SeatNo} on flight {flight.FlightId}.");
    }
}
