using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inp_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inp.Text))
            {
                outp.Clear();
            }
            else { 
                if (!(String.IsNullOrEmpty(ss2.Text)))
                {
                    if (ss1.Text == "10")
                    {
                        if (!(String.IsNullOrEmpty(inp.Text)))
                        {


                            outp.Text = DecFrom(Convert.ToInt32(inp.Text), Convert.ToInt32(ss2.Text));

                        } else { outp.Clear(); }




                    }

                    else if (ss2.Text == "10")
                    {
                        if (!(String.IsNullOrEmpty(inp.Text)))
                        {


                            outp.Text = DecTo(inp.Text, ss1.Text);

                        }
                        else { outp.Clear(); }
                    }

                    else
                    {
                        if (!(String.IsNullOrEmpty(inp.Text)))
                        {


                            outp.Text = DecFrom(Convert.ToInt32(DecTo(inp.Text, ss1.Text)), Convert.ToInt32(ss2.Text));

                        }
                        else { outp.Clear(); }

                    }


                } else { outp.Text = "Укажите системы счисления"; } }
        }

        #region методы
        static string DecTo(string num, string ss)
        {
            int newNum = 0;
            string temp = "";
            int t;
            int i;
            for (i = 0; i < num.Length; i++)
            {
                temp = "";
                temp += newCh(num.Substring(i, 1), "from");
                t = (int)Math.Pow(Convert.ToDouble(ss), Convert.ToDouble(num.Length - (i + 1)));
                newNum += Convert.ToInt32(temp) * t;
            }
            return newNum.ToString();
        }

        static string newCh(string sym, string otk)
        {
            string ltr = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string s = "";
            if (otk == "to")
            {
                if (Convert.ToInt32(sym) > 10)
                    s += ltr.Substring(Convert.ToInt32(sym) - 10, 1);
                else
                    s += sym;
            }
            else if (otk == "from")
            {
                if (ltr.IndexOf(sym) == -1)
                    s += sym;
                else
                    s += (ltr.IndexOf(sym) + 10).ToString();
            }
            return s;
        }


        static string DecFrom(long num, int ss)
        {
            string res = "";

            if (ss < 2 || ss > 36) { res = "Неверная СС (только от 1 до 36)"; }
            else
            {


                while (num > 0)
                {
                    long mod = num % ss;
                    if (mod < 10)
                        res = (char)(mod + 48) + res;
                    else
                        res = (char)(mod + 55) + res;
                    num /= ss;
                }
            }
            
            return res;
        }

        


        #endregion


        private void ss1_TextChanged(object sender, EventArgs e)
        {
            inp.Clear();
            outp.Clear();
        }

        private void ss2_TextChanged(object sender, EventArgs e)
        {
            inp.Clear();
            outp.Clear();
        }


        // Только цифры и бэкспейс
        private void inp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            


            
        }
    }
}
