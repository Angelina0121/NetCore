
using MyAirport.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace MF.MyAirport.EF
{
    /// <summary>
    /// Objet Bagage
    /// </summary>
    public class Bagage
    {
        /// <summary>
        /// Id clé primaire de l'objet bagage
        /// </summary>
        public int BagageId { get; set; }
        /// <summary>
        /// Vol associé au bagage
        /// </summary>
        public int? VolId { get; set; }
        /// <summary>
        /// CoddeIata du bagage, unique à un instant t
        /// </summary>
        public string CodeIata { get; set; }
        /// <summary>
        /// Date à laquelle le bagage a été créé par la compagnie
        /// </summary>
        public DateTime DateCreation { get; set; }

        /// <summary>
        /// Propriété de navigation
        /// </summary>
        public Vol? Vol { get; set; }
        public string? Classe { get; set; }
        public bool? Prioritaire { get; set; }
        public string? Sta { get; set; }
        public string? Ssur { get; set; }
        public string? Destination { get; set; }
        public string? Escale { get; set; }

        public Bagage() { }

        public Bagage(string codeIata, DateTime dateCreation)
        {
            CodeIata = codeIata;
            DateCreation = dateCreation;
        }

    }
}
