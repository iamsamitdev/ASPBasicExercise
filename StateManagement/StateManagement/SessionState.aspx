<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionState.aspx.cs" Inherits="StateManagement.SessionState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >

   <head runat="server">
      <title>
         Untitled Page
      </title>
   </head>
   
   <body>
      <form id="form1" runat="server">
         <div>
            &nbsp; &nbsp; &nbsp;
            
            <table style="width: 568px; height: 103px">
            
               <tr>
                  <td style="width: 209px">
                     <asp:Label ID="lblstr" runat="server" Text="Enter a String"  style="width:94px">
                     </asp:Label>
                  </td>
					
                  <td style="width: 317px">
                     <asp:TextBox ID="txtstr" runat="server" style="width:227px">
                     </asp:TextBox>
                  </td>
               </tr>
	
               <tr>
                  <td style="width: 209px"> </td>
                  <td style="width: 317px"> </td>
               </tr>
	
               <tr>
                  <td style="width: 209px">
                     <asp:Button ID="btnnrm" runat="server" 
                        Text="No action button" style="width:128px" />
                  </td>
	
                  <td style="width: 317px">
                     <asp:Button ID="btnstr" runat="server" 
                        OnClick="btnstr_Click" Text="Submit the String" />
                  </td> 
               </tr>
	
               <tr>
                  <td style="width: 209px">  
					  <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear Session" Width="127px" />
				   </td>
	
                  <td style="width: 317px">  </td>  
               </tr>
	
               <tr>
                  <td style="width: 209px">
                     <asp:Label ID="lblsession" runat="server"  style="width:231px"  >
                     </asp:Label>
                  </td>
	
                  <td style="width: 317px">  </td>
               </tr>
	
               <tr>
                  <td style="width: 209px">
                     <asp:Label ID="lblshstr" runat="server">
                     </asp:Label>
                  </td>
	
                  <td style="width: 317px">  
					  <asp:LinkButton ID="linkShowData" runat="server" PostBackUrl="~/ShowSessionData.aspx">Show Session Data</asp:LinkButton>
				   </td>
               </tr>
               
            </table>
            
         </div>
      </form>
   </body>
</html>
