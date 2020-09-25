using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace Admin_Panel_Authgg
{
    public partial class AdminPanel : Form
    {
        
        public AdminPanel()
        {
            InitializeComponent();
            banneroldmodz95.Visible = true;
        }

        WebClient PanelAdmin = new WebClient();
        public static string authgg = "https://developers.auth.gg";
        public static string API = "API AUTH.GG";

        private void timerkey_Tick(object sender, EventArgs e)
        {
            timerkey.Stop();
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            loghwid.Text = PanelAdmin.DownloadString(authgg + "/HWID/?type=fetch&authorization=" + API + "&user=" + usernamehwidinfos.Text);
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            loghwid.Text = PanelAdmin.DownloadString(authgg + "/HWID/?type=reset&authorization=" + API + "&user=" + usernamehawidreset.Text);
        }

        private void siticoneRoundedButton5_Click(object sender, EventArgs e)
        {
            logsuser.Text = PanelAdmin.DownloadString(authgg + "/USERS/?type=fetchall&authorization=" + API);
        }

        private void siticoneRoundedButton4_Click(object sender, EventArgs e)
        {
            logsuser.Text = PanelAdmin.DownloadString(authgg + "/USERS/?type=fetch&authorization=" + API + "&user=" + userinfostext.Text);
        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            logsuser.Text = PanelAdmin.DownloadString(authgg + "/USERS/?type=delete&authorization=" + API + "&user=" + deletuser.Text);
        }

        private void siticoneRoundedButton7_Click(object sender, EventArgs e)
        {
            loguser1.Text = PanelAdmin.DownloadString(authgg + "/USERS/?type=editvar&authorization=" + API + "&user=" + edituser.Text + "&value=" + editvar.Text);
        }

        private void siticoneRoundedButton6_Click(object sender, EventArgs e)
        {
            loguser1.Text = PanelAdmin.DownloadString(authgg + "/USERS/?type=changepw&authorization=" + API + "&user=" + userpass.Text + "&password=" + passpass.Text);
        }

        private void validusercount_Click(object sender, EventArgs e)
        {
            loguser1.Text = PanelAdmin.DownloadString(authgg + "/USERS/?type=count&authorization=" + API);
        }

        private void countlicenses_Click(object sender, EventArgs e)
        {
            loglicense.Text = PanelAdmin.DownloadString(authgg + "/LICENSES/?type=count&authorization=" + API);

        }

        private void alllicenses_Click(object sender, EventArgs e)
        {
            loglicense.Text = PanelAdmin.DownloadString(authgg + "/LICENSES/?type=fetchall&authorization=" + API);
        }

        private void siticoneRoundedButton10_Click(object sender, EventArgs e)
        {
            loglicense.Text = PanelAdmin.DownloadString(authgg + "/LICENSES/?type=unuse&license=" + unuselicense.Text + "&authorization=" + API);
        }

        private void siticoneRoundedButton11_Click(object sender, EventArgs e)
        {
            loglicense.Text = PanelAdmin.DownloadString(authgg + "/LICENSES/?type=use&license=" + uselicense.Text + "&authorization=" + API);
        }

        private void siticoneRoundedButton8_Click(object sender, EventArgs e)
        {
            loglicense1.Text = PanelAdmin.DownloadString(authgg + "/LICENSES/?type=fetch&authorization=" + API + "&license=" + fetchlicenseinfos.Text);
        }

        private void siticoneRoundedButton9_Click(object sender, EventArgs e)
        {
            loglicense1.Text = PanelAdmin.DownloadString(authgg + "/LICENSES/?type=delete&license=" + deletlicense.Text + "&authorization=" + API);
        }

        private void siticoneRoundedButton12_Click(object sender, EventArgs e)
        {
            loglicense1.Text = PanelAdmin.DownloadString(authgg + "/LICENSES/?type=generate&days=" + days.Text + "&amount=" + amount.Text + "&level=" + level.Text + "&authorization=" + API);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void clic_Click(object sender, EventArgs e)
        {
            loghwid.Clear();
            logsuser.Clear();
            loguser1.Clear();
            loglicense.Clear();
            loglicense1.Clear();
        }

        private void userinfostext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fetchvalid.PerformClick();
                e.Handled = true;
            }
        }

        private void deletuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                deletuservalid.PerformClick();
                e.Handled = true;
            }
        }

        private void edituser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                edituservalid.PerformClick();
                e.Handled = true;
            }
        }

        private void editvar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                edituservalid.PerformClick();
                e.Handled = true;
            }
        }

        private void userpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changepassvalid.PerformClick();
                e.Handled = true;
            }
        }

        private void passpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changepassvalid.PerformClick();
                e.Handled = true;
            }
        }

        private void usernamehwidinfos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gethwidvalid.PerformClick();
                e.Handled = true;
            }
        }

        private void usernamehawidreset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                resethwidvalid.PerformClick();
                e.Handled = true;
            }
        }

        private void unuselicense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                unuselicensevalid.PerformClick();
                e.Handled = true;
            }
        }

        private void uselicense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                uselicensevalid.PerformClick();
                e.Handled = true;
            }
        }

        private void fetchlicenseinfos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                infoslicensevalid.PerformClick();
                e.Handled = true;
            }
        }

        private void deletlicense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                deletuservalid.PerformClick();
                e.Handled = true;
            }
        }

        private void days_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                deletuservalid.PerformClick();
                e.Handled = true;
            }
        }

        private void amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                deletuservalid.PerformClick();
                e.Handled = true;
            }
        }

        private void level_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                deletuservalid.PerformClick();
                e.Handled = true;
            }
        }

        private void siticoneRoundedButton1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://oldmodz95.me");
        }

        private void siticoneRoundedButton2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://authgg.oldmodz95.me");
        }

        private void siticoneRoundedButton3_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/3t2568W");
        }

        private void siticoneRoundedButton4_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/GBH7Nk9");
        }
    }
}
