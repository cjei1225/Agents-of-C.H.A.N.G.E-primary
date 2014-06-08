using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace AgentsOfChange3
{
    public partial class Mission_PivotPage : PhoneApplicationPage
    {
        private string user = "USER";
        private string mission = "MISSION";

        public string Mission
        {
            get { return mission; }
            set { mission = value; }
        }

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public Mission_PivotPage()
        {
            InitializeComponent();
            //textblock_yourMission.Text = "Your mission agent " + User + ", should you choose to accept it, " + mission;
        }
    }
}