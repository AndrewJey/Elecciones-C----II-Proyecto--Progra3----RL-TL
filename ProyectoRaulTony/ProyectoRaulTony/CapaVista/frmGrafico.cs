using ProyectoRaulTony.CapaLogica;
using ProyectoRaulTony.estructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoRaulTony.CapaVista
{
    public partial class frmGrafico : Form
    {
        public frmGrafico()
        {
            InitializeComponent();
            creaGrafico();
        }

        private void creaGrafico()
        {
            //metodo que define los diferentes atributos del grafico y los muestra
            CandidatosCL oCandidatoCl = new CandidatosCL();
            List<Candidato> candidatos = oCandidatoCl.ObtenerCandidato();
            List<string> nombresPartidos = new List<string> { };
            nombresPartidos.Add("Nulo");
            List<Int32> votos = new List<int> { };
            votos.Add(0);
            for (int i = 0; i < candidatos.Count(); i++)
            {
                nombresPartidos.Add(candidatos[i].Partidos);
                votos.Add(0);
            }
            VotacionesCL oVotacionesCl = new VotacionesCL();
            List<Votacion> votacion = new List<Votacion> { };
            votacion = oVotacionesCl.ObtenerVotaciones();
            for (int i = 0; i < votacion.Count(); i++)
            {
                for (int j = 0; j < nombresPartidos.Count; j++)
                {
                    if (nombresPartidos[j] == votacion[i].Id)
                    {
                        votos[j] += 1;
                    }
                }
            }

            this.chtGrafico.Palette = ChartColorPalette.EarthTones;

            // Set title.
            this.chtGrafico.Titles.Add("Elecciones Nacionales");

            // Add series.
            for (int i = 0; i < nombresPartidos.Count; i++)
            {
                // Add series.
                Series series = this.chtGrafico.Series.Add(nombresPartidos[i]);

                // Add point.
                series.Points.Add(votos[i]);
            }
        }

        private void btbSalir_Click(object sender, EventArgs e)
        {//metodo que cierra el windowns form
            this.Close();
        }
    }
}
