using System;
using System.Drawing;
using System.Windows.Forms;
using clubNauticoProyecto.Controller;
using clubNauticoProyecto.Model;

namespace clubNauticoProyecto
{
    public partial class Vistas_Pais : Form
    {
        PaisController paisController = new PaisController();
        public Vistas_Pais()
        {
            InitializeComponent();
        }

        private void btn_agregar_pais_Click(object sender, EventArgs e)
        {
            if (txt_NomPais.Text != "")
            {
                paisController.Pais.NamePais = txt_NomPais.Text.Trim();
                if (paisController.insertPais().IdPais == -1)
                    MessageBox.Show("El pais " + paisController.Pais.NamePais + " ya se encuentra registrado");
                else
                {
                    MessageBox.Show("El pais " + paisController.Pais.NamePais + " se registro");
                    txt_NomPais.Text = "";
                    DGV_ListaPaises.DataSource = paisController.ListaPais;
                }
            }else
                MessageBox.Show("El campo no debe estar vacio.");

        }

        private void Vistas_Pais_Load(object sender, EventArgs e)
        {
            DGV_ListaPaises.DataSource = paisController.ListaPais;
        }

        private void buscarPais(object sender, EventArgs e)
        {
            DGV_ListaPaises.DataSource = paisController.busquedaPais(new Pais(txt_buscarPais.Text.ToString()));
        }

        private void accionesCelda(object sender, DataGridViewCellMouseEventArgs e)
        {
            grb_Acciones.Visible = true;
            groupBox1.Visible = false;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < DGV_ListaPaises.Rows.Count)
            {
                DataGridViewRow filaSeleccionada = DGV_ListaPaises.Rows[e.RowIndex];
                if (filaSeleccionada != null)
                {
                    // Obtén el valor de las celdas en la fila seleccionada
                    txt_editar_nombre_pais.Text= filaSeleccionada.Cells[1].Value?.ToString().Trim();
                    paisController.Pais.IdPais = Convert.ToInt32(filaSeleccionada.Cells[0].Value?.ToString());
                    paisController.Pais.NamePais = filaSeleccionada.Cells[1].Value?.ToString().Trim();
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar el registro seleccionado, con esto se eliminaran las ciudades que este tenga registrado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes && paisController.Pais.NamePais!="" && paisController.Pais.NamePais== txt_editar_nombre_pais.Text)
            {
                if (paisController.deletePais().IdPais==1)
                {
                    DGV_ListaPaises.DataSource = paisController.ListaPais;
                    MessageBox.Show(txt_editar_nombre_pais.Text.ToString() + " se elimino correctamente.");
                    txt_editar_nombre_pais.Text = "";
                }
                else
                {
                    MessageBox.Show(txt_editar_nombre_pais.Text.ToString() + " no se elimino.");
                }

            }
            else
            {
                MessageBox.Show(txt_editar_nombre_pais.Text.ToString() + " no se elimino.");
            }
            grb_Acciones.Visible = false;
            groupBox1.Visible = true;
            

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas modificar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            paisController.Pais.NamePais = txt_editar_nombre_pais.Text.ToString().Trim();
            if (resultado == DialogResult.Yes && paisController.Pais.NamePais != "")
            {
                if (paisController.updatePais().IdPais != -1)
                {
                    DGV_ListaPaises.DataSource = paisController.ListaPais;
                    MessageBox.Show(txt_editar_nombre_pais.Text.ToString() + " se modifico correctamente.");
                    txt_editar_nombre_pais.Text = "";
                }
                else
                {
                    MessageBox.Show(txt_editar_nombre_pais.Text.ToString() + " no se modifico.");
                }
            }
            else
            {
                MessageBox.Show(txt_editar_nombre_pais.Text.ToString() + " no se modifico.");
            }
            grb_Acciones.Visible = false;
            groupBox1.Visible = true;
        }

        private void btn_agregar_h_Click(object sender, EventArgs e)
        {
            grb_Acciones.Visible = false;
            groupBox1.Visible = true;
        }

        private void btn_volver_pais_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void restablecer_texto(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text == "Buscar...")
            {
                txtBox.Clear();
                txtBox.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
