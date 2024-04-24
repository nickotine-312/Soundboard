using WMPLib;
using System.Windows.Forms.VisualStyles;
using System.Text.RegularExpressions;
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
        public WMPLib.WindowsMediaPlayer wplayer9;
        private Dictionary<string, List<string>> sceneList = new Dictionary<string, List<string>>();
        private Dictionary<string, WMPLib.WindowsMediaPlayer> wPlayerList = new Dictionary<string, WindowsMediaPlayer>();
        private List<SoundFile> soundDefaults = new List<SoundFile>();
        private List<SoundFile> musicDefaults = new List<SoundFile>();
        private string validFileExtensions = @"\.(mp3|wav|m4a|avi)";

        public Form1()
        {
            InitializeComponent();

            //Initialize all players here, set defaults, add to list.
            wplayer1 = new WMPLib.WindowsMediaPlayer(); wplayer1.settings.setMode("loop", true); wPlayerList.Add("wplayer1", wplayer1);
            wplayer2 = new WMPLib.WindowsMediaPlayer(); wplayer2.settings.setMode("loop", true); wPlayerList.Add("wplayer2", wplayer2);
            wplayer3 = new WMPLib.WindowsMediaPlayer(); wplayer3.settings.setMode("loop", true); wPlayerList.Add("wplayer3", wplayer3);
            wplayer4 = new WMPLib.WindowsMediaPlayer(); wplayer4.settings.setMode("loop", true); wPlayerList.Add("wplayer4", wplayer4);
            wplayer5 = new WMPLib.WindowsMediaPlayer(); wplayer5.settings.setMode("loop", true); wPlayerList.Add("wplayer5", wplayer5);
            wplayer6 = new WMPLib.WindowsMediaPlayer(); wplayer6.settings.setMode("loop", true); wPlayerList.Add("wplayer6", wplayer6);
            wplayer7 = new WMPLib.WindowsMediaPlayer(); wplayer7.settings.setMode("loop", true); wPlayerList.Add("wplayer7", wplayer7);
            wplayer8 = new WMPLib.WindowsMediaPlayer(); wplayer8.settings.setMode("loop", true); wPlayerList.Add("wplayer8", wplayer8);
            wplayer9 = new WMPLib.WindowsMediaPlayer(); wplayer9.settings.setMode("loop", true); wPlayerList.Add("wplayer9", wplayer9);

            #region populate default sound, scene, and music objects, and related dropdown boxes.
            //First: Sounds
            string[] soundFiles = Directory.GetFiles(@"Sounds\");
            foreach (string sound in soundFiles)
            {
                if (!Regex.IsMatch(sound, validFileExtensions)) { continue; }

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

            //We call .ToList() to create a copy each time. Using the same object caused duplicate event issues.
            this.btn1SoundSelectBox.DataSource = fileNames.ToList();
            this.btn1SoundSelectBox.SelectedItem = null;
            this.btn1SoundSelectBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.btn2SoundSelectBox.DataSource = fileNames.ToList();
            this.btn2SoundSelectBox.SelectedItem = null;
            this.btn2SoundSelectBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.btn3SoundSelectBox.DataSource = fileNames.ToList();
            this.btn3SoundSelectBox.SelectedItem = null;
            this.btn3SoundSelectBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.btn4SoundSelectBox.DataSource = fileNames.ToList();
            this.btn4SoundSelectBox.SelectedItem = null;
            this.btn4SoundSelectBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.btn5SoundSelectBox.DataSource = fileNames.ToList();
            this.btn5SoundSelectBox.SelectedItem = null;
            this.btn5SoundSelectBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.btn6SoundSelectBox.DataSource = fileNames.ToList();
            this.btn6SoundSelectBox.SelectedItem = null;
            this.btn6SoundSelectBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.btn7SoundSelectBox.DataSource = fileNames.ToList();
            this.btn7SoundSelectBox.SelectedItem = null;
            this.btn7SoundSelectBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.btn8SoundSelectBox.DataSource = fileNames.ToList();
            this.btn8SoundSelectBox.SelectedItem = null;
            this.btn8SoundSelectBox.DropDownStyle = ComboBoxStyle.DropDownList;

            //Second: Music
            string[] musicFiles = Directory.GetFiles(@"Music\");
            foreach (string music in musicFiles)
            {
                if (!Regex.IsMatch(music, validFileExtensions)) { continue; }

                string displayName = music.Replace(@"Music\", "");
                displayName = displayName.Substring(0, displayName.IndexOf('.'));
                musicDefaults.Add(new SoundFile(music, displayName));
            }
            //Grab only the display names, and populate the dropdown.
            List<String> songNames = new List<String>();
            foreach (SoundFile song in musicDefaults)
            {
                songNames.Add(song.getDisplayName());
            }
            this.btn9MusicSelectBox.DataSource = songNames.ToList();
            this.btn9MusicSelectBox.SelectedItem = null;
            this.btn9MusicSelectBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.button9.Text = "Select Sound";

            //Third: Scenes
            populateScenes();
            var scenes = sceneList.Keys;
            this.sceneSelectorBox.DataSource = scenes.ToList();
            this.sceneSelectorBox.SelectedItem = "Clear";
            this.sceneSelectorBox.DropDownStyle= ComboBoxStyle.DropDownList;
            #endregion

            //List of various ideas here:
            //TODO: Add a series of dropdowns (or a new form?) allowing the user to select different files on their machine?
            //TODO: add more scenes to scene selector
            //TODO: Have a custom scene creator that adds different scenes to the list. 
            //TODO: make backgrounds not look terrible.
            //TODO: Dropdown for selecting background image (or toolbar option?)
            //TODO: Fix stutter on first loop iteration.
        }

        private void button_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string playerName = (string)btn.Tag;

            WMPLib.WindowsMediaPlayer wmp = wPlayerList[playerName];
            WMPPlayState isPlaying = wmp.playState;

            if (isPlaying.Equals(WMPPlayState.wmppsPlaying))
            {
                wmp.controls.stop();
            }
            else
            {
                wmp.controls.play();
            }
        }

        private void loop_toggle(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            string playerName = (string)box.Tag;
            WMPLib.WindowsMediaPlayer wmp = wPlayerList[playerName];
            bool isLooped = wmp.settings.getMode("loop");

            wmp.settings.setMode("loop", !isLooped);
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = (TrackBar)sender;
            string playerName = (string)bar.Tag;

            wPlayerList[playerName].settings.volume = bar.Value;
        }

        private void selectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if(comboBox.SelectedItem == null) { return; }

            string playerName = (string)comboBox.Tag;
            WMPLib.WindowsMediaPlayer wmp = wPlayerList[playerName];
            string buttonName = "button" + playerName[^1];
            string newFileName = soundDefaults.Find(soundFile => soundFile.getDisplayName().Equals(comboBox.Text)).getDisplayName();

            updateButton(buttonName, playerName, newFileName);
        }

        //This gets its own function because it searches the Music list, rather than the sound list. 
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedItem == null) { return; }

            string newFileName = musicDefaults.Find(soundFile => soundFile.getDisplayName().Equals(btn9MusicSelectBox.Text)).getFilePath();

            wplayer9.URL = newFileName;
            wplayer9.controls.stop();

            button9.Text = btn9MusicSelectBox.Text;
        }

        //TODO: How to optimize the speed of this? In setScene, this function is called 8x. Can that be improved?
        private void updateButton(string btnName, string wpName, string sound)
        {
            this.Controls.Find(btnName, true)[0].Text = sound;
            WMPLib.WindowsMediaPlayer wmp = wPlayerList[wpName];
            wmp.URL = soundDefaults.Find(soundFile => soundFile.getDisplayName().Equals(sound)).getFilePath();
            wmp.controls.stop();
        }

        #region Functions for the scene selector dropdown
        private void setScene(object sender, EventArgs e)
        {
            //TODO: Optimize the run of this, learn async. 
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedItem == null) { return; }
            string sceneName = (string)comboBox.Text;
            string buttonName;
            string wplayerName;
            string soundName;

            if(sceneName == "Clear")
            {
                clearScene();
                return;
            }

            List<string> sounds = sceneList[sceneName];
            for(int i = 0; i < sounds.Count; i++)
            {
                buttonName = "button" + (i + 1);
                wplayerName = "wplayer" + (i + 1);
                soundName = sounds[i];

                updateButton(buttonName, wplayerName, soundName);
            }
        }

        //special function invoked by the scene "Clear"
        private void clearScene()
        {
            foreach(Button btn in this.Controls.OfType<Button>())
            {
                //For every button except 9, which is music and not sounds
                if (btn.Name[^1] != 9)
                {
                    btn.Text = "Select Sound";
                    string wpname = "wplayer" + btn.Name[^1];
                    WMPLib.WindowsMediaPlayer wmp = wPlayerList[wpname];
                    wmp.URL = string.Empty;
                    wmp.controls.stop();
                }
            }
            //TODO: Do we also reset volume sliders here?
        }

        private void populateScenes()
        {
            string[] scenes = Directory.GetFiles(@"Scenes\");
            foreach(string scene in scenes)
            {
                string sceneName = scene.Replace(@"Scenes\", "");
                sceneName = sceneName.Substring(0, sceneName.IndexOf('.'));

                List<string> sounds = new List<string>();

                StreamReader sr = new StreamReader(scene);
                string line = sr.ReadLine();
                while(line != null)
                {
                    Debug.WriteLine(line);
                    sounds.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                
                sceneList.Add(sceneName, sounds);
            }
            //Add special "Clear" scene which empties the list.
            sceneList.Add("Clear", null);
        }
        #endregion

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
