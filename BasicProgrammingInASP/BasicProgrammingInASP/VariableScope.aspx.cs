using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicProgrammingInASP
{
	public partial class VariableScope : System.Web.UI.Page
	{
		// Web Form Scope variable
		string global_fullname = "Samit Koyom";

		protected void Page_Load(object sender, EventArgs e)
		{
			// Local Scope Variable
			string local_fullname = "Sarawut Kongdee";
			Response.Write(global_fullname+"<br>");
			Response.Write(local_fullname + "<br>");

			int row;
			for (row = 0; row <= 10; row++)
			{
				// Block Scope Variable
				string block_fullname = "Johny dept";
				Response.Write(row+"."+block_fullname+"<br>");
			}

		}

		protected void btn_showdata_Click(object sender, EventArgs e)
		{
			lbresult.Text = global_fullname;
		}
	}
}