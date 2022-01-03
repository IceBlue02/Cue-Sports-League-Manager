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



namespace _8_Ball_League
{
    
    public partial class Form1 : Form
    {
        bool DEBUG = true;
        List<string> playernames = new List<string>();
        List<float> playerrankings = new List<float>();
        Form2 form2 = new Form2();

        public static string _rp;

        string resourcepath
        {
            get
            {
                return _rp;
            }

            set
            {
                _rp = value;
                setfilepath();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void updateplayerlist() 
        {
            List<int> checked_players = new List<int>();

            for(int i = 0; i < playerlist.CheckedIndices.Count; i++)
            {
                checked_players.Add(playerlist.CheckedIndices[i]);
            }
            
            playerlist.Items.Clear();

            for (int i = 0; i < playernames.Count; i++)
            {
                string player = playernames[i] + " (" + playerrankings[i] + ")";
                playerlist.Items.Add(player);
            }

            for (int i = 0; i < checked_players.Count; i++)
            {
                playerlist.SetItemChecked(checked_players[i], true);
            }

        }

        private string[] splitstring(string line, char splitter)
        {
            List<string> ans = new List<string>();

            for(int i = 0; i < line.Length; i++)
            {
                
                if (line[i] == splitter)
                {
                    string part1 = line.Substring(0, i);
                    string part2 = line.Substring(i+1, line.Length-i-1);
                    ans.Add(part1);
                    ans.Add(part2);
                    break;
                }

            }

            return ans.ToArray();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (DEBUG)
            {
                // If debugging, autoload a ranking file and check the first 8 players
                filepathbox.Text = "D:\\Documents\\git\\cuesports\\data\\local\\rank\\rankings_test.txt"; 
                updatelist();
                for (int i = 0; i < 8; i++)
                {
                    playerlist.SetItemChecked(i, true);
                }
            }
            
            /*string path = Directory.GetCurrentDirectory();
            path += "\\Resources";
            //if(!Directory.Exists(path))
            string file = path + "\\test1.txt";

            resourcepath = file;*/


        }

        private void Addplayerbutton_Click(object sender, EventArgs e)
        {

            if (Newplayername.Text != "")
            {
                float newranking = 50;
                float.TryParse(newplayerranking.Text, out newranking);
                playernames.Add(Newplayername.Text);
                playerrankings.Add(newranking);

                Newplayername.Text = "";

                updateplayerlist();
            }

        }

        private void Removeplayerbutton_Click(object sender, EventArgs e)
        {
            int index = playerlist.SelectedIndex;
            
            if (index > -1 && index < playernames.Count)
            {
                playernames.RemoveAt(index);
                playerrankings.RemoveAt(index);

                updateplayerlist();
            }

        }

        private void Beginbutton_Click(object sender, EventArgs e)
        {
        if(filepathbox.Text == "")
            {
                string message = "File path required.";
                string caption = "";

                MessageBox.Show(message, caption, MessageBoxButtons.OK);
                return;
            }

        if(playerlist.CheckedIndices.Count == 0)
            {

                string message = "No players selected.";
                string caption = "";

                MessageBox.Show(message, caption, MessageBoxButtons.OK);
                return;

            }
            
            if (form2.IsDisposed)
            {
                form2 = new Form2();
                form2.form1 = this;
            }

            if (!form2.Visible)
            {
                form2.form1 = this;

                form2.Visible = true;
                List<string> selplay = new List<string>();
                List<float> selrank = new List<float>();
                
               for (int i = 0; i < playerlist.CheckedIndices.Count; i++)
                {
                    selplay.Add(playernames[playerlist.CheckedIndices[i]]);
                    selrank.Add(playerrankings[playerlist.CheckedIndices[i]]);
                }

                form2.init(selplay, selrank, playernames, playerrankings);


                //form2.init(playernames, playerrankings);
            }

        }

        private void button1_Click(object sender, EventArgs e) //browse button
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                string path = Directory.GetCurrentDirectory();
                //path += "\\Resources";
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    resourcepath = filePath;

                    updatelist();
                }

            }

        }

        private void setfilepath()
        {
            filepathbox.Text = resourcepath;
        }

        private void filepathbox_TextChanged(object sender, EventArgs e)
        {
            resourcepath = filepathbox.Text;
        }

        private void updateplstbutton_Click(object sender, EventArgs e)
        {
            updatelist();
            
        }

        private void playerlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Selectallbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < playerlist.Items.Count; i ++)
            {
                playerlist.SetItemChecked(i, true);
            }
        }
    
        public List<string> getplayerlist_names ()
        {
           
                List<string> selplay = new List<string>();
                //List<float> selrank = new List<float>();

                for (int i = 0; i < playerlist.CheckedIndices.Count; i++)
                {
                    selplay.Add(playernames[playerlist.CheckedIndices[i]]);
                    //selrank.Add(playerrankings[playerlist.CheckedIndices[i]]);
                }

                /*
                if (selplay.Count % 2 != 0)
                {
                    selplay.Add("Bye");
                    //selrank.Add(0);
                }
                */

            return selplay;

                //form2.init(playernames, playerrankings);
            
        }

        public List<float> getplayerlist_rank()
        {

            //List<string> selplay = new List<string>();
            List<float> selrank = new List<float>();

            for (int i = 0; i < playerlist.CheckedIndices.Count; i++)
            {
                //selplay.Add(playernames[playerlist.CheckedIndices[i]]);
                selrank.Add(playerrankings[playerlist.CheckedIndices[i]]);
            }

           

            return selrank;

            //form2.init(playernames, playerrankings);

        }

        private void updatelist()
        {

            if (File.Exists(resourcepath))
            {
                playernames.Clear();
                playerrankings.Clear();

                string[] lines = File.ReadAllLines(resourcepath);

                foreach (string line in lines)
                {
                    string[] parts = splitstring(line, ',');
                    playernames.Add(parts[0]);
                    float rank = 0;
                    float.TryParse(parts[1], out rank);
                    playerrankings.Add(rank);
                }

                updateplayerlist();
            }

        }
    }


}
