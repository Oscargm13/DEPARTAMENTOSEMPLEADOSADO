namespace DEPARTAMENTOSEMPLEADOSADO
{
    partial class EmpleadosDepartamentos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtLocalidad = new TextBox();
            txtApellido = new TextBox();
            txtOficio = new TextBox();
            txtSalario = new TextBox();
            cmbDepartamentos = new ComboBox();
            lstEmpleados = new ListBox();
            btnInsertarDepartamento = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 56);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 176);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 1;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 249);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 323);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 3;
            label4.Text = "Localidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(304, 56);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 4;
            label5.Text = "Empleados";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(633, 56);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 5;
            label6.Text = "Apellido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(633, 139);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 6;
            label7.Text = "Oficio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(633, 224);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 7;
            label8.Text = "Salario";
            // 
            // txtId
            // 
            txtId.Location = new Point(37, 200);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(37, 273);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 9;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(37, 347);
            txtLocalidad.Margin = new Padding(3, 4, 3, 4);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(114, 27);
            txtLocalidad.TabIndex = 10;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(633, 80);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(114, 27);
            txtApellido.TabIndex = 11;
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(633, 165);
            txtOficio.Margin = new Padding(3, 4, 3, 4);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(114, 27);
            txtOficio.TabIndex = 12;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(633, 249);
            txtSalario.Margin = new Padding(3, 4, 3, 4);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(114, 27);
            txtSalario.TabIndex = 13;
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(37, 80);
            cmbDepartamentos.Margin = new Padding(3, 4, 3, 4);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(138, 28);
            cmbDepartamentos.TabIndex = 14;
            cmbDepartamentos.SelectedIndexChanged += cmbDepartamentos_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(304, 80);
            lstEmpleados.Margin = new Padding(3, 4, 3, 4);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(249, 364);
            lstEmpleados.TabIndex = 15;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // btnInsertarDepartamento
            // 
            btnInsertarDepartamento.Location = new Point(37, 415);
            btnInsertarDepartamento.Margin = new Padding(3, 4, 3, 4);
            btnInsertarDepartamento.Name = "btnInsertarDepartamento";
            btnInsertarDepartamento.Size = new Size(114, 53);
            btnInsertarDepartamento.TabIndex = 16;
            btnInsertarDepartamento.Text = "Insertar departamento";
            btnInsertarDepartamento.UseVisualStyleBackColor = true;
            btnInsertarDepartamento.Click += btnInsertarDepartamento_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(633, 300);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(114, 43);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // EmpleadosDepartamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsertarDepartamento);
            Controls.Add(lstEmpleados);
            Controls.Add(cmbDepartamentos);
            Controls.Add(txtSalario);
            Controls.Add(txtOficio);
            Controls.Add(txtApellido);
            Controls.Add(txtLocalidad);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmpleadosDepartamentos";
            Text = "Form1EmpleadosDepartamentosAdo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtLocalidad;
        private TextBox txtApellido;
        private TextBox txtOficio;
        private TextBox txtSalario;
        private ComboBox cmbDepartamentos;
        private ListBox lstEmpleados;
        private Button btnInsertarDepartamento;
        private Button btnUpdate;
    }
}
