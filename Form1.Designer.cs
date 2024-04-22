namespace Soundboard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            trackBar1 = new TrackBar();
            label1 = new Label();
            button7 = new Button();
            button8 = new Button();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            forestToolStripMenuItem = new ToolStripMenuItem();
            seaToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btn3SoundSelectBox = new ComboBox();
            label4 = new Label();
            btn2SoundSelectBox = new ComboBox();
            btn2FileSelectLabel = new Label();
            btn1SoundSelectBox = new ComboBox();
            btn1FileSelectLabel = new Label();
            label2 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label3 = new Label();
            comboBox1 = new ComboBox();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(59, 115);
            button1.Name = "button1";
            button1.Size = new Size(120, 39);
            button1.TabIndex = 0;
            button1.Text = "Button 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(245, 115);
            button2.Name = "button2";
            button2.Size = new Size(120, 39);
            button2.TabIndex = 1;
            button2.Text = "Button 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(59, 230);
            button3.Name = "button3";
            button3.Size = new Size(120, 39);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(245, 230);
            button4.Name = "button4";
            button4.Size = new Size(120, 39);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(59, 345);
            button5.Name = "button5";
            button5.Size = new Size(120, 39);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(245, 345);
            button6.Name = "button6";
            button6.Size = new Size(120, 39);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 10;
            trackBar1.Location = new Point(59, 160);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(120, 45);
            trackBar1.TabIndex = 6;
            trackBar1.TickFrequency = 5;
            trackBar1.Value = 100;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 25);
            label1.Name = "label1";
            label1.Size = new Size(522, 59);
            label1.TabIndex = 7;
            label1.Text = "Nickotine's Soundboard";
            // 
            // button7
            // 
            button7.Location = new Point(59, 460);
            button7.Name = "button7";
            button7.Size = new Size(120, 39);
            button7.TabIndex = 8;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(245, 460);
            button8.Name = "button8";
            button8.Size = new Size(120, 39);
            button8.TabIndex = 9;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(984, 25);
            toolStrip1.TabIndex = 10;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { forestToolStripMenuItem, seaToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(84, 22);
            toolStripDropDownButton1.Text = "Background";
            // 
            // forestToolStripMenuItem
            // 
            forestToolStripMenuItem.Name = "forestToolStripMenuItem";
            forestToolStripMenuItem.Size = new Size(106, 22);
            forestToolStripMenuItem.Text = "Forest";
            // 
            // seaToolStripMenuItem
            // 
            seaToolStripMenuItem.Name = "seaToolStripMenuItem";
            seaToolStripMenuItem.Size = new Size(106, 22);
            seaToolStripMenuItem.Text = "Sea";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn3SoundSelectBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btn2SoundSelectBox);
            groupBox1.Controls.Add(btn2FileSelectLabel);
            groupBox1.Controls.Add(btn1SoundSelectBox);
            groupBox1.Controls.Add(btn1FileSelectLabel);
            groupBox1.Location = new Point(601, 194);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 244);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sound selector";
            // 
            // btn3SoundSelectBox
            // 
            btn3SoundSelectBox.FormattingEnabled = true;
            btn3SoundSelectBox.Location = new Point(94, 87);
            btn3SoundSelectBox.Name = "btn3SoundSelectBox";
            btn3SoundSelectBox.Size = new Size(121, 23);
            btn3SoundSelectBox.TabIndex = 18;
            btn3SoundSelectBox.Text = "Select Sound";
            btn3SoundSelectBox.SelectedIndexChanged += btn3SoundSelectBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 90);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 17;
            label4.Text = "Button 3:";
            // 
            // btn2SoundSelectBox
            // 
            btn2SoundSelectBox.AllowDrop = true;
            btn2SoundSelectBox.FormattingEnabled = true;
            btn2SoundSelectBox.Location = new Point(94, 57);
            btn2SoundSelectBox.Name = "btn2SoundSelectBox";
            btn2SoundSelectBox.Size = new Size(121, 23);
            btn2SoundSelectBox.TabIndex = 16;
            btn2SoundSelectBox.Text = "Select Sound";
            btn2SoundSelectBox.SelectedIndexChanged += btn2SoundSelectBox_SelectedIndexChanged;
            // 
            // btn2FileSelectLabel
            // 
            btn2FileSelectLabel.AutoSize = true;
            btn2FileSelectLabel.Location = new Point(6, 60);
            btn2FileSelectLabel.Name = "btn2FileSelectLabel";
            btn2FileSelectLabel.Size = new Size(55, 15);
            btn2FileSelectLabel.TabIndex = 2;
            btn2FileSelectLabel.Text = "Button 2:";
            // 
            // btn1SoundSelectBox
            // 
            btn1SoundSelectBox.AllowDrop = true;
            btn1SoundSelectBox.DisplayMember = "none";
            btn1SoundSelectBox.FormattingEnabled = true;
            btn1SoundSelectBox.Location = new Point(94, 26);
            btn1SoundSelectBox.Name = "btn1SoundSelectBox";
            btn1SoundSelectBox.Size = new Size(121, 23);
            btn1SoundSelectBox.TabIndex = 1;
            btn1SoundSelectBox.Text = "Select Sound";
            btn1SoundSelectBox.SelectedIndexChanged += btn1SoundSelectBox_SelectedIndexChanged;
            // 
            // btn1FileSelectLabel
            // 
            btn1FileSelectLabel.AutoSize = true;
            btn1FileSelectLabel.Location = new Point(6, 29);
            btn1FileSelectLabel.Name = "btn1FileSelectLabel";
            btn1FileSelectLabel.Size = new Size(55, 15);
            btn1FileSelectLabel.TabIndex = 0;
            btn1FileSelectLabel.Text = "Button 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 127);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 12;
            label2.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(607, 161);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 13;
            label3.Text = "Scene selector";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(695, 158);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 14;
            // 
            // trackBar2
            // 
            trackBar2.LargeChange = 10;
            trackBar2.Location = new Point(245, 160);
            trackBar2.Maximum = 100;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(120, 45);
            trackBar2.TabIndex = 15;
            trackBar2.TickFrequency = 5;
            trackBar2.Value = 100;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // trackBar3
            // 
            trackBar3.LargeChange = 10;
            trackBar3.Location = new Point(59, 275);
            trackBar3.Maximum = 100;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(120, 45);
            trackBar3.TabIndex = 16;
            trackBar3.TickFrequency = 5;
            trackBar3.Value = 100;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Nickotine's Soundboard";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TrackBar trackBar1;
        private Label label1;
        private Button button7;
        private Button button8;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem forestToolStripMenuItem;
        private ToolStripMenuItem seaToolStripMenuItem;
        private GroupBox groupBox1;
        private Label btn1FileSelectLabel;
        private Label label2;
        private FolderBrowserDialog folderBrowserDialog1;
        private ComboBox btn1SoundSelectBox;
        private Label label3;
        private ComboBox comboBox1;
        private TrackBar trackBar2;
        private ComboBox btn2SoundSelectBox;
        private Label btn2FileSelectLabel;
        private ComboBox btn3SoundSelectBox;
        private Label label4;
        private TrackBar trackBar3;
    }
}
