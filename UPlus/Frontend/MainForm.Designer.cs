namespace UPlus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DragControl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.DragPanel = new Guna.UI.WinForms.GunaPanel();
            this.browse1 = new UPlus.Frontend.UserControls.Browse();
            this.Main_RoundEdge = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Library = new Guna.UI.WinForms.GunaLabel();
            this.Background_RoundEdge = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.CreateLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.LibraryButton = new Siticone.UI.WinForms.SiticoneImageButton();
            this.siticoneImageButton1 = new Siticone.UI.WinForms.SiticoneImageButton();
            this.CreateButton = new Siticone.UI.WinForms.SiticoneImageButton();
            this.panel1.SuspendLayout();
            this.BackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.DragPanel;
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanel.Location = new System.Drawing.Point(0, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(773, 36);
            this.DragPanel.TabIndex = 6;
            // 
            // browse1
            // 
            this.browse1.Location = new System.Drawing.Point(-3, 11);
            this.browse1.Name = "browse1";
            this.browse1.Size = new System.Drawing.Size(773, 252);
            this.browse1.TabIndex = 5;
            // 
            // Main_RoundEdge
            // 
            this.Main_RoundEdge.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.CreateLabel);
            this.panel1.Controls.Add(this.Library);
            this.panel1.Controls.Add(this.LibraryButton);
            this.panel1.Controls.Add(this.siticoneImageButton1);
            this.panel1.Controls.Add(this.CreateButton);
            this.panel1.Location = new System.Drawing.Point(0, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 61);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Library
            // 
            this.Library.AutoSize = true;
            this.Library.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Library.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.Library.Location = new System.Drawing.Point(284, 39);
            this.Library.Name = "Library";
            this.Library.Size = new System.Drawing.Size(43, 15);
            this.Library.TabIndex = 3;
            this.Library.Text = "Library";
            // 
            // Background_RoundEdge
            // 
            this.Background_RoundEdge.BorderRadius = 10;
            this.Background_RoundEdge.TargetControl = this.BackgroundPanel;
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.Controls.Add(this.browse1);
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 31);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(773, 315);
            this.BackgroundPanel.TabIndex = 8;
            // 
            // CreateLabel
            // 
            this.CreateLabel.AutoSize = true;
            this.CreateLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CreateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.CreateLabel.Location = new System.Drawing.Point(376, 41);
            this.CreateLabel.Name = "CreateLabel";
            this.CreateLabel.Size = new System.Drawing.Size(41, 15);
            this.CreateLabel.TabIndex = 4;
            this.CreateLabel.Text = "Create";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(135)))), ((int)(((byte)(129)))));
            this.gunaLabel1.Location = new System.Drawing.Point(471, 39);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(41, 15);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Create";
            // 
            // LibraryButton
            // 
            this.LibraryButton.CheckedState.Parent = this.LibraryButton;
            this.LibraryButton.HoveredState.Parent = this.LibraryButton;
            this.LibraryButton.Image = global::UPlus.Properties.Resources.library__1_;
            this.LibraryButton.ImageSize = new System.Drawing.Size(30, 30);
            this.LibraryButton.Location = new System.Drawing.Point(281, 3);
            this.LibraryButton.Margin = new System.Windows.Forms.Padding(40);
            this.LibraryButton.Name = "LibraryButton";
            this.LibraryButton.PressedState.Parent = this.LibraryButton;
            this.LibraryButton.Size = new System.Drawing.Size(47, 42);
            this.LibraryButton.TabIndex = 2;
            // 
            // siticoneImageButton1
            // 
            this.siticoneImageButton1.CheckedState.Parent = this.siticoneImageButton1;
            this.siticoneImageButton1.HoveredState.Parent = this.siticoneImageButton1;
            this.siticoneImageButton1.Image = global::UPlus.Properties.Resources.search__1_;
            this.siticoneImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.siticoneImageButton1.Location = new System.Drawing.Point(465, 3);
            this.siticoneImageButton1.Margin = new System.Windows.Forms.Padding(40);
            this.siticoneImageButton1.Name = "siticoneImageButton1";
            this.siticoneImageButton1.PressedState.Parent = this.siticoneImageButton1;
            this.siticoneImageButton1.Size = new System.Drawing.Size(47, 42);
            this.siticoneImageButton1.TabIndex = 1;
            this.siticoneImageButton1.Click += new System.EventHandler(this.siticoneImageButton1_Click_1);
            // 
            // CreateButton
            // 
            this.CreateButton.CheckedState.Parent = this.CreateButton;
            this.CreateButton.HoveredState.Parent = this.CreateButton;
            this.CreateButton.Image = global::UPlus.Properties.Resources.add;
            this.CreateButton.ImageSize = new System.Drawing.Size(40, 40);
            this.CreateButton.Location = new System.Drawing.Point(371, 1);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.PressedState.Parent = this.CreateButton;
            this.CreateButton.Size = new System.Drawing.Size(47, 42);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Click += new System.EventHandler(this.siticoneImageButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackgroundPanel);
            this.Controls.Add(this.DragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BackgroundPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneDragControl DragControl;
        private Frontend.UserControls.Browse browse1;
        private Guna.UI.WinForms.GunaPanel DragPanel;
        private Siticone.UI.WinForms.SiticoneElipse Main_RoundEdge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel BackgroundPanel;
        private Siticone.UI.WinForms.SiticoneElipse Background_RoundEdge;
        private Siticone.UI.WinForms.SiticoneImageButton CreateButton;
        private Siticone.UI.WinForms.SiticoneImageButton siticoneImageButton1;
        private Siticone.UI.WinForms.SiticoneImageButton LibraryButton;
        private Guna.UI.WinForms.GunaLabel Library;
        private Guna.UI.WinForms.GunaLabel CreateLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}

