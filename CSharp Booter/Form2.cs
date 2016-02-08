using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Booter {
    public partial class Form2 : Form {

        public Form2()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Program.formInstance.StartPosition = FormStartPosition.Manual;
            Program.formInstance.Location = this.Location;

            this.Close();
        }

        private void btn_add_Click( object sender, EventArgs e )
        {
            if( textBox1.Text.Length > 0 && textBox2.Text.Length > 0 ) {
                listView1.Items.Add( textBox1.Text ).SubItems.Add( textBox2.Text );
            }
        }

        private void btn_remove_Click( object sender, EventArgs e )
        {
            foreach( ListViewItem item in listView1.SelectedItems ) {
                listView1.Items.Remove( item );
            }
        }

        private void btn_set_Click( object sender, EventArgs e )
        {
            if( listView1.SelectedItems.Count != 1 )
                return;

            Program.formInstance.setIP( listView1.SelectedItems[0].SubItems[1].Text );

            Program.formInstance.StartPosition = FormStartPosition.Manual;
            Program.formInstance.Location = this.Location;
            this.Close();
        }

        private void Form2_Load( object sender, EventArgs e )
        {
            loadItems();
        }

        private void Form2_FormClosing( object sender, FormClosingEventArgs e )
        {
            saveItems();
        }

        // LISTVIEW MANIPULATION
        private void loadItems()
        {
            string content;
            try {
                content = File.ReadAllText( Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\IPList.cfg" );
            }catch( Exception e ) { return; }

            string[] lines = content.Split( Char.Parse( "\n" ) ); //includes last line which is whitespace

            for( int i = 0; i < (lines.Length-1); i++ ) { // compensating for last line
                string[] line = lines[i].Split( Char.Parse( " " ) );
                if( line.Length == 2 )
                    listView1.Items.Add( line[0] ).SubItems.Add( line[1] );
            }
            
        }

        private void saveItems()
        {
            if( listView1.Items.Count <= 0 )
                return;

            using( var tw = new StreamWriter( "IPList.cfg" ) ) {
                foreach( ListViewItem item in listView1.Items ) {
                    tw.Write( item.Text + " " + item.SubItems[1].Text + Char.Parse( "\n" ) );
                }
                tw.Close();
            }
        }
    }
}
