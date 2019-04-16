using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GokkersApp
{
    
    public partial class mainForm : Form
    {
       
        public TeamListForm teamListForm = new TeamListForm();
        ServerConnection server = new ServerConnection();
        public bool logedIn;
        Team[] storedTeams =
        {

        };
        public List<Team> teams = new List<Team>();
        public TeamSaveObject teamSave;
        Team team0 = new Team("FluffyBears",true);
        Team team1 = new Team("RoughChickens", true);
        
        Team lastSelectedTeam;
        public mainForm()
        {
            InitializeComponent();
            InitalizeBaseTeams();
            teams.Add(team0);
            teams.Add(team1);
            teamSave = new TeamSaveObject("Cyborg", teams);
            teamListForm.saveObject = teamSave;
        }
        void InitalizeBaseTeams()
        {
            Player player0 = new Player("James");
            Player player1 = new Player("Tom");
            Player player2 = new Player("Eric");
            team0.addPlayer(player0,player1,player2);

            Player player3 = new Player("James");
            Player player4 = new Player("Tom");
            Player player5 = new Player("Eric");
            team1.addPlayer(player3, player4, player5);


        

        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if(!logedIn)
            {
                AccountForm accountForm = new AccountForm();
                accountForm.ShowDialog();
                if(accountForm.DialogResult !=DialogResult.OK)
                {
                    MessageBox.Show("Okay!");
                    server = accountForm.testConnection;
                    MessageBox.Show("Welcome "+ server.activeUserName+ "!!!");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void teamsMenuButton_Click(object sender, EventArgs e)
        {
            
            teamListForm.Show();
            if(teamListForm.DialogResult != DialogResult.OK)
            {
                MessageBox.Show("Good.");
                
                teamSave = teamListForm.saveObject;
                
                teams.Clear();
                for (int i = 0; i < teamSave.currentTeams.Count; i++)
                {
                    teams.Add(teamSave.currentTeams[i]);
                    MessageBox.Show(teams[i].teamName.ToString());
                }
                
            }
        }
    }
}
