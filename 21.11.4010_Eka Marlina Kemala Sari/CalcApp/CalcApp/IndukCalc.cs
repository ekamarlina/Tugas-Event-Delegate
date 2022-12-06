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
    public partial class IndukCalc : Form
    {
        private IList<Calc> listofCalc = new List<Calc>();
        private void AnakCalc_OnCreate(Calc calc)
        {
            listofCalc.Add(calc);

            ListViewItem item = new ListViewItem();
            item.SubItems.Add(calc.Operasi);
            item.SubItems.Add(calc.NilaiA);
            item.SubItems.Add(calc.NilaiB);
            listhasil.Items.Add(item);
        }
        
            public IndukCalc()
        {
            InitializeComponent();
        }
        private void tampilan(int operasi, int a, int b, int hasil)
        {
            char[] operasi_simbol = { '+', '-', 'x', '/' };
            string[] operasi_str = { "Penambahan", "Pengurangan", "Perkalian", "Pembagian" };
            listhasil.Items.Add($"Hasil {(operasi_str[operasi]).ToLower()} {a} {operasi_simbol[operasi]} {b} = {hasil}");
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            AnakCalc hitung = new AnakCalc();
            hitung.OnProses += tampilan;
            hitung.ShowDialog();
        }
    }
}

