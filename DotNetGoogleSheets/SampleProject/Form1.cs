using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetGoogleSheets;
using Google.GData.Client;

namespace SampleProject
{
    public partial class Form1 : Form
    {
        Sheeting.AuthorizationResponse authorizationResponse;
        OAuth2Parameters parameters;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            Sheeting sheets = new Sheeting();
            authorizationResponse=sheets.GetOAuthUrl(txtClientID.Text, txtClientSecret.Text, "");
            lnkAuthUrl.Text = authorizationResponse.authorizationUrl;
            lnkAuthUrl.Visible = true;
            lblAuthInstructions.Visible = true;
            txtAccessCode.Visible = true;
            btnContinue.Visible = true;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Sheeting sheets = new Sheeting();
            parameters=sheets.GetToken(authorizationResponse.parameters, txtAccessCode.Text);
            MessageBox.Show("Access Token:" + parameters.AccessToken);
        }

        private void lnkAuthUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lnkAuthUrl.Text);
        }
    }
}
