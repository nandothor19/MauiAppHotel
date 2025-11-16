using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppHotel.Models
{
    public class Evento
    {
        public string NomeEvento { get; set; }
        public DateTime InicioEvento { get; set; }
        public DateTime FimEvento { get; set; }
        public int NumeroParticipantes { get; set; }
        public string LocalEvento { get; set; }
        public int ValorParticipante { get; set; }
        public double ValorEventoTotal
        {
            get
            {
                double ValorTotal = ValorParticipante * NumeroParticipantes;
                return ValorTotal;
            }
        }
    }
}
