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

namespace SuperbowlWinners
{
    public partial class Superbowl : Form
    {
        public Superbowl()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // variables for the array
                string[] superbowlteams = new string[53];

                // declare index
                int index = 0;

                // declare count
                int count = 0;

                // input string
                string team;

                // input file
                StreamReader inputSuperbowl;

                // open the file
                inputSuperbowl = File.OpenText("superbowlresult.txt");

                team = txtSearch.Text;

                // Read the test scores into the array.
                while (!inputSuperbowl.EndOfStream && index < superbowlteams.Length)
                {
                    superbowlteams[index] = inputSuperbowl.ReadLine();
                    index++;
                }

                inputSuperbowl.Close();

                

                for (int i = 0; i < superbowlteams.Length; i++)
                {
                    while (team.Equals(superbowlteams[i].ToString()))
                    {
                        count++;
                        break;
                    }
                }

                txtCount.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closes application
            Application.Exit();
        }

        private void Superbowl_Load(object sender, EventArgs e)
        {
            try
            {
                // Declare a variable to hold a team name.
                string teamName;               
                
                // Declare a StreamReader variable.
                StreamReader inputTeam;                   

                // Open the file and get a StreamReader object.
                inputTeam = File.OpenText("teamnames.txt");

                // Clear anything currently in the ListBox.
                teamsListBox.Items.Clear();
                
                // Read the file's contents.
                while (!inputTeam.EndOfStream)
                {
                    // Get a country name.
                    teamName = inputTeam.ReadLine();

                    // Add the country name to the ListBox.
                    teamsListBox.Items.Add(teamName);
                }

                inputTeam.Close();
            }
            catch (Exception ex)
            {
                // Display Error Message
                MessageBox.Show(ex.Message);
            }
        }
    }
}
