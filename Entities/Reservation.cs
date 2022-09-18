using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreatmentExceptions.Entities
{
    internal class Reservation
    {
        public int NumberRoom { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int numberRoom, DateTime checkIn, DateTime checkOut)
        {
            NumberRoom = numberRoom;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDate(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }


        public override string ToString()
        {
            return "Room: "
                   + NumberRoom
                   + ", Entry date: "
                   + CheckIn.ToString("dd/MM/yyyy")
                   + ", Departure date: "
                   + CheckOut.ToString("dd/MM/yyyy")
                   + ", Stay duration: "
                   + Duration()
                   + " Days:";
        }

    }
}
