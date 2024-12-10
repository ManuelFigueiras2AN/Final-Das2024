using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            ConfigurarVideo();
        }

        private void ConfigurarVideo()
        {
            string videoPath = "C:\\Users\\Ente\\source\\repos\\Final-Das2024\\Final_DAS2024\\Vista\\Properties\\Resources\\Videos\\fondo.mp4"; // Asegúrate de colocar la ruta correcta del video

            // Reproduce el video en el fondo
            mdp_Background.URL = videoPath;
            mdp_Background.Ctlcontrols.play();
            mdp_Background.settings.setMode("loop", true);  // Opcional: Hacer que el video se repita en bucle
            mdp_Background.uiMode = "None";
            
            // Poner el control de video en segundo plano
            mdp_Background.SendToBack();
        }
    }
}
