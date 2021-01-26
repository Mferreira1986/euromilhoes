using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroMilhoes
{
    public partial class EuroMilhoes : Form
    {
        int[] randomnrs = new int[5];
        int[] randomest = new int[2];
        //int varaux = 0;
        Random rnd = new Random();

        public EuroMilhoes()
        {
            InitializeComponent();
            MessageBox.Show("Boa Sorte!", "Euro Milhões", MessageBoxButtons.OK);
        }

        
        private void btn_gerarchave_Click(object sender, EventArgs e)
        {

            //int MinNR = 1;
            //int MaxNR = 50;
            //int MinEst = 1;
            //int MaxEst = 12;
                    
            for (int i = 0; i < randomnrs.Length; i++)
            {
                randomnrs[i] = rnd.Next(1, 51);

                for (int j = 0; j < randomest.Length; j++)
                {
                    randomest[j] = rnd.Next(1, 13);
                    lbl_numeros.Text = string.Join(" ", randomnrs) + " + " + string.Join(" ", randomest);
                }
            }
        }

        private void estadoInicial()
        {
            lbl_numeros.Text = string.Empty;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            estadoInicial();
        }

        private void btn_ordenar_Click(object sender, EventArgs e)
        {
            Array.Sort(randomnrs);
            Array.Sort(randomest);
            lbl_numeros.Text = string.Join(" ", randomnrs) + " + " + string.Join(" ", randomest);
        }
    }
}
