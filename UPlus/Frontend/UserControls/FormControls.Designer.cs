namespace UPlus.Frontend.UserControls
{
    partial class FormControls
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
            this.MinimiseControlBox = new Guna.UI.WinForms.GunaControlBox();
            this.CloseControlBox = new Guna.UI.WinForms.GunaControlBox();
            this.SuspendLayout();
            // 
            // MinimiseControlBox
            // 
            this.MinimiseControlBox.Animated = true;
            this.MinimiseControlBox.AnimationHoverSpeed = 0.07F;
            this.MinimiseControlBox.AnimationSpeed = 0.03F;
            this.MinimiseControlBox.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.MinimiseControlBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MinimiseControlBox.IconColor = System.Drawing.Color.Black;
            this.MinimiseControlBox.IconSize = 15F;
            this.MinimiseControlBox.Location = new System.Drawing.Point(0, 0);
            this.MinimiseControlBox.Name = "MinimiseControlBox";
            this.MinimiseControlBox.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.MinimiseControlBox.OnHoverIconColor = System.Drawing.Color.White;
            this.MinimiseControlBox.OnPressedColor = System.Drawing.Color.Black;
            this.MinimiseControlBox.Size = new System.Drawing.Size(45, 33);
            this.MinimiseControlBox.TabIndex = 3;
            // 
            // CloseControlBox
            // 
            this.CloseControlBox.Animated = true;
            this.CloseControlBox.AnimationHoverSpeed = 0.07F;
            this.CloseControlBox.AnimationSpeed = 0.03F;
            this.CloseControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseControlBox.IconColor = System.Drawing.Color.Black;
            this.CloseControlBox.IconSize = 15F;
            this.CloseControlBox.Location = new System.Drawing.Point(52, 0);
            this.CloseControlBox.Name = "CloseControlBox";
            this.CloseControlBox.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.CloseControlBox.OnHoverIconColor = System.Drawing.Color.White;
            this.CloseControlBox.OnPressedColor = System.Drawing.Color.Black;
            this.CloseControlBox.Size = new System.Drawing.Size(45, 33);
            this.CloseControlBox.TabIndex = 2;
            // 
            // FormControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MinimiseControlBox);
            this.Controls.Add(this.CloseControlBox);
            this.Name = "FormControls";
            this.Size = new System.Drawing.Size(97, 33);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaControlBox MinimiseControlBox;
        private Guna.UI.WinForms.GunaControlBox CloseControlBox;
    }
}
