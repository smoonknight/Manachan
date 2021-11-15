
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manachan
{
    public partial class ManachanDesktopForm : Form
    {
        public ManachanDesktopForm()
        {
            InitializeComponent();
        }

        private void ChattingButton_Click(object sender, EventArgs e)
        {
            ActiveUnitControls(chattingUC1, ChattingActiveIcon,ChattingActiveIconExtend.Tag.ToString(), ChattingActiveIconExtend.BackColor);
        }
        private async void HoverContent(Panel p)
        {
                while (p.Size.Width < 50)
                {
                    await Task.Delay(5);
                    p.Size = new Size(p.Size.Width * 2, p.Size.Height);
                }
                p.Size = new Size(50, p.Size.Height);

        }
        private async void LeaveContent(Panel p)
        {

                while (p.Size.Width > 10)
                {
                    await Task.Delay(5);
                    p.Size = new Size(p.Size.Width - 10, p.Size.Height);
                }
                p.Size = new Size(10, p.Size.Height);

        }
        private void ActiveUnitControls(UserControl uc, Panel p , string tag, Color color)
        {
            DashboardActiveIcon.BackColor = Color.FromArgb(245, 246, 250);
            ChattingActiveIcon.BackColor = Color.FromArgb(245, 246, 250);
            ConfigureActiveIcon.BackColor = Color.FromArgb(245, 246, 250);
            AboutActiveIcon.BackColor = Color.FromArgb(245, 246, 250);
            uc.BringToFront();
            string[] text = tag.Split('&');
            p.BackColor = color;
            ActiveUserControlLabel.Text = text[0];
            DescriptionUserControlLabel.Text = text[1];
            ActiveBarPanel.BackColor = color;
        }

        private void DashboardButton_MouseHover(object sender, EventArgs e)
        {
            HoverContent(DashboardActiveIconExtend);
        }

        private void DashboardButton_MouseLeave(object sender, EventArgs e)
        {
            LeaveContent(DashboardActiveIconExtend);
        }

        private void ChattingButton_MouseHover(object sender, EventArgs e)
        {
            HoverContent(ChattingActiveIconExtend);
        }

        private void ChattingButton_MouseLeave(object sender, EventArgs e)
        {
            LeaveContent(ChattingActiveIconExtend);
        }

        private void ConfigureButton_MouseHover(object sender, EventArgs e)
        {
            HoverContent(ConfigureActiveIconExtend);
        }

        private void ConfigureButton_MouseLeave(object sender, EventArgs e)
        {
            LeaveContent(ConfigureActiveIconExtend);
        }

        private void AboutButton_MouseHover(object sender, EventArgs e)
        {
            HoverContent(AboutActiveIconExtend);
        }

        private void AboutButton_MouseLeave(object sender, EventArgs e)
        {
            LeaveContent(AboutActiveIconExtend);
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            ActiveUnitControls(dashboardUC1, DashboardActiveIcon, DashboardActiveIconExtend.Tag.ToString(), DashboardActiveIconExtend.BackColor);
        }

        private void ConfigureButton_Click(object sender, EventArgs e)
        {
            ActiveUnitControls(configureUC1, ConfigureActiveIcon, ConfigureActiveIconExtend.Tag.ToString(), ConfigureActiveIconExtend.BackColor);
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            ActiveUnitControls(aboutUC1, AboutActiveIcon, AboutActiveIconExtend.Tag.ToString(), AboutActiveIconExtend.BackColor);
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {

        }
    }
}
