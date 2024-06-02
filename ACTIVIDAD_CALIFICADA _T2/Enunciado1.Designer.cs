namespace ACTIVIDAD_CALIFICADA__T2
{
    partial class Enunciado1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnAscendente = new System.Windows.Forms.Button();
            this.btnDescendente = new System.Windows.Forms.Button();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Número:";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(261, 33);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(100, 22);
            this.tbNumero.TabIndex = 1;
            this.tbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(391, 33);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnAscendente
            // 
            this.btnAscendente.Location = new System.Drawing.Point(324, 123);
            this.btnAscendente.Name = "btnAscendente";
            this.btnAscendente.Size = new System.Drawing.Size(253, 23);
            this.btnAscendente.TabIndex = 4;
            this.btnAscendente.Text = "Ordenar de forma ascendente";
            this.btnAscendente.UseVisualStyleBackColor = true;
            this.btnAscendente.Click += new System.EventHandler(this.btnAscendente_Click);
            // 
            // btnDescendente
            // 
            this.btnDescendente.Location = new System.Drawing.Point(324, 164);
            this.btnDescendente.Name = "btnDescendente";
            this.btnDescendente.Size = new System.Drawing.Size(253, 23);
            this.btnDescendente.TabIndex = 5;
            this.btnDescendente.Text = "Ordenar de forma descendente";
            this.btnDescendente.UseVisualStyleBackColor = true;
            this.btnDescendente.Click += new System.EventHandler(this.btnDescendente_Click);
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.ItemHeight = 16;
            this.lbLista.Location = new System.Drawing.Point(101, 114);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(194, 388);
            this.lbLista.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar:";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(380, 264);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(100, 22);
            this.tbBuscar.TabIndex = 8;
            this.tbBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(486, 264);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 31);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Número :";
            // 
            // tbNumEliminar
            // 
            this.tbNumEliminar.Location = new System.Drawing.Point(392, 363);
            this.tbNumEliminar.Name = "tbNumEliminar";
            this.tbNumEliminar.Size = new System.Drawing.Size(100, 22);
            this.tbNumEliminar.TabIndex = 11;
            this.tbNumEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumEliminar_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(498, 363);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(79, 28);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Enunciado1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 624);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.tbNumEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.btnDescendente);
            this.Controls.Add(this.btnAscendente);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.label1);
            this.Name = "Enunciado1";
            this.Text = "Enunciado1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnAscendente;
        private System.Windows.Forms.Button btnDescendente;
        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNumEliminar;
        private System.Windows.Forms.Button btnEliminar;
    }
}