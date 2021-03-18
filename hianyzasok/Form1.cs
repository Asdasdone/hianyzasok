using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace hianyzasok
{
    public partial class Form1 : Form
    {
        static List<hiany> lista = new List<hiany>();
        public Form1()
        {
            InitializeComponent();
            ol();
        }

        private void ol()
        {
            StreamReader ol = new StreamReader("szeptember.csv");
            string[] fejlec = ol.ReadLine().Split(';');
            lblista.Items.Add(fejlec[0] + "\t" + fejlec[1] + "\t" + fejlec[2] + "\t" + fejlec[3] + "\t" + fejlec[4] + "\t");
            while (!ol.EndOfStream)
            {
                string[] sed = ol.ReadLine().Split(';');
                lblista.Items.Add(sed[0] + "\t" + sed[1] + "\t" + sed[2] + "\t" + sed[3] + "\t" + sed[4] + "\t");
                lista.Add(new hiany(sed[0], sed[1], int.Parse(sed[2]), int.Parse(sed[3]), int.Parse(sed[4])));
            }


            ol.Close();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            string nev = tbnev.Text.Trim();
            string osz = tbosz.Text.Trim();
            string el = tbelso.Text.Trim();
            string ut = tbutso.Text.Trim();
            string mu = tbmul.Text.Trim();
            if (el == "" || mu == "" || nev == "" || osz == "" || ut=="")
            {
                MessageBox.Show("Minden mezőt ki kell tölteni");
            }
            else
            {

                if (!Regex.IsMatch(el, @"^\d+$") || !Regex.IsMatch(ut, @"^\d+$") || !Regex.IsMatch(mu, @"^\d+$"))
                {
                    MessageBox.Show("Nem számot adtál meg");
                }
                else
                {
                    int elso = int.Parse(el);
                    int utso = int.Parse(ut);

                    if (elso<1 || elso>30 || utso<1 || utso>30)
                    {
                        MessageBox.Show("Hibás adat! Csak 1 és 30 közzöti érték lehet!");
                    }
                    else
                    {
                        if (elso>utso)
                        {
                            MessageBox.Show("Az utolsó nap nagyobb legyen mint az első");
                        }
                        else
                        {
                            MessageBox.Show("Az állomány bővítése sikeres volt!");
                            StreamWriter ir = new StreamWriter("szeptember.csv", true);
                            ir.WriteLine("{0};{1};{2};{3};{4}",nev,osz,el,ut,mu);

                            ir.Close();
                        }
                    }
                }
            }
        }
    }
}
