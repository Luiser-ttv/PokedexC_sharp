using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_sharp
{
    
    public partial class buscaPokemon : Form
    {
        Conexion miConexion = new Conexion();
        DataTable pokemonPorNombre = new DataTable();
        VentanaPrincipal VP = new VentanaPrincipal();
        private TextBox nombrePokemones;
        private Label label1;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
        private VentanaPrincipal mainForm = null;
        public buscaPokemon(Form callingForm)
        {
            mainForm = callingForm as VentanaPrincipal;
            InitializeComponent();

            ///
            ///labels transparentes
            ///
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            String nombrePokemon = nombrePokemones.Text;
            pokemonPorNombre = miConexion.getPokemonPorNombre(nombrePokemon);
            if (pokemonPorNombre.Rows.Count == 0)
            {
                label2.Text = "El Pokemon escrito no existe, por favor intentalo de nuevo";
            }
            else
            {
                VentanaPrincipal.idActual = int.Parse(pokemonPorNombre.Rows[0]["id"].ToString());
                this.mainForm.setPokemonInfo(VentanaPrincipal.idActual);
                this.Hide();
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscaPokemon));
            this.nombrePokemones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombrePokemones
            // 
            this.nombrePokemones.Location = new System.Drawing.Point(12, 111);
            this.nombrePokemones.Name = "nombrePokemones";
            this.nombrePokemones.Size = new System.Drawing.Size(190, 20);
            this.nombrePokemones.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(12, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Busca";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 447);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buscaPokemon
            // 
            this.ClientSize = new System.Drawing.Size(324, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombrePokemones);
            this.Controls.Add(this.pictureBox1);
            this.Name = "buscaPokemon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}