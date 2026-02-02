namespace Presentacion
{
    partial class FrmRegisterAdmin
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
            this.lblNameRegister = new System.Windows.Forms.Label();
            this.txtNameRegister = new System.Windows.Forms.TextBox();
            this.lblPassRegister = new System.Windows.Forms.Label();
            this.txtPassRegister = new System.Windows.Forms.TextBox();
            this.lblEmailRegister = new System.Windows.Forms.Label();
            this.txtEmailRegister = new System.Windows.Forms.TextBox();
            this.btnAceptRegister = new System.Windows.Forms.Button();
            this.btnCancelRegister = new System.Windows.Forms.Button();
            this.lblRepeatPass = new System.Windows.Forms.Label();
            this.txtRepeatPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNameRegister
            // 
            this.lblNameRegister.AutoSize = true;
            this.lblNameRegister.Location = new System.Drawing.Point(157, 76);
            this.lblNameRegister.Name = "lblNameRegister";
            this.lblNameRegister.Size = new System.Drawing.Size(44, 13);
            this.lblNameRegister.TabIndex = 0;
            this.lblNameRegister.Text = "Nombre";
            // 
            // txtNameRegister
            // 
            this.txtNameRegister.Location = new System.Drawing.Point(259, 73);
            this.txtNameRegister.Name = "txtNameRegister";
            this.txtNameRegister.Size = new System.Drawing.Size(208, 20);
            this.txtNameRegister.TabIndex = 1;
            // 
            // lblPassRegister
            // 
            this.lblPassRegister.AutoSize = true;
            this.lblPassRegister.Location = new System.Drawing.Point(157, 198);
            this.lblPassRegister.Name = "lblPassRegister";
            this.lblPassRegister.Size = new System.Drawing.Size(61, 13);
            this.lblPassRegister.TabIndex = 2;
            this.lblPassRegister.Text = "Contrasena";
            // 
            // txtPassRegister
            // 
            this.txtPassRegister.Location = new System.Drawing.Point(259, 191);
            this.txtPassRegister.Name = "txtPassRegister";
            this.txtPassRegister.Size = new System.Drawing.Size(208, 20);
            this.txtPassRegister.TabIndex = 3;
            // 
            // lblEmailRegister
            // 
            this.lblEmailRegister.AutoSize = true;
            this.lblEmailRegister.Location = new System.Drawing.Point(157, 136);
            this.lblEmailRegister.Name = "lblEmailRegister";
            this.lblEmailRegister.Size = new System.Drawing.Size(32, 13);
            this.lblEmailRegister.TabIndex = 4;
            this.lblEmailRegister.Text = "Email";
            // 
            // txtEmailRegister
            // 
            this.txtEmailRegister.Location = new System.Drawing.Point(259, 128);
            this.txtEmailRegister.Name = "txtEmailRegister";
            this.txtEmailRegister.Size = new System.Drawing.Size(208, 20);
            this.txtEmailRegister.TabIndex = 5;
            // 
            // btnAceptRegister
            // 
            this.btnAceptRegister.Location = new System.Drawing.Point(259, 300);
            this.btnAceptRegister.Name = "btnAceptRegister";
            this.btnAceptRegister.Size = new System.Drawing.Size(75, 23);
            this.btnAceptRegister.TabIndex = 6;
            this.btnAceptRegister.Text = "Ingresar";
            this.btnAceptRegister.UseVisualStyleBackColor = true;
            this.btnAceptRegister.Click += new System.EventHandler(this.btnAceptRegister_Click);
            // 
            // btnCancelRegister
            // 
            this.btnCancelRegister.Location = new System.Drawing.Point(392, 300);
            this.btnCancelRegister.Name = "btnCancelRegister";
            this.btnCancelRegister.Size = new System.Drawing.Size(75, 23);
            this.btnCancelRegister.TabIndex = 7;
            this.btnCancelRegister.Text = "Volver";
            this.btnCancelRegister.UseVisualStyleBackColor = true;
            // 
            // lblRepeatPass
            // 
            this.lblRepeatPass.AutoSize = true;
            this.lblRepeatPass.Location = new System.Drawing.Point(168, 244);
            this.lblRepeatPass.Name = "lblRepeatPass";
            this.lblRepeatPass.Size = new System.Drawing.Size(94, 13);
            this.lblRepeatPass.TabIndex = 8;
            this.lblRepeatPass.Text = "Repita contraseña";
            // 
            // txtRepeatPass
            // 
            this.txtRepeatPass.Location = new System.Drawing.Point(268, 244);
            this.txtRepeatPass.Name = "txtRepeatPass";
            this.txtRepeatPass.Size = new System.Drawing.Size(199, 20);
            this.txtRepeatPass.TabIndex = 9;
            // 
            // FrmRegisterAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRepeatPass);
            this.Controls.Add(this.lblRepeatPass);
            this.Controls.Add(this.btnCancelRegister);
            this.Controls.Add(this.btnAceptRegister);
            this.Controls.Add(this.txtEmailRegister);
            this.Controls.Add(this.lblEmailRegister);
            this.Controls.Add(this.txtPassRegister);
            this.Controls.Add(this.lblPassRegister);
            this.Controls.Add(this.txtNameRegister);
            this.Controls.Add(this.lblNameRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegisterAdmin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameRegister;
        private System.Windows.Forms.TextBox txtNameRegister;
        private System.Windows.Forms.Label lblPassRegister;
        private System.Windows.Forms.TextBox txtPassRegister;
        private System.Windows.Forms.Label lblEmailRegister;
        private System.Windows.Forms.TextBox txtEmailRegister;
        private System.Windows.Forms.Button btnAceptRegister;
        private System.Windows.Forms.Button btnCancelRegister;
        private System.Windows.Forms.Label lblRepeatPass;
        private System.Windows.Forms.TextBox txtRepeatPass;
    }
}