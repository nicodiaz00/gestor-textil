namespace Presentacion
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.emailLBL = new System.Windows.Forms.Label();
            this.pcbLogin = new System.Windows.Forms.PictureBox();
            this.TxtEmailLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassLogin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLBL
            // 
            this.emailLBL.AutoSize = true;
            this.emailLBL.Location = new System.Drawing.Point(326, 376);
            this.emailLBL.Name = "emailLBL";
            this.emailLBL.Size = new System.Drawing.Size(35, 13);
            this.emailLBL.TabIndex = 0;
            this.emailLBL.Text = "Email:";
            // 
            // pcbLogin
            // 
            this.pcbLogin.Image = global::Presentacion.Properties.Resources.oak_logo;
            this.pcbLogin.InitialImage = null;
            this.pcbLogin.Location = new System.Drawing.Point(286, 43);
            this.pcbLogin.Name = "pcbLogin";
            this.pcbLogin.Size = new System.Drawing.Size(379, 265);
            this.pcbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogin.TabIndex = 1;
            this.pcbLogin.TabStop = false;
            // 
            // TxtEmailLogin
            // 
            this.TxtEmailLogin.Location = new System.Drawing.Point(395, 373);
            this.TxtEmailLogin.Name = "TxtEmailLogin";
            this.TxtEmailLogin.Size = new System.Drawing.Size(174, 20);
            this.TxtEmailLogin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña:";
            // 
            // txtPassLogin
            // 
            this.txtPassLogin.Location = new System.Drawing.Point(396, 410);
            this.txtPassLogin.Name = "txtPassLogin";
            this.txtPassLogin.Size = new System.Drawing.Size(173, 20);
            this.txtPassLogin.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Registrarse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPassLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEmailLogin);
            this.Controls.Add(this.pcbLogin);
            this.Controls.Add(this.emailLBL);
            this.Name = "FrmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailLBL;
        private System.Windows.Forms.PictureBox pcbLogin;
        private System.Windows.Forms.TextBox TxtEmailLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

