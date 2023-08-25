using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          int numx = 0;

            int[] numeros = new int[5];

            numeros[0] = 23455;
            numeros[1] = 6567;
            numeros[2] = 2568;
            numeros[3] = 4454;
            numeros[4] = 4444;

            MessageBox.Show(numeros[0].ToString());

                for (int i = 0; i < numeros.Length; i++) ;
            {
                MessageBox.Show(numeros[1].ToString());
                MessageBox.Show(numeros[2].ToString());
                MessageBox.Show(numeros[3].ToString());
                MessageBox.Show(numeros[4].ToString());
            }
;        }
    }
}
