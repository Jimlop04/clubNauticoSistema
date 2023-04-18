
namespace clubNauticoProyecto
{
    partial class Vista_Ciudad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_ListaCiudades = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_pais = new System.Windows.Forms.ComboBox();
            this.txt_NomCiudad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_agregar_ciudad = new System.Windows.Forms.Button();
            this.btn_volver_ciudad = new System.Windows.Forms.Button();
            this.txt_buscarCiudad = new System.Windows.Forms.TextBox();
            this.drp_acciones = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.cmb_edita_pais = new System.Windows.Forms.ComboBox();
            this.txt_editar_ciudad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_modifica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListaCiudades)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.drp_acciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "CIUDADES";
            // 
            // DGV_ListaCiudades
            // 
            this.DGV_ListaCiudades.AllowUserToAddRows = false;
            this.DGV_ListaCiudades.AllowUserToDeleteRows = false;
            this.DGV_ListaCiudades.AllowUserToResizeColumns = false;
            this.DGV_ListaCiudades.AllowUserToResizeRows = false;
            this.DGV_ListaCiudades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ListaCiudades.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ListaCiudades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_ListaCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ListaCiudades.Location = new System.Drawing.Point(12, 75);
            this.DGV_ListaCiudades.Name = "DGV_ListaCiudades";
            this.DGV_ListaCiudades.ReadOnly = true;
            this.DGV_ListaCiudades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_ListaCiudades.RowHeadersVisible = false;
            this.DGV_ListaCiudades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ListaCiudades.Size = new System.Drawing.Size(402, 219);
            this.DGV_ListaCiudades.TabIndex = 7;
            this.DGV_ListaCiudades.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.seleccionar_ciudad_accion);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.cmb_pais);
            this.groupBox1.Controls.Add(this.txt_NomCiudad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_agregar_ciudad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(431, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 143);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AGREGAR NUEVA CIUDAD";
            // 
            // cmb_pais
            // 
            this.cmb_pais.FormattingEnabled = true;
            this.cmb_pais.Location = new System.Drawing.Point(9, 77);
            this.cmb_pais.Name = "cmb_pais";
            this.cmb_pais.Size = new System.Drawing.Size(225, 23);
            this.cmb_pais.TabIndex = 10;
            this.cmb_pais.SelectionChangeCommitted += new System.EventHandler(this.seleccionar_pais);
            this.cmb_pais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscar_pais);
            // 
            // txt_NomCiudad
            // 
            this.txt_NomCiudad.Location = new System.Drawing.Point(9, 50);
            this.txt_NomCiudad.Name = "txt_NomCiudad";
            this.txt_NomCiudad.Size = new System.Drawing.Size(225, 21);
            this.txt_NomCiudad.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "NOMBRE CIUDAD :";
            // 
            // btn_agregar_ciudad
            // 
            this.btn_agregar_ciudad.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregar_ciudad.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_agregar_ciudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_ciudad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_agregar_ciudad.Location = new System.Drawing.Point(60, 106);
            this.btn_agregar_ciudad.Name = "btn_agregar_ciudad";
            this.btn_agregar_ciudad.Size = new System.Drawing.Size(114, 26);
            this.btn_agregar_ciudad.TabIndex = 4;
            this.btn_agregar_ciudad.Text = "AGREGAR";
            this.btn_agregar_ciudad.UseVisualStyleBackColor = false;
            this.btn_agregar_ciudad.Click += new System.EventHandler(this.btn_agregar_ciudad_Click);
            // 
            // btn_volver_ciudad
            // 
            this.btn_volver_ciudad.BackColor = System.Drawing.Color.Transparent;
            this.btn_volver_ciudad.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btn_volver_ciudad.FlatAppearance.BorderSize = 2;
            this.btn_volver_ciudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver_ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver_ciudad.Location = new System.Drawing.Point(587, 267);
            this.btn_volver_ciudad.Name = "btn_volver_ciudad";
            this.btn_volver_ciudad.Size = new System.Drawing.Size(84, 27);
            this.btn_volver_ciudad.TabIndex = 12;
            this.btn_volver_ciudad.Text = "VOLVER";
            this.btn_volver_ciudad.UseVisualStyleBackColor = false;
            this.btn_volver_ciudad.Click += new System.EventHandler(this.btn_volver_ciudad_Click);
            // 
            // txt_buscarCiudad
            // 
            this.txt_buscarCiudad.Location = new System.Drawing.Point(12, 49);
            this.txt_buscarCiudad.Name = "txt_buscarCiudad";
            this.txt_buscarCiudad.Size = new System.Drawing.Size(402, 20);
            this.txt_buscarCiudad.TabIndex = 14;
            this.txt_buscarCiudad.Text = "Buscar...";
            this.txt_buscarCiudad.Click += new System.EventHandler(this.restablecer_campos);
            this.txt_buscarCiudad.TextChanged += new System.EventHandler(this.buscar_ciudad);
            // 
            // drp_acciones
            // 
            this.drp_acciones.BackColor = System.Drawing.Color.LightBlue;
            this.drp_acciones.Controls.Add(this.button1);
            this.drp_acciones.Controls.Add(this.btn_eliminar);
            this.drp_acciones.Controls.Add(this.cmb_edita_pais);
            this.drp_acciones.Controls.Add(this.txt_editar_ciudad);
            this.drp_acciones.Controls.Add(this.label2);
            this.drp_acciones.Controls.Add(this.btn_modifica);
            this.drp_acciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drp_acciones.Location = new System.Drawing.Point(431, 75);
            this.drp_acciones.Name = "drp_acciones";
            this.drp_acciones.Size = new System.Drawing.Size(240, 143);
            this.drp_acciones.TabIndex = 15;
            this.drp_acciones.TabStop = false;
            this.drp_acciones.Text = "ACCIONES CIUDAD";
            this.drp_acciones.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(192, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_eliminar.Location = new System.Drawing.Point(99, 106);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(87, 26);
            this.btn_eliminar.TabIndex = 11;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // cmb_edita_pais
            // 
            this.cmb_edita_pais.FormattingEnabled = true;
            this.cmb_edita_pais.Location = new System.Drawing.Point(9, 77);
            this.cmb_edita_pais.Name = "cmb_edita_pais";
            this.cmb_edita_pais.Size = new System.Drawing.Size(225, 23);
            this.cmb_edita_pais.TabIndex = 10;
            this.cmb_edita_pais.SelectionChangeCommitted += new System.EventHandler(this.editar_pais);
            this.cmb_edita_pais.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cargar_lista_paises);
            // 
            // txt_editar_ciudad
            // 
            this.txt_editar_ciudad.Location = new System.Drawing.Point(9, 50);
            this.txt_editar_ciudad.Name = "txt_editar_ciudad";
            this.txt_editar_ciudad.Size = new System.Drawing.Size(225, 21);
            this.txt_editar_ciudad.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "NOMBRE CIUDAD :";
            // 
            // btn_modifica
            // 
            this.btn_modifica.BackColor = System.Drawing.Color.Transparent;
            this.btn_modifica.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_modifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_modifica.Location = new System.Drawing.Point(6, 106);
            this.btn_modifica.Name = "btn_modifica";
            this.btn_modifica.Size = new System.Drawing.Size(87, 26);
            this.btn_modifica.TabIndex = 4;
            this.btn_modifica.Text = "MODIFICAR";
            this.btn_modifica.UseVisualStyleBackColor = false;
            this.btn_modifica.Click += new System.EventHandler(this.btn_modifica_Click);
            // 
            // Vista_Ciudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(683, 306);
            this.Controls.Add(this.drp_acciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_buscarCiudad);
            this.Controls.Add(this.btn_volver_ciudad);
            this.Controls.Add(this.DGV_ListaCiudades);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Vista_Ciudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista_Ciudad";
            this.Load += new System.EventHandler(this.Vista_Ciudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListaCiudades)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.drp_acciones.ResumeLayout(false);
            this.drp_acciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_ListaCiudades;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_NomCiudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_agregar_ciudad;
        private System.Windows.Forms.Button btn_volver_ciudad;
        private System.Windows.Forms.TextBox txt_buscarCiudad;
        private System.Windows.Forms.ComboBox cmb_pais;
        private System.Windows.Forms.GroupBox drp_acciones;
        private System.Windows.Forms.ComboBox cmb_edita_pais;
        private System.Windows.Forms.TextBox txt_editar_ciudad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_modifica;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button button1;
    }
}