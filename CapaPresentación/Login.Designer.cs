namespace CapaPresentación
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_entrar_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalirLogin = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 498);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 209);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btn_entrar_login
            // 
            this.btn_entrar_login.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_entrar_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_entrar_login.ForeColor = System.Drawing.Color.Snow;
            this.btn_entrar_login.Location = new System.Drawing.Point(349, 231);
            this.btn_entrar_login.Name = "btn_entrar_login";
            this.btn_entrar_login.Size = new System.Drawing.Size(225, 39);
            this.btn_entrar_login.TabIndex = 1;
            this.btn_entrar_login.Text = "Entrar";
            this.btn_entrar_login.UseVisualStyleBackColor = false;
            this.btn_entrar_login.Click += new System.EventHandler(this.btn_entrar_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(302, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 87);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stac Business";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSalirLogin
            // 
            this.btnSalirLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalirLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalirLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalirLogin.Location = new System.Drawing.Point(349, 446);
            this.btnSalirLogin.Name = "btnSalirLogin";
            this.btnSalirLogin.Size = new System.Drawing.Size(225, 39);
            this.btnSalirLogin.TabIndex = 3;
            this.btnSalirLogin.Text = "Salir";
            this.btnSalirLogin.UseVisualStyleBackColor = false;
            this.btnSalirLogin.Click += new System.EventHandler(this.btnSalirLogin_Click);
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(813, 497);
            this.Controls.Add(this.btnSalirLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_entrar_login);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load_1);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Boton_entrar_login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_entrar_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalirLogin;
    }
}