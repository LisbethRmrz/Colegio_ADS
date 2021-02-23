namespace Proyectov1._0
{
    partial class Ciencias1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.AlumnosPrimero = new System.Windows.Forms.DataGridView();
            this.botonesleng = new System.Windows.Forms.Panel();
            this.eliminar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtestudiante = new System.Windows.Forms.TextBox();
            this.nota3 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nota2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.nota1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvciencias1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnosPrimero)).BeginInit();
            this.botonesleng.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvciencias1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(716, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 83;
            this.label1.Text = "Seleccionar Alumno";
            // 
            // AlumnosPrimero
            // 
            this.AlumnosPrimero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AlumnosPrimero.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AlumnosPrimero.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AlumnosPrimero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlumnosPrimero.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AlumnosPrimero.EnableHeadersVisualStyles = false;
            this.AlumnosPrimero.Location = new System.Drawing.Point(716, 61);
            this.AlumnosPrimero.Name = "AlumnosPrimero";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AlumnosPrimero.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AlumnosPrimero.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.AlumnosPrimero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AlumnosPrimero.Size = new System.Drawing.Size(263, 193);
            this.AlumnosPrimero.TabIndex = 78;
            this.AlumnosPrimero.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AlumnosPrimero_CellContentClick);
            // 
            // botonesleng
            // 
            this.botonesleng.Controls.Add(this.eliminar);
            this.botonesleng.Controls.Add(this.limpiar);
            this.botonesleng.Controls.Add(this.actualizar);
            this.botonesleng.Controls.Add(this.guardar);
            this.botonesleng.Location = new System.Drawing.Point(93, 260);
            this.botonesleng.Name = "botonesleng";
            this.botonesleng.Size = new System.Drawing.Size(640, 64);
            this.botonesleng.TabIndex = 79;
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(149)))));
            this.eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eliminar.FlatAppearance.BorderSize = 0;
            this.eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.ForeColor = System.Drawing.Color.White;
            this.eliminar.Image = global::Proyectov1._0.Properties.Resources.delete;
            this.eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminar.Location = new System.Drawing.Point(317, 13);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(150, 40);
            this.eliminar.TabIndex = 47;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(149)))));
            this.limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiar.FlatAppearance.BorderSize = 0;
            this.limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.ForeColor = System.Drawing.Color.White;
            this.limpiar.Image = global::Proyectov1._0.Properties.Resources.wiping_swipe_for_floors;
            this.limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.limpiar.Location = new System.Drawing.Point(473, 13);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(150, 40);
            this.limpiar.TabIndex = 46;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // actualizar
            // 
            this.actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(149)))));
            this.actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actualizar.FlatAppearance.BorderSize = 0;
            this.actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar.ForeColor = System.Drawing.Color.White;
            this.actualizar.Image = global::Proyectov1._0.Properties.Resources.refresh;
            this.actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.actualizar.Location = new System.Drawing.Point(161, 13);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(150, 40);
            this.actualizar.TabIndex = 44;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = false;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(149)))));
            this.guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardar.FlatAppearance.BorderSize = 0;
            this.guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.ForeColor = System.Drawing.Color.White;
            this.guardar.Image = global::Proyectov1._0.Properties.Resources.download_button;
            this.guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guardar.Location = new System.Drawing.Point(3, 13);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(150, 40);
            this.guardar.TabIndex = 43;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txtestudiante);
            this.panel11.Controls.Add(this.nota3);
            this.panel11.Controls.Add(this.label15);
            this.panel11.Controls.Add(this.nota2);
            this.panel11.Controls.Add(this.label16);
            this.panel11.Controls.Add(this.nota1);
            this.panel11.Controls.Add(this.label17);
            this.panel11.Controls.Add(this.label19);
            this.panel11.Location = new System.Drawing.Point(107, 52);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(577, 193);
            this.panel11.TabIndex = 82;
            // 
            // txtestudiante
            // 
            this.txtestudiante.Location = new System.Drawing.Point(105, 28);
            this.txtestudiante.Name = "txtestudiante";
            this.txtestudiante.Size = new System.Drawing.Size(455, 20);
            this.txtestudiante.TabIndex = 40;
            // 
            // nota3
            // 
            this.nota3.Location = new System.Drawing.Point(105, 164);
            this.nota3.Name = "nota3";
            this.nota3.Size = new System.Drawing.Size(128, 20);
            this.nota3.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 20);
            this.label15.TabIndex = 38;
            this.label15.Text = "Nota 3";
            // 
            // nota2
            // 
            this.nota2.Location = new System.Drawing.Point(105, 119);
            this.nota2.Name = "nota2";
            this.nota2.Size = new System.Drawing.Size(128, 20);
            this.nota2.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 20);
            this.label16.TabIndex = 36;
            this.label16.Text = "Nota 2";
            // 
            // nota1
            // 
            this.nota1.Location = new System.Drawing.Point(105, 75);
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(128, 20);
            this.nota1.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 20);
            this.label17.TabIndex = 34;
            this.label17.Text = "Nota 1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(15, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 20);
            this.label19.TabIndex = 31;
            this.label19.Text = "Estudiante";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(415, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 32);
            this.label13.TabIndex = 81;
            this.label13.Text = "Ciencias";
            // 
            // dgvciencias1
            // 
            this.dgvciencias1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvciencias1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvciencias1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvciencias1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvciencias1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvciencias1.EnableHeadersVisualStyles = false;
            this.dgvciencias1.Location = new System.Drawing.Point(128, 330);
            this.dgvciencias1.Name = "dgvciencias1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvciencias1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvciencias1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvciencias1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvciencias1.Size = new System.Drawing.Size(801, 214);
            this.dgvciencias1.TabIndex = 80;
            this.dgvciencias1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvciencias1_CellContentClick);
            // 
            // Ciencias1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AlumnosPrimero);
            this.Controls.Add(this.botonesleng);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvciencias1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ciencias1";
            this.Text = "Ciencias1";
            this.Load += new System.EventHandler(this.Ciencias1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlumnosPrimero)).EndInit();
            this.botonesleng.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvciencias1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AlumnosPrimero;
        private System.Windows.Forms.Panel botonesleng;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtestudiante;
        private System.Windows.Forms.TextBox nota3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox nota2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox nota1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvciencias1;
    }
}