using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class backGround : Form
    {
        public backGround()
        {
            InitializeComponent();
            text.Visible = false;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
          
            
           
           playButton.Visible = false;
           text.Visible = true;

            text.Text = "3";

            Refresh();
            Thread.Sleep(1000);

            text.Text = "2";

            Refresh();
            Thread.Sleep(1000);

            text.Text = "1";

            Refresh();
            Thread.Sleep(1000);
           
            text.Text = "Go";

            Refresh();
            Thread.Sleep(1000);

            text.Visible=false;

            SoundPlayer player = new SoundPlayer(Properties.Resources.sword2);
            player.Play();
            
            Refresh();
            Thread.Sleep(1000);
            
            playButton.Visible=true;
            Refresh(); 
        }





    }
}
