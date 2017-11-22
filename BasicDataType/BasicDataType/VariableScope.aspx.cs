using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicDataType
{
	public partial class VariableScope : System.Web.UI.Page
	{
		// Web form variable scope
		string fullname = "Samit Koyom";

		protected void Page_Load(object sender, EventArgs e)
		{
			// Local variable scope
			string fullname = "Johny Dept";
			Response.Write(fullname+"<br>"); // local variable
			Response.Write(this.fullname + "<br>"); // web form variable
			this.fullname = "Manut Putdee";
			Response.Write(this.fullname);

			for (int row = 1; row <= 10; row++)
			{
				// Block variable scope
				string product = "Electronic";
				Response.Write(row + "." + product+"<br>");
			}

		}

		protected void btn_sayHello_Click(object sender, EventArgs e)
		{
			fullname = "Somsak Wadee";
			lbResult.Text = "Hello " + fullname;
		}
	}
}