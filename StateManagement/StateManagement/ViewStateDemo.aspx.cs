using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
	public partial class ViewStateDemo : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (IsPostBack)
			{
				if (ViewState["count"] != null)
				{
					int ViewStateVal = Convert.ToInt32(ViewState["count"]) + 1;
					Label1.Text = ViewStateVal.ToString();
					ViewState["count"] = ViewStateVal.ToString();
				}
				else
				{
					ViewState["count"] = "1";
				}
			}

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			Label1.Text = ViewState["count"].ToString();
		}
	}
}