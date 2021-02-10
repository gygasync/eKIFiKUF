using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace EKIFKUF
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            // Provjeri da li postoji config.ini
            try
            {
                if (File.Exists("config.ini"))
                {
                    foreach (var row in File.ReadAllLines("config.ini"))
                        Config.Add(row.Split('=')[0], string.Join("=", row.Split('=').Skip(1).ToArray()));

                    PDV = Config["pdv"];
                }
                else
                    File.Create("config.ini");
            }
            catch (Exception)
            {
                // Ne zali se
            }

            txtPDV.Text = PDV;

        }
        private Dictionary<string, string> Config { get; set; } = new Dictionary<string, string>();

        private string PDV { get; set; }
        private int Godina { get; set; }
        private int Mjesec { get; set; }

        private void btnUlaz_Click(object sender, EventArgs e)
        {
            var validator = validateForm();
            if (validator != "OK")
            {
                MessageBox.Show(validator);
            }
            else
            {
                DataForm dataForm = new DataForm(PDV, Godina, Mjesec, "KUF");
                dataForm.Show();
            }
        }

        private string validateForm()
        {
            string pdv = txtPDV.Text;
            int mjesec = comboMjesec.SelectedIndex + 1;
            string godina = txtGodina.Text;


            if (pdv.Length != 12)
                return "PDV broj nije dužine 12 cifara.";

            if (!pdv.All(Char.IsDigit))
                return "PDV broj smije samo sadržati cifre.";

            if (mjesec == 0)
                return "Mjesec mora biti izabran.";

            if (godina.Length != 4)
                return "Godina mora imati 4 cifre.";

            if (!godina.All(Char.IsDigit))
                return "Godina smije samo sadržati cifre.";

            PDV = pdv;
            Godina = Int32.Parse(godina);
            Mjesec = mjesec;

            Config["pdv"] = PDV;

            WriteConfig();

            return "OK";
        }

        public void WriteConfig()
        {
            List<string> writer = new List<string>();

            foreach(var entry in Config)
                writer.Add($"{entry.Key}={entry.Value}");

            File.WriteAllLines("config.ini", writer.ToArray());
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            var validator = validateForm();
            if (validator != "OK")
            {
                MessageBox.Show(validator);
            }
            else
            {
                DataForm dataForm = new DataForm(PDV, Godina, Mjesec, "KIF");
                dataForm.Show();
            }
        }

        private void btnOtvori_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                Filter = "CSV fajlovi (*.csv)|*.csv",
                Title = "Otvori CSV fal"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog1.FileName;
                    string[] filelines = File.ReadAllLines(filePath);

                    if(filelines.Length > 1)
                    {
                        SlogZaglavlje zaglavlje = SlogZaglavlje.FromCSV(filelines[0]);
                        

                        IList <string[]> polja = new List<string[]>();

                        for (int i = 1; i < filelines.Length - 1; i++)
                        {
                            string[] temp = new string[9];
                            string[] poljaSplit = filelines[i].Split(';');

                            if(zaglavlje.TipDatoteke == "1") // KUF
                            {
                                temp[0] = poljaSplit[2] + ".";
                                temp[1] = poljaSplit[4];
                                temp[2] = poljaSplit[5];
                                temp[3] = poljaSplit[7];
                                temp[4] = poljaSplit[8];
                                temp[5] = poljaSplit[9];
                                temp[6] = poljaSplit[11];
                                temp[7] = poljaSplit[14];
                                temp[8] = poljaSplit[12];

                            }
                            else // KIF
                            {
                                temp[0] = poljaSplit[2] + ".";
                                temp[1] = poljaSplit[4];
                                temp[2] = poljaSplit[5];
                                temp[3] = poljaSplit[6];
                                temp[4] = poljaSplit[7];
                                temp[5] = poljaSplit[8];
                                temp[6] = temp[5] == "" ? poljaSplit[16] : poljaSplit[14];
                                temp[7] = temp[5] == "" ? poljaSplit[17] : poljaSplit[15];
                                temp[8] = poljaSplit[10];
                            }

                            polja.Add(temp);
                        }


                        DataForm dataForm = new DataForm(zaglavlje.PDVBroj, zaglavlje.PoreskiPeriod, zaglavlje.TipDatoteke == "2" ? "KIF" : "KUF", polja);
                        dataForm.Show();
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
                catch (Exception exc)
                {
                    MessageBox.Show($"Fajl je neispravan\n {exc.Message}");
                }
            }
        }
    }
}
