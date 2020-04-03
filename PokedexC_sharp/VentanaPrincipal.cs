using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_sharp
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        DataTable pokemonPorNombre = new DataTable();

        public static int idActual = 1;
        public VentanaPrincipal()
        {
            InitializeComponent();
            setPokemonInfo(1);
            pokemonPorNombre = miConexion.getPokemonPorNombre("Bulbasaur");
            Console.WriteLine(pokemonPorNombre.Rows[0]["id"].ToString());

            nombrePokemon.Parent = pictureBox1;
            nombrePokemon.BackColor = Color.Transparent;
        }

        private void boton_izq_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual <= 0) idActual = 151;

            setPokemonInfo(idActual);
        }

        private void boton_der_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 152) idActual = 1;

            setPokemonInfo(idActual);
        }

        private Image convierteBlobImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        
        public void setPokemonInfo(int id)
        {
            misPokemons = miConexion.getPokemonPorId(id);
            nombrePokemon.Text = "Nombre: " + misPokemons.Rows[0]["nombre"].ToString();
            numPokedex.Text = "Numero de Pokedex: " + misPokemons.Rows[0]["id"].ToString() + "º";         
            alturaPokemon.Text = "Altura: " + misPokemons.Rows[0]["altura"].ToString() + " m";
            pesoPokemon.Text = "Peso: " + misPokemons.Rows[0]["peso"].ToString() + " kg";
            especiePokemon.Text = "Especie: " + misPokemons.Rows[0]["especie"].ToString();
            habitatPokemon.Text = "Habitat: " + misPokemons.Rows[0]["habitat"].ToString();
            tipoPokemon.Text = "Tipo: " + misPokemons.Rows[0]["tipo1"].ToString() + (!"".Equals(misPokemons.Rows[0]["tipo2"].ToString()) ? (" / " + misPokemons.Rows[0]["tipo2"].ToString()) : "");
            habilidadPokemon.Text = "Habilidad: " + misPokemons.Rows[0]["habilidad"].ToString();

            String movimiento = misPokemons.Rows[0]["movimiento1"].ToString();

            for (int i = 2; i < 5; i++)
            {
                movimiento += !"".Equals(misPokemons.Rows[0]["movimiento" + i].ToString()) ? (" / " + misPokemons.Rows[0]["movimiento" + i].ToString()) : "";
            }

            movimientoPokemon.Text = "Movimientos: " + movimiento;

            fotoPokemon.Image = convierteBlobImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void pesoPokemon_Click(object sender, EventArgs e)
        {

        }

        private void especiePokemon_Click(object sender, EventArgs e)
        {

        }

        private void nombrePokemon_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            buscaPokemon ventana = new buscaPokemon(this);
            ventana.Show();
        }

        
    }
}
