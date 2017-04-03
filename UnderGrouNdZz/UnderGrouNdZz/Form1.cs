using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnderGrouNdZz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Criação do objeto Carro1, que é uma instancia da classe Carro
            //Preenchimento dos atributos de Carro1
            Carro carro1 = new Carro();
            carro1.modelo = "uno";
            carro1.marca = "fiat";
            carro1.cor = "prata";
            carro1.motorizacao = "1.0";
            carro1.ano_fabricacao = 2010;
            carro1.velocidade_maxima = 120;
            carro1.quantidade_marchas = 6;

            //Preenchimento da ficha do carro
            lblModelo.Text = carro1.modelo;
            lblMarca.Text = carro1.marca;
            lblCor.Text = carro1.cor;
            lblMotorizacao.Text = carro1.motorizacao;
            lblAnoFabricacao.Text = carro1.ano_fabricacao.ToString();
            lblVelocidadeMaxima.Text = carro1.velocidade_maxima.ToString();
            lblQuantidadeMarchas.Text = carro1.quantidade_marchas.ToString();

            picUno.Visible = true;
            picMonza.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Criação do objeto Carro2, que é uma instancia da classe Carro
            //Preenchimento dos atributos de Carro2
            Carro carro2 = new Carro();
            carro2.modelo = "monza";
            carro2.marca = "chevrolet";
            carro2.cor = "vinho";
            carro2.motorizacao = "2.0";
            carro2.ano_fabricacao = 1989;
            carro2.velocidade_maxima = 240;
            carro2.quantidade_marchas = 5;

            //Preenchimento da ficha do carro
            lblModelo.Text = carro2.modelo;
            lblMarca.Text = carro2.marca;
            lblCor.Text = carro2.cor;
            lblMotorizacao.Text = carro2.motorizacao;
            lblAnoFabricacao.Text = carro2.ano_fabricacao.ToString();
            lblVelocidadeMaxima.Text = carro2.velocidade_maxima.ToString();
            lblQuantidadeMarchas.Text = carro2.quantidade_marchas.ToString();

            picUno.Visible = false;
            picMonza.Visible = true;
        }
    }
}
