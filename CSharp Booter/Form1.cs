using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CSharp_Booter
{
    public partial class Form1 : Form
    {
        public bool isEnabled = true;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click( object sender, EventArgs e )
        {
            if( Main.initBrowser() )
                btn_launch.Enabled = true;

            label_status.Text = "Ready!";
        }

        private async void btn_launch_Click( object sender, EventArgs e )
        {
            if( btn_launch.Text.Contains("Stop") ) {
                btn_launch.Text = "Launch";
                isEnabled = false;

                label_status.Text = "Ready!";

                return;
            }

            try {
                Int32.Parse( textBox_time.Text );
            } catch( FormatException ex ){
                label_action.Text = ex.Message;
                label_status.Text = "Time is not a number!";
                return;
            }
            btn_launch.Text = "Stop";

            int times = 0;
            label_status.Text = "Working! Shut down " + times + " times";
            bool ret = await Main.initAttack( textBox_IP.Text, textBox_time.Text );

            while( ret && isEnabled ) {
                times++;
                label_status.Text = "Working! Shut down " + times + " times";
                await Task.Delay( Int32.Parse( textBox_time.Text )*1000 + 10000 );

                Main.driver.Navigate().Refresh();
                ret = await Main.initAttack( textBox_IP.Text, textBox_time.Text );
            }
        }

        private void Form1_FormClosing( object sender, FormClosingEventArgs e )
        {
            Main.exitBrowser();
        }

        private void iPListToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location;

            this.Hide();
            form2.ShowDialog();
            this.Show();

            this.BringToFront();
        }


        // SETTERS
        public void setAction( string action )
        {
            label_action.Text = action;
        }

        public void setIP( string IP ) { textBox_IP.Text = IP; }
    }
}
