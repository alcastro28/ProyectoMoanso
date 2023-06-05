namespace CapaPresentación
{
    partial class CoreVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoreVenta));
            this.btn_salir_core = new System.Windows.Forms.Button();
            this.btn_registrar_core = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cantidad_P = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_ventas = new System.Windows.Forms.DataGridView();
            this.btn_mostrar_ventasP = new System.Windows.Forms.Button();
            this.txt_id_venta_VentasP = new System.Windows.Forms.Label();
            this.txt_idventas_P = new System.Windows.Forms.TextBox();
            this.btn_limpiar_registro = new System.Windows.Forms.Button();
            this.cb_producto = new System.Windows.Forms.ComboBox();
            this.cb_tipopago = new System.Windows.Forms.ComboBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir_core
            // 
            this.btn_salir_core.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_salir_core.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_salir_core.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_salir_core.Location = new System.Drawing.Point(824, 492);
            this.btn_salir_core.Name = "btn_salir_core";
            this.btn_salir_core.Size = new System.Drawing.Size(95, 38);
            this.btn_salir_core.TabIndex = 1;
            this.btn_salir_core.Text = "Salir";
            this.btn_salir_core.UseVisualStyleBackColor = false;
            this.btn_salir_core.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_registrar_core
            // 
            this.btn_registrar_core.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_registrar_core.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_registrar_core.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_registrar_core.Location = new System.Drawing.Point(660, 436);
            this.btn_registrar_core.Name = "btn_registrar_core";
            this.btn_registrar_core.Size = new System.Drawing.Size(103, 38);
            this.btn_registrar_core.TabIndex = 2;
            this.btn_registrar_core.Text = "Registrar";
            this.btn_registrar_core.UseVisualStyleBackColor = false;
            this.btn_registrar_core.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(232, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "CONTROL DE REGISTRO DE VENTAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(369, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Area de ventas :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(375, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seleccione tipo de pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(677, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 66);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(375, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccione producto:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_cantidad_P
            // 
            this.txt_cantidad_P.Location = new System.Drawing.Point(681, 203);
            this.txt_cantidad_P.Name = "txt_cantidad_P";
            this.txt_cantidad_P.Size = new System.Drawing.Size(141, 20);
            this.txt_cantidad_P.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(677, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fecha:";
            // 
            // dgv_ventas
            // 
            this.dgv_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ventas.Location = new System.Drawing.Point(34, 380);
            this.dgv_ventas.Name = "dgv_ventas";
            this.dgv_ventas.RowHeadersWidth = 51;
            this.dgv_ventas.Size = new System.Drawing.Size(596, 150);
            this.dgv_ventas.TabIndex = 16;
            // 
            // btn_mostrar_ventasP
            // 
            this.btn_mostrar_ventasP.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_mostrar_ventasP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_mostrar_ventasP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_mostrar_ventasP.Location = new System.Drawing.Point(734, 380);
            this.btn_mostrar_ventasP.Name = "btn_mostrar_ventasP";
            this.btn_mostrar_ventasP.Size = new System.Drawing.Size(103, 38);
            this.btn_mostrar_ventasP.TabIndex = 17;
            this.btn_mostrar_ventasP.Text = "Actualizar";
            this.btn_mostrar_ventasP.UseVisualStyleBackColor = false;
            this.btn_mostrar_ventasP.Click += new System.EventHandler(this.btn_mostrar_ventasP_Click);
            // 
            // txt_id_venta_VentasP
            // 
            this.txt_id_venta_VentasP.AutoSize = true;
            this.txt_id_venta_VentasP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_venta_VentasP.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_id_venta_VentasP.Location = new System.Drawing.Point(375, 126);
            this.txt_id_venta_VentasP.Name = "txt_id_venta_VentasP";
            this.txt_id_venta_VentasP.Size = new System.Drawing.Size(83, 20);
            this.txt_id_venta_VentasP.TabIndex = 20;
            this.txt_id_venta_VentasP.Text = "Id ventas";
            // 
            // txt_idventas_P
            // 
            this.txt_idventas_P.Enabled = false;
            this.txt_idventas_P.Location = new System.Drawing.Point(379, 149);
            this.txt_idventas_P.Name = "txt_idventas_P";
            this.txt_idventas_P.Size = new System.Drawing.Size(100, 20);
            this.txt_idventas_P.TabIndex = 21;
            // 
            // btn_limpiar_registro
            // 
            this.btn_limpiar_registro.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_limpiar_registro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_limpiar_registro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_limpiar_registro.Location = new System.Drawing.Point(660, 492);
            this.btn_limpiar_registro.Name = "btn_limpiar_registro";
            this.btn_limpiar_registro.Size = new System.Drawing.Size(103, 38);
            this.btn_limpiar_registro.TabIndex = 23;
            this.btn_limpiar_registro.Text = "Limpiar";
            this.btn_limpiar_registro.UseVisualStyleBackColor = false;
            this.btn_limpiar_registro.Click += new System.EventHandler(this.btn_limpiar_registro_Click);
            // 
            // cb_producto
            // 
            this.cb_producto.FormattingEnabled = true;
            this.cb_producto.Location = new System.Drawing.Point(379, 208);
            this.cb_producto.Name = "cb_producto";
            this.cb_producto.Size = new System.Drawing.Size(167, 21);
            this.cb_producto.TabIndex = 24;
            // 
            // cb_tipopago
            // 
            this.cb_tipopago.FormattingEnabled = true;
            this.cb_tipopago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cb_tipopago.Location = new System.Drawing.Point(379, 274);
            this.cb_tipopago.Name = "cb_tipopago";
            this.cb_tipopago.Size = new System.Drawing.Size(167, 21);
            this.cb_tipopago.TabIndex = 25;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(681, 271);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha.TabIndex = 26;
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_calcular.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_calcular.Location = new System.Drawing.Point(824, 436);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(95, 38);
            this.btn_calcular.TabIndex = 27;
            this.btn_calcular.Text = "Calcular Monto";
            this.btn_calcular.UseVisualStyleBackColor = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_buscar.Location = new System.Drawing.Point(535, 336);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(95, 38);
            this.btn_buscar.TabIndex = 28;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(364, 346);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(165, 20);
            this.txt_buscar.TabIndex = 29;
            // 
            // CoreVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 570);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.cb_tipopago);
            this.Controls.Add(this.cb_producto);
            this.Controls.Add(this.btn_limpiar_registro);
            this.Controls.Add(this.txt_idventas_P);
            this.Controls.Add(this.txt_id_venta_VentasP);
            this.Controls.Add(this.btn_mostrar_ventasP);
            this.Controls.Add(this.dgv_ventas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cantidad_P);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_registrar_core);
            this.Controls.Add(this.btn_salir_core);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CoreVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoreVenta";
            this.Load += new System.EventHandler(this.CoreVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_salir_core;
        private System.Windows.Forms.Button btn_registrar_core;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cantidad_P;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_ventas;
        private System.Windows.Forms.Button btn_mostrar_ventasP;
        private System.Windows.Forms.Label txt_id_venta_VentasP;
        private System.Windows.Forms.TextBox txt_idventas_P;
        private System.Windows.Forms.Button btn_limpiar_registro;
        private System.Windows.Forms.ComboBox cb_producto;
        private System.Windows.Forms.ComboBox cb_tipopago;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
    }
}