using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_excepcion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       //rulo
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int A, B, Resultado;
            try
            {
                A = int.Parse(TBN1.Text);
                B = int.Parse(TBN2.Text);
                Resultado = A / B;
                LBLResultado.Text = Resultado.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ingrese numeros");

            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por cero");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. Comuniquese con sistemas");
            }
            finally 
            {
                LBLResultado.BackColor = Color.Red;
            }
            //Modificacion 2
        }
    }
}
