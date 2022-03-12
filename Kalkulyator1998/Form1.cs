using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulyator1998
{
    public partial class Form1 : Form
    {      
        CLASS Odd = new CLASS();
        Injiner Inj = new Injiner();
        programma prog = new programma();
        double a = 0, a1 = 0;
        int amal = 0;
        int sanoq = 16;
        bool radian = true;

        public Form1()
        {
            InitializeComponent();
            
            aylanaButton83.Enabled = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void aylanaButton24_Click(object sender, EventArgs e)
        {
            Odd.Hisobla(amal);

            textBox1.Clear();
            // label1.Text += n;
            textBox1.Text = Odd.natija().ToString();
            amal = 0;
        }

        private void aylanaButton20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "1";
            Odd.bosish(Convert.ToDouble(textBox1.Text));
        }

        private void aylanaButton19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "2";
            Odd.bosish(Convert.ToDouble(textBox1.Text));
        }

        private void aylanaButton18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "3";
            Odd.bosish(Convert.ToDouble(textBox1.Text));
        }

        private void aylanaButton15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "4";
            Odd.bosish(Convert.ToDouble(textBox1.Text));
        }

        private void aylanaButton14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "5";
            Odd.bosish(Convert.ToDouble(textBox1.Text));
        }

        private void aylanaButton13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "6";
            Odd.bosish(Convert.ToDouble(textBox1.Text));
        }

        private void aylanaButton10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "7";
            Odd.bosish(Convert.ToDouble(textBox1.Text));
        }

        private void aylanaButton9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "8";
            Odd.bosish(Convert.ToDouble(textBox1.Text));
        }

        private void aylanaButton8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "9";
            Odd.bosish(Convert.ToDouble(textBox1.Text));
        }

        private void aylanaButton16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "00";
            Odd.bosish(Convert.ToDouble(textBox1.Text));
        }

        private void aylanaButton21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "0";
            Odd.bosish(Convert.ToDouble(textBox1.Text));
        }

        private void aylanaButton22_Click(object sender, EventArgs e)
        {

            string t; int g = 0;
            t = Convert.ToString(textBox1.Text);
            for (int i = 0; i < t.Length; i++)
                if (t[i] == ',') g++;
            if (g < 1) textBox1.Text += ",";

        }

        private void aylanaButton7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Odd.Hisobla(amal);
            amal = 4;
        }

        private void aylanaButton12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Odd.Hisobla(amal);
            amal = 3;
        }

        private void aylanaButton17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Odd.Hisobla(amal);
            amal = 2;
        }

        private void aylanaButton23_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Odd.Hisobla(amal);
            amal = 1;
        }

        private void aylanaButton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void aylanaButton3_Click(object sender, EventArgs e)
        {
           a1 = Convert.ToDouble(textBox1.Text);
            a1 *= -1;
            Odd.bosish(a1);
            textBox1.Text = a1.ToString();
        }

        private void aylanaButton4_Click(object sender, EventArgs e)
        {
            a1 = Odd.foiz();
            Odd.bosish(a1);
            amal = 0;
            textBox1.Text = a1.ToString();
        }

        private void aylanaButton5_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(textBox1.Text);
            a1 = Math.Sqrt(a1);
            textBox1.Text = a1.ToString();
            Odd.bosish(a1);
        }

        private void aylanaButton6_Click(object sender, EventArgs e)
        {

            a1 = Convert.ToDouble(textBox1.Text);
            a1 = Math.Pow(a1, 2);
            Odd.bosish(a1);
            textBox1.Text = a1.ToString();
        }

        private void aylanaButton11_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(textBox1.Text);
            a1 = 1 / a1;
            Odd.bosish(a1);
            textBox1.Text = a1.ToString();
        }

        private void aylanaButton1_Click(object sender, EventArgs e)
        {
            string l;
            l = Convert.ToString(textBox1.Text);
            if (l != "0")
            {
                l = l.Substring(0, l.Length - 1);
                textBox1.Text = l;
            }
            if (l.Length == 0)
                textBox1.Text = "0";
            Odd.bosish(Convert.ToDouble(textBox1.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radian = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aylanaButton40_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Clear();
            textBox2.Text += "7";
            Inj.bosish(Convert.ToDouble(textBox2.Text));
        }

        private void aylanaButton39_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Clear();
            textBox2.Text += "8";
            Inj.bosish(Convert.ToDouble(textBox2.Text));
        }

        private void aylanaButton38_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Clear();
            textBox2.Text += "9";
            Inj.bosish(Convert.ToDouble(textBox2.Text));
        }

        private void aylanaButton48_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Clear();
            textBox2.Text += "4";
            Inj.bosish(Convert.ToDouble(textBox2.Text));
        }

        private void aylanaButton47_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Clear();
            textBox2.Text += "5";
            Inj.bosish(Convert.ToDouble(textBox2.Text));
        }

        private void aylanaButton46_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Clear();
            textBox2.Text += "6";
            Inj.bosish(Convert.ToDouble(textBox2.Text));
        }

        private void aylanaButton54_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Clear();
            textBox2.Text += "3";
            Inj.bosish(Convert.ToDouble(textBox2.Text));
        }

        private void aylanaButton55_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Clear();
            textBox2.Text += "2";
            Inj.bosish(Convert.ToDouble(textBox2.Text));
        }

        private void aylanaButton56_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Clear();
            textBox2.Text += "1";
            Inj.bosish(Convert.ToDouble(textBox2.Text));
        }

        private void aylanaButton53_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Clear();
            textBox2.Text += "0";
            Inj.bosish(Convert.ToDouble(textBox2.Text));
        }

        private void aylanaButton59_Click(object sender, EventArgs e)
        {

            string t; int g = 0;
            t = Convert.ToString(textBox2.Text);
            for (int i = 0; i < t.Length; i++)
                if (t[i] == ',') g++;
            if (g < 1) textBox2.Text += ",";
        }

        private void aylanaButton58_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(textBox2.Text);
            a1 *= -1;
            Odd.bosish(a1);
            textBox2.Text = a1.ToString();
        }

        private void aylanaButton36_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Inj.Hisobla(amal);
            amal = 4;
        }

        private void aylanaButton44_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Inj.Hisobla(amal);
            amal = 3;
        }

        private void aylanaButton52_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Inj.Hisobla(amal);
            amal = 2;
        }

        private void aylanaButton57_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Inj.Hisobla(amal);
            amal = 1;
        }

        private void aylanaButton26_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void aylanaButton25_Click(object sender, EventArgs e)
        {
            string d;
            d = Convert.ToString(textBox2.Text);
            if (d != "0")
            {
                d = d.Substring(0, d.Length - 1);
                textBox2.Text = d;
            }
            if (d.Length == 0)
                textBox2.Text = "0";
            a1 = Convert.ToDouble(textBox2.Text);
        }

        private void aylanaButton27_Click(object sender, EventArgs e)
        {
            a1 = Inj.foiz();
            Inj.bosish(a1);
            amal = 0;
            textBox2.Text = a1.ToString();

        }

        private void aylanaButton29_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(textBox2.Text);
            a1 = Inj.ildiz(a1);
            Inj.bosish(a1);
            textBox2.Text = a1.ToString();
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void aylanaButton28_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(textBox2.Text);
            a1 = Inj.sinush(a1, radian);
            textBox2.Text = a1.ToString();
        }

        private void aylanaButton37_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Inj.Hisobla(amal);
            amal = 8;
        }

        private void aylanaButton45_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(textBox2.Text);
            a1 = 1 / a1;
            Inj.bosish(a1);
            textBox2.Text = a1.ToString();
        }

        private void aylanaButton30_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(textBox2.Text);
            a1 = Inj.cosh(a1, radian);
            textBox2.Text = a1.ToString();
        }

        private void aylanaButton35_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(textBox2.Text);
            a1 = Inj.sinus(a1, radian);
            textBox2.Text = a1.ToString();
        }

        private void aylanaButton43_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(textBox2.Text);
            a1 = Inj.cosinus(a1, radian);
            textBox2.Text = a1.ToString();

        }

        private void aylanaButton51_Click(object sender, EventArgs e)
        {

            a1 = Convert.ToDouble(textBox2.Text);
            a1 = Inj.tangens(a1, radian);
            textBox2.Text = a1.ToString();
        }

        private void aylanaButton62_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(textBox2.Text);
            a1 = 1 / Inj.tangens(a1, radian);
            textBox2.Text = a1.ToString();
        }

        private void aylanaButton31_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(textBox2.Text);
            a1 = Inj.tangensh(a1, radian);
            textBox2.Text = a1.ToString();
        }

        private void aylanaButton34_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(textBox2.Text);
            a1 = Math.Pow(a1, 2);
            Inj.bosish(a1);
            textBox2.Text = a1.ToString();
        }

        private void aylanaButton42_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(textBox2.Text);
            a1 = Math.Pow(a1, 3);
            Inj.bosish(a1);
            textBox2.Text = a1.ToString();
        }

        private void aylanaButton50_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(textBox2.Text);
            a1 = Math.Pow(10, a1);
            Inj.bosish(a1);
            textBox2.Text = a1.ToString();
    
        }

        private void aylanaButton61_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Inj.Hisobla(amal);
            amal = 5;
        }

        private void aylanaButton32_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox2.Text);
            n = Inj.faktaryal(n);
            Inj.bosish(n);
            textBox2.Text = n.ToString();
        }

        private void aylanaButton33_Click(object sender, EventArgs e)
        {
            a1 = Math.PI;
            textBox2.Text = a1.ToString();
            Inj.bosish(a1);
        }

        private void aylanaButton41_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(textBox2.Text);
            a1 = Inj.lnlog(a1);
            textBox2.Text = a1.ToString();
            Inj.bosish(a1);
        }

        private void aylanaButton49_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(textBox2.Text);
            textBox2.Clear();
            a = Convert.ToDouble(textBox2.Text);
            a1 = Inj.Logarifim(a1) / Inj.Logarifim(a);
            Inj.bosish(a1);
            textBox2.Text = a1.ToString();
        }

        private void aylanaButton60_Click(object sender, EventArgs e)
        {
            Inj.Hisobla(amal);
            textBox2.Clear();
            amal = 7;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radian = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
                sanoq = 16;
            aylanaButton63.Enabled = true;
            aylanaButton72.Enabled = true;
            aylanaButton77.Enabled = true;
            aylanaButton82.Enabled = true;
            aylanaButton85.Enabled = true;
            aylanaButton64.Enabled = true;
            int m = prog.nat();
            textBox3.Text = Convert.ToString(m, sanoq);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void aylanaButton63_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0") textBox3.Clear();
            textBox3.Text += "A";
            prog.bosish(Convert.ToInt32(textBox3.Text, sanoq));  
        }

        private void aylanaButton72_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0") textBox3.Clear();
            textBox3.Text += "B";
            prog.bosish(Convert.ToInt32(textBox3.Text, sanoq));  
        }

        private void aylanaButton77_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0") textBox3.Clear();
            textBox3.Text += "C";
            prog.bosish(Convert.ToInt32(textBox3.Text, sanoq));  
        }

        private void aylanaButton82_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0") textBox3.Clear();
            textBox3.Text += "D";
            prog.bosish(Convert.ToInt32(textBox3.Text, sanoq));  
        }

        private void aylanaButton85_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0") textBox3.Clear();
            textBox3.Text += "E";
            prog.bosish(Convert.ToInt32(textBox3.Text, sanoq));  
        }

        private void aylanaButton64_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0") textBox3.Clear();
            textBox3.Text += "F";
            prog.bosish(Convert.ToInt32(textBox3.Text, sanoq));  
        }

        private void aylanaButton71_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0") 
                textBox3.Clear();
            textBox3.Text += "7";
            prog.bosish(Convert.ToInt32(textBox3.Text, sanoq));   
        }

        private void aylanaButton70_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0") textBox3.Clear();
            textBox3.Text += "8";
            prog.bosish(Convert.ToInt32(textBox3.Text, sanoq));   
        }

        private void aylanaButton69_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0") textBox3.Clear();
            textBox3.Text += "9";
            prog.bosish(Convert.ToInt32(textBox3.Text, sanoq));   
        }

        private void aylanaButton76_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0") textBox3.Clear();
            textBox3.Text += "4";
            prog.bosish(Convert.ToInt32(textBox3.Text, sanoq));  
        }

        private void aylanaButton75_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0") textBox3.Clear();
            textBox3.Text += "5";
            prog.bosish(Convert.ToInt32(textBox3.Text, sanoq));   
        }

        private void aylanaButton74_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0") textBox3.Clear();
            textBox3.Text += "6";
            prog.bosish(Convert.ToInt32(textBox3.Text, sanoq));   
        }

        private void aylanaButton81_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0") textBox3.Clear();
            textBox3.Text += "1";
            prog.bosish(Convert.ToInt32(textBox3.Text, sanoq));   
        }

        private void aylanaButton80_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0") textBox3.Clear();
            textBox3.Text += "2";
            prog.bosish(Convert.ToInt32(textBox3.Text, sanoq));   
        }

        private void aylanaButton79_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0") textBox3.Clear();
            textBox3.Text += "3";
            prog.bosish(Convert.ToInt32(textBox3.Text, sanoq));   
        }

        private void aylanaButton84_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0") textBox3.Clear();
            textBox3.Text += "0";
            prog.bosish(Convert.ToInt32(textBox3.Text, sanoq));   
        }

        private void aylanaButton83_Click(object sender, EventArgs e)
        {
            textBox3.Text += ",";
        }

        private void aylanaButton65_Click(object sender, EventArgs e)
        {
            string s;
            s = Convert.ToString(textBox3.Text);
            if (s != "0")
            {
                s = s.Substring(0, s.Length - 1);
                textBox3.Text = s;
            }
            if (s.Length == 0)
                textBox3.Text = "0";
            a1 = Convert.ToInt32(textBox3.Text, sanoq);  
        }

        private void aylanaButton66_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void aylanaButton67_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            prog.Hisobla(amal);
            amal = 4;
        }

        private void aylanaButton68_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            prog.Hisobla(amal);
            amal = 3;
        }

        private void aylanaButton73_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            prog.Hisobla(amal);
            amal = 2;
        }

        private void aylanaButton78_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            prog.Hisobla(amal);
            amal = 1;
        }

        private void aylanaButton86_Click(object sender, EventArgs e)
        {
            int m;
            prog.Hisobla(amal);
            textBox3.Clear();
            m = prog.nat();
            textBox3.Text = Convert.ToString(m, sanoq);
            amal = 0;
        }

        private void Ikkilik_CheckedChanged(object sender, EventArgs e)
        {
            if (Ikkilik.Checked)
                sanoq = 2;
            aylanaButton71.Enabled = false;
            aylanaButton70.Enabled = false;
            aylanaButton69.Enabled = false;
            aylanaButton76.Enabled = false;
            aylanaButton75.Enabled = false;
            aylanaButton74.Enabled = false;
            aylanaButton80.Enabled = false;
            aylanaButton79.Enabled = false;
            int m = prog.nat();
            textBox3.Text = Convert.ToString(m, sanoq);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                sanoq = 8;
            aylanaButton70.Enabled = false;
            aylanaButton69.Enabled = false;
            aylanaButton63.Enabled = false;
            aylanaButton72.Enabled = false;
            aylanaButton77.Enabled = false;
            aylanaButton82.Enabled = false;
            aylanaButton85.Enabled = false;
            aylanaButton64.Enabled = false;
            //++++++++++++++++++++++++++++++++
            aylanaButton71.Enabled = true;
            aylanaButton76.Enabled = true;
            aylanaButton75.Enabled = true;
            aylanaButton74.Enabled = true;
            aylanaButton80.Enabled = true;
            aylanaButton79.Enabled = true;
            int m = prog.nat();
            textBox3.Text = Convert.ToString(m, sanoq);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
                sanoq = 10;
            aylanaButton63.Enabled = false;
            aylanaButton72.Enabled = false;
            aylanaButton77.Enabled = false;
            aylanaButton82.Enabled = false;
            aylanaButton85.Enabled = false;
            aylanaButton64.Enabled = false;
            //+++++++++++++++++++++++
            aylanaButton70.Enabled = true;
            aylanaButton69.Enabled = true;
            int m = prog.nat();
            textBox3.Text = Convert.ToString(m, sanoq);
        }

        private void aylanaButton88_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void aylanaButton87_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }

        private void aylanaButton89_Click(object sender, EventArgs e)
        {
            Inj.Hisobla(amal);
            textBox2.Clear();
            textBox2.Text = Inj.natija().ToString();
        }

        private void aylanaButton90_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
