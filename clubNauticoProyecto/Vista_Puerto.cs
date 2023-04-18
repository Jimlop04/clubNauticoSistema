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
    public partial class Vista_Puerto : Form
    {
        PuertoController puertoController;
        CiudadController ciudadController;
        public Vista_Puerto()
        {
            InitializeComponent();
        }

        private void Vista_Puerto_Load(object sender, EventArgs e)
        {
            puertoController = new PuertoController();
            DGV_ListaPuertos.DataSource = puertoController.ListaPuerto;
            obtener_pais_seleccion_puerto();
        }

        private void lista_ciudades_pais(object sender, EventArgs e)
        {
            var seleccionado = cmb_pais.SelectedItem as DataRowView;
            if (seleccionado != null)
            {
                puertoController.Puerto_Destino.Ciudad.Pais.NamePais = seleccionado[cmb_pais.DisplayMember].ToString();
                puertoController.Puerto_Destino.Ciudad.Pais.IdPais = Convert.ToInt32(seleccionado[cmb_pais.ValueMember].ToString());
            }
            puertoController.llenarListaCiudad(cmb_ListaCiudades, "CIUDAD", "IDCIUDAD", "registro_ciudad_pais");
        }

        private void seleccionar_ciudad_destino(object sender, EventArgs e)
        {
            var seleccionado = cmb_ListaCiudades.SelectedItem as DataRowView;
            if (seleccionado != null)
            {
                puertoController.Puerto_Destino.Ciudad.Name_ciudad = seleccionado[cmb_ListaCiudades.DisplayMember].ToString();
                puertoController.Puerto_Destino.Ciudad.IdCiudad = Convert.ToInt32(seleccionado[cmb_ListaCiudades.ValueMember].ToString());
            }
        }

        private void btn_agregar_Puerto_Click(object sender, EventArgs e)
        {
            if (txt_NomPuerto.Text!=""&& puertoController.Puerto_Destino.Ciudad.Name_ciudad!=""&& 
                puertoController.Puerto_Destino.Ciudad.IdCiudad>0)
            {
                puertoController.Puerto_Destino.NombrePuerto = txt_NomPuerto.Text.ToString();
                if (puertoController.insertPuerto().IdPuerto==-1)
                {
                    MessageBox.Show("El Puerto " + puertoController.Puerto_Destino.NombrePuerto + " ya se encuentra registrado");
                }
                else
                {
                    MessageBox.Show("El Puerto " + puertoController.Puerto_Destino.NombrePuerto + " se registro correctamente.");
                    puertoController = new PuertoController();
                    puertoController.Puerto_Destino.NombrePuerto = " ";
                    DGV_ListaPuertos.DataSource = puertoController.ListaPuerto;
                    obtener_pais_seleccion_puerto();
                    txt_NomPuerto.Text = "";
                  
                }
            }
            else
            {
                MessageBox.Show("El campo no debe estar vacio.");
            }               

        }

        private void obtener_datos_puerto(object sender, DataGridViewCellMouseEventArgs e)
        {
            grb_AccionesPuerto.Visible = true;
            groupBoxPuerto.Visible = false;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < DGV_ListaPuertos.Rows.Count)
            {
                DataGridViewRow filaSeleccionada = DGV_ListaPuertos.Rows[e.RowIndex];
                if (filaSeleccionada != null)
                {
                    puertoController = new PuertoController();
                    txt_editar_nombre_puerto.Text = filaSeleccionada.Cells[2].Value?.ToString().Trim();
                    puertoController.Puerto_Destino.Ciudad.IdCiudad = Convert.ToInt32(filaSeleccionada.Cells[1].Value?.ToString());
                    puertoController.Puerto_Destino.IdPuerto = Convert.ToInt32(filaSeleccionada.Cells[0].Value?.ToString());
                    puertoController.Puerto_Destino.NombrePuerto = filaSeleccionada.Cells[2].Value?.ToString().Trim();
                    puertoController.llenarListaCiudadID(cmb_edit_ciudad, "CIUDAD", "IDCIUDAD", "ciudad_puerto");
                    puertoController.llenarListaPaisID(cmb_edit_pais, "PAIS", "IDPAIS", "pais_puerto");
                }
            }
        }

        private void btn_volver_puerto_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void listar_paises(object sender, MouseEventArgs e)
        {
            puertoController.Puerto_Destino.Ciudad.Pais.NamePais = " ";
            puertoController.llenarListaPais(cmb_edit_pais, "PAIS", "IDPAIS", "registroPais");
        }

        private void listar_ciudad(object sender, MouseEventArgs e)
        {

        }

        private void selection_edit_pais(object sender, EventArgs e)
        {
            var seleccionado = cmb_edit_pais.SelectedItem as DataRowView;
            if (seleccionado != null)
            {
                puertoController.Puerto_Destino.Ciudad.Pais.NamePais = seleccionado[cmb_edit_pais.DisplayMember].ToString();
                puertoController.Puerto_Destino.Ciudad.Pais.IdPais = Convert.ToInt32(seleccionado[cmb_edit_pais.ValueMember].ToString());
            }
            puertoController.llenarListaCiudad(cmb_edit_ciudad, "CIUDAD", "IDCIUDAD", "registro_ciudad_pais");
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas modificar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            puertoController.Puerto_Destino.NombrePuerto = txt_editar_nombre_puerto.Text.ToString().Trim();
            if (resultado == DialogResult.Yes && puertoController.Puerto_Destino.NombrePuerto != "")
            {
                if (puertoController.updatePuerto().IdPuerto != -1)
                {
                    puertoController = new PuertoController();
                    DGV_ListaPuertos.DataSource = puertoController.ListaPuerto;
                    MessageBox.Show(txt_editar_nombre_puerto.Text.ToString() + " se modifico correctamente.");
                    txt_editar_nombre_puerto.Text = "";
                }
                else
                {
                    MessageBox.Show(txt_editar_nombre_puerto.Text.ToString() + " no se modifico.");
                }
            }
            else
            {
                MessageBox.Show(txt_editar_nombre_puerto.Text.ToString() + " no se modifico.");
            }
            grb_AccionesPuerto.Visible = false;
            groupBoxPuerto.Visible = true;
        }

        private void list_ciudad_pais(object sender, EventArgs e)
        {
            var seleccionado = cmb_edit_ciudad.SelectedItem as DataRowView;
            if (seleccionado != null)
            {
                puertoController.Puerto_Destino.Ciudad.Name_ciudad = seleccionado[cmb_edit_ciudad.DisplayMember].ToString();
                puertoController.Puerto_Destino.Ciudad.IdCiudad = Convert.ToInt32(seleccionado[cmb_edit_ciudad.ValueMember].ToString());
            }
        }

        private void btn_agregar_h_Click(object sender, EventArgs e)
        {
            grb_AccionesPuerto.Visible = false;
            groupBoxPuerto.Visible = true;
        }

        private void obtener_pais_seleccion_puerto()
        {
            puertoController = new PuertoController();
            puertoController.llenarListaPais(cmb_pais, "PAIS", "IDPAIS", "registroPais");
            if (cmb_pais.Items.Count > 0)
            {
                cmb_pais.SelectedIndex = 0;
                puertoController.Puerto_Destino.Ciudad.Pais.NamePais = cmb_pais.GetItemText(cmb_pais.SelectedItem); // Obtener el valor del DisplayMember
                puertoController.Puerto_Destino.Ciudad.Pais.IdPais = Convert.ToInt32(cmb_pais.SelectedValue.ToString()); // Obtener el valor del ValueMember
            }
        }

        private void obtener_ciudad_seleccion_puerto()
        {
            puertoController = new PuertoController();
            puertoController.llenarListaCiudad(cmb_ListaCiudades, "CIUDAD", "IDCIUDAD", "registroCiudad");
            if (cmb_ListaCiudades.Items.Count > 0)
            {
                cmb_ListaCiudades.SelectedIndex = 0;
                puertoController.Puerto_Destino.Ciudad.Name_ciudad = cmb_ListaCiudades.GetItemText(cmb_ListaCiudades.SelectedItem); // Obtener el valor del DisplayMember
                puertoController.Puerto_Destino.Ciudad.IdCiudad = Convert.ToInt32(cmb_ListaCiudades.SelectedValue.ToString()); // Obtener el valor del ValueMember
            }
        }


        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes && puertoController.Puerto_Destino.NombrePuerto != "")
            {
                if (puertoController.deletePuerto().IdPuerto == 1)
                {
                    puertoController = new PuertoController();
                    ciudadController = new CiudadController();
                    DGV_ListaPuertos.DataSource = puertoController.ListaPuerto;
                    MessageBox.Show(txt_editar_nombre_puerto.Text.ToString() + " se elimino correctamente.");
                    obtener_pais_seleccion_puerto();
                    txt_editar_nombre_puerto.Text = "";
                }
                else
                {
                    MessageBox.Show(txt_editar_nombre_puerto.Text.ToString() + " no se elimino.");
                }
            }
            else
            {
                MessageBox.Show(txt_editar_nombre_puerto.Text.ToString() + " no se elimino.");
            }
            grb_AccionesPuerto.Visible = false;
            groupBoxPuerto.Visible = true;
        }

        private void txt_buscarPuerto_TextChanged(object sender, EventArgs e)
        {
            DGV_ListaPuertos.DataSource = puertoController.busquedaPuerto(new Puerto_Destino(txt_buscarPuerto.Text.ToString()));
        }
    }
}
