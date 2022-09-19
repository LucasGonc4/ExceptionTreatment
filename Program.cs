using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;
using TreatmentExceptions.Entities;
using TreatmentExceptions.Exceptions;

namespace Course.Entities;

class Program
{
    static void Main(string[] args)
    
    {
        try
        {
            Console.WriteLine("Number room: ");
            int numberroom = int.Parse(Console.ReadLine());

            Console.WriteLine("Entry date: ");
            DateTime entrydate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Departure date: ");
            DateTime departuredate = DateTime.Parse(Console.ReadLine());

            Reservation reservation = new Reservation(numberroom, entrydate, departuredate);
            Console.WriteLine(reservation);
            Console.WriteLine();

            Console.Write("Want update reservation (y/n)?");
            char ans = char.Parse(Console.ReadLine());

            if (ans == 'y')
            {
                Console.WriteLine("Enter date to update reservation: ");
                Console.WriteLine();

                Console.Write("Entry date: ");
                entrydate = DateTime.Parse(Console.ReadLine());

                Console.Write("Departure Date: ");
                departuredate = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDate(entrydate, departuredate);
            }
            else
            {
                Console.WriteLine(reservation);
            }
        }
        catch (DomainException e)
        {
            Console.WriteLine("Error in reservation: " + e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Format error: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected error" + e.Message);
        }




    }
}