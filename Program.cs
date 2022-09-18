using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;
using TreatmentExceptions.Entities;

namespace Course.Entities;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Number room: ");
        int numberroom = int.Parse(Console.ReadLine());

        Console.WriteLine("Entry date: ");
        DateTime entrydate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Departure date: ");
        DateTime departuredate = DateTime.Parse(Console.ReadLine());

        if (departuredate <= entrydate)
        {
            Console.WriteLine("Error in reservation! : Departure date must be after entry date");
        }
        else
        {
            Reservation reservation = new Reservation(numberroom, entrydate, departuredate);
            Console.WriteLine(reservation);

            Console.WriteLine();
            Console.Write("Want update reservation (y/n)?");
            char ans = char.Parse(Console.ReadLine());
            if (ans == 'y')
            {
                Console.Write("Enter date to update reservation: ");
                Console.Write("Entry date: ");
                entrydate = DateTime.Parse(Console.ReadLine());
                Console.Write("DepartureDate: ");
                departuredate = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;

                if(entrydate < now || departuredate < now)
                {
                    Console.WriteLine("Error in reservation : Date entry and departure must be after now");
                }
                else if(departuredate <= entrydate)
                {
                    Console.WriteLine("Error in reservation! : Departure date must be after entry date");
                }
                else 
                { 
                    reservation.UpdateDate(entrydate, departuredate);
                    Console.WriteLine(reservation);
                }
            }
            else
            {
                Console.WriteLine(reservation);
            }


        }
        

    }
}