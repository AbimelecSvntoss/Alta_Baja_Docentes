namespace ProyectoUnidad2UzielAguilar
{
    partial class Académico
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Académico));
            txtNombre = new TextBox();
            txtMatricula = new TextBox();
            cmbTipo = new ComboBox();
            btnPrincipal = new Button();
            lstVisualizacion = new ListBox();
            btnEliminar = new Button();
            lblNombre = new Label();
            label2 = new Label();
            lblMatricula = new Label();
            label1 = new Label();
            txtID = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtApellidos = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtEspecialidad = new TextBox();
            copyright = new Label();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Window;
            txtNombre.Location = new Point(12, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(169, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(213, 153);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(169, 23);
            txtMatricula.TabIndex = 1;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Docente", "Alumno" });
            cmbTipo.Location = new Point(12, 207);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(370, 23);
            cmbTipo.TabIndex = 3;
            // 
            // btnPrincipal
            // 
            btnPrincipal.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrincipal.Location = new Point(12, 435);
            btnPrincipal.Name = "btnPrincipal";
            btnPrincipal.Size = new Size(94, 32);
            btnPrincipal.TabIndex = 4;
            btnPrincipal.Text = "Agregar\r\n";
            btnPrincipal.UseVisualStyleBackColor = true;
            btnPrincipal.Click += btnPrincipalClick;
            // 
            // lstVisualizacion
            // 
            lstVisualizacion.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstVisualizacion.FormattingEnabled = true;
            lstVisualizacion.ItemHeight = 14;
            lstVisualizacion.Location = new Point(407, 29);
            lstVisualizacion.Name = "lstVisualizacion";
            lstVisualizacion.Size = new Size(492, 424);
            lstVisualizacion.TabIndex = 5;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(112, 435);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 32);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Tahoma", 9F);
            lblNombre.ForeColor = SystemColors.ActiveCaptionText;
            lblNombre.Location = new Point(12, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(50, 14);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 8;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Tahoma", 9F);
            lblMatricula.ForeColor = SystemColors.ActiveCaptionText;
            lblMatricula.Location = new Point(213, 136);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(54, 14);
            lblMatricula.TabIndex = 9;
            lblMatricula.Text = "Matrícula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 190);
            label1.Name = "label1";
            label1.Size = new Size(145, 14);
            label1.TabIndex = 10;
            label1.Text = "Cargo (Alumno/Docente)";
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 153);
            txtID.Name = "txtID";
            txtID.Size = new Size(169, 23);
            txtID.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(19, 14);
            label3.TabIndex = 12;
            label3.Text = "ID";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(213, 46);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(169, 23);
            txtTelefono.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(213, 29);
            label4.Name = "label4";
            label4.Size = new Size(56, 14);
            label4.TabIndex = 14;
            label4.Text = "Teléfono";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(12, 100);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(169, 23);
            txtApellidos.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(12, 83);
            label5.Name = "label5";
            label5.Size = new Size(54, 14);
            label5.TabIndex = 16;
            label5.Text = "Apellidos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(213, 83);
            label6.Name = "label6";
            label6.Size = new Size(71, 14);
            label6.TabIndex = 17;
            label6.Text = "Especialidad";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(213, 100);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(169, 23);
            txtEspecialidad.TabIndex = 18;
            // 
            // copyright
            // 
            copyright.AutoSize = true;
            copyright.Font = new Font("Verdana", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            copyright.ForeColor = SystemColors.AppWorkspace;
            copyright.Location = new Point(676, 457);
            copyright.Name = "copyright";
            copyright.Size = new Size(223, 13);
            copyright.TabIndex = 19;
            copyright.Text = " © TecNM | All Rights Reserved 2026.";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(213, 435);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 32);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar Información";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Académico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(909, 479);
            Controls.Add(btnGuardar);
            Controls.Add(copyright);
            Controls.Add(txtEspecialidad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtApellidos);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(lblMatricula);
            Controls.Add(label2);
            Controls.Add(lblNombre);
            Controls.Add(btnEliminar);
            Controls.Add(lstVisualizacion);
            Controls.Add(btnPrincipal);
            Controls.Add(cmbTipo);
            Controls.Add(txtMatricula);
            Controls.Add(txtNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Académico";
            Text = "Tec Académico";
            Load += Académico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtMatricula;
        private ComboBox cmbTipo;
        private Button btnPrincipal;
        private ListBox lstVisualizacion;
        private Button btnEliminar;
        private Label lblNombre;
        private Label label2;
        private Label lblMatricula;
        private Label label1;
        private TextBox txtID;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtApellidos;
        private Label label5;
        private Label label6;
        private TextBox txtEspecialidad;
        private Label copyright;
        private Button btnGuardar;
    }
}
