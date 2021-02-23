namespace Proyectov1._0
{
    partial class Primer_Grado
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelDatosprimero = new System.Windows.Forms.Panel();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.txtdui1 = new System.Windows.Forms.MaskedTextBox();
            this.txtresponsable1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnlimpiar1 = new System.Windows.Forms.Button();
            this.btneliminar1 = new System.Windows.Forms.Button();
            this.btnactualizar1 = new System.Windows.Forms.Button();
            this.btnguardar1 = new System.Windows.Forms.Button();
            this.fechanac1 = new System.Windows.Forms.DateTimePicker();
            this.txtdir1 = new System.Windows.Forms.TextBox();
            this.txtapellidos1 = new System.Windows.Forms.TextBox();
            this.txtnombres1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDGVprimero = new System.Windows.Forms.Panel();
            this.Datos1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtbuscar1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.alumnosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet2 = new Proyectov1._0.ProyectoDataSet2();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet1 = new Proyectov1._0.ProyectoDataSet1();
            this.alumnosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosTableAdapter = new Proyectov1._0.ProyectoDataSet1TableAdapters.AlumnosTableAdapter();
            this.alumnosTableAdapter1 = new Proyectov1._0.ProyectoDataSet2TableAdapters.AlumnosTableAdapter();
            this.panelDatosprimero.SuspendLayout();
            this.panelDGVprimero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer Grado";
            // 
            // panelDatosprimero
            // 
            this.panelDatosprimero.Controls.Add(this.maskedTextBox2);
            this.panelDatosprimero.Controls.Add(this.txtdui1);
            this.panelDatosprimero.Controls.Add(this.txtresponsable1);
            this.panelDatosprimero.Controls.Add(this.textBox1);
            this.panelDatosprimero.Controls.Add(this.btnlimpiar1);
            this.panelDatosprimero.Controls.Add(this.btneliminar1);
            this.panelDatosprimero.Controls.Add(this.btnactualizar1);
            this.panelDatosprimero.Controls.Add(this.btnguardar1);
            this.panelDatosprimero.Controls.Add(this.fechanac1);
            this.panelDatosprimero.Controls.Add(this.txtdir1);
            this.panelDatosprimero.Controls.Add(this.txtapellidos1);
            this.panelDatosprimero.Controls.Add(this.txtnombres1);
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
            this.panelDatosprimero.TabIndex = 1;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(200, 243);
            this.maskedTextBox2.Mask = "0000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(278, 20);
            this.maskedTextBox2.TabIndex = 26;
            // 
            // txtdui1
            // 
            this.txtdui1.Location = new System.Drawing.Point(200, 200);
            this.txtdui1.Mask = "00000000-0";
            this.txtdui1.Name = "txtdui1";
            this.txtdui1.Size = new System.Drawing.Size(278, 20);
            this.txtdui1.TabIndex = 25;
            // 
            // txtresponsable1
            // 
            this.txtresponsable1.Location = new System.Drawing.Point(200, 158);
            this.txtresponsable1.Name = "txtresponsable1";
            this.txtresponsable1.Size = new System.Drawing.Size(278, 20);
            this.txtresponsable1.TabIndex = 24;
            this.txtresponsable1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtresponsable_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            // 
            // btnlimpiar1
            // 
            this.btnlimpiar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(149)))));
            this.btnlimpiar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlimpiar1.FlatAppearance.BorderSize = 0;
            this.btnlimpiar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnlimpiar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnlimpiar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar1.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar1.Image = global::Proyectov1._0.Properties.Resources.wiping_swipe_for_floors;
            this.btnlimpiar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlimpiar1.Location = new System.Drawing.Point(271, 423);
            this.btnlimpiar1.Name = "btnlimpiar1";
            this.btnlimpiar1.Size = new System.Drawing.Size(163, 40);
            this.btnlimpiar1.TabIndex = 19;
            this.btnlimpiar1.Text = "Limpiar";
            this.btnlimpiar1.UseVisualStyleBackColor = false;
            // 
            // btneliminar1
            // 
            this.btneliminar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(149)))));
            this.btneliminar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btneliminar1.FlatAppearance.BorderSize = 0;
            this.btneliminar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btneliminar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btneliminar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar1.ForeColor = System.Drawing.Color.White;
            this.btneliminar1.Image = global::Proyectov1._0.Properties.Resources.delete;
            this.btneliminar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar1.Location = new System.Drawing.Point(53, 423);
            this.btneliminar1.Name = "btneliminar1";
            this.btneliminar1.Size = new System.Drawing.Size(163, 40);
            this.btneliminar1.TabIndex = 18;
            this.btneliminar1.Text = "Eliminar";
            this.btneliminar1.UseVisualStyleBackColor = false;
            this.btneliminar1.Click += new System.EventHandler(this.btneliminar1_Click);
            // 
            // btnactualizar1
            // 
            this.btnactualizar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(149)))));
            this.btnactualizar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnactualizar1.FlatAppearance.BorderSize = 0;
            this.btnactualizar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnactualizar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnactualizar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar1.ForeColor = System.Drawing.Color.White;
            this.btnactualizar1.Image = global::Proyectov1._0.Properties.Resources.refresh;
            this.btnactualizar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualizar1.Location = new System.Drawing.Point(271, 342);
            this.btnactualizar1.Name = "btnactualizar1";
            this.btnactualizar1.Size = new System.Drawing.Size(163, 40);
            this.btnactualizar1.TabIndex = 17;
            this.btnactualizar1.Text = "Actualizar";
            this.btnactualizar1.UseVisualStyleBackColor = false;
            this.btnactualizar1.Click += new System.EventHandler(this.btnactualizar1_Click);
            // 
            // btnguardar1
            // 
            this.btnguardar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(149)))));
            this.btnguardar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnguardar1.FlatAppearance.BorderSize = 0;
            this.btnguardar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnguardar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnguardar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar1.ForeColor = System.Drawing.Color.White;
            this.btnguardar1.Image = global::Proyectov1._0.Properties.Resources.download_button1;
            this.btnguardar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar1.Location = new System.Drawing.Point(53, 342);
            this.btnguardar1.Name = "btnguardar1";
            this.btnguardar1.Size = new System.Drawing.Size(163, 40);
            this.btnguardar1.TabIndex = 16;
            this.btnguardar1.Text = "Guardar";
            this.btnguardar1.UseVisualStyleBackColor = false;
            this.btnguardar1.Click += new System.EventHandler(this.btnguardar1_Click);
            // 
            // fechanac1
            // 
            this.fechanac1.Location = new System.Drawing.Point(200, 124);
            this.fechanac1.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.fechanac1.MinDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.fechanac1.Name = "fechanac1";
            this.fechanac1.Size = new System.Drawing.Size(278, 20);
            this.fechanac1.TabIndex = 15;
            this.fechanac1.Value = new System.DateTime(2019, 4, 9, 0, 0, 0, 0);
            this.fechanac1.ValueChanged += new System.EventHandler(this.fechanac1_ValueChanged);
            // 
            // txtdir1
            // 
            this.txtdir1.Location = new System.Drawing.Point(200, 285);
            this.txtdir1.Name = "txtdir1";
            this.txtdir1.Size = new System.Drawing.Size(278, 20);
            this.txtdir1.TabIndex = 14;
            this.txtdir1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdir1_KeyPress);
            // 
            // txtapellidos1
            // 
            this.txtapellidos1.Location = new System.Drawing.Point(200, 91);
            this.txtapellidos1.Name = "txtapellidos1";
            this.txtapellidos1.Size = new System.Drawing.Size(278, 20);
            this.txtapellidos1.TabIndex = 10;
            this.txtapellidos1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidos1_KeyPress);
            // 
            // txtnombres1
            // 
            this.txtnombres1.Location = new System.Drawing.Point(200, 56);
            this.txtnombres1.Name = "txtnombres1";
            this.txtnombres1.Size = new System.Drawing.Size(278, 20);
            this.txtnombres1.TabIndex = 9;
            this.txtnombres1.TextChanged += new System.EventHandler(this.txtnombres1_TextChanged);
            this.txtnombres1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombres1_KeyPress);
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
            // panelDGVprimero
            // 
            this.panelDGVprimero.Controls.Add(this.Datos1);
            this.panelDGVprimero.Controls.Add(this.btnBuscar);
            this.panelDGVprimero.Controls.Add(this.txtbuscar1);
            this.panelDGVprimero.Controls.Add(this.label10);
            this.panelDGVprimero.Location = new System.Drawing.Point(519, 73);
            this.panelDGVprimero.Name = "panelDGVprimero";
            this.panelDGVprimero.Size = new System.Drawing.Size(519, 502);
            this.panelDGVprimero.TabIndex = 2;
            // 
            // Datos1
            // 
            this.Datos1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Datos1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datos1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Datos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Datos1.EnableHeadersVisualStyles = false;
            this.Datos1.Location = new System.Drawing.Point(24, 91);
            this.Datos1.Name = "Datos1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datos1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Datos1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Datos1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datos1.Size = new System.Drawing.Size(466, 308);
            this.Datos1.TabIndex = 4;
            this.Datos1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datos1_CellContentClick_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(244, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtbuscar1
            // 
            this.txtbuscar1.Location = new System.Drawing.Point(121, 10);
            this.txtbuscar1.Name = "txtbuscar1";
            this.txtbuscar1.Size = new System.Drawing.Size(336, 20);
            this.txtbuscar1.TabIndex = 2;
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
            // alumnosBindingSource2
            // 
            this.alumnosBindingSource2.DataMember = "Alumnos";
            this.alumnosBindingSource2.DataSource = this.proyectoDataSet2;
            // 
            // proyectoDataSet2
            // 
            this.proyectoDataSet2.DataSetName = "ProyectoDataSet2";
            this.proyectoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            // 
            // proyectoDataSet1
            // 
            this.proyectoDataSet1.DataSetName = "ProyectoDataSet1";
            this.proyectoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosBindingSource1
            // 
            this.alumnosBindingSource1.DataMember = "Alumnos";
            this.alumnosBindingSource1.DataSource = this.proyectoDataSet1;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // alumnosTableAdapter1
            // 
            this.alumnosTableAdapter1.ClearBeforeFill = true;
            // 
            // Primer_Grado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.panelDGVprimero);
            this.Controls.Add(this.panelDatosprimero);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Primer_Grado";
            this.Text = "Primer_Grado";
            this.Load += new System.EventHandler(this.Primer_Grado_Load);
            this.panelDatosprimero.ResumeLayout(false);
            this.panelDatosprimero.PerformLayout();
            this.panelDGVprimero.ResumeLayout(false);
            this.panelDGVprimero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDatosprimero;
        private System.Windows.Forms.DateTimePicker fechanac1;
        private System.Windows.Forms.TextBox txtdir1;
        private System.Windows.Forms.TextBox txtapellidos1;
        private System.Windows.Forms.TextBox txtnombres1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelDGVprimero;
        private System.Windows.Forms.Button btnguardar1;
        private System.Windows.Forms.Button btnlimpiar1;
        private System.Windows.Forms.Button btneliminar1;
        private System.Windows.Forms.Button btnactualizar1;
        private System.Windows.Forms.TextBox txtbuscar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtresponsable1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox txtdui1;
        private System.Windows.Forms.Button btnBuscar;
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
        private ProyectoDataSet1 proyectoDataSet1;
        private System.Windows.Forms.BindingSource alumnosBindingSource1;
        private ProyectoDataSet1TableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.DataGridView Datos1;
        private ProyectoDataSet2 proyectoDataSet2;
        private System.Windows.Forms.BindingSource alumnosBindingSource2;
        private ProyectoDataSet2TableAdapters.AlumnosTableAdapter alumnosTableAdapter1;
    }
}