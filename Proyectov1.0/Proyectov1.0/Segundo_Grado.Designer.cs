namespace Proyectov1._0
{
    partial class Segundo_Grado
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDGVprimero = new System.Windows.Forms.Panel();
            this.Btnbuscar2 = new System.Windows.Forms.Button();
            this.txtbuscar2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Datos2 = new System.Windows.Forms.DataGridView();
            this.alumnosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet = new Proyectov1._0.ProyectoDataSet();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelDatosprimero = new System.Windows.Forms.Panel();
            this.txttel2 = new System.Windows.Forms.MaskedTextBox();
            this.txtdui2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fechanac2 = new System.Windows.Forms.DateTimePicker();
            this.btnlimpiar2 = new System.Windows.Forms.Button();
            this.btneliminar2 = new System.Windows.Forms.Button();
            this.btnactualizar2 = new System.Windows.Forms.Button();
            this.btnguardar2 = new System.Windows.Forms.Button();
            this.txtdir2 = new System.Windows.Forms.TextBox();
            this.txtresponsable2 = new System.Windows.Forms.TextBox();
            this.txtapellidos2 = new System.Windows.Forms.TextBox();
            this.txtnombres2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alumnosTableAdapter = new Proyectov1._0.ProyectoDataSetTableAdapters.AlumnosTableAdapter();
            this.panelDGVprimero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            this.panelDatosprimero.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDGVprimero
            // 
            this.panelDGVprimero.Controls.Add(this.Btnbuscar2);
            this.panelDGVprimero.Controls.Add(this.txtbuscar2);
            this.panelDGVprimero.Controls.Add(this.label10);
            this.panelDGVprimero.Controls.Add(this.Datos2);
            this.panelDGVprimero.Location = new System.Drawing.Point(519, 73);
            this.panelDGVprimero.Name = "panelDGVprimero";
            this.panelDGVprimero.Size = new System.Drawing.Size(519, 502);
            this.panelDGVprimero.TabIndex = 5;
            // 
            // Btnbuscar2
            // 
            this.Btnbuscar2.Location = new System.Drawing.Point(229, 41);
            this.Btnbuscar2.Name = "Btnbuscar2";
            this.Btnbuscar2.Size = new System.Drawing.Size(75, 23);
            this.Btnbuscar2.TabIndex = 3;
            this.Btnbuscar2.Text = "BUSCAR";
            this.Btnbuscar2.UseVisualStyleBackColor = true;
            this.Btnbuscar2.Click += new System.EventHandler(this.Btnbuscar2_Click);
            // 
            // txtbuscar2
            // 
            this.txtbuscar2.Location = new System.Drawing.Point(121, 10);
            this.txtbuscar2.Name = "txtbuscar2";
            this.txtbuscar2.Size = new System.Drawing.Size(367, 20);
            this.txtbuscar2.TabIndex = 2;
            this.txtbuscar2.TextChanged += new System.EventHandler(this.txtbuscar2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nombre";
            // 
            // Datos2
            // 
            this.Datos2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Datos2.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datos2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Datos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Datos2.EnableHeadersVisualStyles = false;
            this.Datos2.Location = new System.Drawing.Point(24, 91);
            this.Datos2.Name = "Datos2";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datos2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Datos2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Datos2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datos2.Size = new System.Drawing.Size(492, 414);
            this.Datos2.TabIndex = 0;
            this.Datos2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datos2_CellContentClick);
            // 
            // alumnosBindingSource1
            // 
            this.alumnosBindingSource1.DataMember = "Alumnos";
            this.alumnosBindingSource1.DataSource = this.proyectoDataSet;
            // 
            // proyectoDataSet
            // 
            this.proyectoDataSet.DataSetName = "ProyectoDataSet";
            this.proyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            // 
            // panelDatosprimero
            // 
            this.panelDatosprimero.Controls.Add(this.txttel2);
            this.panelDatosprimero.Controls.Add(this.txtdui2);
            this.panelDatosprimero.Controls.Add(this.textBox1);
            this.panelDatosprimero.Controls.Add(this.fechanac2);
            this.panelDatosprimero.Controls.Add(this.btnlimpiar2);
            this.panelDatosprimero.Controls.Add(this.btneliminar2);
            this.panelDatosprimero.Controls.Add(this.btnactualizar2);
            this.panelDatosprimero.Controls.Add(this.btnguardar2);
            this.panelDatosprimero.Controls.Add(this.txtdir2);
            this.panelDatosprimero.Controls.Add(this.txtresponsable2);
            this.panelDatosprimero.Controls.Add(this.txtapellidos2);
            this.panelDatosprimero.Controls.Add(this.txtnombres2);
            this.panelDatosprimero.Controls.Add(this.label9);
            this.panelDatosprimero.Controls.Add(this.label8);
            this.panelDatosprimero.Controls.Add(this.label7);
            this.panelDatosprimero.Controls.Add(this.label6);
            this.panelDatosprimero.Controls.Add(this.label5);
            this.panelDatosprimero.Controls.Add(this.label4);
            this.panelDatosprimero.Controls.Add(this.label3);
            this.panelDatosprimero.Location = new System.Drawing.Point(4, 73);
            this.panelDatosprimero.Name = "panelDatosprimero";
            this.panelDatosprimero.Size = new System.Drawing.Size(497, 502);
            this.panelDatosprimero.TabIndex = 4;
            this.panelDatosprimero.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDatosprimero_Paint);
            // 
            // txttel2
            // 
            this.txttel2.Location = new System.Drawing.Point(200, 242);
            this.txttel2.Mask = "0000-0000";
            this.txttel2.Name = "txttel2";
            this.txttel2.Size = new System.Drawing.Size(278, 20);
            this.txttel2.TabIndex = 21;
            // 
            // txtdui2
            // 
            this.txtdui2.Location = new System.Drawing.Point(200, 200);
            this.txtdui2.Mask = "00000000-0";
            this.txtdui2.Name = "txtdui2";
            this.txtdui2.Size = new System.Drawing.Size(278, 20);
            this.txtdui2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // fechanac2
            // 
            this.fechanac2.Location = new System.Drawing.Point(200, 124);
            this.fechanac2.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.fechanac2.MinDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.fechanac2.Name = "fechanac2";
            this.fechanac2.Size = new System.Drawing.Size(278, 20);
            this.fechanac2.TabIndex = 15;
            // 
            // btnlimpiar2
            // 
            this.btnlimpiar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(149)))));
            this.btnlimpiar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlimpiar2.FlatAppearance.BorderSize = 0;
            this.btnlimpiar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnlimpiar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnlimpiar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar2.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar2.Image = global::Proyectov1._0.Properties.Resources.wiping_swipe_for_floors;
            this.btnlimpiar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlimpiar2.Location = new System.Drawing.Point(271, 423);
            this.btnlimpiar2.Name = "btnlimpiar2";
            this.btnlimpiar2.Size = new System.Drawing.Size(163, 40);
            this.btnlimpiar2.TabIndex = 19;
            this.btnlimpiar2.Text = "Limpiar";
            this.btnlimpiar2.UseVisualStyleBackColor = false;
            // 
            // btneliminar2
            // 
            this.btneliminar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(149)))));
            this.btneliminar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btneliminar2.FlatAppearance.BorderSize = 0;
            this.btneliminar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btneliminar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btneliminar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar2.ForeColor = System.Drawing.Color.White;
            this.btneliminar2.Image = global::Proyectov1._0.Properties.Resources.delete;
            this.btneliminar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar2.Location = new System.Drawing.Point(53, 423);
            this.btneliminar2.Name = "btneliminar2";
            this.btneliminar2.Size = new System.Drawing.Size(163, 40);
            this.btneliminar2.TabIndex = 18;
            this.btneliminar2.Text = "Eliminar";
            this.btneliminar2.UseVisualStyleBackColor = false;
            this.btneliminar2.Click += new System.EventHandler(this.btneliminar2_Click);
            // 
            // btnactualizar2
            // 
            this.btnactualizar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(149)))));
            this.btnactualizar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnactualizar2.FlatAppearance.BorderSize = 0;
            this.btnactualizar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnactualizar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnactualizar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar2.ForeColor = System.Drawing.Color.White;
            this.btnactualizar2.Image = global::Proyectov1._0.Properties.Resources.refresh;
            this.btnactualizar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualizar2.Location = new System.Drawing.Point(271, 342);
            this.btnactualizar2.Name = "btnactualizar2";
            this.btnactualizar2.Size = new System.Drawing.Size(163, 40);
            this.btnactualizar2.TabIndex = 17;
            this.btnactualizar2.Text = "Actualizar";
            this.btnactualizar2.UseVisualStyleBackColor = false;
            this.btnactualizar2.Click += new System.EventHandler(this.btnactualizar2_Click);
            // 
            // btnguardar2
            // 
            this.btnguardar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(149)))));
            this.btnguardar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnguardar2.FlatAppearance.BorderSize = 0;
            this.btnguardar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnguardar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnguardar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar2.ForeColor = System.Drawing.Color.White;
            this.btnguardar2.Image = global::Proyectov1._0.Properties.Resources.download_button;
            this.btnguardar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar2.Location = new System.Drawing.Point(53, 342);
            this.btnguardar2.Name = "btnguardar2";
            this.btnguardar2.Size = new System.Drawing.Size(163, 40);
            this.btnguardar2.TabIndex = 16;
            this.btnguardar2.Text = "Guardar";
            this.btnguardar2.UseVisualStyleBackColor = false;
            this.btnguardar2.Click += new System.EventHandler(this.btnguardar2_Click);
            // 
            // txtdir2
            // 
            this.txtdir2.Location = new System.Drawing.Point(200, 285);
            this.txtdir2.Name = "txtdir2";
            this.txtdir2.Size = new System.Drawing.Size(278, 20);
            this.txtdir2.TabIndex = 14;
            this.txtdir2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdir2_KeyPress);
            // 
            // txtresponsable2
            // 
            this.txtresponsable2.Location = new System.Drawing.Point(200, 156);
            this.txtresponsable2.Name = "txtresponsable2";
            this.txtresponsable2.Size = new System.Drawing.Size(278, 20);
            this.txtresponsable2.TabIndex = 11;
            this.txtresponsable2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtresponsable2_KeyPress);
            // 
            // txtapellidos2
            // 
            this.txtapellidos2.Location = new System.Drawing.Point(200, 91);
            this.txtapellidos2.Name = "txtapellidos2";
            this.txtapellidos2.Size = new System.Drawing.Size(278, 20);
            this.txtapellidos2.TabIndex = 10;
            this.txtapellidos2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidos2_KeyPress);
            // 
            // txtnombres2
            // 
            this.txtnombres2.Location = new System.Drawing.Point(200, 56);
            this.txtnombres2.Name = "txtnombres2";
            this.txtnombres2.Size = new System.Drawing.Size(278, 20);
            this.txtnombres2.TabIndex = 9;
            this.txtnombres2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombres2_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dui Responsable";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Responsable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Segundo Grado";
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // Segundo_Grado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.panelDGVprimero);
            this.Controls.Add(this.panelDatosprimero);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Segundo_Grado";
            this.Text = "Segundo_Grado";
            this.Load += new System.EventHandler(this.Segundo_Grado_Load);
            this.panelDGVprimero.ResumeLayout(false);
            this.panelDGVprimero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            this.panelDatosprimero.ResumeLayout(false);
            this.panelDatosprimero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDGVprimero;
        private System.Windows.Forms.TextBox txtbuscar2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView Datos2;
        private System.Windows.Forms.Panel panelDatosprimero;
        private System.Windows.Forms.Button btnlimpiar2;
        private System.Windows.Forms.Button btneliminar2;
        private System.Windows.Forms.Button btnactualizar2;
        private System.Windows.Forms.Button btnguardar2;
        private System.Windows.Forms.DateTimePicker fechanac2;
        private System.Windows.Forms.TextBox txtdir2;
        private System.Windows.Forms.TextBox txtresponsable2;
        private System.Windows.Forms.TextBox txtapellidos2;
        private System.Windows.Forms.TextBox txtnombres2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btnbuscar2;
        private System.Windows.Forms.MaskedTextBox txttel2;
        private System.Windows.Forms.MaskedTextBox txtdui2;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreResponsableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duiResponsableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGradoDataGridViewTextBoxColumn;
        private ProyectoDataSet proyectoDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource1;
        private ProyectoDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
    }
}