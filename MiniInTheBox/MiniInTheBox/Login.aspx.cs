using MiniInTheBox.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiniInTheBox
{
    public partial class Login : System.Web.UI.Page
    {
        Container container = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            container = new Container();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Account account = null;
            account = container.LogIn(tbUsername.Text, tbPassword.Text);
            if(account != null)
            {
                Session["Account"] = tbUsername.Text;
                lblLogin.Text = "";
            }
            else
            {
                lblLogin.Text = "Inloggen Mislukt!";
            }
        }
    }
}