
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

        /// <summary>
        /// Classe du passager (1ère, éco, business)
        /// </summary>
        public string? Classe { get; set; }
        /// <summary>
        /// Définit si le passager est considéré prioritaire lors de l'embarquement
        /// </summary>
        public bool? Prioritaire { get; set; }
        /// <summary>
        /// Statut du bagage
        /// </summary>
        public string? Sta { get; set; }
        /// <summary>
        /// ?
        /// </summary>
        public string? Ssur { get; set; }
        /// <summary>
        /// Lieu de destination du vol
        /// </summary>
        public string? Destination { get; set; }
        /// <summary>
        /// Lieu de l'escale, s'il y en a une
        /// </summary>
        public string? Escale { get; set; }

        /// <summary>
        /// Création d'un bagage vide afin de pouvoir mettre les bagaes à null lors de la création d'un vol
        /// </summary>
        public Bagage() { }

        /// <summary>
        /// Création d'un bagage
        /// </summary>
        public Bagage(string codeIata, DateTime dateCreation)
        {
            CodeIata = codeIata;
            DateCreation = dateCreation;
        }

    }
}
