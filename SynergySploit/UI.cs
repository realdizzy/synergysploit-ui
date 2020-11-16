using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sxlib;
using sxlib.Specialized;
using System.IO;

namespace SynergySploit
{
    public partial class UI : Form
    {






    // If you see this, my code is very messy and im sorry about that lol.












        public bool Attached;
        public bool Loaded;
        public static string Direct = Directory.GetCurrentDirectory();
        public UI()
        {
            InitializeComponent();

            Functions.Lib = SxLib.InitializeWinForms(this, Direct);
            Functions.Lib.Load();
            Functions.Lib.LoadEvent += SynLoadEvent;

        }

        private void SynLoadEvent(SxLibBase.SynLoadEvents Event, object Param)
        {
            switch(Event)
            {
                case SxLibBase.SynLoadEvents.CHECKING_WL:
                    this.AttachingLabel.ForeColor = Color.FromArgb(255, 0, 0);
                    this.AttachingLabel.Text = "Status: Check WL";
                    return;
                case SxLibBase.SynLoadEvents.READY:
                    this.AttachingLabel.ForeColor = Color.FromArgb(0, 255, 0);
                    this.AttachingLabel.Text = "Status: Able to Attach";
                    this.Loaded = true;
                    return;

            }
        }

        private void SynAttachEvent(SxLibBase.SynAttachEvents Event, object Param)
        {
            switch(Event)
            {
                case SxLibBase.SynAttachEvents.INJECTING:
                    this.AttachingLabel.ForeColor = Color.FromArgb(255, 0, 0);
                    this.AttachingLabel.Text = "Status: Injecting";
                    return;
                case SxLibBase.SynAttachEvents.READY:
                    this.AttachingLabel.ForeColor = Color.FromArgb(0, 255, 0);
                    this.AttachingLabel.Text = "Status: Attached.";
                    return;
            }
        }





        private void ClearButton_Click(object sender, EventArgs e)
        {
            ScriptBox.Clear();
        }

        

        private void AttachButton_Click(object sender, EventArgs e)
        {
            Functions.Lib.Attach();
            Functions.Lib.AttachEvent += SynAttachEvent;
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            string script = this.ScriptBox.Text;
            Functions.Lib.Execute(script);
        }

        private void UI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
