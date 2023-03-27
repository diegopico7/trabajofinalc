namespace TP7PicoDiego
{
    partial class Form1
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.chkCasado = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(613, 303);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(759, 303);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(668, 110);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(214, 20);
            this.txtNombreCompleto.TabIndex = 2;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(659, 147);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 3;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(659, 245);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 5;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(659, 185);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 7;
            // 
            // chkCasado
            // 
            this.chkCasado.AutoSize = true;
            this.chkCasado.Location = new System.Drawing.Point(659, 211);
            this.chkCasado.Name = "chkCasado";
            this.chkCasado.Size = new System.Drawing.Size(62, 17);
            this.chkCasado.TabIndex = 8;
            this.chkCasado.Text = "Casado";
            this.chkCasado.UseVisualStyleBackColor = true;
            this.chkCasado.CheckedChanged += new System.EventHandler(this.chkCasado_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(668, 84);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(37, 20);
            this.txtID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre Completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Edad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Salario:";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 25);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(559, 312);
            this.dgvEmpleados.TabIndex = 15;
            this.dgvEmpleados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(627, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 27);
            this.label6.TabIndex = 16;
            this.label6.Text = "Registro Empleados";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.chkCasado);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.CheckBox chkCasado;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label label6;
    }
}

