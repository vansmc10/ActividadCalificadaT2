namespace ACTIVIDAD_CALIFICADA__T2
{
    partial class Enunciado2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.lvLista = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRegistro = new System.Windows.Forms.Button();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbNonbreBuscar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lvListaMascota = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRegistroMascota = new System.Windows.Forms.Button();
            this.cbDueño = new System.Windows.Forms.ComboBox();
            this.tbRaza = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbNombreMascota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(987, 595);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lvLista);
            this.tabPage1.Controls.Add(this.btnRegistro);
            this.tabPage1.Controls.Add(this.tbTelefono);
            this.tabPage1.Controls.Add(this.tbDireccion);
            this.tabPage1.Controls.Add(this.tbNombre);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(979, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro Dueño";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "REGISTRO DE DUEÑOS";
            // 
            // lvLista
            // 
            this.lvLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvLista.HideSelection = false;
            this.lvLista.Location = new System.Drawing.Point(149, 293);
            this.lvLista.Name = "lvLista";
            this.lvLista.Size = new System.Drawing.Size(681, 245);
            this.lvLista.TabIndex = 17;
            this.lvLista.UseCompatibleStateImageBehavior = false;
            this.lvLista.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 198;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dirección";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Teléfono";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(683, 221);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(80, 39);
            this.btnRegistro.TabIndex = 16;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(255, 231);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(216, 22);
            this.tbTelefono.TabIndex = 15;
            this.tbTelefono.TextChanged += new System.EventHandler(this.tbTelefono_TextChanged);
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            this.tbTelefono.Leave += new System.EventHandler(this.tbTelefono_Leave);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(255, 174);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(342, 22);
            this.tbDireccion.TabIndex = 14;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(255, 106);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(351, 22);
            this.tbNombre.TabIndex = 13;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dirección :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBuscar);
            this.tabPage2.Controls.Add(this.tbNonbreBuscar);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.lvListaMascota);
            this.tabPage2.Controls.Add(this.btnRegistroMascota);
            this.tabPage2.Controls.Add(this.cbDueño);
            this.tabPage2.Controls.Add(this.tbRaza);
            this.tabPage2.Controls.Add(this.tbEdad);
            this.tabPage2.Controls.Add(this.tbNombreMascota);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(979, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro Mascota";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(588, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbNonbreBuscar
            // 
            this.tbNonbreBuscar.Location = new System.Drawing.Point(179, 66);
            this.tbNonbreBuscar.Name = "tbNonbreBuscar";
            this.tbNonbreBuscar.Size = new System.Drawing.Size(302, 22);
            this.tbNonbreBuscar.TabIndex = 33;
            this.tbNonbreBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNonbreBuscar_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Nombre : ";
            // 
            // lvListaMascota
            // 
            this.lvListaMascota.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvListaMascota.HideSelection = false;
            this.lvListaMascota.Location = new System.Drawing.Point(94, 310);
            this.lvListaMascota.Name = "lvListaMascota";
            this.lvListaMascota.Size = new System.Drawing.Size(836, 214);
            this.lvListaMascota.TabIndex = 31;
            this.lvListaMascota.UseCompatibleStateImageBehavior = false;
            this.lvListaMascota.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nombre";
            this.columnHeader4.Width = 235;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Edad";
            this.columnHeader5.Width = 94;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Raza";
            this.columnHeader6.Width = 163;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Dueño";
            this.columnHeader7.Width = 337;
            // 
            // btnRegistroMascota
            // 
            this.btnRegistroMascota.Location = new System.Drawing.Point(564, 236);
            this.btnRegistroMascota.Name = "btnRegistroMascota";
            this.btnRegistroMascota.Size = new System.Drawing.Size(85, 34);
            this.btnRegistroMascota.TabIndex = 30;
            this.btnRegistroMascota.Text = "Registro";
            this.btnRegistroMascota.UseVisualStyleBackColor = true;
            this.btnRegistroMascota.Click += new System.EventHandler(this.btnRegistroMascota_Click);
            // 
            // cbDueño
            // 
            this.cbDueño.FormattingEnabled = true;
            this.cbDueño.Location = new System.Drawing.Point(621, 150);
            this.cbDueño.Name = "cbDueño";
            this.cbDueño.Size = new System.Drawing.Size(242, 24);
            this.cbDueño.TabIndex = 29;
            // 
            // tbRaza
            // 
            this.tbRaza.Location = new System.Drawing.Point(167, 250);
            this.tbRaza.Name = "tbRaza";
            this.tbRaza.Size = new System.Drawing.Size(86, 22);
            this.tbRaza.TabIndex = 28;
            this.tbRaza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRaza_KeyPress);
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(167, 191);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(86, 22);
            this.tbEdad.TabIndex = 27;
            this.tbEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEdad_KeyPress);
            // 
            // tbNombreMascota
            // 
            this.tbNombreMascota.Location = new System.Drawing.Point(167, 150);
            this.tbNombreMascota.Name = "tbNombreMascota";
            this.tbNombreMascota.Size = new System.Drawing.Size(314, 22);
            this.tbNombreMascota.TabIndex = 26;
            this.tbNombreMascota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombreMascota_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Dueño :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Raza :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Edad :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Nombre :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(297, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(352, 29);
            this.label9.TabIndex = 21;
            this.label9.Text = "REGISTRO DE MASCOTAS";
            // 
            // Enunciado2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 620);
            this.Controls.Add(this.tabControl1);
            this.Name = "Enunciado2";
            this.Text = "Enunciado2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvLista;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvListaMascota;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnRegistroMascota;
        private System.Windows.Forms.ComboBox cbDueño;
        private System.Windows.Forms.TextBox tbRaza;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbNombreMascota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbNonbreBuscar;
        private System.Windows.Forms.Label label10;
    }
}