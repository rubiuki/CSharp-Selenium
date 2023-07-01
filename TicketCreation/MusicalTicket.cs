using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCreation
{
    internal class MusicalTicket : TicketReservation
    {
        private string artistFullname;

        public MusicalTicket(DateTime date, string place, string title, string fullname) : base(date, place, title)
        {
            artistFullname = fullname;
        }
    }
}
