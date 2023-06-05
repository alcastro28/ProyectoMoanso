namespace CapaPresentación
{
    partial class MantenedorReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorReserva));
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.btn_cancelar_clienteM = new System.Windows.Forms.Button();
            this.btn_editar_clienteM = new System.Windows.Forms.Button();
            this.btn_agregar_clienteM = new System.Windows.Forms.Button();
            this.btn_mostrar_clienteM = new System.Windows.Forms.Button();
            this.btn_nuevo_clienteM = new System.Windows.Forms.Button();
            this.txtIDreserva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIDProducto = new System.Windows.Forms.ComboBox();
            this.cmbIDcliente = new System.Windows.Forms.ComboBox();
            this.cbkEstadoReserva = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(560, 303);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(236, 20);
            this.dtFecha.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "ID cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "ID producto";
            // 
            // dgvReserva
            // 
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.Location = new System.Drawing.Point(186, 510);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.Size = new System.Drawing.Size(687, 150);
            this.dgvReserva.TabIndex = 52;
            // 
            // btn_cancelar_clienteM
            // 
            this.btn_cancelar_clienteM.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_cancelar_clienteM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar_clienteM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancelar_clienteM.Location = new System.Drawing.Point(38, 638);
            this.btn_cancelar_clienteM.Name = "btn_cancelar_clienteM";
            this.btn_cancelar_clienteM.Size = new System.Drawing.Size(94, 34);
            this.btn_cancelar_clienteM.TabIndex = 51;
            this.btn_cancelar_clienteM.Text = "Cancelar";
            this.btn_cancelar_clienteM.UseVisualStyleBackColor = false;
            this.btn_cancelar_clienteM.Click += new System.EventHandler(this.btn_cancelar_clienteM_Click);
            // 
            // btn_editar_clienteM
            // 
            this.btn_editar_clienteM.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_editar_clienteM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_clienteM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_editar_clienteM.Location = new System.Drawing.Point(38, 548);
            this.btn_editar_clienteM.Name = "btn_editar_clienteM";
            this.btn_editar_clienteM.Size = new System.Drawing.Size(100, 34);
            this.btn_editar_clienteM.TabIndex = 50;
            this.btn_editar_clienteM.Text = "Editar";
            this.btn_editar_clienteM.UseVisualStyleBackColor = false;
            this.btn_editar_clienteM.Click += new System.EventHandler(this.btn_editar_clienteM_Click);
            // 
            // btn_agregar_clienteM
            // 
            this.btn_agregar_clienteM.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregar_clienteM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_clienteM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_agregar_clienteM.Location = new System.Drawing.Point(46, 495);
            this.btn_agregar_clienteM.Name = "btn_agregar_clienteM";
            this.btn_agregar_clienteM.Size = new System.Drawing.Size(83, 34);
            this.btn_agregar_clienteM.TabIndex = 49;
            this.btn_agregar_clienteM.Text = "Agregar";
            this.btn_agregar_clienteM.UseVisualStyleBackColor = false;
            this.btn_agregar_clienteM.Click += new System.EventHandler(this.btn_agregar_clienteM_Click);
            // 
            // btn_mostrar_clienteM
            // 
            this.btn_mostrar_clienteM.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_mostrar_clienteM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar_clienteM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_mostrar_clienteM.Location = new System.Drawing.Point(38, 442);
            this.btn_mostrar_clienteM.Name = "btn_mostrar_clienteM";
            this.btn_mostrar_clienteM.Size = new System.Drawing.Size(93, 34);
            this.btn_mostrar_clienteM.TabIndex = 48;
            this.btn_mostrar_clienteM.Text = "Mostrar";
            this.btn_mostrar_clienteM.UseVisualStyleBackColor = false;
            this.btn_mostrar_clienteM.Click += new System.EventHandler(this.btn_mostrar_clienteM_Click);
            // 
            // btn_nuevo_clienteM
            // 
            this.btn_nuevo_clienteM.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_nuevo_clienteM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_clienteM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_nuevo_clienteM.Location = new System.Drawing.Point(38, 402);
            this.btn_nuevo_clienteM.Name = "btn_nuevo_clienteM";
            this.btn_nuevo_clienteM.Size = new System.Drawing.Size(91, 34);
            this.btn_nuevo_clienteM.TabIndex = 47;
            this.btn_nuevo_clienteM.Text = "Nuevo";
            this.btn_nuevo_clienteM.UseVisualStyleBackColor = false;
            this.btn_nuevo_clienteM.Click += new System.EventHandler(this.btn_nuevo_clienteM_Click);
            // 
            // txtIDreserva
            // 
            this.txtIDreserva.Location = new System.Drawing.Point(560, 128);
            this.txtIDreserva.Name = "txtIDreserva";
            this.txtIDreserva.Size = new System.Drawing.Size(236, 20);
            this.txtIDreserva.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID reserva";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(5, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 75);
            this.panel1.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Subheading", 22.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(448, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 43);
            this.label4.TabIndex = 0;
            this.label4.Text = "Reserva";
            // 
            // cmbIDProducto
            // 
            this.cmbIDProducto.FormattingEnabled = true;
            this.cmbIDProducto.Location = new System.Drawing.Point(560, 186);
            this.cmbIDProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIDProducto.Name = "cmbIDProducto";
            this.cmbIDProducto.Size = new System.Drawing.Size(236, 21);
            this.cmbIDProducto.TabIndex = 73;
            // 
            // cmbIDcliente
            // 
            this.cmbIDcliente.FormattingEnabled = true;
            this.cmbIDcliente.Location = new System.Drawing.Point(560, 244);
            this.cmbIDcliente.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIDcliente.Name = "cmbIDcliente";
            this.cmbIDcliente.Size = new System.Drawing.Size(236, 21);
            this.cmbIDcliente.TabIndex = 74;
            // 
            // cbkEstadoReserva
            // 
            this.cbkEstadoReserva.AutoSize = true;
            this.cbkEstadoReserva.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbkEstadoReserva.Location = new System.Drawing.Point(679, 354);
            this.cbkEstadoReserva.Name = "cbkEstadoReserva";
            this.cbkEstadoReserva.Size = new System.Drawing.Size(117, 17);
            this.cbkEstadoReserva.TabIndex = 79;
            this.cbkEstadoReserva.Text = "Estado de Reserva";
            this.cbkEstadoReserva.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(38, 598);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 34);
            this.btnEliminar.TabIndex = 80;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(461, 442);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(169, 20);
            this.txt_buscar.TabIndex = 81;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(735, 442);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 34);
            this.btnBuscar.TabIndex = 82;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // MantenedorReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 684);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cbkEstadoReserva);
            this.Controls.Add(this.cmbIDcliente);
            this.Controls.Add(this.cmbIDProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvReserva);
            this.Controls.Add(this.btn_cancelar_clienteM);
            this.Controls.Add(this.btn_editar_clienteM);
            this.Controls.Add(this.btn_agregar_clienteM);
            this.Controls.Add(this.btn_mostrar_clienteM);
            this.Controls.Add(this.btn_nuevo_clienteM);
            this.Controls.Add(this.txtIDreserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MantenedorReserva";
            this.Text = "MantenedorReserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvReserva;
        private System.Windows.Forms.Button btn_cancelar_clienteM;
        private System.Windows.Forms.Button btn_editar_clienteM;
        private System.Windows.Forms.Button btn_agregar_clienteM;
        private System.Windows.Forms.Button btn_mostrar_clienteM;
        private System.Windows.Forms.Button btn_nuevo_clienteM;
        private System.Windows.Forms.TextBox txtIDreserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbIDProducto;
        private System.Windows.Forms.ComboBox cmbIDcliente;
        private System.Windows.Forms.CheckBox cbkEstadoReserva;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}