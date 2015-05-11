using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson2
{

    public partial class _default : System.Web.UI.Page
    {

        public int x;

        protected void Page_Load(object sender, EventArgs e)
        {
            //add code here
            //only increment x if the page is not being reloaded
            if (!IsPostBack){
                x = 0;
                 x++;
                 lblx.Text = x.ToString();
            }
           
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //get the current count of x from the label
            x = Convert.ToInt32(lblx.Text);
            x++;

            //increment the label value by 1 or just write x back to the label
            lblx.Text = x.ToString();

            //copy the value from txt box to the lable
            lblFirstName.Text = txtFirstName.Text;

            //also copy the value to the literal
            ltlFirstName.Text = txtFirstName.Text;

            //remove the text from the text box
            txtFirstName.Text = "";
        }
    }
}