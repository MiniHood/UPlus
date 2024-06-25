namespace UPlus.Frontend.UserControls
{
    partial class NavigationPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationPanel));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.SettingsButton = new Guna.UI.WinForms.GunaButton();
            this.PresetDropDown = new Guna.UI.WinForms.GunaPanel();
            this.LocalButton = new Guna.UI.WinForms.GunaButton();
            this.FavouriteButton = new Guna.UI.WinForms.GunaButton();
            this.CreatedButton = new Guna.UI.WinForms.GunaButton();
            this.BrowseButton = new Guna.UI.WinForms.GunaButton();
            this.PresetButton = new Guna.UI.WinForms.GunaButton();
            this.CreateButton = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            this.PresetDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.gunaPanel1.Controls.Add(this.SettingsButton);
            this.gunaPanel1.Controls.Add(this.PresetDropDown);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(140, 347);
            this.gunaPanel1.TabIndex = 3;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Animated = true;
            this.SettingsButton.AnimationHoverSpeed = 0.07F;
            this.SettingsButton.AnimationSpeed = 0.03F;
            this.SettingsButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.SettingsButton.BorderColor = System.Drawing.Color.Black;
            this.SettingsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsButton.FocusedColor = System.Drawing.Color.Empty;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Image = global::UPlus.Properties.Resources.logout__1_;
            this.SettingsButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SettingsButton.Location = new System.Drawing.Point(0, 305);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.SettingsButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SettingsButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SettingsButton.OnHoverImage = null;
            this.SettingsButton.OnPressedColor = System.Drawing.Color.Black;
            this.SettingsButton.Size = new System.Drawing.Size(140, 42);
            this.SettingsButton.TabIndex = 0;
            this.SettingsButton.Text = "Exit";
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // PresetDropDown
            // 
            this.PresetDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.PresetDropDown.Controls.Add(this.CreateButton);
            this.PresetDropDown.Controls.Add(this.LocalButton);
            this.PresetDropDown.Controls.Add(this.FavouriteButton);
            this.PresetDropDown.Controls.Add(this.CreatedButton);
            this.PresetDropDown.Controls.Add(this.BrowseButton);
            this.PresetDropDown.Controls.Add(this.PresetButton);
            this.PresetDropDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.PresetDropDown.Location = new System.Drawing.Point(0, 0);
            this.PresetDropDown.MaximumSize = new System.Drawing.Size(171, 216);
            this.PresetDropDown.MinimumSize = new System.Drawing.Size(171, 41);
            this.PresetDropDown.Name = "PresetDropDown";
            this.PresetDropDown.Size = new System.Drawing.Size(171, 41);
            this.PresetDropDown.TabIndex = 3;
            // 
            // LocalButton
            // 
            this.LocalButton.Animated = true;
            this.LocalButton.AnimationHoverSpeed = 0.07F;
            this.LocalButton.AnimationSpeed = 0.03F;
            this.LocalButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.LocalButton.BorderColor = System.Drawing.Color.Black;
            this.LocalButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LocalButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LocalButton.FocusedColor = System.Drawing.Color.Empty;
            this.LocalButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LocalButton.ForeColor = System.Drawing.Color.White;
            this.LocalButton.Image = ((System.Drawing.Image)(resources.GetObject("LocalButton.Image")));
            this.LocalButton.ImageSize = new System.Drawing.Size(20, 20);
            this.LocalButton.Location = new System.Drawing.Point(0, 144);
            this.LocalButton.Name = "LocalButton";
            this.LocalButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.LocalButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LocalButton.OnHoverForeColor = System.Drawing.Color.White;
            this.LocalButton.OnHoverImage = null;
            this.LocalButton.OnPressedColor = System.Drawing.Color.Black;
            this.LocalButton.Size = new System.Drawing.Size(171, 34);
            this.LocalButton.TabIndex = 4;
            this.LocalButton.Text = "Local";
            // 
            // FavouriteButton
            // 
            this.FavouriteButton.Animated = true;
            this.FavouriteButton.AnimationHoverSpeed = 0.07F;
            this.FavouriteButton.AnimationSpeed = 0.03F;
            this.FavouriteButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.FavouriteButton.BorderColor = System.Drawing.Color.Black;
            this.FavouriteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FavouriteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FavouriteButton.FocusedColor = System.Drawing.Color.Empty;
            this.FavouriteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FavouriteButton.ForeColor = System.Drawing.Color.White;
            this.FavouriteButton.Image = ((System.Drawing.Image)(resources.GetObject("FavouriteButton.Image")));
            this.FavouriteButton.ImageSize = new System.Drawing.Size(20, 20);
            this.FavouriteButton.Location = new System.Drawing.Point(0, 110);
            this.FavouriteButton.Name = "FavouriteButton";
            this.FavouriteButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.FavouriteButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.FavouriteButton.OnHoverForeColor = System.Drawing.Color.White;
            this.FavouriteButton.OnHoverImage = null;
            this.FavouriteButton.OnPressedColor = System.Drawing.Color.Black;
            this.FavouriteButton.Size = new System.Drawing.Size(171, 34);
            this.FavouriteButton.TabIndex = 3;
            this.FavouriteButton.Text = "Favorites";
            // 
            // CreatedButton
            // 
            this.CreatedButton.Animated = true;
            this.CreatedButton.AnimationHoverSpeed = 0.07F;
            this.CreatedButton.AnimationSpeed = 0.03F;
            this.CreatedButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.CreatedButton.BorderColor = System.Drawing.Color.Black;
            this.CreatedButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CreatedButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreatedButton.FocusedColor = System.Drawing.Color.Empty;
            this.CreatedButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CreatedButton.ForeColor = System.Drawing.Color.White;
            this.CreatedButton.Image = ((System.Drawing.Image)(resources.GetObject("CreatedButton.Image")));
            this.CreatedButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CreatedButton.Location = new System.Drawing.Point(0, 76);
            this.CreatedButton.Name = "CreatedButton";
            this.CreatedButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.CreatedButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CreatedButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CreatedButton.OnHoverImage = null;
            this.CreatedButton.OnPressedColor = System.Drawing.Color.Black;
            this.CreatedButton.Size = new System.Drawing.Size(171, 34);
            this.CreatedButton.TabIndex = 2;
            this.CreatedButton.Text = "Created";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Animated = true;
            this.BrowseButton.AnimationHoverSpeed = 0.07F;
            this.BrowseButton.AnimationSpeed = 0.03F;
            this.BrowseButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.BrowseButton.BorderColor = System.Drawing.Color.Black;
            this.BrowseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BrowseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BrowseButton.FocusedColor = System.Drawing.Color.Empty;
            this.BrowseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BrowseButton.ForeColor = System.Drawing.Color.White;
            this.BrowseButton.Image = ((System.Drawing.Image)(resources.GetObject("BrowseButton.Image")));
            this.BrowseButton.ImageSize = new System.Drawing.Size(20, 20);
            this.BrowseButton.Location = new System.Drawing.Point(0, 42);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.BrowseButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BrowseButton.OnHoverForeColor = System.Drawing.Color.White;
            this.BrowseButton.OnHoverImage = null;
            this.BrowseButton.OnPressedColor = System.Drawing.Color.Black;
            this.BrowseButton.Size = new System.Drawing.Size(171, 34);
            this.BrowseButton.TabIndex = 1;
            this.BrowseButton.Text = "Browse";
            // 
            // PresetButton
            // 
            this.PresetButton.Animated = true;
            this.PresetButton.AnimationHoverSpeed = 0.07F;
            this.PresetButton.AnimationSpeed = 0.03F;
            this.PresetButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.PresetButton.BorderColor = System.Drawing.Color.Black;
            this.PresetButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PresetButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PresetButton.FocusedColor = System.Drawing.Color.Empty;
            this.PresetButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PresetButton.ForeColor = System.Drawing.Color.White;
            this.PresetButton.Image = global::UPlus.Properties.Resources.control;
            this.PresetButton.ImageSize = new System.Drawing.Size(20, 20);
            this.PresetButton.Location = new System.Drawing.Point(0, 0);
            this.PresetButton.Name = "PresetButton";
            this.PresetButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.PresetButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PresetButton.OnHoverForeColor = System.Drawing.Color.White;
            this.PresetButton.OnHoverImage = null;
            this.PresetButton.OnPressedColor = System.Drawing.Color.Black;
            this.PresetButton.Size = new System.Drawing.Size(171, 42);
            this.PresetButton.TabIndex = 0;
            this.PresetButton.Text = "Presets";
            this.PresetButton.Click += new System.EventHandler(this.PresetButton_Click_1);
            // 
            // CreateButton
            // 
            this.CreateButton.Animated = true;
            this.CreateButton.AnimationHoverSpeed = 0.07F;
            this.CreateButton.AnimationSpeed = 0.03F;
            this.CreateButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.CreateButton.BorderColor = System.Drawing.Color.Black;
            this.CreateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CreateButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateButton.FocusedColor = System.Drawing.Color.Empty;
            this.CreateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CreateButton.ForeColor = System.Drawing.Color.White;
            this.CreateButton.Image = global::UPlus.Properties.Resources.edit;
            this.CreateButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CreateButton.Location = new System.Drawing.Point(0, 178);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.CreateButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CreateButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CreateButton.OnHoverImage = null;
            this.CreateButton.OnPressedColor = System.Drawing.Color.Black;
            this.CreateButton.Size = new System.Drawing.Size(171, 34);
            this.CreateButton.TabIndex = 5;
            this.CreateButton.Text = "Create";
            // 
            // NavigationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaPanel1);
            this.Name = "NavigationPanel";
            this.Size = new System.Drawing.Size(140, 347);
            this.Load += new System.EventHandler(this.NavigationPanel_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.PresetDropDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel PresetDropDown;
        private Guna.UI.WinForms.GunaButton LocalButton;
        private Guna.UI.WinForms.GunaButton FavouriteButton;
        private Guna.UI.WinForms.GunaButton CreatedButton;
        private Guna.UI.WinForms.GunaButton BrowseButton;
        private Guna.UI.WinForms.GunaButton PresetButton;
        private Guna.UI.WinForms.GunaButton SettingsButton;
        private Guna.UI.WinForms.GunaButton CreateButton;
    }
}
