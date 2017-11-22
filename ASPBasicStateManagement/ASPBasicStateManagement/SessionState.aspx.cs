using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPBasicStateManagement
{
	public partial class SessionState : System.Web.UI.Page
	{
		// Web form varible
		string mystr;

		protected void Page_Load(object sender, EventArgs e)
		{
			// แสดงผลใน label ที่มาจาก textbox
			lbTextbox.Text = this.mystr;
			// แสดงผลใน label ที่มาจาก session
			lbResult.Text = (String)Session["sess_str"];
		}

		protected void btnNoSession_Click(object sender, EventArgs e)
		{
			lbTextbox.Text = txtFullname.Text.ToString();
		}

		protected void btnKeepSession_Click(object sender, EventArgs e)
		{
			this.mystr = txtFullname.Text;
			// เก็บลงตัวแปร session
			Session["sess_str"] = this.txtFullname.Text;
			// แสดงผลใน label ที่มาจาก textbox
			lbTextbox.Text = this.mystr;
			// แสดงผลใน label ที่มาจาก session
			lbResult.Text = (String)Session["sess_str"];
		}

		protected void btnRemoveSession_Click(object sender, EventArgs e)
		{
			this.Session.RemoveAll();
		}
	}
}