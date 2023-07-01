using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCreation
{
    abstract class TicketReservation
    {
        private DateTime eventDate;
        private string eventPlace;
        private string eventTitle;

        public TicketReservation(DateTime date, string place, string title)
        {
            eventDate = date;
            eventPlace = place;
            eventTitle = title;
        }

    }
}
