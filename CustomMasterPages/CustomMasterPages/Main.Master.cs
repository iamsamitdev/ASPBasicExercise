using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomMasterPages
{
	public partial class Main : System.Web.UI.MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string activepage = Request.RawUrl;
			if (activepage.Contains("Default.aspx"))
			{
				page_default.Attributes.Add("class", "active");
			}
			else if (activepage.Contains("About.aspx"))
			{
				page_about.Attributes.Add("class", "active");
			}
			else
			{
				page_default.Attributes.Add("class", "active");
			}
		}
	}
}