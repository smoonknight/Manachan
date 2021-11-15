using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manachan.UserControls
{
    public partial class ConfigureUC : UserControl
    {
        public ConfigureUC()
        {
            InitializeComponent();

        }

        private async void ActiveButtonAnimMove(Button Source, Button Actived)
        {
            Actived.Text = "";
            while (Source.Location.X >= Actived.Location.X)
            {
                await Task.Delay(1);
                Actived.Location = new Point(Actived.Location.X + 11, Actived.Location.Y);
            }

            Source.Location = new Point(Source.Location.X, Source.Location.Y);
            while (Source.Location.X <= Actived.Location.X)
            {
                await Task.Delay(1);
                Actived.Location = new Point(Actived.Location.X - 11, Actived.Location.Y);
            }
            Actived.Location = new Point(Source.Location.X, Source.Location.Y);
            Actived.Text = Source.Text;
        }

        private async void ActiveButtonAnimHeight(Button Source, Button Actived)
        {
            Actived.Text = "";
            Actived.Location = new Point(Source.Location.X, Source.Location.Y);
            Actived.Width = 0;
            while (Actived.Width < 75)
            {
                await Task.Delay(1);
                Actived.Width += 10;
            }
            Actived.Width = 75;
            Actived.Text = Source.Text;
        }

        private async void ToggleTagHelpPanel()
        {
            
            if(HelpTagPanel.Height == 0)
            {
                HelpTagPanel.Width = 210;
                HelpTagPanel.Height = 0;
                while (HelpTagPanel.Height < 170)
                {
                    await Task.Delay(1);
                    HelpTagPanel.Height += 10;
                }
                HelpTagPanel.Height = 170;
            }
            else if(HelpTagPanel.Height > 0)
            {
                HelpTagPanel.Height = 170;
                while (HelpTagPanel.Height > 0)
                {
                    await Task.Delay(1);
                    HelpTagPanel.Height -= 10;
                }
                HelpTagPanel.Width = 0;
            }   
        }
        private void ActivedButtonRule_Click(object sender, EventArgs e)
        {
            string Text = "";
            Button button = sender as Button;
            if(button.Text == "Insert")
            {
                Text = "[title] telah ditambahkan";
            }
            else if(button.Text == "Delete")
            {
                Text = "Tugas telah terhapus";
            }
            else if(button.Text == "Add data")
            {
                Text = "User data telah ditambahkan";
            }
            else if(button.Text == "Update")
            {
                Text = "Data telah diupdate";
            }
            else if(button.Text == "Custom")
            {
                Text = "Hello World";
            }
            else if(button.Text == "Select")
            {
                Text = "[title]\n" +
                "Dateline:[dateline]\n" +
                "Label:[label]\n" +
                "Category:[category]\n\n" +
                "[description]\n" +
                "Assignment to [assignment]\n\n" +
                "User data\n" +
                "[userdata]\n\n" +
                "-[codedata] -";
            }
            else if(button.Text == "List")
            {
                Text = "List of Data\n" +
                    "[codedata]";
            }
            ActiveButtonAnimHeight(button, ActivedRuleButton);
            ResponseRichTextbox.Text = Text;
        }

        private void ActivedButtonTarget_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            ActiveButtonAnimMove(button, ActivedTargetUsageButton);
        }

        private void WriteCommand_Enter(object sender, EventArgs e)
        {
            WriteCommandBox.Text = WriteCommandBox.Text == "Write a command ..." ? "" : WriteCommandBox.Text;
        }

        private void WriteCommand_Leave(object sender, EventArgs e)
        {
            WriteCommandBox.Text = WriteCommandBox.Text == "" ? "Write a command ..." : WriteCommandBox.Text;
        }

        private void CustomResponseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ResponseRichTextbox.Enabled = CustomResponseCheckbox.Checked == true ? true : false;
        }



        private void HoverHelpTagButton_Click(object sender, EventArgs e)
        {
            ToggleTagHelpPanel();
        }
    }
}
