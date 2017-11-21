using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicProgrammingInASP
{
	public partial class IsPostbackForm : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (Page.IsPostBack == true)
			{
				Response.Write(lbresult.Text);
				lbresult.Text = null;
			}
		}

		protected void btnEnter_Click(object sender, EventArgs e)
		{
			lbresult.Text = txtsubject.Text;
		}
	}
}