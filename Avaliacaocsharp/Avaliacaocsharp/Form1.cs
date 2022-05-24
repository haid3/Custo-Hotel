using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacaocsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            lbl_consumo.Text = txtbox_consumo.Text;
            lbl_dias.Text = box_dias.Text;
            lbl_quarto. = comboBox1.Text;
           
            

            if (txtbox_consumo.Text == "" || comboBox1.Text == "" || box_dias.Text ==""||
                txtbox_consumo.Text =="")
            {
                MessageBox.Show("Preencha todos os campos!");
                
            }
            else
            {

                lbl_nome.Text = txtbox_nome.Text + " você gastou um total de: R$" + " no " + comboBox1.Text + ", se hospedando por " + box_dias.Text + " dias.";

                if (comboBox1.Text == "Quarto pobre") MessageBox.Show("O quarto pobre custa R$10 reais o dia.");
                if (comboBox1.Text == "Quarto mediano") MessageBox.Show("O quarto mediano custa R$100,00 reais o dia.");
                if (comboBox1.Text == "Quarto de rico") MessageBox.Show("O quarto de rico custa R$1.000 reais o dia.");
                if (comboBox1.Text == "Quarto o$tentação") MessageBox.Show("O quarto o$tentação custa R$10.000 reais o dia.");

                if (lbl_quarto.Text == "Quarto pobre")
                {
                    lbl_valorquarto.Text = 1;
                }



            }

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }
    }
}
