using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicDataType
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// Data type in C#

			int age = 35;
			Int32 qty = 100;
			byte piece = 10;
			sbyte data = -80;

			//float price = 20.40;
			//Single totalPrice = 3200.75;
			Double sumprice = 30.50;
			double vat = 7.5;

			char type = 'A';
			String province = "Bangkok";
			string fullname = "Samit Koyom";

			bool status = true;
			Boolean stat = false;

			var x = "2.5";
			var y = 2;
			var z = 3.5;

			Response.Write(province+"<br>");
			Response.Write(qty * piece + "<br>");
			Response.Write(qty * sumprice + "<br>");
			Response.Write(data * vat + "<br>");

			Response.Write((Convert.ToDouble(x)) + y);
		}
	}
}