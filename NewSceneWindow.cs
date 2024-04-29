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
        //TODO: Iterating on this.Controls.OfType<ComboBox>() does not return a list of combo boxes, for some reason. 
        List<ComboBox> choices;
        public NewSceneWindow(Point startingPoint, List<String> fileNames)
        {
            InitializeComponent();
            choices = new List<ComboBox>();
            this.StartPosition = FormStartPosition.Manual;

            //If the window is fullscreen (or close), reset to the middle of the screen. 
            if(startingPoint.X > Screen.GetBounds(startingPoint).Width * 0.75)
                startingPoint.X = (startingPoint.X / 2);

            this.Location = startingPoint;

            this.choice1.DataSource = fileNames.ToList();
            this.choice1.SelectedItem = null;
            this.choice1.DropDownStyle = ComboBoxStyle.DropDownList;
            choices.Add((ComboBox)this.Controls.Find("choice1", true)[0]);

            this.choice2.DataSource = fileNames.ToList();
            this.choice2.SelectedItem = null;
            this.choice2.DropDownStyle = ComboBoxStyle.DropDownList;
            choices.Add((ComboBox)this.Controls.Find("choice2", true)[0]);

            this.choice3.DataSource = fileNames.ToList();
            this.choice3.SelectedItem = null;
            this.choice3.DropDownStyle = ComboBoxStyle.DropDownList;
            choices.Add((ComboBox)this.Controls.Find("choice3", true)[0]);

            this.choice4.DataSource = fileNames.ToList();
            this.choice4.SelectedItem = null;
            this.choice4.DropDownStyle = ComboBoxStyle.DropDownList;
            choices.Add((ComboBox)this.Controls.Find("choice4", true)[0]);

            this.choice5.DataSource = fileNames.ToList();
            this.choice5.SelectedItem = null;
            this.choice5.DropDownStyle = ComboBoxStyle.DropDownList;
            choices.Add((ComboBox)this.Controls.Find("choice5", true)[0]);

            this.choice6.DataSource = fileNames.ToList();
            this.choice6.SelectedItem = null;
            this.choice6.DropDownStyle = ComboBoxStyle.DropDownList;
            choices.Add((ComboBox)this.Controls.Find("choice6", true)[0]);

            this.choice7.DataSource = fileNames.ToList();
            this.choice7.SelectedItem = null;
            this.choice7.DropDownStyle = ComboBoxStyle.DropDownList;
            choices.Add((ComboBox)this.Controls.Find("choice7", true)[0]);

            this.choice8.DataSource = fileNames.ToList();
            this.choice8.SelectedItem = null;
            this.choice8.DropDownStyle = ComboBoxStyle.DropDownList;
            choices.Add((ComboBox)this.Controls.Find("choice8", true)[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(File.Exists(Path.Combine(@"Scenes\", sceneNameTextBox.Text + ".txt")))
            {
                MessageBox.Show("Scene with name '" + sceneNameTextBox.Text + "' already exists.");
                return;
            }
            else if(sceneNameTextBox.Text.IndexOfAny(Path.GetInvalidFileNameChars()) > 0)
            {
                MessageBox.Show("Invalid characters in scene name.");
                return;
            }

            string filePath = @"Scenes\" + sceneNameTextBox.Text + ".txt";
            List<string> lines = new List<string>();

            foreach(ComboBox box in choices)
                lines.Add(box.Text);

            File.WriteAllLines(filePath, lines);
            Thread.Sleep(300);
            MessageBox.Show("Scene created successfully!");
            this.Close();
        }
    }
}
