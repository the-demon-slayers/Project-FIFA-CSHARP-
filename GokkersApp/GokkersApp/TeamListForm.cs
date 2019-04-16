using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
namespace GokkersApp
{
    public partial class TeamListForm : Form
    {
        string teamDB = "CrazyKitten\n";
        List<Team> allTeams = new List<Team>();
        public TeamSaveObject saveObject = new TeamSaveObject();
        public TeamListForm()
        {
           
            InitializeComponent();
        }
        void LoadTeamData()
        {
            bool fileExists;
            try
            {
                FileStream fs = new FileStream("Null", FileMode.OpenOrCreate);
                try
                {
                    fs = File.Open("teamDB.gok", FileMode.Open);
                    fileExists = true;
                }
                catch(FileNotFoundException)
                {
                    fileExists = false;
                }

                StreamWriter writer = new StreamWriter(fs);
                StreamReader reader = new StreamReader(fs);
                JsonWriter jsonWriter = new JsonTextWriter(writer);
                
                JsonSerializer serializer = new JsonSerializer();
                jsonWriter.Formatting = Formatting.Indented;
                if (fileExists)
                {
                    JsonReader jsonReader = new JsonTextReader(reader);
                    saveObject = serializer.Deserialize<TeamSaveObject>(jsonReader);
                    MessageBox.Show(saveObject.ToString() + saveObject.points.ToString());

                }
                else
                {
                    serializer.Serialize(jsonWriter, saveObject);
                }
                jsonWriter.Close();
            }
            catch (IOException err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void TeamListForm_Load(object sender, EventArgs e)
        {
            LoadTeamData();
        }
    }
}
