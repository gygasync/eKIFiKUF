using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static EKIFKUF.Tools;

namespace EKIFKUF
{
    class SlogPrateci
    {
        private const int SlogLength = 11;
        private string VrstaSloga { get; set; }
        private string UkupanIznosBezPDVa { get; set; }
        private string UkupanIznosSaPDVom { get; set; }
        private string UkupanIznosPausalneNaknade { get; set; }
        private string UkupanIznosUlaznogPDVa { get; set; }
        private string UkupanUlazniPDVMogucOdbiti { get; set; }
        private string UkupanUlazniPDVNemogucOdbiti { get; set; }
        private string UkupanUlazniPDVNemogucOdbitiPolje32 { get; set; }
        private string UkupanUlazniPDVNemogucOdbitiPolje33 { get; set; }
        private string UkupanUlazniPDVNemogucOdbitiPolje34 { get; set; }
        private string UkupanBrojRedova { get; set; }

        public SlogPrateci(string vrstaSloga, string ukupanIznosBezPDVa, string ukupanIznosSaPDVom, string ukupanIznosPausalneNaknade, string ukupanIznosUlaznogPDVa, string ukupanUlazniPDVMogucOdbiti, string ukupanUlazniPDVNemogucOdbiti, string ukupanUlazniPDVNemogucOdbitiPolje32, string ukupanUlazniPDVNemogucOdbitiPolje33, string ukupanUlazniPDVNemogucOdbitiPolje34, string ukupanBrojRedova)
        {
            VrstaSloga = vrstaSloga;
            UkupanIznosBezPDVa = ukupanIznosBezPDVa;
            UkupanIznosSaPDVom = ukupanIznosSaPDVom;
            UkupanIznosPausalneNaknade = ukupanIznosPausalneNaknade;
            UkupanIznosUlaznogPDVa = ukupanIznosUlaznogPDVa;
            UkupanUlazniPDVMogucOdbiti = ukupanUlazniPDVMogucOdbiti;
            UkupanUlazniPDVNemogucOdbiti = ukupanUlazniPDVNemogucOdbiti;
            UkupanUlazniPDVNemogucOdbitiPolje32 = ukupanUlazniPDVNemogucOdbitiPolje32;
            UkupanUlazniPDVNemogucOdbitiPolje33 = ukupanUlazniPDVNemogucOdbitiPolje33;
            UkupanUlazniPDVNemogucOdbitiPolje34 = ukupanUlazniPDVNemogucOdbitiPolje34;
            UkupanBrojRedova = ukupanBrojRedova;
        }

        public SlogPrateci(string vrstaSloga, string ukupanIznosBezPDVa, string ukupanIznosSaPDVom, string ukupanIznosUlaznogPDVa, string ukupanBrojRedova)
        {
            VrstaSloga = vrstaSloga;
            UkupanIznosBezPDVa = ukupanIznosBezPDVa;
            UkupanIznosSaPDVom = ukupanIznosSaPDVom;
            UkupanIznosPausalneNaknade = "0.00";
            UkupanIznosUlaznogPDVa = ukupanIznosUlaznogPDVa;
            UkupanUlazniPDVMogucOdbiti = "0.00";
            UkupanUlazniPDVNemogucOdbiti = "0.00";
            UkupanUlazniPDVNemogucOdbitiPolje32 = "0.00";
            UkupanUlazniPDVNemogucOdbitiPolje33 = "0.00";
            UkupanUlazniPDVNemogucOdbitiPolje34 = "0.00";
            UkupanBrojRedova = ukupanBrojRedova;
        }

        public string ToCSV()
        {
            return csvGenerator(new List<string>
            {
                VrstaSloga,
                UkupanIznosBezPDVa,
                UkupanIznosSaPDVom,
                UkupanIznosPausalneNaknade,
                UkupanIznosUlaznogPDVa,
                UkupanUlazniPDVMogucOdbiti,
                UkupanUlazniPDVNemogucOdbiti,
                UkupanUlazniPDVNemogucOdbitiPolje32,
                UkupanUlazniPDVNemogucOdbitiPolje33,
                UkupanUlazniPDVNemogucOdbitiPolje34,
                UkupanBrojRedova
        });
        }

        public static SlogPrateci FromCSV(string csv)
        {
            csv = csv.Trim();
            string[] csvFields = csv.Split(';');
            if (csvFields.Length != SlogLength)
                throw new FormatException("Slog nabavke nije ispravno formatiran.");

            // TODO: provjeriti ispravnost polja prema specifikaciji
            return new SlogPrateci(
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
                csvFields[10]
                );
        }
    }
}
