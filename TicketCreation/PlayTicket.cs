using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCreation
{
    internal class PlayTicket : TicketReservation
    {
        private string playGenre;

        public PlayTicket(DateTime date, string place, string title, string genre) : base(date, place,title)
        {
            genre = playGenre;
        }
    }
}
