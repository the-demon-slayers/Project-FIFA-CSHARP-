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
        ServerConnection server = new ServerConnection();
        public bool logedIn;
        public mainForm()
        {
            InitializeComponent();
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
                    MessageBox.Show(server.databaseName);
                }
            }
        }
    }
}
