using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string piramidaVysota1 = textBox1.Text;
            float piramidaVysota2 = float.Parse(piramidaVysota1);

            string piramidaDov1 = textBox11.Text;
            float piramidaDov2 = float.Parse(piramidaDov1);

            var Pentagona = new PentagonalPyramid { height = piramidaVysota2, Width = piramidaDov2 };

            double resultPlo1 = Pentagona.Area();
            double resultVolume1 = Pentagona.Volume();

            string resultPlo2 = resultPlo1.ToString();
            string resultVolume2 = resultVolume1.ToString();

            label4.Text = resultPlo2;
            label5.Text = resultVolume2;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string TrykutVysota1 = textBox8.Text;
            float TrykutVysota2 = float.Parse(TrykutVysota1);

            string DovgynaOsnovy1 = textBox7.Text;
            float DovgynaOsnovy2 = float.Parse(DovgynaOsnovy1);

            var rectanle = new Triangle { height = TrykutVysota2, bottomWidth = DovgynaOsnovy2 };

            double resultPlo1 = rectanle.Area();
            double resultPere1 = rectanle.Perimeter();

            string resultPlo2 = resultPlo1.ToString();
            string resultPere2 = resultPere1.ToString();

            label24.Text = resultPlo2;
            label26.Text = resultPere2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string CylVysota1 = textBox2.Text;
            float CylVysota2 = float.Parse(CylVysota1);

            string CylRad1 = textBox3.Text;
            float CylRad12 = float.Parse(CylRad1);

            var Cyl = new Cylinder { height = CylVysota2, radius = CylRad12 };

            double resultArea1 = Cyl.Area();
            double resultVol1 = Cyl.Volume();

            string resultArea2 = resultArea1.ToString();
            string resultVol2 = resultVol1.ToString();

            label11.Text = resultArea2;
            label12.Text = resultVol2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ConlVysota1 = textBox4.Text;
            float ConVysota2 = float.Parse(ConlVysota1);

            string ConRad1 = textBox5.Text;
            float ConRad2 = float.Parse(ConRad1);

            string ConDov1 = textBox12.Text;
            float ConDov2 = float.Parse(ConDov1);

            var Con = new Cone { height = ConVysota2, radius = ConRad2, L = ConDov2 };

            double resultArea1 = Con.Area();
            double resultVol1 = Con.Volume();

            string resultArea2 = resultArea1.ToString();
            string resultVol2 = resultVol1.ToString();

            label16.Text = resultArea2;
            label17.Text = resultVol2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Fdiag1 = textBox9.Text;
            float Fdiag2 = float.Parse(Fdiag1);

            string Sdiag1 = textBox10.Text;
            float Sdiag2 = float.Parse(Sdiag1);

            var Rom = new Rhomb { diagonal_1 = Fdiag2, diagonal_2 = Sdiag2 };

            double resultArea1 = Rom.Area();
            double resultVol1 = Rom.Perimeter();

            string resultArea2 = resultArea1.ToString();
            string resultVol2 = resultVol1.ToString();

            label20.Text = resultArea2;
            label21.Text = resultVol2;
        }
    }
}
