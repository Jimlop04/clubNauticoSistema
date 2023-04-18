
using System;
using System.Windows.Forms;

namespace clubNauticoProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_Pais_Click(object sender, EventArgs e)
        {
            Vistas_Pais vistas_Pais = new Vistas_Pais();
            vistas_Pais.Show();
            this.Hide();
        }

        private void btn_Ciudad_Click(object sender, EventArgs e)
        {
            Vista_Ciudad vistas_ciudad = new Vista_Ciudad();
            vistas_ciudad.Show();
            this.Hide();
        }

        private void btn_Puerto_Click(object sender, EventArgs e)
        {
            Vista_Puerto vista_Puerto = new Vista_Puerto();
            vista_Puerto.Show();
            this.Hide();
        }
    }
}
