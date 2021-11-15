using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manachan.UserControls
{
    public partial class ChattingUC : UserControl
    {
        public ChattingUC()
        {
            InitializeComponent();
        }
        string ChatTextFilter(string ChatText)
        {
            string[] raw = ChatText.Split(' ');
            string line = "";
            string result = "";
            int count = 0;
            while(count < raw.Count())
            {
                while (line.Count() < 45 && count < raw.Count())
                {
                    line += raw[count] + " ";
                    count++;
                }
                result += line + "\n";
                line = "";
            }
            return result;
        }
        void SendMsg(string ChatText, bool Sender = true)
        {
            ChatText = ChatText.Count() > 45 ? ChatTextFilter(ChatText) : ChatText;

            FlowLayoutPanel container = new FlowLayoutPanel();
            container.AutoSize = true;
            container.Dock = DockStyle.Bottom;
            container.FlowDirection = (Sender == true ? FlowDirection.RightToLeft : FlowDirection.LeftToRight);
            ChatDisplayPanel.Controls.Add(container);

            PictureBox ProfilePicture = new OvalPictureBox();
            ProfilePicture.Size = new Size(35, 35);
            ProfilePicture.ImageLocation = Sender == true ? "https://cf.shopee.co.id/file/58b0021bc47cb641c8b0af56d19e475c" : "";
            container.Controls.Add(ProfilePicture);

            Panel ChatTextPanel = new Panel();
            ChatTextPanel.AutoSize = true;
            ChatTextPanel.Padding = new Padding(5);
            ChatTextPanel.BackColor = (Sender == true ? Color.FromArgb(223, 228, 234) : Color.FromArgb(87, 96, 111));
            container.Controls.Add(ChatTextPanel);

            Label ChatTextLabel = new Label();
            ChatTextLabel.Text = ChatText;
            ChatTextLabel.AutoSize = true;
            ChatTextLabel.Padding = new Padding(5);
            ChatTextLabel.ForeColor = (Sender == true ? Color.FromArgb(116, 125, 140) : Color.WhiteSmoke);
            ChatTextLabel.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChatTextPanel.Controls.Add(ChatTextLabel);

            ChatDisplayPanel.AutoScrollPosition = new Point(
                container.Right - ChatDisplayPanel.AutoScrollPosition.X, 
                container.Bottom - ChatDisplayPanel.AutoScrollPosition.Y);
        }
        private async void ChatResponse(string ChatText)
        {
            await Task.Delay(1000);
            SendMsg("Dalam perkembangan", false);
        }
        private async void AlertPanel(Panel p)
        {
            while (p.Location.X > 447)
            {
                await Task.Delay(10);
                p.Location = new Point(p.Location.X - 5, p.Location.Y);
            }
            await Task.Delay(1000);
            while (p.Location.X < 600)
            {
                await Task.Delay(10);
                p.Location = new Point(p.Location.X + 5, p.Location.Y);
            }
            p.Location = new Point(600, p.Location.Y);
        }

        private void SendMsgBox_Click(object sender, EventArgs e)
        {
            if (ChatTextbox.Text == "Write a message...") 
            {
                if(AlertMsgPanel.Location.X == 600)
                {
                    AlertPanel(AlertMsgPanel);
                }
            }
            else
            {
                SendMsg(ChatTextbox.Text);
                ChatTextbox.Text = "";
                ChatResponse(ChatTextbox.Text);
            }
        }

        private void ChatTextbox_Enter(object sender, EventArgs e)
        {
            ChatTextbox.Text = ChatTextbox.Text == "Write a message..." ? "" : ChatTextbox.Text;
        }

        private void ChatTextbox_Leave(object sender, EventArgs e)
        {
            ChatTextbox.Text = ChatTextbox.Text == "" ? "Write a message..." : ChatTextbox.Text;
        }
    }
}
