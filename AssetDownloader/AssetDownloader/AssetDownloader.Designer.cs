namespace AssetDownloader
{
    partial class AssetDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetDownloader));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Panel();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Download = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Pants = new System.Windows.Forms.RadioButton();
            this.Shirt = new System.Windows.Forms.RadioButton();
            this.Face = new System.Windows.Forms.RadioButton();
            this.Audio = new System.Windows.Forms.RadioButton();
            this.Accessory = new System.Windows.Forms.RadioButton();
            this.Animation = new System.Windows.Forms.RadioButton();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TopPanel.Controls.Add(this.Title);
            this.TopPanel.Controls.Add(this.Minimize);
            this.TopPanel.Controls.Add(this.Close);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(399, 32);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // Title
            // 
            this.Title.BackgroundImage = global::AssetDownloader.Properties.Resources.Title_ASSET;
            this.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Title.Location = new System.Drawing.Point(1, 1);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(339, 188);
            this.Title.TabIndex = 6;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackgroundImage = global::AssetDownloader.Properties.Resources.MacMin;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Location = new System.Drawing.Point(361, 10);
            this.Minimize.MaximumSize = new System.Drawing.Size(12, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(12, 12);
            this.Minimize.TabIndex = 5;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackgroundImage = global::AssetDownloader.Properties.Resources.MacClose;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Location = new System.Drawing.Point(379, 10);
            this.Close.MaximumSize = new System.Drawing.Size(12, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(12, 12);
            this.Close.TabIndex = 4;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseHover);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Close.MouseHover += new System.EventHandler(this.Close_MouseHover);
            // 
            // Browser
            // 
            this.Browser.Location = new System.Drawing.Point(618, 333);
            this.Browser.Name = "Browser";
            this.Browser.ScriptErrorsSuppressed = true;
            this.Browser.Size = new System.Drawing.Size(0, 0);
            this.Browser.TabIndex = 5;
            this.Browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Browser_DocumentCompleted);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(221, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Asset ID";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Enter += new System.EventHandler(this.RemoveText);
            this.textBox1.Leave += new System.EventHandler(this.AddText);
            // 
            // Download
            // 
            this.Download.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Download.FlatAppearance.BorderSize = 0;
            this.Download.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Download.ForeColor = System.Drawing.Color.LightGray;
            this.Download.Location = new System.Drawing.Point(237, 145);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(100, 23);
            this.Download.TabIndex = 3;
            this.Download.Text = "Download";
            this.Download.UseVisualStyleBackColor = false;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Pants
            // 
            this.Pants.Image = global::AssetDownloader.Properties.Resources.PantsSelector1;
            this.Pants.Location = new System.Drawing.Point(12, 212);
            this.Pants.Name = "Pants";
            this.Pants.Size = new System.Drawing.Size(177, 29);
            this.Pants.TabIndex = 11;
            this.Pants.TabStop = true;
            this.Pants.UseVisualStyleBackColor = true;
            this.Pants.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Shirt
            // 
            this.Shirt.Image = global::AssetDownloader.Properties.Resources.ShirtsSelector;
            this.Shirt.Location = new System.Drawing.Point(12, 177);
            this.Shirt.Name = "Shirt";
            this.Shirt.Size = new System.Drawing.Size(177, 29);
            this.Shirt.TabIndex = 10;
            this.Shirt.TabStop = true;
            this.Shirt.UseVisualStyleBackColor = true;
            this.Shirt.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Face
            // 
            this.Face.Image = global::AssetDownloader.Properties.Resources.FaceSelector1;
            this.Face.Location = new System.Drawing.Point(12, 142);
            this.Face.Name = "Face";
            this.Face.Size = new System.Drawing.Size(177, 29);
            this.Face.TabIndex = 9;
            this.Face.TabStop = true;
            this.Face.UseVisualStyleBackColor = true;
            this.Face.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Audio
            // 
            this.Audio.Image = global::AssetDownloader.Properties.Resources.AudioSelector;
            this.Audio.Location = new System.Drawing.Point(12, 107);
            this.Audio.Name = "Audio";
            this.Audio.Size = new System.Drawing.Size(177, 29);
            this.Audio.TabIndex = 8;
            this.Audio.TabStop = true;
            this.Audio.UseVisualStyleBackColor = true;
            this.Audio.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Accessory
            // 
            this.Accessory.Image = global::AssetDownloader.Properties.Resources.AccessoriesSelector;
            this.Accessory.Location = new System.Drawing.Point(13, 37);
            this.Accessory.Name = "Accessory";
            this.Accessory.Size = new System.Drawing.Size(177, 29);
            this.Accessory.TabIndex = 7;
            this.Accessory.TabStop = true;
            this.Accessory.UseVisualStyleBackColor = true;
            this.Accessory.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Animation
            // 
            this.Animation.Image = global::AssetDownloader.Properties.Resources.AnimationsSelector;
            this.Animation.Location = new System.Drawing.Point(12, 72);
            this.Animation.Name = "Animation";
            this.Animation.Size = new System.Drawing.Size(177, 29);
            this.Animation.TabIndex = 6;
            this.Animation.TabStop = true;
            this.Animation.UseVisualStyleBackColor = true;
            this.Animation.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // AssetDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(399, 245);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Pants);
            this.Controls.Add(this.Shirt);
            this.Controls.Add(this.Face);
            this.Controls.Add(this.Audio);
            this.Controls.Add(this.Accessory);
            this.Controls.Add(this.Animation);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssetDownloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MutliTool Launcher";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AssetDownloader_Load);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel Close;
        private System.Windows.Forms.Panel Minimize;
        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.Panel Title;
        private System.Windows.Forms.RadioButton Animation;
        private System.Windows.Forms.RadioButton Accessory;
        private System.Windows.Forms.RadioButton Audio;
        private System.Windows.Forms.RadioButton Face;
        private System.Windows.Forms.RadioButton Shirt;
        private System.Windows.Forms.RadioButton Pants;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Button button1;
    }
}

