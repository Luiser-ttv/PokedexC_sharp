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
        private VentanaPrincipal mainForm = null;
        public buscaPokemon(Form callingForm)
        {
            mainForm = callingForm as VentanaPrincipal;
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            String nombrePokemon = nombrePokemones.Text;
            pokemonPorNombre = miConexion.getPokemonPorNombre(nombrePokemon);
            if (pokemonPorNombre.Rows.Count == 0)
            {
                label2.Text = "El Pokemon que ha escrito no existe, por favor intentalo de nuevo";
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
            this.nombrePokemones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombrePokemones
            // 
            this.nombrePokemones.Location = new System.Drawing.Point(84, 49);
            this.nombrePokemones.Name = "nombrePokemones";
            this.nombrePokemones.Size = new System.Drawing.Size(190, 20);
            this.nombrePokemones.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // buscaPokemon
            // 
            this.ClientSize = new System.Drawing.Size(513, 448);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombrePokemones);
            this.Name = "buscaPokemon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}