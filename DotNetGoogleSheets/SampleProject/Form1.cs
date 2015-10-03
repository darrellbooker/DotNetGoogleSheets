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
using Google.GData.Spreadsheets;

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

        private void button1_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////////////////////////////////
            //// STEP 5: Make an OAuth authorized request to Google
            //////////////////////////////////////////////////////////////////////////////

            // Initialize the variables needed to make the request
            GOAuth2RequestFactory requestFactory =
                new GOAuth2RequestFactory(null, "TourTracking", parameters);
            SpreadsheetsService service = new SpreadsheetsService("TourTracking");
            service.RequestFactory = requestFactory;

            // Instantiate a SpreadsheetQuery object to retrieve spreadsheets.
            SpreadsheetQuery query = new SpreadsheetQuery();

            // Make a request to the API and get all spreadsheets.
            SpreadsheetFeed feed = service.Query(query);

            // Iterate through all of the spreadsheets returned
            foreach (SpreadsheetEntry entry in feed.Entries)
            {
                // Print the title of this spreadsheet to the screen
                MessageBox.Show(entry.Title.Text);
            }
        }
    }
}
