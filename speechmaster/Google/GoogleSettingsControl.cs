using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace speechmaster
{
    public partial class GoogleSettingsControl : UserControl
    {
        public GoogleSettingsControl()
        {
            InitializeComponent();

            typeInput.Text = GoogleAuthSettings.Instance.type;
            projectIdInput.Text = GoogleAuthSettings.Instance.projectId;
            privateKeyIdInput.Text = GoogleAuthSettings.Instance.privateKeyId;
            privateKeyInput.Text = GoogleAuthSettings.Instance.privateKey;
            clientEmailInput.Text = GoogleAuthSettings.Instance.clientEmail;
            clientIdInput.Text = GoogleAuthSettings.Instance.clientId;
            authUriInput.Text = GoogleAuthSettings.Instance.authUri;
            tokenUriInput.Text = GoogleAuthSettings.Instance.tokenUri;
            authProviderX509CertUrlInput.Text = GoogleAuthSettings.Instance.authProviderX509CertUrl;
            clientX509CertUrlInput.Text = GoogleAuthSettings.Instance.clientX509CertUrl;
        }


        private void saveButton_Click_1(object sender, EventArgs e)
        {
            GoogleAuthSettings.Instance.type = typeInput.Text;
            GoogleAuthSettings.Instance.projectId = projectIdInput.Text;
            GoogleAuthSettings.Instance.privateKeyId = privateKeyIdInput.Text;
            GoogleAuthSettings.Instance.privateKey = privateKeyInput.Text;
            GoogleAuthSettings.Instance.clientEmail = clientEmailInput.Text;
            GoogleAuthSettings.Instance.clientId = clientIdInput.Text;
            GoogleAuthSettings.Instance.authUri = authUriInput.Text;
            GoogleAuthSettings.Instance.tokenUri = tokenUriInput.Text;
            GoogleAuthSettings.Instance.authProviderX509CertUrl = authProviderX509CertUrlInput.Text;
            GoogleAuthSettings.Instance.clientX509CertUrl = clientX509CertUrlInput.Text;

            GoogleAuthSettings.Instance.Save();
        }
    }
}
