<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Q1.aspx.cs" Inherits="questionnaire.Q1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <p style="margin-left: 560px">
                </p>
        </div>
        <p style="margin-left: 560px">
            <asp:Label ID="Label1" runat="server" Text="1. Wht is the capital of India? "></asp:Label>          </p>
        <p style="margin-left: 560px">
            <asp:Label ID="Label2" runat="server" visible="false"></asp:Label>
        </p>
        <p style="margin-left: 560px">
            <asp:Label ID="Label3" runat="server" visible="false"></asp:Label>
        </p>
        <p style="margin-left: 560px">
            <asp:CheckBoxList ID="Options"   runat="server" OnSelectedIndexChanged="onlyone()" >
                <asp:ListItem Text="Kolkata" Value ="1"></asp:ListItem>
                <asp:ListItem Text ="Delhi" Value ="2"></asp:ListItem>
                <asp:ListItem Text ="Guwahati" Value ="3" ></asp:ListItem>
                <asp:ListItem Text ="Mumbai" Value ="4"></asp:ListItem>
                <asp:ListItem  Text ="Patna" Value ="5"></asp:ListItem>
            </asp:CheckBoxList>
        </p>
        <p style="margin-left: 560px">
            &nbsp;</p>
        <p style="margin-left: 560px">
            <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Next" OnClick="Button2_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Submit Test" OnClick="Button3_Click" />
        </p>
    </form>

      <script type="text/javascript">
          function onlyone() {


              if (document.getElementById(Options).onchange) {
                  alert("Inside JS");
              }


          }
      </script>
</body>
  
</html>

