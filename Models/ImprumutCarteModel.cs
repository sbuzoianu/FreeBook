using System;
using System.Collections.Generic;
using System.Text;

namespace FreeBook.Models {
    class ImprumutCarteModel {
        public int Index { get; set; }
        public int IDCarte { get; set; }
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public DateTime DataImprumut { get; set; }
        public DateTime DataDisponibilitate { get; set; }
        public bool CarteExpirata { get; set; }
    }
}
