using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Principal : Form
    {
        public static string[] arraySocoata = new string[1];
        public static List<string> arrayText = new List<string>();
        public static int ok;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUnu_Click(object sender, EventArgs e)
        {
            arrayText.Add(btnUnu.Text);
            arraySocoata[0] = string.Join("", arrayText).ToString();
            lblText.Text = arraySocoata[0];
            ok = 1;

        }

        private void btnPls_Click(object sender, EventArgs e)
        {
            arrayText.Add("+");
            arraySocoata[0] = string.Join("", arrayText).ToString();
            lblText.Text = arraySocoata[0];
            ok = 1;
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            if ((arraySocoata[0].Contains("+") || arraySocoata[0].Contains("-") || arraySocoata[0].Contains("*") || arraySocoata[0].Contains("/")) && (arraySocoata[0].ElementAt(0) != Convert.ToChar("*") && arraySocoata[0].ElementAt(0) != Convert.ToChar("/") && arraySocoata[0].ElementAt(0) != Convert.ToChar("+") && arraySocoata[0].ElementAt(0) != Convert.ToChar("-")))
            {
            DataTable nr = new DataTable();
            if (arraySocoata[0].Contains("/"))
            {
                try
                {
                    double rezultat = (double)nr.Compute(arraySocoata[0], "");
                    lblText.Text = Convert.ToString(rezultat);
                }
                catch { lblText.Text = "gazilioane!?"; }
            }
            else
            {
                try
                {
                    int rezultat = (int)nr.Compute(arraySocoata[0], "");
                    lblText.Text = Convert.ToString(rezultat);
                }
                catch { lblText.Text = "gazilioane!?"; }
            }
            arrayText.Clear();
            arrayText.Add(lblText.Text);
            ok = 0;
            }
        }

        private void btnStrg_Click(object sender, EventArgs e)
        {
            if (arraySocoata[0].Length > 0 && ok == 1)
            {
                arraySocoata[0] = arraySocoata[0].Substring(0, (arraySocoata[0].Length - 1));
                lblText.Text = arraySocoata[0];
                arrayText.Clear();
                arrayText.Add(lblText.Text);
            }
            if (ok == 0)
            {
                arrayText.Clear();
                arraySocoata[0]="0";
            }
            lblText.Text = arraySocoata[0];
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            arrayText.Add(btnDoi.Text);
            arraySocoata[0] = string.Join("", arrayText).ToString();
            lblText.Text = arraySocoata[0];
            ok = 1;
        }

        private void btnTrei_Click(object sender, EventArgs e)
        {
            arrayText.Add(btnTrei.Text);
            arraySocoata[0] = string.Join("", arrayText).ToString();
            lblText.Text = arraySocoata[0];
            ok = 1;
        }

        private void btnPatru_Click(object sender, EventArgs e)
        {
            arrayText.Add(btnPatru.Text);
            arraySocoata[0] = string.Join("", arrayText).ToString();
            lblText.Text = arraySocoata[0];
            ok = 1;
        }

        private void btnCinci_Click(object sender, EventArgs e)
        {
            arrayText.Add(btnCinci.Text);
            arraySocoata[0] = string.Join("", arrayText).ToString();
            lblText.Text = arraySocoata[0];
            ok = 1;
        }

        private void btnSase_Click(object sender, EventArgs e)
        {
            arrayText.Add(btnSase.Text);
            arraySocoata[0] = string.Join("", arrayText).ToString();
            lblText.Text = arraySocoata[0];
            ok = 1;
        }

        private void btnSapte_Click(object sender, EventArgs e)
        {
            arrayText.Add(btnSapte.Text);
            arraySocoata[0] = string.Join("", arrayText).ToString();
            lblText.Text = arraySocoata[0];
            ok = 1;
        }

        private void btnOpt_Click(object sender, EventArgs e)
        {
            arrayText.Add(btnOpt.Text);
            arraySocoata[0] = string.Join("", arrayText).ToString();
            lblText.Text = arraySocoata[0];
            ok = 1;
        }

        private void btnNoua_Click(object sender, EventArgs e)
        {
            arrayText.Add(btnNoua.Text);
            arraySocoata[0] = string.Join("", arrayText).ToString();
            lblText.Text = arraySocoata[0];
            ok = 1;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            arrayText.Add(btnZero.Text);
            arraySocoata[0] = string.Join("", arrayText).ToString();
            lblText.Text = arraySocoata[0];
            ok = 1;
        }

        private void btnOri_Click(object sender, EventArgs e)
        {
            arrayText.Add("*");
            arraySocoata[0] = string.Join("", arrayText).ToString();
            lblText.Text = arraySocoata[0];
            ok = 1;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            arrayText.Add("-");
            arraySocoata[0] = string.Join("", arrayText).ToString();
            lblText.Text = arraySocoata[0];
            ok = 1;
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            arrayText.Add("/");
            arraySocoata[0] = string.Join("", arrayText).ToString();
            lblText.Text = arraySocoata[0];
            ok = 1;
        }

    }
}
