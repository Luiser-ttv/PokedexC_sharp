namespace PokedexC_sharp
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boton_izq = new System.Windows.Forms.Button();
            this.boton_der = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.fotoPokemon = new System.Windows.Forms.PictureBox();
            this.pesoPokemon = new System.Windows.Forms.Label();
            this.alturaPokemon = new System.Windows.Forms.Label();
            this.especiePokemon = new System.Windows.Forms.Label();
            this.habitatPokemon = new System.Windows.Forms.Label();
            this.tipoPokemon = new System.Windows.Forms.Label();
            this.habilidadPokemon = new System.Windows.Forms.Label();
            this.movimientoPokemon = new System.Windows.Forms.Label();
            this.numPokedex = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1020, 647);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // boton_izq
            // 
            this.boton_izq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_izq.Location = new System.Drawing.Point(152, 467);
            this.boton_izq.Name = "boton_izq";
            this.boton_izq.Size = new System.Drawing.Size(38, 23);
            this.boton_izq.TabIndex = 1;
            this.boton_izq.Text = "button1";
            this.boton_izq.UseVisualStyleBackColor = true;
            this.boton_izq.Click += new System.EventHandler(this.boton_izq_Click);
            // 
            // boton_der
            // 
            this.boton_der.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_der.Location = new System.Drawing.Point(217, 467);
            this.boton_der.Name = "boton_der";
            this.boton_der.Size = new System.Drawing.Size(41, 23);
            this.boton_der.TabIndex = 2;
            this.boton_der.Text = "button2";
            this.boton_der.UseVisualStyleBackColor = true;
            this.boton_der.Click += new System.EventHandler(this.boton_der_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.AutoSize = true;
            this.nombrePokemon.Location = new System.Drawing.Point(308, 381);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(35, 13);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.Text = "label1";
            // 
            // fotoPokemon
            // 
            this.fotoPokemon.Location = new System.Drawing.Point(366, 73);
            this.fotoPokemon.Name = "fotoPokemon";
            this.fotoPokemon.Size = new System.Drawing.Size(166, 165);
            this.fotoPokemon.TabIndex = 4;
            this.fotoPokemon.TabStop = false;
            // 
            // pesoPokemon
            // 
            this.pesoPokemon.AutoSize = true;
            this.pesoPokemon.Location = new System.Drawing.Point(308, 413);
            this.pesoPokemon.Name = "pesoPokemon";
            this.pesoPokemon.Size = new System.Drawing.Size(35, 13);
            this.pesoPokemon.TabIndex = 5;
            this.pesoPokemon.Text = "label1";
            // 
            // alturaPokemon
            // 
            this.alturaPokemon.AutoSize = true;
            this.alturaPokemon.Location = new System.Drawing.Point(456, 413);
            this.alturaPokemon.Name = "alturaPokemon";
            this.alturaPokemon.Size = new System.Drawing.Size(35, 13);
            this.alturaPokemon.TabIndex = 6;
            this.alturaPokemon.Text = "label2";
            // 
            // especiePokemon
            // 
            this.especiePokemon.AutoSize = true;
            this.especiePokemon.Location = new System.Drawing.Point(308, 450);
            this.especiePokemon.Name = "especiePokemon";
            this.especiePokemon.Size = new System.Drawing.Size(35, 13);
            this.especiePokemon.TabIndex = 7;
            this.especiePokemon.Text = "label3";
            // 
            // habitatPokemon
            // 
            this.habitatPokemon.AutoSize = true;
            this.habitatPokemon.Location = new System.Drawing.Point(456, 488);
            this.habitatPokemon.Name = "habitatPokemon";
            this.habitatPokemon.Size = new System.Drawing.Size(35, 13);
            this.habitatPokemon.TabIndex = 8;
            this.habitatPokemon.Text = "label4";
            // 
            // tipoPokemon
            // 
            this.tipoPokemon.AutoSize = true;
            this.tipoPokemon.Location = new System.Drawing.Point(308, 488);
            this.tipoPokemon.Name = "tipoPokemon";
            this.tipoPokemon.Size = new System.Drawing.Size(35, 13);
            this.tipoPokemon.TabIndex = 9;
            this.tipoPokemon.Text = "label1";
            // 
            // habilidadPokemon
            // 
            this.habilidadPokemon.AutoSize = true;
            this.habilidadPokemon.Location = new System.Drawing.Point(456, 450);
            this.habilidadPokemon.Name = "habilidadPokemon";
            this.habilidadPokemon.Size = new System.Drawing.Size(35, 13);
            this.habilidadPokemon.TabIndex = 10;
            this.habilidadPokemon.Text = "label1";
            // 
            // movimientoPokemon
            // 
            this.movimientoPokemon.AutoSize = true;
            this.movimientoPokemon.Location = new System.Drawing.Point(308, 525);
            this.movimientoPokemon.Name = "movimientoPokemon";
            this.movimientoPokemon.Size = new System.Drawing.Size(35, 13);
            this.movimientoPokemon.TabIndex = 11;
            this.movimientoPokemon.Text = "label2";
            // 
            // numPokedex
            // 
            this.numPokedex.AutoSize = true;
            this.numPokedex.Location = new System.Drawing.Point(456, 381);
            this.numPokedex.Name = "numPokedex";
            this.numPokedex.Size = new System.Drawing.Size(35, 13);
            this.numPokedex.TabIndex = 12;
            this.numPokedex.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(809, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(189, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "button3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 654);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.numPokedex);
            this.Controls.Add(this.movimientoPokemon);
            this.Controls.Add(this.habilidadPokemon);
            this.Controls.Add(this.tipoPokemon);
            this.Controls.Add(this.habitatPokemon);
            this.Controls.Add(this.especiePokemon);
            this.Controls.Add(this.alturaPokemon);
            this.Controls.Add(this.pesoPokemon);
            this.Controls.Add(this.fotoPokemon);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.boton_der);
            this.Controls.Add(this.boton_izq);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button boton_izq;
        private System.Windows.Forms.Button boton_der;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.PictureBox fotoPokemon;
        private System.Windows.Forms.Label pesoPokemon;
        private System.Windows.Forms.Label alturaPokemon;
        private System.Windows.Forms.Label especiePokemon;
        private System.Windows.Forms.Label habitatPokemon;
        private System.Windows.Forms.Label tipoPokemon;
        private System.Windows.Forms.Label habilidadPokemon;
        private System.Windows.Forms.Label movimientoPokemon;
        private System.Windows.Forms.Label numPokedex;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}

