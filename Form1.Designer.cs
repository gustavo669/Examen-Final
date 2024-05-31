namespace Examen_Final.Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Genero = new System.Windows.Forms.TextBox();
            this.Plataforma = new System.Windows.Forms.TextBox();
            this.FechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.Disponible = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.SystemColors.Desktop;
            this.Nombre.Font = new System.Drawing.Font("Lucky Coffee", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.White;
            this.Nombre.Location = new System.Drawing.Point(121, 77);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(184, 27);
            this.Nombre.TabIndex = 0;
            // 
            // Genero
            // 
            this.Genero.BackColor = System.Drawing.SystemColors.Desktop;
            this.Genero.Font = new System.Drawing.Font("Lucky Coffee", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genero.ForeColor = System.Drawing.Color.White;
            this.Genero.Location = new System.Drawing.Point(311, 77);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(176, 27);
            this.Genero.TabIndex = 1;
            // 
            // Plataforma
            // 
            this.Plataforma.BackColor = System.Drawing.SystemColors.Desktop;
            this.Plataforma.Font = new System.Drawing.Font("Lucky Coffee", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plataforma.ForeColor = System.Drawing.Color.White;
            this.Plataforma.Location = new System.Drawing.Point(493, 77);
            this.Plataforma.Name = "Plataforma";
            this.Plataforma.Size = new System.Drawing.Size(190, 27);
            this.Plataforma.TabIndex = 2;
            // 
            // FechaLanzamiento
            // 
            this.FechaLanzamiento.CalendarMonthBackground = System.Drawing.Color.Black;
            this.FechaLanzamiento.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FechaLanzamiento.CausesValidation = false;
            this.FechaLanzamiento.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLanzamiento.Location = new System.Drawing.Point(221, 145);
            this.FechaLanzamiento.Name = "FechaLanzamiento";
            this.FechaLanzamiento.Size = new System.Drawing.Size(221, 24);
            this.FechaLanzamiento.TabIndex = 4;
            this.FechaLanzamiento.Validated += new System.EventHandler(this.Form1_Load);
            // 
            // Disponible
            // 
            this.Disponible.AutoSize = true;
            this.Disponible.BackColor = System.Drawing.Color.White;
            this.Disponible.Font = new System.Drawing.Font("Lucky Coffee", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disponible.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Disponible.Location = new System.Drawing.Point(295, 42);
            this.Disponible.Name = "Disponible";
            this.Disponible.Size = new System.Drawing.Size(56, 18);
            this.Disponible.TabIndex = 5;
            this.Disponible.Text = "Activo";
            this.Disponible.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Font = new System.Drawing.Font("Vladimir Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Lime;
            this.btnAgregar.Location = new System.Drawing.Point(241, 224);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(149, 55);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnLeer.Font = new System.Drawing.Font("Vladimir Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeer.ForeColor = System.Drawing.Color.White;
            this.btnLeer.Location = new System.Drawing.Point(80, 224);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(149, 55);
            this.btnLeer.TabIndex = 7;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnActualizar.Font = new System.Drawing.Font("Vladimir Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Cyan;
            this.btnActualizar.Location = new System.Drawing.Point(398, 223);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(149, 55);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Font = new System.Drawing.Font("Vladimir Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(556, 223);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 55);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 138);
            this.dataGridView1.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.SystemColors.Menu;
            this.ID.Font = new System.Drawing.Font("Lucky Coffee", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(181, 37);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(48, 27);
            this.ID.TabIndex = 13;
            this.ID.TextChanged += new System.EventHandler(this.Form1_Load);
            this.ID.VisibleChanged += new System.EventHandler(this.Form1_Load);
            this.ID.Enter += new System.EventHandler(this.Form1_Load);
            this.ID.Validated += new System.EventHandler(this.Form1_Load);
            // 
            // Precio
            // 
            this.Precio.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio.Location = new System.Drawing.Point(483, 145);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(120, 21);
            this.Precio.TabIndex = 14;
            this.Precio.ValueChanged += new System.EventHandler(this.Form1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(539, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Plataforma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Disponible";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Fecha de Lanzamieto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(514, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "Precio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.Disponible);
            this.Controls.Add(this.FechaLanzamiento);
            this.Controls.Add(this.Plataforma);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.Nombre);
            this.DoubleBuffered = true;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Form1";
            this.Text = "Animes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.btnAgregar_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Genero;
        private System.Windows.Forms.TextBox Plataforma;
        private System.Windows.Forms.DateTimePicker FechaLanzamiento;
        private System.Windows.Forms.CheckBox Disponible;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.NumericUpDown Precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

