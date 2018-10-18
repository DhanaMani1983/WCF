<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WCFTraining._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WCF Hello World</title>
    <script src="//code.jquery.com/jquery-1.11.0.min.js"></script>
    <script>
        function getDate(datestr) {
            var s = "new " + datestr.replace(/\//g, "");
            return eval(s);
        }
        $(
            function () {
                $("#<%= btnHello.ClientID %>").click(
                        function () {
                            $.ajax(
                                {
                                    url: "/Services/HelloWorld.svc/Hello",
                                    type: "post",
                                    dataType: "json",
                                    contentType: "application/json",
                                    success: function (data) {
                                        // var s = data.Name + " - " + getDate(data.ServerTime);
                                        alert(data);
                                    }
                                }
                                );
                            return false;
                        }
                    );
                $("#<%= btnDataContract.ClientID %>").click(
                       function () {
                           $.ajax(
                               {
                                   url: "/Services/HelloWorld.svc/getPerson",
                                   type: "post",
                                   dataType: "json",
                                   contentType: "application/json",
                                   success: function (data) {
                                       var s = data.Name + " - " + getDate(data.DateOfBirth);
                                       alert(s);
                                   }
                               }
                               );
                           return false;
                       }
                   );
            }
            );
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:Button ID="btnHello" runat="server" Text="JQuery Ajax Hello" />
            <asp:Button ID="btnDataContract" runat="server" Text="JQuery Ajax Data Contract" />
            <br />
            <br />
            <asp:Button ID="btnWCFLibraryCall" runat="server" Text="WCF Library Call" OnClick="btnWCFLibraryCall_Click" />
            <asp:Button ID="btnCustomers" runat="server" Text="WCF Customer List" OnClick="btnCustomers_Click" />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
    </div>
    </form>
</body>
</html>
