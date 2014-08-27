namespace macsurvControl
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.fpsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sendSckDebuglbl = new System.Windows.Forms.Label();
            this.linkBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rightBtn = new System.Windows.Forms.Button();
            this.leftBtn = new System.Windows.Forms.Button();
            this.downBtn = new System.Windows.Forms.Button();
            this.upBtn = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fpsLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 430);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(624, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // fpsLabel
            // 
            this.fpsLabel.AutoSize = false;
            this.fpsLabel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.fpsLabel.BackgroundImage = global::macsurvControl.Properties.Resources.camoMacsurv;
            this.fpsLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(609, 17);
            this.fpsLabel.Spring = true;
            this.fpsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.videoSourcePlayer.BorderColor = System.Drawing.Color.Transparent;
            this.videoSourcePlayer.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer.Location = new System.Drawing.Point(4, 3);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(322, 242);
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.TabStop = false;
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer_NewFrame);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.videoSourcePlayer);
            this.mainPanel.Location = new System.Drawing.Point(150, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(330, 248);
            this.mainPanel.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl.Location = new System.Drawing.Point(221, 413);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 15);
            this.lbl.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // sendSckDebuglbl
            // 
            this.sendSckDebuglbl.AutoSize = true;
            this.sendSckDebuglbl.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.sendSckDebuglbl.Location = new System.Drawing.Point(12, 118);
            this.sendSckDebuglbl.Name = "sendSckDebuglbl";
            this.sendSckDebuglbl.Size = new System.Drawing.Size(33, 13);
            this.sendSckDebuglbl.TabIndex = 21;
            this.sendSckDebuglbl.Text = "alpha";
            this.sendSckDebuglbl.Visible = false;
            // 
            // linkBtn
            // 
            this.linkBtn.Image = global::macsurvControl.Properties.Resources.connect;
            this.linkBtn.Location = new System.Drawing.Point(12, 15);
            this.linkBtn.Name = "linkBtn";
            this.linkBtn.Size = new System.Drawing.Size(60, 60);
            this.linkBtn.TabIndex = 27;
            this.linkBtn.UseVisualStyleBackColor = true;
            this.linkBtn.Click += new System.EventHandler(this.linkBtn_Click_2);
            // 
            // button4
            // 
            this.button4.Image = global::macsurvControl.Properties.Resources.horn;
            this.button4.Location = new System.Drawing.Point(420, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 26;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // rightBtn
            // 
            this.rightBtn.Image = global::macsurvControl.Properties.Resources.rightBtn;
            this.rightBtn.Location = new System.Drawing.Point(347, 352);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(60, 60);
            this.rightBtn.TabIndex = 25;
            this.rightBtn.UseVisualStyleBackColor = true;
            // 
            // leftBtn
            // 
            this.leftBtn.Image = global::macsurvControl.Properties.Resources.leftBtn;
            this.leftBtn.Location = new System.Drawing.Point(215, 352);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(60, 60);
            this.leftBtn.TabIndex = 24;
            this.leftBtn.UseVisualStyleBackColor = true;
            // 
            // downBtn
            // 
            this.downBtn.Image = global::macsurvControl.Properties.Resources.downBtn;
            this.downBtn.Location = new System.Drawing.Point(281, 352);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(60, 60);
            this.downBtn.TabIndex = 23;
            this.downBtn.UseVisualStyleBackColor = true;
            // 
            // upBtn
            // 
            this.upBtn.Image = global::macsurvControl.Properties.Resources.upBtn;
            this.upBtn.Location = new System.Drawing.Point(281, 288);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(60, 60);
            this.upBtn.TabIndex = 22;
            this.upBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::macsurvControl.Properties.Resources.camoMacsurv;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 452);
            this.Controls.Add(this.linkBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.rightBtn);
            this.Controls.Add(this.leftBtn);
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.upBtn);
            this.Controls.Add(this.sendSckDebuglbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MACSURV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripStatusLabel fpsLabel;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label sendSckDebuglbl;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.Button downBtn;
        private System.Windows.Forms.Button leftBtn;
        private System.Windows.Forms.Button rightBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button linkBtn;
    }
}

