namespace gamedemp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.movebgtimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.leftmovetimer = new System.Windows.Forms.Timer(this.components);
            this.rightmovetimer = new System.Windows.Forms.Timer(this.components);
            this.upmovetimer = new System.Windows.Forms.Timer(this.components);
            this.downmovetimer = new System.Windows.Forms.Timer(this.components);
            this.movemunitiontimer = new System.Windows.Forms.Timer(this.components);
            this.enemytimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // movebgtimer
            // 
            this.movebgtimer.Enabled = true;
            this.movebgtimer.Interval = 10;
            this.movebgtimer.Tick += new System.EventHandler(this.movebgtimer_Tick);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Player, "Player");
            this.Player.Name = "Player";
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // leftmovetimer
            // 
            this.leftmovetimer.Interval = 5;
            this.leftmovetimer.Tick += new System.EventHandler(this.leftmovetimer_Tick);
            // 
            // rightmovetimer
            // 
            this.rightmovetimer.Interval = 5;
            this.rightmovetimer.Tick += new System.EventHandler(this.rightmovetimer_Tick);
            // 
            // upmovetimer
            // 
            this.upmovetimer.Interval = 5;
            this.upmovetimer.Tick += new System.EventHandler(this.upmovetimer_Tick);
            // 
            // downmovetimer
            // 
            this.downmovetimer.Interval = 5;
            this.downmovetimer.Tick += new System.EventHandler(this.downmovetimer_Tick);
            // 
            // movemunitiontimer
            // 
            this.movemunitiontimer.Enabled = true;
            this.movemunitiontimer.Interval = 5;
            this.movemunitiontimer.Tick += new System.EventHandler(this.movemunitiontimer_Tick);
            // 
            // enemytimer
            // 
            this.enemytimer.Enabled = true;
            this.enemytimer.Interval = 20;
            this.enemytimer.Tick += new System.EventHandler(this.enemytimer_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer movebgtimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer leftmovetimer;
        private System.Windows.Forms.Timer rightmovetimer;
        private System.Windows.Forms.Timer upmovetimer;
        private System.Windows.Forms.Timer downmovetimer;
        private System.Windows.Forms.Timer movemunitiontimer;
        private System.Windows.Forms.Timer enemytimer;
    }
}

