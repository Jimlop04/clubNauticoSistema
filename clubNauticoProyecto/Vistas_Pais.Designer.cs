
namespace clubNauticoProyecto
{
    partial class Vistas_Pais
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_agregar_pais = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_ListaPaises = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_NomPais = new System.Windows.Forms.TextBox();
            this.grb_Acciones = new System.Windows.Forms.GroupBox();
            this.btn_agregar_h = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txt_editar_nombre_pais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_volver_pais = new System.Windows.Forms.Button();
            this.txt_buscarPais = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListaPaises)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grb_Acciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_agregar_pais
            // 
            this.btn_agregar_pais.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregar_pais.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_agregar_pais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_pais.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_agregar_pais.Location = new System.Drawing.Point(63, 87);
            this.btn_agregar_pais.Name = "btn_agregar_pais";
            this.btn_agregar_pais.Size = new System.Drawing.Size(114, 26);
            this.btn_agregar_pais.TabIndex = 4;
            this.btn_agregar_pais.Text = "AGREGAR";
            this.btn_agregar_pais.UseVisualStyleBackColor = false;
            this.btn_agregar_pais.Click += new System.EventHandler(this.btn_agregar_pais_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "PAISES";
            // 
            // DGV_ListaPaises
            // 
            this.DGV_ListaPaises.AllowUserToAddRows = false;
            this.DGV_ListaPaises.AllowUserToDeleteRows = false;
            this.DGV_ListaPaises.AllowUserToResizeColumns = false;
            this.DGV_ListaPaises.AllowUserToResizeRows = false;
            this.DGV_ListaPaises.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_ListaPaises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ListaPaises.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ListaPaises.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_ListaPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ListaPaises.Location = new System.Drawing.Point(12, 83);
            this.DGV_ListaPaises.MultiSelect = false;
            this.DGV_ListaPaises.Name = "DGV_ListaPaises";
            this.DGV_ListaPaises.ReadOnly = true;
            this.DGV_ListaPaises.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_ListaPaises.RowHeadersVisible = false;
            this.DGV_ListaPaises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ListaPaises.Size = new System.Drawing.Size(413, 211);
            this.DGV_ListaPaises.TabIndex = 6;
            this.DGV_ListaPaises.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.accionesCelda);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "NOMBRE PAIS :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.txt_NomPais);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_agregar_pais);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(431, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 129);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AGREGAR NUEVO PAIS";
            // 
            // txt_NomPais
            // 
            this.txt_NomPais.Location = new System.Drawing.Point(9, 50);
            this.txt_NomPais.Name = "txt_NomPais";
            this.txt_NomPais.Size = new System.Drawing.Size(225, 21);
            this.txt_NomPais.TabIndex = 9;
            // 
            // grb_Acciones
            // 
            this.grb_Acciones.BackColor = System.Drawing.Color.LightBlue;
            this.grb_Acciones.Controls.Add(this.btn_agregar_h);
            this.grb_Acciones.Controls.Add(this.btn_eliminar);
            this.grb_Acciones.Controls.Add(this.txt_editar_nombre_pais);
            this.grb_Acciones.Controls.Add(this.label2);
            this.grb_Acciones.Controls.Add(this.btn_modificar);
            this.grb_Acciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Acciones.Location = new System.Drawing.Point(431, 71);
            this.grb_Acciones.Name = "grb_Acciones";
            this.grb_Acciones.Size = new System.Drawing.Size(240, 129);
            this.grb_Acciones.TabIndex = 13;
            this.grb_Acciones.TabStop = false;
            this.grb_Acciones.Text = "ACCIONES PAIS";
            this.grb_Acciones.Visible = false;
            // 
            // btn_agregar_h
            // 
            this.btn_agregar_h.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregar_h.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_agregar_h.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_h.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_agregar_h.Location = new System.Drawing.Point(207, 87);
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
            this.btn_eliminar.Location = new System.Drawing.Point(108, 87);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(93, 26);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_editar_nombre_pais
            // 
            this.txt_editar_nombre_pais.Location = new System.Drawing.Point(9, 50);
            this.txt_editar_nombre_pais.Name = "txt_editar_nombre_pais";
            this.txt_editar_nombre_pais.Size = new System.Drawing.Size(225, 21);
            this.txt_editar_nombre_pais.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "NOMBRE PAIS :";
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.Transparent;
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_modificar.Location = new System.Drawing.Point(9, 87);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(93, 26);
            this.btn_modificar.TabIndex = 4;
            this.btn_modificar.Text = "MODIFICAR";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_volver_pais
            // 
            this.btn_volver_pais.BackColor = System.Drawing.Color.Transparent;
            this.btn_volver_pais.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btn_volver_pais.FlatAppearance.BorderSize = 2;
            this.btn_volver_pais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver_pais.Location = new System.Drawing.Point(587, 267);
            this.btn_volver_pais.Name = "btn_volver_pais";
            this.btn_volver_pais.Size = new System.Drawing.Size(84, 27);
            this.btn_volver_pais.TabIndex = 10;
            this.btn_volver_pais.Text = "VOLVER";
            this.btn_volver_pais.UseVisualStyleBackColor = false;
            this.btn_volver_pais.Click += new System.EventHandler(this.btn_volver_pais_Click);
            // 
            // txt_buscarPais
            // 
            this.txt_buscarPais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscarPais.Location = new System.Drawing.Point(12, 52);
            this.txt_buscarPais.Name = "txt_buscarPais";
            this.txt_buscarPais.Size = new System.Drawing.Size(413, 20);
            this.txt_buscarPais.TabIndex = 12;
            this.txt_buscarPais.Text = "Buscar...";
            this.txt_buscarPais.Click += new System.EventHandler(this.restablecer_texto);
            this.txt_buscarPais.TextChanged += new System.EventHandler(this.buscarPais);
            // 
            // Vistas_Pais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(683, 306);
            this.Controls.Add(this.grb_Acciones);
            this.Controls.Add(this.txt_buscarPais);
            this.Controls.Add(this.btn_volver_pais);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV_ListaPaises);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Vistas_Pais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista_Pais";
            this.Load += new System.EventHandler(this.Vistas_Pais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListaPaises)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grb_Acciones.ResumeLayout(false);
            this.grb_Acciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar_pais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_ListaPaises;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_NomPais;
        private System.Windows.Forms.Button btn_volver_pais;
        private System.Windows.Forms.TextBox txt_buscarPais;
        private System.Windows.Forms.GroupBox grb_Acciones;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txt_editar_nombre_pais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_agregar_h;
    }
}