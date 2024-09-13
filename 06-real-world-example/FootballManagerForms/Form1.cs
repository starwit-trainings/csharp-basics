using FootballManager.entities;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Windows.Forms;
using entities;

namespace FootballManagerForms
{
    public partial class Form1 : Form
    {
        DataFunctions df = new DataFunctions();

        public Form1()
        {
            InitializeComponent();
        }

        // load data
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // figure out, where am I running
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            // load data
            df.LoadData(directory);

            //bind data to GridView
            var bindingList = new BindingList<ClubEntity>(df.Clubs);
            var source = new BindingSource(bindingList, null);
            clubsGridView.DataSource = source;
        }

        // exit program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // show info box
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Window contains versioning information", "Release Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // stuff you want to do on startup
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
