using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static EKIFKUF.Tools;

namespace EKIFKUF
{
    class SlogPrateciIsporuka
    {
        private const int SlogLength = 13;
        private string VrstaSloga { get; set; }
        private string UkupanIznosFakture { get; set; }
        private string UkupanIznosInterneFakture { get; set; }
        private string UkupanIznosFaktureIzvozneIsporukeCarinske { get; set; }
        private string UkupanIznosFaktureOstaleIsporukeOslobodjenePDVa { get; set; }
        private string UkupnaOsnovicaObracunPDVaRegistrovanObveznik { get; set; }
        private string UkupanIznosIzlaznogPDVaRegistrovanObveznik { get; set; }
        private string UkupnaOsnovicaObracunPDVaNeregistrovanObveznik { get; set; }
        private string UkupanIznosIzlaznogPDVaNegistrovanObveznik { get; set; }
        private string UkupanIznosIzlaznogPDVaPolje32 { get; set; }
        private string UkupanIznosIzlaznogPDVaPolje33 { get; set; }
        private string UkupanIznosIzlaznogPDVaPolje34 { get; set; }
        private string UkupanBrojRedova { get; set; }

        public SlogPrateciIsporuka(string vrstaSloga, string ukupanIznosFakture, string ukupanIznosInterneFakture, string ukupanIznosFaktureIzvozneIsporukeCarinske, string ukupanIznosFaktureOstaleIsporukeOslobodjenePDVa, string ukupnaOsnovicaObracunPDVaRegistrovanObveznik, string ukupanIznosIzlaznogPDVaRegistrovanObveznik, string ukupnaOsnovicaObracunPDVaNeregistrovanObveznik, string ukupanIznosIzlaznogPDVaNegistrovanObveznik, string ukupanIznosIzlaznogPDVaPolje32, string ukupanIznosIzlaznogPDVaPolje33, string ukupanIznosIzlaznogPDVaPolje34, string ukupanBrojRedova)
        {
            VrstaSloga = vrstaSloga;
            UkupanIznosFakture = ukupanIznosFakture;
            UkupanIznosInterneFakture = ukupanIznosInterneFakture;
            UkupanIznosFaktureIzvozneIsporukeCarinske = ukupanIznosFaktureIzvozneIsporukeCarinske;
            UkupanIznosFaktureOstaleIsporukeOslobodjenePDVa = ukupanIznosFaktureOstaleIsporukeOslobodjenePDVa;
            UkupnaOsnovicaObracunPDVaRegistrovanObveznik = ukupnaOsnovicaObracunPDVaRegistrovanObveznik;
            UkupanIznosIzlaznogPDVaRegistrovanObveznik = ukupanIznosIzlaznogPDVaRegistrovanObveznik;
            UkupnaOsnovicaObracunPDVaNeregistrovanObveznik = ukupnaOsnovicaObracunPDVaNeregistrovanObveznik;
            UkupanIznosIzlaznogPDVaNegistrovanObveznik = ukupanIznosIzlaznogPDVaNegistrovanObveznik;
            UkupanIznosIzlaznogPDVaPolje32 = ukupanIznosIzlaznogPDVaPolje32;
            UkupanIznosIzlaznogPDVaPolje33 = ukupanIznosIzlaznogPDVaPolje33;
            UkupanIznosIzlaznogPDVaPolje34 = ukupanIznosIzlaznogPDVaPolje34;
            UkupanBrojRedova = ukupanBrojRedova;
        }

        public SlogPrateciIsporuka(string vrstaSloga, string ukupanIznosFakture, string ukupnaOsnovicaObracunPDVaRegistrovanObveznik, string ukupanIznosIzlaznogPDVaRegistrovanObveznik, string ukupnaOsnovicaObracunPDVaNeregistrovanObveznik, string ukupanIznosIzlaznogPDVaNegistrovanObveznik, string ukupanBrojRedova)
        {
            VrstaSloga = vrstaSloga;
            UkupanIznosFakture = ukupanIznosFakture;
            UkupanIznosInterneFakture = "0.00";
            UkupanIznosFaktureIzvozneIsporukeCarinske = "0.00";
            UkupanIznosFaktureOstaleIsporukeOslobodjenePDVa = "0.00";
            UkupnaOsnovicaObracunPDVaRegistrovanObveznik = ukupnaOsnovicaObracunPDVaRegistrovanObveznik;
            UkupanIznosIzlaznogPDVaRegistrovanObveznik = ukupanIznosIzlaznogPDVaRegistrovanObveznik;
            UkupnaOsnovicaObracunPDVaNeregistrovanObveznik = ukupnaOsnovicaObracunPDVaNeregistrovanObveznik;
            UkupanIznosIzlaznogPDVaNegistrovanObveznik = ukupanIznosIzlaznogPDVaNegistrovanObveznik;
            UkupanIznosIzlaznogPDVaPolje32 = "0.00";
            UkupanIznosIzlaznogPDVaPolje33 = "0.00";
            UkupanIznosIzlaznogPDVaPolje34 = "0.00";
            UkupanBrojRedova = ukupanBrojRedova;
        }

        public string ToCSV()
        {
            return csvGenerator(new List<string>
            {
                VrstaSloga,
                UkupanIznosFakture,
                UkupanIznosInterneFakture,
                UkupanIznosFaktureIzvozneIsporukeCarinske,
                UkupanIznosFaktureOstaleIsporukeOslobodjenePDVa,
                UkupnaOsnovicaObracunPDVaRegistrovanObveznik,
                UkupanIznosIzlaznogPDVaRegistrovanObveznik,
                UkupnaOsnovicaObracunPDVaNeregistrovanObveznik,
                UkupanIznosIzlaznogPDVaNegistrovanObveznik,
                UkupanIznosIzlaznogPDVaPolje32,
                UkupanIznosIzlaznogPDVaPolje33,
                UkupanIznosIzlaznogPDVaPolje34,
                UkupanBrojRedova
            });
        }

        public static SlogPrateciIsporuka FromCSV(string csv)
        {
            csv = csv.Trim();
            string[] csvFields = csv.Split(';');
            if (csvFields.Length != SlogLength)
                throw new FormatException("Slog isporuke nije ispravno formatiran.");

            // TODO: provjeriti ispravnost polja prema specifikaciji
            return new SlogPrateciIsporuka(
                csvFields[0],
                csvFields[1],
                csvFields[2],
                csvFields[3],
                csvFields[4],
                csvFields[5],
                csvFields[6],
                csvFields[7],
                csvFields[8],
                csvFields[9],
                csvFields[10],
                csvFields[11],
                csvFields[12]
                );
        }
    }
}
