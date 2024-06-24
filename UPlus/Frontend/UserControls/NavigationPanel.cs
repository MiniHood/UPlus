using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace UPlus.Frontend.UserControls
{
    public partial class NavigationPanel : UserControl
    {
        private Timer animationTimer = new Timer();
        private bool isCollapsing;
        private Control currentControl; // The control currently being animated

        public NavigationPanel()
        {
            InitializeComponent();
            animationTimer.Interval = 1; // Set the interval for smooth animation
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void NavigationPanel_Load(object sender, EventArgs e)
        {
            StartAnimation(PresetDropDown);
        }

        private void PresetButton_Click_1(object sender, EventArgs e)
        {
            StartAnimation(PresetDropDown);
        }

        private void StartAnimation(Control control)
        {
            if (animationTimer.Enabled) // If already animating, stop current animation
            {
                animationTimer.Stop();
                isCollapsing = !isCollapsing; // Toggle collapse state
            }

            currentControl = control;
            isCollapsing = currentControl.Height == currentControl.MinimumSize.Height;
            animationTimer.Start(); // Start new animation
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            switch (isCollapsing)
            {
                case true:
                    currentControl.Height += 10;
                    if (currentControl.Height >= currentControl.MaximumSize.Height)
                    {
                        currentControl.Height = currentControl.MaximumSize.Height;
                        animationTimer.Stop();
                    }
                    break;
                case false:
                    currentControl.Height -= 10;
                    if (currentControl.Height <= currentControl.MinimumSize.Height)
                    {
                        currentControl.Height = currentControl.MinimumSize.Height;
                        animationTimer.Stop();
                    }
                    break;
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            // TODO: Clean up everything after it's done
            Application.Exit();
        }
    }
}
