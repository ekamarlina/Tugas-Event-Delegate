using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcApp
{
    public partial class AnakCalc : Form
    {
        public delegate void PenghubungProses(int operasi, int a, int b, int hasil);
        public event PenghubungProses OnProses;

        public AnakCalc()
        {
            InitializeComponent();
             txtOp.SelectedIndex = 0;
        }
        private void btnProses_Click(object sender, EventArgs e)
        {
            string operasi = txtOp.SelectedItem.ToString();
            int a = Convert.ToInt32(txtNilaiA.Text);   //casting
            int b = Convert.ToInt32(txtNilaiB.Text);   //casting
            int hasil;


            switch (txtOp.SelectedIndex)
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
            this.OnProses(txtOp.SelectedIndex, a, b, hasil);

        }
    }
}
