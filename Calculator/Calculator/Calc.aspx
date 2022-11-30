<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calc.aspx.cs" Inherits="Calculator.Calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Button1 {
            width: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height:700px; display:flex; flex-direction:column;align-items:center;justify-content:center; gap:15px" >
            <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="1"  />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="2" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="3" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="4" />
            </div>
            <div>
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="5" />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="6" />
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="7" />
            <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="8" />
            </div>
            <div>
            <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="9" />
            <asp:Button ID="Button0" runat="server" OnClick="Button0_Click" Text="0" />
            </div>
            
            <div>
            <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" Text="+" />
            <asp:Button ID="ButtonSub" runat="server" OnClick="ButtonSub_Click" Text="-" />
            <asp:Button ID="ButtonMult" runat="server" OnClick="ButtonMult_Click" Text="*" />
            <asp:Button ID="ButtonDiv" runat="server" OnClick="ButtonDiv_Click" Text="/" />
            </div>
            <div>
                <asp:Button ID="ButtonEqual" runat="server" OnClick="ButtonEqual_Click" Text="Result" />
                 <asp:Button ID="ButtonClear" runat="server" OnClick="ButtonClear_Click" Text="Clear" />

            </div>
            <label id="test" runat="server"></label>
            <label id="final" runat="server"></label>
        </div>
    </form>
</body>
</html>
