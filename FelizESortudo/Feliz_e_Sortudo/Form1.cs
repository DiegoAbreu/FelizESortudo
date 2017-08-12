using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FelizESortudo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Form load
        private void Form1_Load(object sender, EventArgs e)
        {}

// Elementos visuais e textos:

        // Titulo: Feliz e sortudo?
        private void label1_Click(object sender, EventArgs e)
        { }

        // Texto: insira seu numero abaixo
        private void label3_Click(object sender, EventArgs e)
        { }

        // Campo para inserir Numero
        private void textBox1_TextChanged(object sender, EventArgs e)
        { }

        // Texto: Descubra se seu numero e:
        private void label5_Click(object sender, EventArgs e)
        { }

        // Texto "ou" entre botao feliz e botao sortudo
        private void label4_Click(object sender, EventArgs e)
        { }

        // // Texto "ou" entre botao sortudo e botao feliz e sortudo
        private void label7_Click(object sender, EventArgs e)
        { }

        // Campo resposta: felicidade
        private void label2_Click(object sender, EventArgs e)
        { }

        // Campo resposta: sorte

        private void label6_Click(object sender, EventArgs e)
        { }

        //Background respostas
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        { }

// Botoes

        // Botao Feliz: Verifica Felicidade
        private void button1_Click_1(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToUInt16(textBox1.Text);
            {
                var verifica = new Dictionary<int, bool>();
                var felicidade = num;

                while (!verifica.ContainsKey(felicidade))
                {
                    verifica.Add(felicidade, true);
                    var start = felicidade;
                    felicidade = 0;

                    while (start != 0)
                    {
                        felicidade += (start % 10) * (start % 10);
                        start /= 10;
                    }

                    if (felicidade == 1)
                    {
                        label2.Text = ("Seu número é um número feliz =D");
                    }
                    else
                    {
                        label2.Text = ("Seu número é um número triste =(");
                    }
                }

            }
        }

        // Botao Sortudo: Verifica sorte
        private void button2_Click(object sender, EventArgs e)
        {
            int num;
            int[] sorte = new int[] { 1, 3, 7, 9, 13, 15, 21, 25, 31, 33, 37, 43, 49, 51, 63, 67, 69, 73, 75, 79, 87, 93, 99 };
            num = Convert.ToUInt16(textBox1.Text);
            if (sorte.Contains(num))
            {
                label6.Text = ("Seu número é um número sortudo! ");
            }
            else
            {
                label6.Text = ("Seu número nao é um número de sorte.");
            }
        }
        
        // Botao Feliz e sortudo: Verifica felicidade e sorte
        private void button3_Click_1(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToUInt16(textBox1.Text);
            // Parte que verifica a sorte
            int[] sorte = new int[] { 1, 3, 7, 9, 13, 15, 21, 25, 31, 33, 37, 43, 49, 51, 63, 67, 69, 73, 75, 79, 87, 93, 99 };
            num = Convert.ToUInt16(textBox1.Text);
            if (sorte.Contains(num))
            {
                label6.Text = ("Seu número é um número sortudo! ");
            }
            else
            {
                label6.Text = ("Seu número nao é um número de sorte.");
            }
            // Parte que verifica a felicidade
            {
                var verifica = new Dictionary<int, bool>();
                var felicidade = num;

                while (!verifica.ContainsKey(felicidade))
                {
                    verifica.Add(felicidade, true);
                    var start = felicidade;
                    felicidade = 0;

                    while (start != 0)
                    {
                        felicidade += (start % 10) * (start % 10);
                        start /= 10;
                    }

                    if (felicidade == 1)
                    {
                        label2.Text = ("Seu número é um número feliz =D");
                    }
                    else
                    {
                        label2.Text = ("Seu número é um número triste =(");
                    }
                }
            }
        }

        // Botao Sair/Fechar
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    } 
}

