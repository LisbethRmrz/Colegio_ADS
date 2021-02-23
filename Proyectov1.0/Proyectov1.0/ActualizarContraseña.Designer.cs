namespace Proyectov1._0
{
    partial class ActualizarContraseña
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ConfimarContraseña = new System.Windows.Forms.TextBox();
            this.ContraseñaNueva = new System.Windows.Forms.TextBox();
            this.RecuperarBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Restablecer contraseña";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(149)))));
            this.panel2.Controls.Add(this.ConfimarContraseña);
            this.panel2.Controls.Add(this.ContraseñaNueva);
            this.panel2.Controls.Add(this.RecuperarBT);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 352);
            this.panel2.TabIndex = 1;
            // 
            // ConfimarContraseña
            // 
            this.ConfimarContraseña.Location = new System.Drawing.Point(332, 107);
            this.ConfimarContraseña.Name = "ConfimarContraseña";
            this.ConfimarContraseña.Size = new System.Drawing.Size(244, 20);
            this.ConfimarContraseña.TabIndex = 16;
            this.ConfimarContraseña.UseSystemPasswordChar = true;
            // 
            // ContraseñaNueva
            // 
            this.ContraseñaNueva.Location = new System.Drawing.Point(332, 52);
            this.ContraseñaNueva.Name = "ContraseñaNueva";
            this.ContraseñaNueva.Size = new System.Drawing.Size(244, 20);
            this.ContraseñaNueva.TabIndex = 15;
            this.ContraseñaNueva.UseSystemPasswordChar = true;
            // 
            // RecuperarBT
            // 
            this.RecuperarBT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RecuperarBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecuperarBT.FlatAppearance.BorderSize = 0;
            this.RecuperarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecuperarBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecuperarBT.Location = new System.Drawing.Point(332, 178);
            this.RecuperarBT.Name = "RecuperarBT";
            this.RecuperarBT.Size = new System.Drawing.Size(244, 50);
            this.RecuperarBT.TabIndex = 14;
            this.RecuperarBT.Text = "Actualizar contraseña";
            this.RecuperarBT.UseVisualStyleBackColor = false;
            this.RecuperarBT.Click += new System.EventHandler(this.RecuperarBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(139, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Confirmar contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(166, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contraseña nueva:";
            // 
            // ActualizarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 402);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ActualizarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarContraseña";
            this.Load += new System.EventHandler(this.ActualizarContraseña_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RecuperarBT;
        private System.Windows.Forms.TextBox ConfimarContraseña;
        private System.Windows.Forms.TextBox ContraseñaNueva;
    }
}