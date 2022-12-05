using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiCalculator
{
    public partial class Calculator : Form
    {
        public delegate void PenghubungProses(int operasi, int a, int b, int hasil);
        public event PenghubungProses OnProses;

        public Calculator()
        {
            InitializeComponent();
        }

        private void ProsesNilai_Click(object sender, EventArgs e)
        {
            string operasi = OperasiPilihan.SelectedItem.ToString();
            int a = Convert.ToInt32(NilaiA.Text);   //casting
            int b = Convert.ToInt32(NilaiB.Text);   //casting
            int hasil;

            switch (OperasiPilihan.SelectedIndex)
            {
                case 0: // penjumlahan
                    hasil = a + b;
                    break;
                case 1: // pengurangan
                    hasil = a - b;
                    break;
                case 2: // perkalian
                    hasil = a * b;
                    break;
                case 3: // pembagian
                    hasil = a / b;
                    break;
                default: // default
                    hasil = 0;
                    break;
            }
            this.OnProses(OperasiPilihan.SelectedIndex, a, b, hasil);
        }
    }
}
