namespace VK3_KT3
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stlbPisteet = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslbAika = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbAloitus = new System.Windows.Forms.ToolStrip();
            this.tsbAloitus = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnHit = new System.Windows.Forms.Button();
            this.tmrAika = new System.Windows.Forms.Timer(this.components);
            this.tmrKello = new System.Windows.Forms.Timer(this.components);
            this.lbTime = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.tslbAloitus.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlbPisteet,
            this.tsslbAika});
            this.statusStrip1.Location = new System.Drawing.Point(0, 410);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 22, 0);
            this.statusStrip1.Size = new System.Drawing.Size(916, 32);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // stlbPisteet
            // 
            this.stlbPisteet.Name = "stlbPisteet";
            this.stlbPisteet.Size = new System.Drawing.Size(47, 25);
            this.stlbPisteet.Text = "Hits:";
            this.stlbPisteet.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // tsslbAika
            // 
            this.tsslbAika.Name = "tsslbAika";
            this.tsslbAika.Size = new System.Drawing.Size(96, 25);
            this.tsslbAika.Text = "Time Now:";
            this.tsslbAika.Click += new System.EventHandler(this.tsslbAika_Click);
            // 
            // tslbAloitus
            // 
            this.tslbAloitus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tslbAloitus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAloitus,
            this.toolStripButton1});
            this.tslbAloitus.Location = new System.Drawing.Point(0, 0);
            this.tslbAloitus.Name = "tslbAloitus";
            this.tslbAloitus.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tslbAloitus.Size = new System.Drawing.Size(916, 33);
            this.tslbAloitus.TabIndex = 1;
            this.tslbAloitus.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tslbAloitus_ItemClicked);
            // 
            // tsbAloitus
            // 
            this.tsbAloitus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAloitus.Image = ((System.Drawing.Image)(resources.GetObject("tsbAloitus.Image")));
            this.tsbAloitus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAloitus.Name = "tsbAloitus";
            this.tsbAloitus.Size = new System.Drawing.Size(34, 28);
            this.tsbAloitus.Text = "Game Start!";
            this.tsbAloitus.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(616, 277);
            this.btnHit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(126, 57);
            this.btnHit.TabIndex = 2;
            this.btnHit.Text = "Hit me!";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // tmrAika
            // 
            this.tmrAika.Enabled = true;
            this.tmrAika.Interval = 1000;
            this.tmrAika.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrKello
            // 
            this.tmrKello.Enabled = true;
            this.tmrKello.Tick += new System.EventHandler(this.tmrKello_Tick);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(93, 145);
            this.lbTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(69, 29);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 442);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.tslbAloitus);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Hit Button!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tslbAloitus.ResumeLayout(false);
            this.tslbAloitus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip tslbAloitus;
        private System.Windows.Forms.ToolStripButton tsbAloitus;
        private System.Windows.Forms.ToolStripStatusLabel stlbPisteet;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Timer tmrAika;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Timer tmrKello;
        private System.Windows.Forms.ToolStripStatusLabel tsslbAika;
        private System.Windows.Forms.Label lbTime;
    }
}

