using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class WelcomeForm : Form
    {
        public string level;
        public List<Player> players;
        public WelcomeForm()
        {
            InitializeComponent();
            players = new List<Player>();
            level_cb.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void player2_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (player2_cb.Checked)
            {
                player2_tb.Enabled = false;
            }
            else
            {
                player2_tb.Enabled = true;
            }
        }

        private void player3_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (player3_cb.Checked)
            {
                player3_tb.Enabled = false;
            }
            else
            {
                player3_tb.Enabled = true;
            }
        }

        private void start_bt_Click(object sender, EventArgs e)
        {
            players.Add(new Player(true, player1_tb.Text));
            if (player2_cb.Checked) players.Add(new Player(false, "Гравець2"));
            else players.Add(new Player(true, player2_tb.Text));
            if (player3_cb.Checked) players.Add(new Player(false, "Гравець3"));
            else players.Add(new Player(true, player3_tb.Text));
            level = level_cb.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
