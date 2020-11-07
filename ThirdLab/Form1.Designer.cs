namespace ThirdLab
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxname = new System.Windows.Forms.CheckBox();
            this.checkBoxsex = new System.Windows.Forms.CheckBox();
            this.checkBoxbreed = new System.Windows.Forms.CheckBox();
            this.checkBoxage = new System.Windows.Forms.CheckBox();
            this.checkBoxvac = new System.Windows.Forms.CheckBox();
            this.namebox = new System.Windows.Forms.ComboBox();
            this.sexbox = new System.Windows.Forms.ComboBox();
            this.breedbox = new System.Windows.Forms.ComboBox();
            this.agebox = new System.Windows.Forms.ComboBox();
            this.vacbox = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.radioLINQ = new System.Windows.Forms.RadioButton();
            this.radioSAX = new System.Windows.Forms.RadioButton();
            this.radioDOM = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxname
            // 
            this.checkBoxname.AutoSize = true;
            this.checkBoxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxname.Location = new System.Drawing.Point(63, 57);
            this.checkBoxname.Name = "checkBoxname";
            this.checkBoxname.Size = new System.Drawing.Size(90, 29);
            this.checkBoxname.TabIndex = 0;
            this.checkBoxname.Text = "Name";
            this.checkBoxname.UseVisualStyleBackColor = true;
            this.checkBoxname.CheckedChanged += new System.EventHandler(this.checkBoxname_CheckedChanged);
            // 
            // checkBoxsex
            // 
            this.checkBoxsex.AutoSize = true;
            this.checkBoxsex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxsex.Location = new System.Drawing.Point(63, 112);
            this.checkBoxsex.Name = "checkBoxsex";
            this.checkBoxsex.Size = new System.Drawing.Size(73, 29);
            this.checkBoxsex.TabIndex = 1;
            this.checkBoxsex.Text = "Sex";
            this.checkBoxsex.UseVisualStyleBackColor = true;
            this.checkBoxsex.CheckedChanged += new System.EventHandler(this.checkBoxsex_CheckedChanged);
            // 
            // checkBoxbreed
            // 
            this.checkBoxbreed.AutoSize = true;
            this.checkBoxbreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxbreed.Location = new System.Drawing.Point(63, 174);
            this.checkBoxbreed.Name = "checkBoxbreed";
            this.checkBoxbreed.Size = new System.Drawing.Size(90, 29);
            this.checkBoxbreed.TabIndex = 2;
            this.checkBoxbreed.Text = "Breed";
            this.checkBoxbreed.UseVisualStyleBackColor = true;
            this.checkBoxbreed.CheckedChanged += new System.EventHandler(this.checkBoxbreed_CheckedChanged);
            // 
            // checkBoxage
            // 
            this.checkBoxage.AutoSize = true;
            this.checkBoxage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxage.Location = new System.Drawing.Point(63, 231);
            this.checkBoxage.Name = "checkBoxage";
            this.checkBoxage.Size = new System.Drawing.Size(74, 29);
            this.checkBoxage.TabIndex = 3;
            this.checkBoxage.Text = "Age";
            this.checkBoxage.UseVisualStyleBackColor = true;
            this.checkBoxage.CheckedChanged += new System.EventHandler(this.checkBoxage_CheckedChanged);
            // 
            // checkBoxvac
            // 
            this.checkBoxvac.AutoSize = true;
            this.checkBoxvac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxvac.Location = new System.Drawing.Point(63, 295);
            this.checkBoxvac.Name = "checkBoxvac";
            this.checkBoxvac.Size = new System.Drawing.Size(150, 29);
            this.checkBoxvac.TabIndex = 4;
            this.checkBoxvac.Text = "Vaccinations";
            this.checkBoxvac.UseVisualStyleBackColor = true;
            this.checkBoxvac.CheckedChanged += new System.EventHandler(this.checkBoxvac_CheckedChanged);
            // 
            // namebox
            // 
            this.namebox.FormattingEnabled = true;
            this.namebox.Location = new System.Drawing.Point(219, 59);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(121, 28);
            this.namebox.TabIndex = 5;
            this.namebox.SelectedIndexChanged += new System.EventHandler(this.namebox_SelectedIndexChanged);
            // 
            // sexbox
            // 
            this.sexbox.FormattingEnabled = true;
            this.sexbox.Location = new System.Drawing.Point(219, 112);
            this.sexbox.Name = "sexbox";
            this.sexbox.Size = new System.Drawing.Size(121, 28);
            this.sexbox.TabIndex = 6;
            // 
            // breedbox
            // 
            this.breedbox.FormattingEnabled = true;
            this.breedbox.Location = new System.Drawing.Point(219, 174);
            this.breedbox.Name = "breedbox";
            this.breedbox.Size = new System.Drawing.Size(121, 28);
            this.breedbox.TabIndex = 7;
            this.breedbox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // agebox
            // 
            this.agebox.FormattingEnabled = true;
            this.agebox.Location = new System.Drawing.Point(219, 233);
            this.agebox.Name = "agebox";
            this.agebox.Size = new System.Drawing.Size(121, 28);
            this.agebox.TabIndex = 8;
            // 
            // vacbox
            // 
            this.vacbox.FormattingEnabled = true;
            this.vacbox.Location = new System.Drawing.Point(219, 297);
            this.vacbox.Name = "vacbox";
            this.vacbox.Size = new System.Drawing.Size(121, 28);
            this.vacbox.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(435, 57);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(445, 347);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 33);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.clearToolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 30);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.clearToolStripMenuItem1_Click);
            // 
            // radioLINQ
            // 
            this.radioLINQ.AutoSize = true;
            this.radioLINQ.Location = new System.Drawing.Point(24, 401);
            this.radioLINQ.Name = "radioLINQ";
            this.radioLINQ.Size = new System.Drawing.Size(71, 24);
            this.radioLINQ.TabIndex = 14;
            this.radioLINQ.TabStop = true;
            this.radioLINQ.Text = "LINQ";
            this.radioLINQ.UseVisualStyleBackColor = true;
            // 
            // radioSAX
            // 
            this.radioSAX.AutoSize = true;
            this.radioSAX.Location = new System.Drawing.Point(296, 401);
            this.radioSAX.Name = "radioSAX";
            this.radioSAX.Size = new System.Drawing.Size(67, 24);
            this.radioSAX.TabIndex = 15;
            this.radioSAX.TabStop = true;
            this.radioSAX.Text = "SAX";
            this.radioSAX.UseVisualStyleBackColor = true;
            // 
            // radioDOM
            // 
            this.radioDOM.AutoSize = true;
            this.radioDOM.Location = new System.Drawing.Point(168, 401);
            this.radioDOM.Name = "radioDOM";
            this.radioDOM.Size = new System.Drawing.Size(71, 24);
            this.radioDOM.TabIndex = 16;
            this.radioDOM.TabStop = true;
            this.radioDOM.Text = "DOM";
            this.radioDOM.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 52);
            this.button1.TabIndex = 17;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(435, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 44);
            this.button2.TabIndex = 18;
            this.button2.Text = "To HTML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(695, 465);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 44);
            this.button4.TabIndex = 20;
            this.button4.Text = "From HTML";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 543);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioDOM);
            this.Controls.Add(this.radioSAX);
            this.Controls.Add(this.radioLINQ);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.vacbox);
            this.Controls.Add(this.agebox);
            this.Controls.Add(this.breedbox);
            this.Controls.Add(this.sexbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.checkBoxvac);
            this.Controls.Add(this.checkBoxage);
            this.Controls.Add(this.checkBoxbreed);
            this.Controls.Add(this.checkBoxsex);
            this.Controls.Add(this.checkBoxname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxname;
        private System.Windows.Forms.CheckBox checkBoxsex;
        private System.Windows.Forms.CheckBox checkBoxbreed;
        private System.Windows.Forms.CheckBox checkBoxage;
        private System.Windows.Forms.CheckBox checkBoxvac;
        private System.Windows.Forms.ComboBox namebox;
        private System.Windows.Forms.ComboBox sexbox;
        private System.Windows.Forms.ComboBox breedbox;
        private System.Windows.Forms.ComboBox agebox;
        private System.Windows.Forms.ComboBox vacbox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.RadioButton radioLINQ;
        private System.Windows.Forms.RadioButton radioSAX;
        private System.Windows.Forms.RadioButton radioDOM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

