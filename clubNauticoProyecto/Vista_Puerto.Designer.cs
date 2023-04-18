
namespace clubNauticoProyecto
{
    partial class Vista_Puerto
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
            this.DGV_ListaPuertos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPuerto = new System.Windows.Forms.GroupBox();
            this.cmb_ListaCiudades = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_pais = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NomPuerto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_agregar_Puerto = new System.Windows.Forms.Button();
            this.grb_AccionesPuerto = new System.Windows.Forms.GroupBox();
            this.cmb_edit_ciudad = new System.Windows.Forms.ComboBox();
            this.cmb_edit_pais = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_agregar_h = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txt_editar_nombre_puerto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_volver_puerto = new System.Windows.Forms.Button();
            this.txt_buscarPuerto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListaPuertos)).BeginInit();
            this.groupBoxPuerto.SuspendLayout();
            this.grb_AccionesPuerto.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_ListaPuertos
            // 
            this.DGV_ListaPuertos.AllowUserToAddRows = false;
            this.DGV_ListaPuertos.AllowUserToDeleteRows = false;
            this.DGV_ListaPuertos.AllowUserToResizeColumns = false;
            this.DGV_ListaPuertos.AllowUserToResizeRows = false;
            this.DGV_ListaPuertos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ListaPuertos.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ListaPuertos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_ListaPuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ListaPuertos.Location = new System.Drawing.Point(12, 79);
            this.DGV_ListaPuertos.Name = "DGV_ListaPuertos";
            this.DGV_ListaPuertos.ReadOnly = true;
            this.DGV_ListaPuertos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_ListaPuertos.RowHeadersVisible = false;
            this.DGV_ListaPuertos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ListaPuertos.Size = new System.Drawing.Size(388, 217);
            this.DGV_ListaPuertos.TabIndex = 7;
            this.DGV_ListaPuertos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.obtener_datos_puerto);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "PUERTO DESTINO";
            // 
            // groupBoxPuerto
            // 
            this.groupBoxPuerto.BackColor = System.Drawing.Color.LightBlue;
            this.groupBoxPuerto.Controls.Add(this.cmb_ListaCiudades);
            this.groupBoxPuerto.Controls.Add(this.label4);
            this.groupBoxPuerto.Controls.Add(this.cmb_pais);
            this.groupBoxPuerto.Controls.Add(this.label2);
            this.groupBoxPuerto.Controls.Add(this.txt_NomPuerto);
            this.groupBoxPuerto.Controls.Add(this.label3);
            this.groupBoxPuerto.Controls.Add(this.btn_agregar_Puerto);
            this.groupBoxPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPuerto.Location = new System.Drawing.Point(417, 47);
            this.groupBoxPuerto.Name = "groupBoxPuerto";
            this.groupBoxPuerto.Size = new System.Drawing.Size(255, 217);
            this.groupBoxPuerto.TabIndex = 10;
            this.groupBoxPuerto.TabStop = false;
            this.groupBoxPuerto.Text = "AGREGAR NUEVO PUERTO";
            // 
            // cmb_ListaCiudades
            // 
            this.cmb_ListaCiudades.FormattingEnabled = true;
            this.cmb_ListaCiudades.Location = new System.Drawing.Point(9, 136);
            this.cmb_ListaCiudades.Name = "cmb_ListaCiudades";
            this.cmb_ListaCiudades.Size = new System.Drawing.Size(240, 23);
            this.cmb_ListaCiudades.TabIndex = 13;
            this.cmb_ListaCiudades.SelectionChangeCommitted += new System.EventHandler(this.seleccionar_ciudad_destino);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "ELEGIR CIUDAD :";
            // 
            // cmb_pais
            // 
            this.cmb_pais.FormattingEnabled = true;
            this.cmb_pais.Location = new System.Drawing.Point(9, 92);
            this.cmb_pais.Name = "cmb_pais";
            this.cmb_pais.Size = new System.Drawing.Size(240, 23);
            this.cmb_pais.TabIndex = 11;
            this.cmb_pais.SelectionChangeCommitted += new System.EventHandler(this.lista_ciudades_pais);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "ELEGIR PAIS :";
            // 
            // txt_NomPuerto
            // 
            this.txt_NomPuerto.Location = new System.Drawing.Point(9, 50);
            this.txt_NomPuerto.Name = "txt_NomPuerto";
            this.txt_NomPuerto.Size = new System.Drawing.Size(240, 21);
            this.txt_NomPuerto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "NOMBRE PUERTO :";
            // 
            // btn_agregar_Puerto
            // 
            this.btn_agregar_Puerto.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregar_Puerto.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_agregar_Puerto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_Puerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_Puerto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_agregar_Puerto.Location = new System.Drawing.Point(72, 177);
            this.btn_agregar_Puerto.Name = "btn_agregar_Puerto";
            this.btn_agregar_Puerto.Size = new System.Drawing.Size(114, 26);
            this.btn_agregar_Puerto.TabIndex = 4;
            this.btn_agregar_Puerto.Text = "AGREGAR";
            this.btn_agregar_Puerto.UseVisualStyleBackColor = false;
            this.btn_agregar_Puerto.Click += new System.EventHandler(this.btn_agregar_Puerto_Click);
            // 
            // grb_AccionesPuerto
            // 
            this.grb_AccionesPuerto.BackColor = System.Drawing.Color.LightBlue;
            this.grb_AccionesPuerto.Controls.Add(this.cmb_edit_ciudad);
            this.grb_AccionesPuerto.Controls.Add(this.cmb_edit_pais);
            this.grb_AccionesPuerto.Controls.Add(this.label7);
            this.grb_AccionesPuerto.Controls.Add(this.label6);
            this.grb_AccionesPuerto.Controls.Add(this.btn_agregar_h);
            this.grb_AccionesPuerto.Controls.Add(this.btn_eliminar);
            this.grb_AccionesPuerto.Controls.Add(this.txt_editar_nombre_puerto);
            this.grb_AccionesPuerto.Controls.Add(this.label5);
            this.grb_AccionesPuerto.Controls.Add(this.btn_modificar);
            this.grb_AccionesPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_AccionesPuerto.Location = new System.Drawing.Point(417, 78);
            this.grb_AccionesPuerto.Name = "grb_AccionesPuerto";
            this.grb_AccionesPuerto.Size = new System.Drawing.Size(255, 229);
            this.grb_AccionesPuerto.TabIndex = 14;
            this.grb_AccionesPuerto.TabStop = false;
            this.grb_AccionesPuerto.Text = "ACCIONES PUERTO";
            this.grb_AccionesPuerto.Visible = false;
            // 
            // cmb_edit_ciudad
            // 
            this.cmb_edit_ciudad.FormattingEnabled = true;
            this.cmb_edit_ciudad.Location = new System.Drawing.Point(6, 134);
            this.cmb_edit_ciudad.Name = "cmb_edit_ciudad";
            this.cmb_edit_ciudad.Size = new System.Drawing.Size(243, 23);
            this.cmb_edit_ciudad.TabIndex = 16;
            this.cmb_edit_ciudad.SelectionChangeCommitted += new System.EventHandler(this.list_ciudad_pais);
            this.cmb_edit_ciudad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listar_ciudad);
            // 
            // cmb_edit_pais
            // 
            this.cmb_edit_pais.FormattingEnabled = true;
            this.cmb_edit_pais.Location = new System.Drawing.Point(6, 90);
            this.cmb_edit_pais.Name = "cmb_edit_pais";
            this.cmb_edit_pais.Size = new System.Drawing.Size(243, 23);
            this.cmb_edit_pais.TabIndex = 15;
            this.cmb_edit_pais.SelectionChangeCommitted += new System.EventHandler(this.selection_edit_pais);
            this.cmb_edit_pais.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listar_paises);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "NOMBRE CIUDAD :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "NOMBRE PAIS :";
            // 
            // btn_agregar_h
            // 
            this.btn_agregar_h.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregar_h.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_agregar_h.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_h.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_agregar_h.Location = new System.Drawing.Point(210, 176);
            this.btn_agregar_h.Name = "btn_agregar_h";
            this.btn_agregar_h.Size = new System.Drawing.Size(27, 26);
            this.btn_agregar_h.TabIndex = 11;
            this.btn_agregar_h.Text = "+";
            this.btn_agregar_h.UseVisualStyleBackColor = false;
            this.btn_agregar_h.Click += new System.EventHandler(this.btn_agregar_h_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_eliminar.Location = new System.Drawing.Point(111, 176);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(93, 26);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_editar_nombre_puerto
            // 
            this.txt_editar_nombre_puerto.Location = new System.Drawing.Point(9, 50);
            this.txt_editar_nombre_puerto.Name = "txt_editar_nombre_puerto";
            this.txt_editar_nombre_puerto.Size = new System.Drawing.Size(240, 21);
            this.txt_editar_nombre_puerto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "NOMBRE PUERTO :";
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.Transparent;
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_modificar.Location = new System.Drawing.Point(12, 176);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(93, 26);
            this.btn_modificar.TabIndex = 4;
            this.btn_modificar.Text = "MODIFICAR";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_volver_puerto
            // 
            this.btn_volver_puerto.BackColor = System.Drawing.Color.Transparent;
            this.btn_volver_puerto.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btn_volver_puerto.FlatAppearance.BorderSize = 2;
            this.btn_volver_puerto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver_puerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver_puerto.Location = new System.Drawing.Point(587, 313);
            this.btn_volver_puerto.Name = "btn_volver_puerto";
            this.btn_volver_puerto.Size = new System.Drawing.Size(84, 27);
            this.btn_volver_puerto.TabIndex = 13;
            this.btn_volver_puerto.Text = "VOLVER";
            this.btn_volver_puerto.UseVisualStyleBackColor = false;
            this.btn_volver_puerto.Click += new System.EventHandler(this.btn_volver_puerto_Click);
            // 
            // txt_buscarPuerto
            // 
            this.txt_buscarPuerto.Location = new System.Drawing.Point(12, 48);
            this.txt_buscarPuerto.Name = "txt_buscarPuerto";
            this.txt_buscarPuerto.Size = new System.Drawing.Size(388, 20);
            this.txt_buscarPuerto.TabIndex = 15;
            this.txt_buscarPuerto.TextChanged += new System.EventHandler(this.txt_buscarPuerto_TextChanged);
            // 
            // Vista_Puerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(683, 361);
            this.Controls.Add(this.grb_AccionesPuerto);
            this.Controls.Add(this.groupBoxPuerto);
            this.Controls.Add(this.txt_buscarPuerto);
            this.Controls.Add(this.btn_volver_puerto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_ListaPuertos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Vista_Puerto";
            this.Text = "Vista_Puerto";
            this.Load += new System.EventHandler(this.Vista_Puerto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListaPuertos)).EndInit();
            this.groupBoxPuerto.ResumeLayout(false);
            this.groupBoxPuerto.PerformLayout();
            this.grb_AccionesPuerto.ResumeLayout(false);
            this.grb_AccionesPuerto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_ListaPuertos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPuerto;
        private System.Windows.Forms.TextBox txt_NomPuerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_agregar_Puerto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_pais;
        private System.Windows.Forms.ComboBox cmb_ListaCiudades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_volver_puerto;
        private System.Windows.Forms.TextBox txt_buscarPuerto;
        private System.Windows.Forms.GroupBox grb_AccionesPuerto;
        private System.Windows.Forms.Button btn_agregar_h;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txt_editar_nombre_puerto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_edit_pais;
        private System.Windows.Forms.ComboBox cmb_edit_ciudad;
    }
}