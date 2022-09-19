using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PUrnasEleicoes05092022.Models
{
    public class Candidato : Pessoa
    {
        public Tipo Tipo { get; set; }
        public Partido Partido { get; set; }

        public Candidato()
        {
        }
    }
}