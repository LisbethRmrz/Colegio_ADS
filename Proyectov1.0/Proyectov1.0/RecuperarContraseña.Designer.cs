namespace Proyectov1._0
{
    partial class RecuperarContraseña
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DUIText = new System.Windows.Forms.MaskedTextBox();
            this.RecuperarBT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.VerificacionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuarioText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.DUIText);
            this.panel1.Controls.Add(this.RecuperarBT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.VerificacionLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.UsuarioText);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 380);
            this.panel1.TabIndex = 0;
            // 
            // DUIText
            // 
            this.DUIText.Location = new System.Drawing.Point(267, 130);
            this.DUIText.Name = "DUIText";
            this.DUIText.Size = new System.Drawing.Size(244, 20);
            this.DUIText.TabIndex = 9;
            this.DUIText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DUIText_KeyUp);
            // 
            // RecuperarBT
            // 
            this.RecuperarBT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RecuperarBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecuperarBT.FlatAppearance.BorderSize = 0;
            this.RecuperarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecuperarBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecuperarBT.Location = new System.Drawing.Point(267, 216);
            this.RecuperarBT.Name = "RecuperarBT";
            this.RecuperarBT.Size = new System.Drawing.Size(244, 50);
            this.RecuperarBT.TabIndex = 8;
            this.RecuperarBT.Text = "Recuperar contraseña";
            this.RecuperarBT.UseVisualStyleBackColor = false;
            this.RecuperarBT.Click += new System.EventHandler(this.RecuperarBT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(202, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "DUI:";
            // 
            // VerificacionLabel
            // 
            this.VerificacionLabel.AutoSize = true;
            this.VerificacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerificacionLabel.ForeColor = System.Drawing.Color.White;
            this.VerificacionLabel.Location = new System.Drawing.Point(535, 81);
            this.VerificacionLabel.Name = "VerificacionLabel";
            this.VerificacionLabel.Size = new System.Drawing.Size(103, 20);
            this.VerificacionLabel.TabIndex = 3;
            this.VerificacionLabel.Text = "Verificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(172, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            // 
            // UsuarioText
            // 
            this.UsuarioText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsuarioText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.UsuarioText.Location = new System.Drawing.Point(267, 81);
            this.UsuarioText.Name = "UsuarioText";
            this.UsuarioText.Size = new System.Drawing.Size(244, 19);
            this.UsuarioText.TabIndex = 1;
            this.UsuarioText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UsuarioText_KeyUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 39);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restablecer contraseña";
            // 
            // RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 380);
            this.Controls.Add(this.panel1);
            this.Name = "RecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperación";
            this.Load += new System.EventHandler(this.RecuperarContraseña_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsuarioText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VerificacionLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RecuperarBT;
        private System.Windows.Forms.MaskedTextBox DUIText;
    }
}