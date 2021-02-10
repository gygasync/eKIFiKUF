using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static EKIFKUF.Tools;

namespace EKIFKUF
{
    public partial class DataForm : Form
    {
        private string PDV { get; set; }
        private int Godina { get; set; }
        private int Mjesec { get; set; }
        private string Tip { get; set; }
        private string Period { get; set; }
        private string UkupnoBezPdv { get; set; }
        private string UkupnoSaPdv { get; set; }
        private string UkupnoPdv { get; set; }
        private int BrojSlogova { get; set; }

        private static double pdvStopa = 0.17;

        public DataForm(string pdv, int godina, int mjesec, string tip)
        {
            InitializeComponent();
            PDV = pdv;
            Godina = godina;
            Mjesec = mjesec;
            Tip = tip;
            BrojSlogova = 0;

            Period = String.Format("{0}{1:00}", Godina.ToString().Substring(2), Mjesec);


            // Postavi labele
            lblPDV.Text = PDV;
            lblPeriod.Text = Period;
            lblTIP.Text = Tip;
            
        }

        public DataForm(string pdv, string period, string tip, IList<string[]> polja)
        {
            InitializeComponent();
            PDV = pdv;
            Tip = tip;
            BrojSlogova = 0;
            Period = period;

            // Postavi labele
            lblPDV.Text = PDV;
            lblPeriod.Text = Period;
            lblTIP.Text = Tip;

            foreach(string[] red in polja)
            {
                dataGrid.Rows.Add(red);
            }

        }



        private void DataForm_Load(object sender, EventArgs e)
        {
            // Osvjezi sume
            UkupnoBezPdv = osvjeziSume("iznosBezPDV");
            UkupnoSaPdv = osvjeziSume("iznosSaPDV");
            UkupnoPdv = osvjeziSume("iznosPDV");

            lblUkupnoBezPDV.Text = UkupnoBezPdv;
            lblUkupnoSaPDV.Text = UkupnoSaPdv;
            lblUkupnoPDV.Text = UkupnoPdv;
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = dataGrid.CurrentRow;


            // Postavi redni broj
            if (currentRow.Index > -1)
            {
                if (currentRow.Cells[0].Value == null)
                {
                    currentRow.Cells[0].Value = String.Format("{0}.", currentRow.Index + 1);
                }

            }

            // Izgenerisi iznose prema osnovici ako je prazno
            try
            {
                if (e.ColumnIndex == dataGrid.Columns["iznosBezPDV"].Index 
                    && currentRow.Cells["iznosBezPDV"].Value != null
                    && currentRow.Cells["iznosSaPDV"].Value == null 
                    && currentRow.Cells["iznosPDV"].Value == null)
                {
                    double iznosBezPdv = Double.Parse(currentRow.Cells["iznosBezPDV"].Value.ToString());
                    currentRow.Cells["iznosSaPDV"].Value = String.Format("{0:0.00}", iznosBezPdv * (1 + pdvStopa));
                    currentRow.Cells["iznosPDV"].Value = String.Format("{0:0.00}", iznosBezPdv * pdvStopa);
                }
            }
            catch (Exception)
            {

            }

            // Osvjezi sume
            UkupnoBezPdv = osvjeziSume("iznosBezPDV");
            UkupnoSaPdv = osvjeziSume("iznosSaPDV");
            UkupnoPdv = osvjeziSume("iznosPDV");

            lblUkupnoBezPDV.Text = UkupnoBezPdv;
            lblUkupnoSaPDV.Text = UkupnoSaPdv;
            lblUkupnoPDV.Text = UkupnoPdv;

            // TODO: Svedi na 2 decimale
            if (e.ColumnIndex == dataGrid.Columns["iznosBezPDV"].Index)
                dataGrid[e.ColumnIndex, e.RowIndex].Value = decimalFixer(dataGrid[e.ColumnIndex, e.RowIndex].Value);
            if (e.ColumnIndex == dataGrid.Columns["iznosSaPDV"].Index)
                dataGrid[e.ColumnIndex, e.RowIndex].Value = decimalFixer(dataGrid[e.ColumnIndex, e.RowIndex].Value);
            if (e.ColumnIndex == dataGrid.Columns["iznosPDV"].Index)
                dataGrid[e.ColumnIndex, e.RowIndex].Value = decimalFixer(dataGrid[e.ColumnIndex, e.RowIndex].Value);


        }

        private string osvjeziSume(string imePolja)
        {
            double suma = 0;
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                try
                {
                    if (row.Cells[imePolja].Value != null)
                        suma += Double.Parse(row.Cells[imePolja].Value.ToString());
                }
                catch (Exception) { }
            }
            return String.Format("{0:0.00}", suma);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            string tip = Tip == "KUF" ? "1" : "2";
            BrojSlogova = 0;

            // Slog zaglavlja http://www.new.uino.gov.ba/get/10399

            string zaglavlje = new SlogZaglavlje(
                "1",
                PDV,
                Period,
                tip,
                "01").ToCSV();

            var stavke = new StringBuilder();


            // Slogovi stavki
            try
            {
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    // Null check
                    bool nullCheckFail = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null && cell.ColumnIndex != dataGrid.Columns["PDVbroj"].Index)
                        {
                            nullCheckFail = true;
                            break;
                        }
                    }

                    if (nullCheckFail)
                        continue;

                    if (Tip == "KUF")
                    { 
                        stavke.AppendLine(new SlogNabavka(
                            "2",
                            Period,
                            row.Cells["redniBroj"].Value.ToString().Remove(row.Cells["redniBroj"].Value.ToString().Length - 1), // Uklanjanje tacke
                            "01",
                            row.Cells["brojFakture"].Value.ToString(),
                            row.Cells["datumFakture"].Value.ToString(),
                            row.Cells["datumFakture"].Value.ToString(),
                            row.Cells["nazivDobavljaca"].Value.ToString(),
                            row.Cells["sjedisteDobavljaca"].Value.ToString(),
                            row.Cells["PDVbroj"].Value == null ? null : row.Cells["PDVbroj"].Value.ToString(),
                            row.Cells["iznosBezPDV"].Value.ToString(),
                            row.Cells["iznosSaPDV"].Value.ToString(),
                            row.Cells["iznosPDV"].Value.ToString()).ToCSV());
                    }
                    else
                    {
                        stavke.AppendLine(new SlogIsporuka(
                            "2",
                            Period,
                            row.Cells["redniBroj"].Value.ToString().Remove(row.Cells["redniBroj"].Value.ToString().Length - 1), // Uklanjanje tacke
                            "01",
                            row.Cells["brojFakture"].Value.ToString(),
                            row.Cells["datumFakture"].Value.ToString(),
                            row.Cells["nazivDobavljaca"].Value.ToString(),
                            row.Cells["sjedisteDobavljaca"].Value.ToString(),
                            row.Cells["PDVbroj"].Value == null ? null : row.Cells["PDVbroj"].Value.ToString(),
                            row.Cells["iznosSaPDV"].Value.ToString(),
                            row.Cells["iznosBezPDV"].Value.ToString(),
                            row.Cells["iznosPDV"].Value.ToString()).ToCSV());
                    }

                    BrojSlogova++;
                }    
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }

            string prateciSlog;

            if (Tip == "KUF")
            {
                prateciSlog = new SlogPrateci(
                    "3",
                    UkupnoBezPdv,
                    UkupnoSaPdv,
                    UkupnoPdv,
                    BrojSlogova.ToString()).ToCSV();
            }
            else
            {
                string osnovicaNeregistrovan;
                string pdvNeregistrovan;
                string osnovicaRegistrovan;
                string pdvRegistrovan;

                
                    double sumaOsnovicaNeregistrovan = 0;
                    double sumaPdvNeregistrovan = 0;
                    double sumaOsnovicaRegistrovan = 0;
                    double sumaPdvRegistrovan = 0;

                    foreach (DataGridViewRow row in dataGrid.Rows)
                    {
                        try
                        {
                            if (String.IsNullOrEmpty((string)row.Cells["PDVbroj"].Value) && row.Cells[0] != null) // Neregistrovan korisnik
                            {
                                if (row.Cells["iznosBezPDV"].Value != null)
                                    sumaOsnovicaNeregistrovan += Double.Parse(row.Cells["iznosBezPDV"].Value.ToString());
                                if (row.Cells["iznosPDV"].Value != null)
                                    sumaPdvNeregistrovan += Double.Parse(row.Cells["iznosPDV"].Value.ToString());
                            }
                            if (!String.IsNullOrEmpty((string)row.Cells["PDVbroj"].Value))
                            {
                                if (row.Cells["iznosBezPDV"].Value != null)
                                    sumaOsnovicaRegistrovan += Double.Parse(row.Cells["iznosBezPDV"].Value.ToString());
                                if (row.Cells["iznosPDV"].Value != null)
                                    sumaPdvRegistrovan += Double.Parse(row.Cells["iznosPDV"].Value.ToString());
                            }
                        }
                        catch(Exception)
                        {
                            continue;
                        }
                    }
                    osnovicaNeregistrovan = String.Format("{0:0.00}", sumaOsnovicaNeregistrovan);
                    pdvNeregistrovan = String.Format("{0:0.00}", sumaPdvNeregistrovan);
                    osnovicaRegistrovan = String.Format("{0:0.00}", sumaOsnovicaRegistrovan);
                    pdvRegistrovan = String.Format("{0:0.00}", sumaPdvRegistrovan);
                MessageBox.Show(osnovicaNeregistrovan + " " + pdvNeregistrovan + " " + osnovicaRegistrovan + " " + pdvRegistrovan);


                prateciSlog = new SlogPrateciIsporuka(
                    "3",
                    UkupnoSaPdv, 
                    osnovicaRegistrovan, 
                    pdvRegistrovan, 
                    osnovicaNeregistrovan, 
                    pdvNeregistrovan, 
                    BrojSlogova.ToString()).ToCSV();
            }


            // Sacuvaj csv fajl
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "CSV fajlovi (*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = $"{PDV}_{Period}_{(Tip == "KIF" ? "2" : "1")}_01.csv";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter streamWriter = new StreamWriter(myStream);

                    streamWriter.WriteLine(zaglavlje);
                    streamWriter.Write(stavke);
                    streamWriter.WriteLine(prateciSlog);
                    streamWriter.Flush();

                    myStream.Close();
                }
            }

        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (dataGrid.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = $"{Tip}_{Period}.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Greška pri čuvanju fajla." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGrid.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGrid.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGrid.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null)
                                        pdfTable.AddCell(cell.Value.ToString());
                                    else
                                        pdfTable.AddCell("");
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Add(new Paragraph($"Osnovica: {UkupnoBezPdv}", FontFactory.GetFont("Tahoma", 16)));
                                pdfDoc.Add(new Paragraph($"Porez: {UkupnoPdv}", FontFactory.GetFont("Tahoma", 16)));
                                pdfDoc.Add(new Paragraph($"Ukupno: {UkupnoSaPdv}", FontFactory.GetFont("Tahoma", 16)));
                                pdfDoc.Close();
                                stream.Close();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Greška :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Tabela je prazna.", "Info");
            }
        }
    }
}
