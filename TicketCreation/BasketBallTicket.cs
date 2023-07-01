using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCreation
{
    internal class BasketBallTicket : TicketReservation
    {
        private string basketballteam1;
        private string basketballteam2;

        public BasketBallTicket(DateTime date, string place, string title, string team1, string team2) : base(date, place, title)
        {
            basketballteam1 = team1;
            basketballteam2 = team2;
        }
    }      
}
