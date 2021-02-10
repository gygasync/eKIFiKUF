using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static EKIFKUF.Tools;
// Po https://e-porezi.uino.gov.ba:4443/Areas/PurchaseAndSale/Instructions/TehnickoUputstvo.pdf

namespace EKIFKUF
{
    class SlogZaglavlje
    {
        private const int SlogLength = 7;
        public string VrstaSloga { get; set; }
        public string PDVBroj { get; set; }
        public string PoreskiPeriod { get; set; }
        public string TipDatoteke { get; set; }
        private string RedniBroj { get; set; }
        private string DatumKreiranja { get; set; }
        private string VrijemeKreiranja { get; set; }

        public SlogZaglavlje(string vrstaSloga, string pDVBroj, string poreskiPeriod, string tipDatoteke, string redniBroj)
        {
            VrstaSloga = vrstaSloga;
            PDVBroj = pDVBroj;
            PoreskiPeriod = poreskiPeriod;
            TipDatoteke = tipDatoteke;
            RedniBroj = redniBroj;
            DatumKreiranja = DateTime.Now.ToString("yyyy-MM-dd");
            VrijemeKreiranja = DateTime.Now.ToString("HH:mm:ss");
        }

        public SlogZaglavlje(string vrstaSloga, string pDVBroj, string poreskiPeriod, string tipDatoteke, string redniBroj, string datumKreiranja, string vrijemeKreiranja)
        {
            VrstaSloga = vrstaSloga;
            PDVBroj = pDVBroj;
            PoreskiPeriod = poreskiPeriod;
            TipDatoteke = tipDatoteke;
            RedniBroj = redniBroj;
            DatumKreiranja = datumKreiranja;
            VrijemeKreiranja = vrijemeKreiranja;
        }

        public string ToCSV()
        {
            return csvGenerator(new List<string>
            {
                VrstaSloga,
                PDVBroj,
                PoreskiPeriod,
                TipDatoteke,
                RedniBroj,
                DatumKreiranja,
                VrijemeKreiranja,
            });
        }

        public static SlogZaglavlje FromCSV(string csv)
        {
            csv = csv.Trim();
            string[] csvFields = csv.Split(';');
            if (csvFields.Length != SlogLength)
                throw new FormatException("Slog zaglavlja nije ispravno formatiran.");

            // TODO: provjeriti ispravnost polja prema specifikaciji
            return new SlogZaglavlje(
                csvFields[0],
                csvFields[1],
                csvFields[2],
                csvFields[3],
                csvFields[4],
                csvFields[5],
                csvFields[6]);
        }
    }
}
