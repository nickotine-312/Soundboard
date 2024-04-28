using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soundboard
{
    public partial class NewSceneWindow : Form
    {
        public NewSceneWindow(Point startingPoint, List<String> fileNames)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            //If the window is fullscreen (or close), reset to the middle of the screen. 
            if(startingPoint.X > Screen.GetBounds(startingPoint).Width * 0.75)
                startingPoint.X = (startingPoint.X / 2);

            this.Location = startingPoint;

            this.choice1.DataSource = fileNames.ToList();
            this.choice1.SelectedItem = null;
            this.choice1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.choice2.DataSource = fileNames.ToList();
            this.choice2.SelectedItem = null;
            this.choice2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.choice3.DataSource = fileNames.ToList();
            this.choice3.SelectedItem = null;
            this.choice3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.choice4.DataSource = fileNames.ToList();
            this.choice4.SelectedItem = null;
            this.choice4.DropDownStyle = ComboBoxStyle.DropDownList;
            this.choice5.DataSource = fileNames.ToList();
            this.choice5.SelectedItem = null;
            this.choice5.DropDownStyle = ComboBoxStyle.DropDownList;
            this.choice6.DataSource = fileNames.ToList();
            this.choice6.SelectedItem = null;
            this.choice6.DropDownStyle = ComboBoxStyle.DropDownList;
            this.choice7.DataSource = fileNames.ToList();
            this.choice7.SelectedItem = null;
            this.choice7.DropDownStyle = ComboBoxStyle.DropDownList;
            this.choice8.DataSource = fileNames.ToList();
            this.choice8.SelectedItem = null;
            this.choice8.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(File.Exists(Path.Combine(@"Scenes\", sceneNameTextBox.Text + ".txt")))
            {
                //Error window explaining file already eixsts
                Debug.WriteLine("FIle already exists.");
                return;
            }
            else if(sceneNameTextBox.Text.IndexOfAny(Path.GetInvalidFileNameChars()) > 0)
            {
                //Different error window for invalid character
                Debug.WriteLine("Invalid characters found.");
                return;
            }

            Debug.WriteLine("Creating new scene");
            string filePath = @"Scenes\" + sceneNameTextBox.Text + ".txt";
            List<string> lines = new List<string>();

            //TODO: Why does this not iterate through the combo boxes????
            foreach(ComboBox box in Controls.OfType<ComboBox>())
            {
                Debug.WriteLine("BOX " + box.Text);
                lines.Add(box.Text);
            }

            File.WriteAllLines(filePath, lines);

            //Pop up a window saying "Scene added successfully!" 
            //Close this window. 
        }
    }
}
