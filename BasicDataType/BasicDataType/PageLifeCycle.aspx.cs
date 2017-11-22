using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicDataType
{
	public partial class PageLifeCycle : System.Web.UI.Page
	{
		private void Page_PreRender(object sender, EventArgs e)
		{
			Response.Write("เกิดเหตุการณ์ Page_PreRender()<br>");
		}

		private void Page_Init(object sender, EventArgs e)
		{
			Response.Write("เกิดเหตุการณ์ Page_Init()<br>");
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			Response.Write("เกิดเหตุการณ์ Page_Load()<br>");
		}

	}
}