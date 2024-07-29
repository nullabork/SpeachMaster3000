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

            typeInput.Text = GoogleAuthSettings.Instance.Type;
            projectIdInput.Text = GoogleAuthSettings.Instance.ProjectId;
            privateKeyIdInput.Text = GoogleAuthSettings.Instance.PrivateKeyId;
            privateKeyInput.Text = GoogleAuthSettings.Instance.PrivateKey;
            clientEmailInput.Text = GoogleAuthSettings.Instance.ClientEmail;
            clientIdInput.Text = GoogleAuthSettings.Instance.ClientId;
            authUriInput.Text = GoogleAuthSettings.Instance.AuthUri;
            tokenUriInput.Text = GoogleAuthSettings.Instance.TokenUri;
            authProviderX509CertUrlInput.Text = GoogleAuthSettings.Instance.AuthProviderX509CertUrl;
            clientX509CertUrlInput.Text = GoogleAuthSettings.Instance.ClientX509CertUrl;
        }


        private void saveButton_Click_1(object sender, EventArgs e)
        {
            GoogleAuthSettings.Instance.Type = typeInput.Text;
            GoogleAuthSettings.Instance.ProjectId = projectIdInput.Text;
            GoogleAuthSettings.Instance.PrivateKeyId = privateKeyIdInput.Text;
            GoogleAuthSettings.Instance.PrivateKey = privateKeyInput.Text;
            GoogleAuthSettings.Instance.ClientEmail = clientEmailInput.Text;
            GoogleAuthSettings.Instance.ClientId = clientIdInput.Text;
            GoogleAuthSettings.Instance.AuthUri = authUriInput.Text;
            GoogleAuthSettings.Instance.TokenUri = tokenUriInput.Text;
            GoogleAuthSettings.Instance.AuthProviderX509CertUrl = authProviderX509CertUrlInput.Text;
            GoogleAuthSettings.Instance.ClientX509CertUrl = clientX509CertUrlInput.Text;

            GoogleAuthSettings.Instance.Save();
        }
    }
}
