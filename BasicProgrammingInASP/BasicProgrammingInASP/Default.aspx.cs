using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicProgrammingInASP
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

			int qty;
			Int32 data;
			double price;
			Double totalPrice;
			string name;
			String Name;
			Single mydata;
			float mydatas;

			char person = 'b';
			string myperson = "Boy Patt";
			Response.Write(myperson);

			var x = "1";
			var y = 2;
			var z = 3.5;

			Response.Write(y + z);


		}
	}
}