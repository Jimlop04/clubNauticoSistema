using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clubNauticoProyecto.Controller;
using clubNauticoProyecto.Model;

namespace clubNauticoProyecto
{
    public partial class Vista_Ciudad : Form
    {
        CiudadController ciudadController;
        public Vista_Ciudad()
        {
            InitializeComponent();
        }

        private void Vista_Ciudad_Load(object sender, EventArgs e)
        {
            ciudadController = new CiudadController();
            DGV_ListaCiudades.DataSource = ciudadController.ListaCiudad;
            obtener_pais_seleccion();
        }
        private void obtener_pais_seleccion()
        {
            ciudadController = new CiudadController();
            ciudadController.llenarListaPais(cmb_pais, "PAIS", "IDPAIS", "registroPais");
            if (cmb_pais.Items.Count > 0)
            {
                cmb_pais.SelectedIndex = 0;
                ciudadController.Ciudad.Pais.NamePais = cmb_pais.GetItemText(cmb_pais.SelectedItem); // Obtener el valor del DisplayMember
                ciudadController.Ciudad.Pais.IdPais = Convert.ToInt32(cmb_pais.SelectedValue.ToString()); // Obtener el valor del ValueMember
            }
        }

        private void seleccionar_pais(object sender, EventArgs e)
        {
            ciudadController = new CiudadController();
            var seleccionado = cmb_pais.SelectedItem as DataRowView;
            if (seleccionado != null)
            {
                ciudadController.Ciudad.Pais.NamePais = seleccionado[cmb_pais.DisplayMember].ToString();
                ciudadController.Ciudad.Pais.IdPais = Convert.ToInt32(seleccionado[cmb_pais.ValueMember].ToString());
            }
        }

        private void btn_agregar_ciudad_Click(object sender, EventArgs e)
        {
            if (txt_NomCiudad.Text != "")
            {
                ciudadController.Ciudad.Name_ciudad = txt_NomCiudad.Text.ToString();
                if (ciudadController.insertCiudad().IdCiudad == -1)
                {
                    MessageBox.Show("La ciudad " + ciudadController.Ciudad.Name_ciudad + " ya se encuentra registrado");
                }
                else
                {
                    MessageBox.Show("La ciudad " + ciudadController.Ciudad.Name_ciudad + " se registro correctamente.");
                    ciudadController.Ciudad.Name_ciudad = " ";
                    DGV_ListaCiudades.DataSource = ciudadController.ListaCiudad;
                    obtener_pais_seleccion();
                    txt_NomCiudad.Text = "";
                }
            }
            else
                MessageBox.Show("El campo no debe estar vacio.");
        }

        private void seleccionar_ciudad_accion(object sender, DataGridViewCellMouseEventArgs e)
        {
            drp_acciones.Visible = true;
            groupBox1.Visible = false;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < DGV_ListaCiudades.Rows.Count)
            {
                DataGridViewRow filaSeleccionada = DGV_ListaCiudades.Rows[e.RowIndex];
                if (filaSeleccionada != null)
                {
                    ciudadController = new CiudadController();
                    txt_editar_ciudad.Text = filaSeleccionada.Cells[2].Value?.ToString().Trim();
                    ciudadController.Ciudad.IdCiudad = Convert.ToInt32(filaSeleccionada.Cells[0].Value?.ToString());
                    ciudadController.Ciudad.Name_ciudad = filaSeleccionada.Cells[2].Value?.ToString().Trim();
                    ciudadController.Ciudad.Pais.IdPais = Convert.ToInt32(filaSeleccionada.Cells[1].Value?.ToString());
                    ciudadController.llenarListaPaisID(cmb_edita_pais, "PAIS", "IDPAIS", "pais_ciudad");
                }
            }
        }

        private void btn_modifica_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas modificar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            ciudadController.Ciudad.Name_ciudad = txt_editar_ciudad.Text.ToString().Trim();
            if (resultado == DialogResult.Yes && ciudadController.Ciudad.Name_ciudad != "")
            {
                if (ciudadController.updateCiudad().IdCiudad != -1)
                {
                    ciudadController = new CiudadController();
                    DGV_ListaCiudades.DataSource = ciudadController.ListaCiudad;
                    MessageBox.Show(txt_editar_ciudad.Text.ToString() + " se modifico correctamente.");
                    obtener_pais_seleccion();
                    txt_editar_ciudad.Text = "";
                }
                else
                {
                    MessageBox.Show(txt_editar_ciudad.Text.ToString() + " no se modifico.");
                }
            }
            else
            {
                MessageBox.Show(txt_editar_ciudad.Text.ToString() + " no se modifico.");
            }
            drp_acciones.Visible = false;
            groupBox1.Visible = true;
        }

        private void cargar_lista_paises(object sender, MouseEventArgs e)
        {
            ciudadController.llenarListaPais(cmb_edita_pais, "PAIS", "IDPAIS", "registroPais");
        }

        private void editar_pais(object sender, EventArgs e)
        {
            var seleccionado = cmb_edita_pais.SelectedItem as DataRowView;
            if (seleccionado != null)
            {
                ciudadController.Ciudad.Pais.NamePais = seleccionado[cmb_edita_pais.DisplayMember].ToString();
                ciudadController.Ciudad.Pais.IdPais = Convert.ToInt32(seleccionado[cmb_edita_pais.ValueMember].ToString());
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes && ciudadController.Ciudad.Name_ciudad != "")
            {
                if (ciudadController.deleteCiudad().IdCiudad == 1)
                {
                    ciudadController = new CiudadController();
                    DGV_ListaCiudades.DataSource = ciudadController.ListaCiudad;
                    MessageBox.Show(txt_editar_ciudad.Text.ToString() + " se elimino correctamente.");
                    obtener_pais_seleccion();
                    txt_editar_ciudad.Text = "";
                }
                else
                {
                    MessageBox.Show(txt_editar_ciudad.Text.ToString() + " no se elimino.");
                }
            }
            else
            {
                MessageBox.Show(txt_editar_ciudad.Text.ToString() + " no se elimino.");
            }
            drp_acciones.Visible = false;
            groupBox1.Visible = true;
        }

        private void btn_volver_ciudad_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drp_acciones.Visible = false;
            groupBox1.Visible = true;
        }

        private void buscar_ciudad(object sender, EventArgs e)
        {
            DGV_ListaCiudades.DataSource = ciudadController.busquedaCiudad(new Ciudad(txt_buscarCiudad.Text.ToString()));
        }

        private void restablecer_campos(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text == "Buscar...")
            {
                txtBox.Clear();
                txtBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void buscar_pais(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                ciudadController.Ciudad.Pais.NamePais = e.KeyChar.ToString();
                ciudadController.llenarListaPais(cmb_pais, "PAIS", "IDPAIS", "registroPais");
            }
        }

    }
}
