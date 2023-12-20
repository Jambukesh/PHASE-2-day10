using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ProductRegistration : System.Web.UI.Page
    {
       // public object TextBox2 { get; private set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            Label1.Visible = false;
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label1.Text = "Product Registration Success!!!";
            Label1.Text += "<br/>Product Name: " + TextBox1.Text;
            Label1.Text += "<br/>Product Catogory: " + DropDownList .Text;
            Label1.Text += "<br/>Product Description" + TextBox3  ;
            Label1.Text += "<br/>Product Release Date: " + Calendar .SelectedDate.ToShortDateString();
        }
    }
}