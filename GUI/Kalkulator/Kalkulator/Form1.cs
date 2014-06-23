using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class LayarUtama : Form
    {
        private double var_1, var_2, tmp;
        private string operasi_kalkulator;
        private bool   mode_input  = false;       // Mode hitungan streak
        private bool   mode_tombol = false;       // Streak untuk tombol
        private bool   mode_awal_kalkulasi   = true;
        private bool   mode_awal_tombol = true;

        private string TAMBAH = "tambah";
        private string KURANG = "kurang";
        private string BAGI   = "bagi";
        private string KALI   = "kali";

        public LayarUtama()
        {
            InitializeComponent();
        }

        private double getAngka()
        {
            return double.Parse(screenKalkulator.Text);
        }

        private void ubahAngka(double angka)
        {
            screenKalkulator.Text = Convert.ToString(angka);
        }

        private void klikTombolAngka(int angka)
        {
            /// Jika kalkulator dalam mode "streak hitungan", ketika ditekan tombol angka
            /// Menghilangkan angka hasil sementara
            if (mode_tombol)
            {
                screenKalkulator.Text = Convert.ToString(angka);
                mode_tombol = false;
            }
            // Jika tidak, perilaku kayak tombol kalkulator biasa
            else
            {
                if (mode_awal_tombol)
                {
                    screenKalkulator.Text = Convert.ToString(angka);
                    mode_awal_tombol = false;
                }
                else
                {
                    screenKalkulator.Text += Convert.ToString(angka);
                }
            }
        }

        private void klikTombolOperasi(string operasi)
        {
            if (screenKalkulator.Text.Length > 0)
            {
                if (!mode_input)
                {
                    operasi_kalkulator = operasi;
                    var_1 = double.Parse(screenKalkulator.Text);
                    if (mode_awal_kalkulasi)
                    {
                        mode_awal_kalkulasi   = false;
                    }
                    else
                    {
                        screenKalkulator.Text = string.Empty;
                    }
                    mode_input  = true;
                }
                else
                {
                    otomatisHitung(operasi);
                    operasi_kalkulator = operasi;
                }
                mode_tombol = true;
            }
        }

        private void caseSwitchHitung()
        {
            var_2 = double.Parse(screenKalkulator.Text);

            switch (operasi_kalkulator)
            {
                case "tambah":
                    tmp = var_1 + var_2;
                    break;
                case "kurang":
                    tmp = var_1 - var_2;
                    break;
                case "bagi":
                    tmp = var_1 / var_2;
                    break;
                case "kali":
                    tmp = var_1 * var_2;
                    break;
            }
            var_1 = tmp;
        }

        private void otomatisHitung(string operasi)
        {
            caseSwitchHitung();
            screenKalkulator.Text = tmp.ToString();
        }

        private void clearMode()
        {
            mode_input = false;
            mode_tombol = false;
            mode_awal_kalkulasi = true;
            mode_awal_tombol = true;
        }

        private void cmdHasil_Click(object sender, EventArgs e)
        {
            if (screenKalkulator.Text.Length > 0)
            {
                caseSwitchHitung();
                screenKalkulator.Text = tmp.ToString();
                mode_input  = false;
                mode_tombol = false;
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            /// Menghapus angka di layar
            /// Mereset semua variabel
            clearMode();
            var_1 = 0;
            var_2 = 0;
            tmp   = 0;
            screenKalkulator.Text = "0";
            operasi_kalkulator    = string.Empty;
        }
        private void angka_1_Click(object sender, EventArgs e)
        {
            klikTombolAngka(1);
        }

        private void angka_2_Click(object sender, EventArgs e)
        {
            klikTombolAngka(2);
        }


        private void angka_3_Click(object sender, EventArgs e)
        {
            klikTombolAngka(3);
        }

        private void angka_4_Click(object sender, EventArgs e)
        {
            klikTombolAngka(4);
        }

        private void angka_5_Click(object sender, EventArgs e)
        {
            klikTombolAngka(5);
        }

        private void angka_6_Click(object sender, EventArgs e)
        {
            klikTombolAngka(6);
        }

        private void angka_7_Click(object sender, EventArgs e)
        {
            klikTombolAngka(7);
        }

        private void angka_8_Click(object sender, EventArgs e)
        {
            klikTombolAngka(8);
        }

        private void angka_9_Click(object sender, EventArgs e)
        {
            klikTombolAngka(9);
        }

        private void angka_0_Click(object sender, EventArgs e)
        {
            if (screenKalkulator.Text.Length > 0 || screenKalkulator.Text != "0")
            {
                klikTombolAngka(0);
            }            
        }        

        private void cmdPlus_Click(object sender, EventArgs e)
        {
            klikTombolOperasi(TAMBAH);
        }

        private void cmdMinus_Click(object sender, EventArgs e)
        {
            klikTombolOperasi(KURANG);
        }

        private void cmdBagi_Click(object sender, EventArgs e)
        {
            klikTombolOperasi(BAGI);
        }

        private void cmdKali_Click(object sender, EventArgs e)
        {
            klikTombolOperasi(KALI);
        }

        private void screenKalkulator_TextChanged(object sender, EventArgs e)
        {
            // Fitur, buat kalkulator nerima input angka dari keyboard.
            // Caranya, enable edit di properties text box
            // terus pastiin setiap input itu angka, kalo bukan angka, hapus itu.
        }

        private void cmdHapus_Click(object sender, EventArgs e)
        {
            if (screenKalkulator.Text.Length > 0)
            {
                screenKalkulator.Text = screenKalkulator.Text.Remove(screenKalkulator.Text.Length - 1);
            }
            if (screenKalkulator.Text.Length == 0)
            {
                screenKalkulator.Text = "0";
            }
        }

        private void cmdKuadrat_Click(object sender, EventArgs e)
        {
            /// Kuadratin angka
            /// 8 -> 64, 13 -> 169
            // screenKalkulator.Text = Convert.ToString(Math.Pow(double.Parse(screenKalkulator.Text), 2));
            ubahAngka(Math.Pow( getAngka(),2 ));
        }

        private void cmdLawan_Click(object sender, EventArgs e)
        {
            /// Melawankan angka
            /// -1 -> 1, 39 -> -39
            ubahAngka(-getAngka());
        }
        private void cmdAkar_Click(object sender, EventArgs e)
        {
            if (getAngka() > 0)
            {
                ubahAngka(Math.Sqrt(getAngka()));
            }
        }

        private void LayarUtama_Load(object sender, EventArgs e)
        {

        }

        private void cmdKoma_Click(object sender, EventArgs e)
        {
            if (screenKalkulator.Text.Length > 0)
            {
                screenKalkulator.Text += ",";
            }
        }

        
    }
}
