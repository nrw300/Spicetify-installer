using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;

namespace Spicetify_installer
{
    public partial class Form1 : Form
    {
        AutoItX3 auto = new AutoItX3();
        

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            auto.AutoItSetOption("SendKeyDelay", 11);
        }

        private void windows_install_btn_Click(object sender, EventArgs e)
        {
            windows_install_btn.Enabled = false;

            auto.WinActivate("[CLASS:CASCADIA_HOSTING_WINDOW_CLASS]");
            Console.WriteLine("Window open!");
            auto.Send("iwr -useb https://raw.githubusercontent.com/spicetify/spicetify-cli/master/install.ps1 | iex");
            auto.Send("{ENTER}");
            Console.WriteLine("Download started!");
            auto.WinActivate("Spicetify installer");
            Console.WriteLine("Please continue!");

            windows_continue_btn.Visible = true;
            label2.Visible = true;
        }

        private void windows_continue_btn_Click(object sender, EventArgs e)
        {
            auto.WinActivate("[CLASS:CASCADIA_HOSTING_WINDOW_CLASS]");
            Console.WriteLine("Window open");
            auto.Send("iwr -useb https://raw.githubusercontent.com/spicetify/spicetify-marketplace/main/resources/install.ps1 | iex");
            auto.Send("{ENTER}");
            Console.WriteLine("Install started!");
            auto.WinActivate("Spicetify installer");
            Console.WriteLine("Please exit!");

            windows_continue_btn.Visible = false;
            windows_install_btn.Visible = false;
            windows_lbl.Visible = false;
            label2.Visible = false;
            label1.Visible = false;

            close_btn.Visible = true;
            close_lbl.Visible = true;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            auto.WinWait("[CLASS:Chrome_WidgetWin_0]");

            Console.WriteLine("Goodbye!");
            auto.WinClose("[CLASS:CASCADIA_HOSTING_WINDOW_CLASS]");
            Application.Exit();
        }
    }
}
