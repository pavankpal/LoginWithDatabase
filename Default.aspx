<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <table>
          <tr>
              <td colspan="3" style="background-color:red; color:white;text-align:center">
                 <h1> Login Here</h1>
              </td>
          </tr>
          <tr>
               <td>
                   User ID:
               </td>
              <td>
                  <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
              </td>
              <td>

              </td>
          </tr>
          <tr>
               <td>
                   Password:
               </td>
              <td>
                  <asp:TextBox ID="txtpwd" TextMode="Password" runat="server"></asp:TextBox>
              </td>
              <td>

              </td>
          </tr>
          <tr>
              <td colspan="3"></td>
          </tr>
           <tr>
              <td colspan="3"></td>
          </tr>
           <tr>
              <td colspan="3">
                  <asp:Label ID="Label1" runat="server" ></asp:Label>
              </td>
          </tr>
           <tr>
              <td colspan="3">
                  <asp:Button ID="btnlog" runat="server" Text="Login" OnClick="btnlog_Click" />
              </td>
          </tr>

      </table>
    </div>
    </form>
</body>
</html>
