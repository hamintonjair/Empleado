namespace Empleado
{
    partial class GUI_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Principal));
            this.btn_Ok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Mayor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_salarioDos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_edadDos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nombreDos = new System.Windows.Forms.TextBox();
            this.btn_aniadirDos = new System.Windows.Forms.Button();
            this.btn_aniadir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_modNomUno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_modNomDos = new System.Windows.Forms.TextBox();
            this.btn_modificarDos = new System.Windows.Forms.Button();
            this.btn_borrartodo = new System.Windows.Forms.Button();
            this.btn_modificarUno = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_nombreEmpresa = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.btn_agregarEmpresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Ok
            // 
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.Location = new System.Drawing.Point(25, 540);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(78, 34);
            this.btn_Ok.TabIndex = 0;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quien es el mayor?";
            // 
            // txt_Mayor
            // 
            this.txt_Mayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mayor.Location = new System.Drawing.Point(124, 548);
            this.txt_Mayor.Name = "txt_Mayor";
            this.txt_Mayor.Size = new System.Drawing.Size(336, 26);
            this.txt_Mayor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Empleado Uno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Empleado Dos";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(108, 171);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(119, 26);
            this.txt_nombre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Edad:";
            // 
            // txt_edad
            // 
            this.txt_edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edad.Location = new System.Drawing.Point(108, 207);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(36, 26);
            this.txt_edad.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Salario:";
            // 
            // txt_salario
            // 
            this.txt_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salario.Location = new System.Drawing.Point(108, 246);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(62, 26);
            this.txt_salario.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(327, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Salario:";
            // 
            // txt_salarioDos
            // 
            this.txt_salarioDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salarioDos.Location = new System.Drawing.Point(434, 243);
            this.txt_salarioDos.Name = "txt_salarioDos";
            this.txt_salarioDos.Size = new System.Drawing.Size(65, 26);
            this.txt_salarioDos.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(327, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Edad:";
            // 
            // txt_edadDos
            // 
            this.txt_edadDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edadDos.Location = new System.Drawing.Point(434, 204);
            this.txt_edadDos.Name = "txt_edadDos";
            this.txt_edadDos.Size = new System.Drawing.Size(39, 26);
            this.txt_edadDos.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(327, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nombre:";
            // 
            // txt_nombreDos
            // 
            this.txt_nombreDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreDos.Location = new System.Drawing.Point(434, 168);
            this.txt_nombreDos.Name = "txt_nombreDos";
            this.txt_nombreDos.Size = new System.Drawing.Size(116, 26);
            this.txt_nombreDos.TabIndex = 12;
            // 
            // btn_aniadirDos
            // 
            this.btn_aniadirDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aniadirDos.Location = new System.Drawing.Point(318, 294);
            this.btn_aniadirDos.Name = "btn_aniadirDos";
            this.btn_aniadirDos.Size = new System.Drawing.Size(78, 34);
            this.btn_aniadirDos.TabIndex = 19;
            this.btn_aniadirDos.Text = "Añadir";
            this.btn_aniadirDos.UseVisualStyleBackColor = true;
            this.btn_aniadirDos.Click += new System.EventHandler(this.btn_aniadirDos_Click);
            // 
            // btn_aniadir
            // 
            this.btn_aniadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aniadir.Location = new System.Drawing.Point(29, 294);
            this.btn_aniadir.Name = "btn_aniadir";
            this.btn_aniadir.Size = new System.Drawing.Size(78, 34);
            this.btn_aniadir.TabIndex = 20;
            this.btn_aniadir.Text = "Añadir";
            this.btn_aniadir.UseVisualStyleBackColor = true;
            this.btn_aniadir.Click += new System.EventHandler(this.btn_aniadir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Modificar Nombre:";
            // 
            // txt_modNomUno
            // 
            this.txt_modNomUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_modNomUno.Location = new System.Drawing.Point(167, 361);
            this.txt_modNomUno.Name = "txt_modNomUno";
            this.txt_modNomUno.Size = new System.Drawing.Size(97, 26);
            this.txt_modNomUno.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(327, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Modificar Nombre:";
            // 
            // txt_modNomDos
            // 
            this.txt_modNomDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_modNomDos.Location = new System.Drawing.Point(470, 361);
            this.txt_modNomDos.Name = "txt_modNomDos";
            this.txt_modNomDos.Size = new System.Drawing.Size(97, 26);
            this.txt_modNomDos.TabIndex = 23;
            // 
            // btn_modificarDos
            // 
            this.btn_modificarDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarDos.Location = new System.Drawing.Point(330, 411);
            this.btn_modificarDos.Name = "btn_modificarDos";
            this.btn_modificarDos.Size = new System.Drawing.Size(98, 34);
            this.btn_modificarDos.TabIndex = 26;
            this.btn_modificarDos.Text = "Modificar";
            this.btn_modificarDos.UseVisualStyleBackColor = true;
            this.btn_modificarDos.Click += new System.EventHandler(this.btn_modificarDos_Click);
            // 
            // btn_borrartodo
            // 
            this.btn_borrartodo.Location = new System.Drawing.Point(506, 551);
            this.btn_borrartodo.Name = "btn_borrartodo";
            this.btn_borrartodo.Size = new System.Drawing.Size(75, 23);
            this.btn_borrartodo.TabIndex = 27;
            this.btn_borrartodo.Text = "Borrar";
            this.btn_borrartodo.UseVisualStyleBackColor = true;
            this.btn_borrartodo.Click += new System.EventHandler(this.btn_borrartodo_Click);
            // 
            // btn_modificarUno
            // 
            this.btn_modificarUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarUno.Location = new System.Drawing.Point(28, 402);
            this.btn_modificarUno.Name = "btn_modificarUno";
            this.btn_modificarUno.Size = new System.Drawing.Size(98, 34);
            this.btn_modificarUno.TabIndex = 28;
            this.btn_modificarUno.Text = "Modificar";
            this.btn_modificarUno.UseVisualStyleBackColor = true;
            this.btn_modificarUno.Click += new System.EventHandler(this.btn_modificarUno_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(351, 29);
            this.label12.TabIndex = 29;
            this.label12.Text = "Digite el nombre de la empresa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 29);
            this.label13.TabIndex = 30;
            this.label13.Text = "Dirección";
            // 
            // txt_nombreEmpresa
            // 
            this.txt_nombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreEmpresa.Location = new System.Drawing.Point(395, 13);
            this.txt_nombreEmpresa.Name = "txt_nombreEmpresa";
            this.txt_nombreEmpresa.Size = new System.Drawing.Size(172, 26);
            this.txt_nombreEmpresa.TabIndex = 31;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion.Location = new System.Drawing.Point(395, 56);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(172, 26);
            this.txt_Direccion.TabIndex = 32;
            // 
            // btn_agregarEmpresa
            // 
            this.btn_agregarEmpresa.Location = new System.Drawing.Point(29, 465);
            this.btn_agregarEmpresa.Name = "btn_agregarEmpresa";
            this.btn_agregarEmpresa.Size = new System.Drawing.Size(161, 23);
            this.btn_agregarEmpresa.TabIndex = 33;
            this.btn_agregarEmpresa.Text = "Agregar empresa";
            this.btn_agregarEmpresa.UseVisualStyleBackColor = true;
            this.btn_agregarEmpresa.Click += new System.EventHandler(this.btn_agregarEmpresa_Click);
            // 
            // GUI_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 581);
            this.Controls.Add(this.btn_agregarEmpresa);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_nombreEmpresa);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_modificarUno);
            this.Controls.Add(this.btn_borrartodo);
            this.Controls.Add(this.btn_modificarDos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_modNomDos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_modNomUno);
            this.Controls.Add(this.btn_aniadir);
            this.Controls.Add(this.btn_aniadirDos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_salarioDos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_edadDos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_nombreDos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_salario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Mayor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Ok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUI_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Mayor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_salarioDos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_edadDos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nombreDos;
        private System.Windows.Forms.Button btn_aniadirDos;
        private System.Windows.Forms.Button btn_aniadir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_modNomUno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_modNomDos;
        private System.Windows.Forms.Button btn_modificarDos;
        private System.Windows.Forms.Button btn_borrartodo;
        private System.Windows.Forms.Button btn_modificarUno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_nombreEmpresa;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Button btn_agregarEmpresa;
    }
}

