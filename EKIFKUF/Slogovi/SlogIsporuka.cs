using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static EKIFKUF.Tools;

namespace EKIFKUF
{
    class SlogIsporuka
    {
        private const int SlogLength = 21;
        private string VrstaSloga { get; set; }
        private string PoreskiPeriod { get; set; }
        private string RedniBroj { get; set; }
        private string TipDokumenta { get; set; }
        private string BrojFakture { get; set; }
        private string DatumFakture { get; set; }
        private string NazivKupca { get; set; }
        private string SjedisteKupca { get; set; }
        private string PDVBroj { get; set; }
        private string JIB { get; set; }
        private string IznosFakture { get; set; }
        private string IznosInterneFakture { get; set; }
        private string IznosFaktureIzvozneIsporukeCarinske { get; set; }
        private string IznosFaktureOstaleIsporukeOslobodjenePDVa { get; set; }
        private string OsnovicaObracunPDVaRegistrovanObveznik { get; set; }
        private string IznosIzlaznogPDVaRegistrovanObveznik { get; set; }
        private string OsnovicaObracunPDVaNeregistrovanObveznik { get; set; }
        private string IznosIzlaznogPDVaNegistrovanObveznik { get; set; }
        private string IznosIzlaznogPDVaPolje32 { get; set; }
        private string IznosIzlaznogPDVaPolje33 { get; set; }
        private string IznosIzlaznogPDVaPolje34 { get; set; }

        public SlogIsporuka(string vrstaSloga, string poreskiPeriod, string redniBroj, string tipDokumenta, string brojFakture, string datumFakture, string nazivKupca, string sjedisteKupca, string pDVBroj, string jIB, string iznosFakture, string iznosInterneFakture, string iznosFaktureIzvozneIsporukeCarinske, string iznosFaktureOstaleIsporukeOslobodjenePDVa, string osnovicaObracunPDVaRegistrovanObveznik, string iznosIzlaznogPDVaRegistrovanObveznik, string osnovicaObracunPDVaNeregistrovanObveznik, string iznosIzlaznogPDVaNegistrovanObveznik, string iznosIzlaznogPDVaPolje32, string iznosIzlaznogPDVaPolje33, string iznosIzlaznogPDVaPolje34)
        {
            VrstaSloga = vrstaSloga;
            PoreskiPeriod = poreskiPeriod;
            RedniBroj = redniBroj;
            TipDokumenta = tipDokumenta;
            BrojFakture = brojFakture;
            DatumFakture = datumFakture;
            NazivKupca = nazivKupca;
            SjedisteKupca = sjedisteKupca;
            PDVBroj = pDVBroj;
            JIB = jIB;
            IznosFakture = iznosFakture;
            IznosInterneFakture = iznosInterneFakture;
            IznosFaktureIzvozneIsporukeCarinske = iznosFaktureIzvozneIsporukeCarinske;
            IznosFaktureOstaleIsporukeOslobodjenePDVa = iznosFaktureOstaleIsporukeOslobodjenePDVa;
            OsnovicaObracunPDVaRegistrovanObveznik = osnovicaObracunPDVaRegistrovanObveznik;
            IznosIzlaznogPDVaRegistrovanObveznik = iznosIzlaznogPDVaRegistrovanObveznik;
            OsnovicaObracunPDVaNeregistrovanObveznik = osnovicaObracunPDVaNeregistrovanObveznik;
            IznosIzlaznogPDVaNegistrovanObveznik = iznosIzlaznogPDVaNegistrovanObveznik;
            IznosIzlaznogPDVaPolje32 = iznosIzlaznogPDVaPolje32;
            IznosIzlaznogPDVaPolje33 = iznosIzlaznogPDVaPolje33;
            IznosIzlaznogPDVaPolje34 = iznosIzlaznogPDVaPolje34;
        }

        public SlogIsporuka(string vrstaSloga, string poreskiPeriod, string redniBroj, string tipDokumenta, string brojFakture, string datumFakture, string nazivKupca, string sjedisteKupca, string pDVBroj, string iznosFakture, string osnovicaObracun, string iznosIzlaznogPDVa)
        {
            VrstaSloga = vrstaSloga;
            PoreskiPeriod = poreskiPeriod;
            RedniBroj = redniBroj;
            TipDokumenta = tipDokumenta;
            BrojFakture = brojFakture;
            DatumFakture = datumFakture;
            NazivKupca = nazivKupca;
            SjedisteKupca = sjedisteKupca;
            PDVBroj = pDVBroj;
            if (String.IsNullOrEmpty(PDVBroj))
            {
                OsnovicaObracunPDVaRegistrovanObveznik = "0.00";
                IznosIzlaznogPDVaRegistrovanObveznik = "0.00";
                OsnovicaObracunPDVaNeregistrovanObveznik = osnovicaObracun;
                IznosIzlaznogPDVaNegistrovanObveznik = iznosIzlaznogPDVa;
            }
            else
            {
                JIB = "4" + PDVBroj;
                OsnovicaObracunPDVaRegistrovanObveznik = osnovicaObracun;
                IznosIzlaznogPDVaRegistrovanObveznik = iznosIzlaznogPDVa;
                OsnovicaObracunPDVaNeregistrovanObveznik = "0.00";
                IznosIzlaznogPDVaNegistrovanObveznik = "0.00";
            }
            
            IznosFakture = iznosFakture;
            IznosInterneFakture = "0.00";
            IznosFaktureIzvozneIsporukeCarinske = "0.00";
            IznosFaktureOstaleIsporukeOslobodjenePDVa = "0.00";
            IznosIzlaznogPDVaPolje32 = "0.00";
            IznosIzlaznogPDVaPolje33 = "0.00";
            IznosIzlaznogPDVaPolje34 = "0.00";
        }

        public string ToCSV()
        {
            return csvGenerator(new List<string>
            {
                VrstaSloga,
                PoreskiPeriod,
                RedniBroj,
                TipDokumenta,
                BrojFakture,
                DatumFakture,
                NazivKupca,
                SjedisteKupca,
                PDVBroj,
                JIB,
                IznosFakture,
                IznosInterneFakture,
                IznosFaktureIzvozneIsporukeCarinske,
                IznosFaktureOstaleIsporukeOslobodjenePDVa,
                OsnovicaObracunPDVaRegistrovanObveznik,
                IznosIzlaznogPDVaRegistrovanObveznik,
                OsnovicaObracunPDVaNeregistrovanObveznik,
                IznosIzlaznogPDVaNegistrovanObveznik,
                IznosIzlaznogPDVaPolje32,
                IznosIzlaznogPDVaPolje33,
                IznosIzlaznogPDVaPolje34
            });
        }

        public static SlogIsporuka FromCSV(string csv)
        {
            csv = csv.Trim();
            string[] csvFields = csv.Split(';');
            if (csvFields.Length != SlogLength)
                throw new FormatException("Slog isporuke nije ispravno formatiran.");

            // TODO: provjeriti ispravnost polja prema specifikaciji
            return new SlogIsporuka(
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
                csvFields[12],
                csvFields[13],
                csvFields[14],
                csvFields[15],
                csvFields[16],
                csvFields[17],
                csvFields[18],
                csvFields[19],
                csvFields[20]
                );
        }
    }
}
