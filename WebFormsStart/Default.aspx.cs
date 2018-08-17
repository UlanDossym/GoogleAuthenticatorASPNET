using Google.Authenticator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
        var setupInfo = tfa.GenerateSetupCode("MyApp", "user@example.com", "SuperSecretKeyGoesHere", 300, 300);
        var setupInfo2 = tfa.GetCurrentPIN("SuperSecretKeyGoesHere");
        lblSecretCode.Text = setupInfo2;
        string qrCodeImageUrl = setupInfo.QrCodeSetupImageUrl;
        string manualEntrySetupCode = setupInfo.ManualEntryKey;
        bool isCorrectPIN = tfa.ValidateTwoFactorPIN("SuperSecretKeyGoesHere", "123456");
        imgQRcode.ImageUrl = qrCodeImageUrl;
        imgQRcode.Width = 300;
        imgQRcode.Height = 300;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        OutputLabel.Text = NameTextBox.Text;
    }
}