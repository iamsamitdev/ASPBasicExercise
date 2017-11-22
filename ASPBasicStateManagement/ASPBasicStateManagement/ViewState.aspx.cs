using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPBasicStateManagement
{
	public partial class ViewState : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// Create State
			if (IsPostBack)
			{
				// เช็คว่าตัวแปร count มีข้อมูล
				if (ViewState["count"] != null)
				{
					int ViewStateVal = Convert.ToInt32(ViewState["count"]) + 1;
					lbResult.Text = ViewStateVal.ToString();
					ViewState["count"] = ViewStateVal.ToString();
				}
				else
				{
					// ถ้าไม่มีข้อมูล
					ViewState["count"] = "1";
				}
			}
		}

		protected void btnCount_Click(object sender, EventArgs e)
		{
			lbResult.Text = ViewState["count"].ToString();
		}
	}
}