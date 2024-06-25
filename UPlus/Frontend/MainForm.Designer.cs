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
            this.Background_RoundEdge = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.BackgroundPanel = new System.Windows.Forms.Panel();
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
            this.browse1.Location = new System.Drawing.Point(82, 42);
            this.browse1.Name = "browse1";
            this.browse1.Size = new System.Drawing.Size(600, 304);
            this.browse1.TabIndex = 5;
            // 
            // Main_RoundEdge
            // 
            this.Main_RoundEdge.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.panel1.Location = new System.Drawing.Point(140, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 50);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Background_RoundEdge
            // 
            this.Background_RoundEdge.BorderRadius = 10;
            this.Background_RoundEdge.TargetControl = this.BackgroundPanel;
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 33);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(773, 313);
            this.BackgroundPanel.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 347);
            this.Controls.Add(this.BackgroundPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.browse1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
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
    }
}

