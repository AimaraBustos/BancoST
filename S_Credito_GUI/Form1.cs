using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_Credito_GUI
{
    public partial class Títilo : Form
    {
        public Títilo()
        {
            InitializeComponent();
        }





        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Títilo_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }
        private void controlBoton1()
        {


            if (txtnombre.Text.Trim() != string.Empty && txtnombre.Text.All(char.IsLetter))
            {
                button1.Enabled = true;
                errorProvider1.SetError(txtnombre, "");
            }
            else
            {
                if (!(txtnombre.Text.All(char.IsLetter)))
                {
                    errorProvider1.SetError(txtnombre, "El nombre solo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(txtnombre, "Debe introduir un nombre");
                }
                button1.Enabled = false;
                txtnombre.Focus();
            }
        }
    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            controlBoton1();
        }

        private void cantCuotas_Click(object sender, EventArgs e)
        {

        }

      

        private void txtmontoCredito_TextChanged(object sender, EventArgs e)
        {
            
            {
               
            }
        }
    }
}
