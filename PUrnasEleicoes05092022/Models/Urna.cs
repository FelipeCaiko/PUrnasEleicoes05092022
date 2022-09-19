using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PUrnasEleicoes05092022.Models
{
    public class Urna
    {
        public int IdUrna { get; set; }
        public int NumeroVotos { get; set; }
        public Candidato Candidato { get; set; }
        public Escola Escola { get; set; }

        public Urna()
        {
        }
    }
}