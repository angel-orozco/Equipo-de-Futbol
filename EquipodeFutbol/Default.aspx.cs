using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Newtonsoft.Json;

namespace EquipodeFutbol
{
    public partial class _Default : Page
    {
        static List<Jugadores> Jugador = new List<Jugadores>();
        static List<Equipo> Equipos = new List<Equipo>();
        static List<Equipo> Equipos2 = new List<Equipo>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Equipos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            Equipos2 = JsonConvert.DeserializeObject<List<Equipo>>(json);
            GridView1.DataSource = Equipos2;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Equipo team = new Equipo();
            team.Ciudad = TextBox2.Text;
            TextBox3.Text = "";
            team.NombreEquipo = TextBox1.Text;
            TextBox1.Text = "";
            team.AñoFundacion = Calendar1.SelectedDate;
            team.Jugadores1 = Jugador.ToList();
            Equipos.Add(team);
            GuardarJson();
            Jugador.Clear();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Jugadores player = new Jugadores();
            player.Nombre = TextBox3.Text;
            TextBox3.Text = "";
            Jugador.Add(player);
            
        }
        private void GuardarJson()
        {
            string json = JsonConvert.SerializeObject(Equipos);
            string archivo = Server.MapPath("Equipos.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        private void GuardarJson2()
        {
            string json = JsonConvert.SerializeObject(Equipos2);
            string archivo = Server.MapPath("Equipos.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seleccion = GridView1.SelectedIndex;

            GridView2.DataSource = Equipos2[seleccion].Jugadores1;
            GridView2.DataBind(); 
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int seleccion = GridView1.SelectedIndex;
            for (int i=0; i<1000; i++)
            {
                if(Equipos2[seleccion].Jugadores1[i].Nombre == TextBox4.Text)
                {
                    int donde = i;
                    Equipos2[seleccion].Jugadores1.RemoveAt(donde);
                    GuardarJson2();
                    GridView2.DataSource = Equipos2[seleccion].Jugadores1;
                    GridView2.DataBind();
                    break;
                }
            }
            TextBox4.Text = "";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int seleccion = GridView1.SelectedIndex;
            for (int i = 0; i < 1000; i++)
            {
                if (Equipos2[seleccion].Jugadores1[i].Nombre == TextBox4.Text)
                {
                    int donde = i;
                    Equipos2[seleccion].Jugadores1[donde].Nombre=TextBox5.Text;
                    GuardarJson2();
                    GridView2.DataSource = Equipos2[seleccion].Jugadores1;
                    GridView2.DataBind();
                    break;
                }
            }
            TextBox4.Text = "";
            TextBox5.Text = "";
        }
    }
}