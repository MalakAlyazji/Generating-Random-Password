using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratePasswordProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum enstatus {lowercase,uppercase,digit,symbols }
        struct stpass { public enstatus scase;public int nofletters;public string result; };
        stpass pass;
        enstatus status = enstatus.lowercase;
        enstatus checkedtoenum(CheckBox cb)
        {
            if ( cb.Text== "LowerCase")
            {
                return pass.scase=enstatus.lowercase;
                    
            }if ( cb.Text == "UpperCase")
            {
                return pass.scase = enstatus.uppercase;
            }
             if ( cb.Text == "Digits")
            {
                return pass.scase = enstatus.digit;
            }
            if( cb.Text == "Symbols")
            {
                return pass.scase = enstatus.symbols;
            }
            return pass.scase ;
        }
        string fillrandom( int nofletters)
        {
            string s = "";
            Random ran = new Random();
            for(int i=0;i< nofletters; i++)
            {
                if (cblower.Checked)
                    s +=(char) ran.Next(97,123);
                if (cbupper.Checked)
                    s += (char)ran.Next(65,90);
                if (cbdigit.Checked)
                    s += (char)ran.Next(48,56);
                if (cbsymbols.Checked)
                    s += (char)ran.Next(33,47);
            }
            return s.Substring(0,nofletters);
        }
            void generate()
        {
            pass.result= fillrandom(pass.nofletters);
        }

        private void cbsymbols_CheckedChanged(object sender, EventArgs e)
        {
            checkedtoenum((CheckBox)sender);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pass.nofletters= trackBar1.Value;
            lbnletters.Text = pass.nofletters.ToString();
        }

        private void btgenerate_Click(object sender, EventArgs e)
        {
            
            generate();
            textBox1.Text = pass.result;
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
