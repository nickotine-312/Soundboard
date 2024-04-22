using WMPLib;
using System.Diagnostics; //TODO: Remove when done debugging
namespace Soundboard
{
    public partial class Form1 : Form
    {
        public WMPLib.WindowsMediaPlayer wplayer1;
        public WMPLib.WindowsMediaPlayer wplayer2;
        public WMPLib.WindowsMediaPlayer wplayer3;
        public WMPLib.WindowsMediaPlayer wplayer4;
        public WMPLib.WindowsMediaPlayer wplayer5;
        public WMPLib.WindowsMediaPlayer wplayer6;
        public WMPLib.WindowsMediaPlayer wplayer7;
        public WMPLib.WindowsMediaPlayer wplayer8;
        private List<SoundFile> soundDefaults = new List<SoundFile>();

        public Form1()
        {
            InitializeComponent();

            //Initialize all players here, so they are not re-created on each button click.
            wplayer1 = new WMPLib.WindowsMediaPlayer();
            wplayer2 = new WMPLib.WindowsMediaPlayer();
            wplayer3 = new WMPLib.WindowsMediaPlayer();
            wplayer4 = new WMPLib.WindowsMediaPlayer();
            wplayer5 = new WMPLib.WindowsMediaPlayer();
            wplayer6 = new WMPLib.WindowsMediaPlayer();
            wplayer7 = new WMPLib.WindowsMediaPlayer();
            wplayer8 = new WMPLib.WindowsMediaPlayer();

            #region populate default sound objects, and related dropdown boxes.
            //Populate the soundDefaults list with each file found in Sounds
            string[] soundFiles = Directory.GetFiles(@"Sounds\");
            foreach (string sound in soundFiles)
            {
                if (sound.Contains(".jpg")) { continue; }

                string displayName = sound.Replace(@"Sounds\", "");
                displayName = displayName.Substring(0, displayName.IndexOf('.'));
                soundDefaults.Add(new SoundFile(sound, displayName));
            }

            //Grab only the display names, and populate the dropdowns.
            List<String> fileNames = new List<String>();
            foreach (SoundFile file in soundDefaults)
            {
                fileNames.Add(file.getDisplayName());
            }
            List<String> fnameDupe = fileNames.ToList();

            //We call .ToList() to create a copy each time. Using the same object caused duplicate event issues.
            this.btn1SoundSelectBox.DataSource = fileNames.ToList();
            this.btn1SoundSelectBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.btn2SoundSelectBox.DataSource = fileNames.ToList();
            this.btn2SoundSelectBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.btn3SoundSelectBox.DataSource = fileNames.ToList();
            this.btn3SoundSelectBox.DropDownStyle = ComboBoxStyle.DropDownList;
            #endregion

            //List of various ideas here:
            //TODO: Add a button to toggle looping for each soundboard button.
            //TODO: Add a series of dropdowns (or a new form?) allowing the user to select different files.
            //TODO: Do we order the code by object type (all clicks grouped together) or source (all button1 methods grouped together.)
            //TODO: have a "scene selector" dropdown which can autopopulate each button with a predefined set of stuff
            //TODO: Have a custom scene creator that adds different scenes to the list. 
            //TODO: Dropdown for selectin background image (or toolbar option?)
        }

        private void button1_Click(object sender, EventArgs e)
        {

            WMPPlayState isPlaying = wplayer1.playState;
            Debug.WriteLine("playstate is " + isPlaying);

            if (isPlaying.Equals(WMPPlayState.wmppsPlaying))
            {
                wplayer1.controls.stop();
            }
            else
            {
                wplayer1.controls.play();
                wplayer1.settings.setMode("loop", true); //TODO: fix stutter step on first loop. 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WMPPlayState isPlaying = wplayer2.playState;
            Debug.WriteLine("playstate is " + isPlaying);

            if (isPlaying.Equals(WMPPlayState.wmppsPlaying))
            {
                wplayer2.controls.stop();
            }
            else
            {
                wplayer2.controls.play();
                wplayer2.settings.setMode("loop", true); //TODO: fix stutter step on first loop. 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WMPPlayState isPlaying = wplayer3.playState;
            Debug.WriteLine("playstate is " + isPlaying);

            if (isPlaying.Equals(WMPPlayState.wmppsPlaying))
            {
                wplayer3.controls.stop();
            }
            else
            {
                wplayer3.controls.play();
                wplayer3.settings.setMode("loop", true); //TODO: fix stutter step on first loop. 
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            wplayer1.settings.volume = trackBar1.Value;
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            wplayer2.settings.volume = trackBar2.Value;
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            wplayer3.settings.volume = trackBar3.Value;
        }


        private void btn1SoundSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newFileName = soundDefaults.Find(soundFile => soundFile.getDisplayName().Equals(btn1SoundSelectBox.Text)).getFilePath();
            Debug.WriteLine("New file path 1 is " + newFileName);

            //Update the file for button 1 and also update the text of the button to reflect this change. 
            wplayer1.URL = newFileName;
            button1.Text = btn1SoundSelectBox.Text;
            wplayer1.controls.stop();
        }
        private void btn2SoundSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newFileName = soundDefaults.Find(soundFile => soundFile.getDisplayName().Equals(btn2SoundSelectBox.Text)).getFilePath();
            Debug.WriteLine("New file path 2 is " + newFileName);

            //Update the file for button 2 and also update the text of the button to reflect this change. 
            wplayer2.URL = newFileName;
            button2.Text = btn2SoundSelectBox.Text;
            wplayer2.controls.stop();
        }
        private void btn3SoundSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newFileName = soundDefaults.Find(soundFile => soundFile.getDisplayName().Equals(btn3SoundSelectBox.Text)).getFilePath();
            Debug.WriteLine("New file path 3 is " + newFileName);

            //Update the file for button 3 and also update the text of the button to reflect this change. 
            wplayer3.URL = newFileName;
            button3.Text = btn3SoundSelectBox.Text;
            wplayer3.controls.stop();
        }

        private class SoundFile(string fpath, string dname)
        {
            private string fullFilePath = fpath;
            private string displayName = dname;

            //We do not provide setters, as each value is known at creation, and will not change. 
            public string getFilePath()
            {
                return fullFilePath;
            }
            public string getDisplayName()
            {
                return displayName;
            }

        }


    }
}
