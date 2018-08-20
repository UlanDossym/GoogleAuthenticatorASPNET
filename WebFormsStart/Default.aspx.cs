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
        var setupInfo = tfa.GenerateSetupCode("MyApp", "user@example.com", "SuperSuperSuperSecretKeyGoesHere", 300, 300);
        var setupInfo2 = tfa.GetCurrentPIN("SuperSuperSuperSecretKeyGoesHere");
        lblSecretCode.Text = setupInfo2;
        string qrCodeImageUrl = setupInfo.QrCodeSetupImageUrl;
        string manualEntrySetupCode = setupInfo.ManualEntryKey;
        bool isCorrectPIN = tfa.ValidateTwoFactorPIN("SuperSuperSuperSecretKeyGoesHere", setupInfo2);
        lblCheck.Text = isCorrectPIN.ToString();
        imgQRcode.ImageUrl = qrCodeImageUrl;
        imgQRcode.Width = 300;
        imgQRcode.Height = 300;
        //if (Request.Cookies.Get("fingerprint") == null)
        //{
        //    HttpCookie cookie = new HttpCookie("fingerprint");
        //    cookie.Value = lblFingerprint.Text;
        //    DateTime dt = DateTime.Now;
        //    cookie.Expires = dt.AddDays(30);
        //    Response.Cookies.Add(cookie);
        //}
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
        bool isCorrectPIN = tfa.GetCurrentPIN("SuperSuperSuperSecretKeyGoesHere") == NameTextBox.Text;
        lblCheck.Text = isCorrectPIN.ToString();
    }
}