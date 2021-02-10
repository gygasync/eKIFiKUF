using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static EKIFKUF.Tools;

namespace EKIFKUF
{
    class SlogNabavka
    {
        private const int SlogLength = 20;
        private string VrstaSloga { get; set; }
        private string PoreskiPeriod { get; set; }
        private string RedniBroj { get; set; }
        private string TipDokumenta { get; set; }
        private string BrojFakture { get; set; }
        private string DatumFakture { get; set; }
        private string DatumPrijemaFakture { get; set; }
        private string NazivDobavljaca { get; set; }
        private string SjedisteDobavljaca { get; set; }
        private string PDVBroj { get; set; }
        private string JIB { get; set; }
        private string IznosBezPDV { get; set; }
        private string IznosSaPDV { get; set; }
        private string IznosPausalneNaknade { get; set; }
        private string IznosUlaznogPDVa { get; set; }
        private string UlazniPdvMogucOdbiti { get; set; }
        private string UlazniPdvNemogucOdbiti { get; set; }
        private string UlazniPdvNemogucOdibitPolje32 { get; set; }
        private string UlazniPdvNemogucOdibitPolje33 { get; set; }
        private string UlazniPdvNemogucOdibitPolje34 { get; set; }

        public SlogNabavka(string vrstaSloga, string poreskiPeriod, string redniBroj, string tipDokumenta, string brojFakture, string datumFakture, string datumPrijemaFakture, string nazivDobavljaca, string sjedisteDobavljaca, string pDVBroj, string iznosBezPDV, string iznosSaPDV, string iznosUlaznogPDVa)
        {
            VrstaSloga = vrstaSloga;
            PoreskiPeriod = poreskiPeriod;
            RedniBroj = redniBroj;
            TipDokumenta = tipDokumenta;
            BrojFakture = brojFakture;
            DatumFakture = datumFakture;
            DatumPrijemaFakture = datumPrijemaFakture;
            NazivDobavljaca = nazivDobavljaca;
            SjedisteDobavljaca = sjedisteDobavljaca;
            PDVBroj = pDVBroj;
            if (PDVBroj != null)
                JIB = "4" + PDVBroj;
            IznosBezPDV = iznosBezPDV;
            IznosSaPDV = iznosSaPDV;
            IznosPausalneNaknade = "0.00";
            IznosUlaznogPDVa = iznosUlaznogPDVa;
            UlazniPdvMogucOdbiti = "0.00";
            UlazniPdvNemogucOdbiti = "0.00";
            UlazniPdvNemogucOdibitPolje32 = "0.00";
            UlazniPdvNemogucOdibitPolje33 = "0.00";
            UlazniPdvNemogucOdibitPolje34 = "0.00";

        }

        public SlogNabavka(string vrstaSloga, string poreskiPeriod, string redniBroj, string tipDokumenta, string brojFakture, string datumFakture, string datumPrijemaFakture, string nazivDobavljaca, string sjedisteDobavljaca, string pDVBroj, string jIB, string iznosBezPDV, string iznosSaPDV, string iznosPausalneNaknade, string iznosUlaznogPDVa, string ulazniPdvMogucOdbiti, string ulazniPdvNemogucOdbiti, string ulazniPdvNemogucOdibitPolje32, string ulazniPdvNemogucOdibitPolje33, string ulazniPdvNemogucOdibitPolje34) : this(vrstaSloga, poreskiPeriod, redniBroj, tipDokumenta, brojFakture, datumFakture, datumPrijemaFakture, nazivDobavljaca, sjedisteDobavljaca, pDVBroj, jIB, iznosBezPDV, iznosSaPDV)
        {
            IznosPausalneNaknade = iznosPausalneNaknade;
            IznosUlaznogPDVa = iznosUlaznogPDVa;
            UlazniPdvMogucOdbiti = ulazniPdvMogucOdbiti;
            UlazniPdvNemogucOdbiti = ulazniPdvNemogucOdbiti;
            UlazniPdvNemogucOdibitPolje32 = ulazniPdvNemogucOdibitPolje32;
            UlazniPdvNemogucOdibitPolje33 = ulazniPdvNemogucOdibitPolje33;
            UlazniPdvNemogucOdibitPolje34 = ulazniPdvNemogucOdibitPolje34;
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
                DatumFakture ,
                DatumPrijemaFakture,
                NazivDobavljaca,
                SjedisteDobavljaca,
                PDVBroj,
                JIB,
                IznosBezPDV,
                IznosSaPDV,
                IznosPausalneNaknade,
                IznosUlaznogPDVa,
                UlazniPdvMogucOdbiti,
                UlazniPdvNemogucOdbiti,
                UlazniPdvNemogucOdibitPolje32,
                UlazniPdvNemogucOdibitPolje33,
                UlazniPdvNemogucOdibitPolje34
            });
        }

        public static SlogNabavka FromCSV(string csv)
        {
            csv = csv.Trim();
            string[] csvFields = csv.Split(';');
            if (csvFields.Length != SlogLength)
                throw new FormatException("Slog nabavke nije ispravno formatiran.");

            // TODO: provjeriti ispravnost polja prema specifikaciji
            return new SlogNabavka(
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
                csvFields[19]
                );
        }
    }
}
