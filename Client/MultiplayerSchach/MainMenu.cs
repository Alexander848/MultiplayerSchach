using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplayerSchach
{
    public partial class MainMenu : Form
    {
        GameLobby gameLobby;

        public MainMenu()
        {
            InitializeComponent();
            gameLobby = new GameLobby();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_btnCreateGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            gameLobby.Show();
        }
    }
}
