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
            this.navigationPanel1 = new UPlus.Frontend.UserControls.NavigationPanel();
            this.SuspendLayout();
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.DragPanel;
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanel.Location = new System.Drawing.Point(140, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(633, 42);
            this.DragPanel.TabIndex = 6;
            // 
            // browse1
            // 
            this.browse1.Location = new System.Drawing.Point(140, 48);
            this.browse1.Name = "browse1";
            this.browse1.Size = new System.Drawing.Size(633, 299);
            this.browse1.TabIndex = 5;
            // 
            // navigationPanel1
            // 
            this.navigationPanel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.navigationPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel1.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel1.Name = "navigationPanel1";
            this.navigationPanel1.Size = new System.Drawing.Size(140, 347);
            this.navigationPanel1.TabIndex = 3;
            this.navigationPanel1.Load += new System.EventHandler(this.navigationPanel1_Load_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 347);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.browse1);
            this.Controls.Add(this.navigationPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneDragControl DragControl;
        private Frontend.UserControls.NavigationPanel navigationPanel1;
        private Frontend.UserControls.Browse browse1;
        private Guna.UI.WinForms.GunaPanel DragPanel;
    }
}

