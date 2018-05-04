<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Login.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowEditing="GridView1_RowEditing" OnRowDeleting="GridView1_RowDeleting" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="Btn_edit" runat="server" Text="Edit" />
                        <asp:Button ID="Btn_del" runat="server" Text="Delete" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Button ID="Btn_update" runat="server" Text="Button" />
                        <asp:Button ID="Btn_cancel" runat="server" Text="Button" />
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="FirstName">
                    <ItemTemplate>
                        <asp:Label ID="Lbl_FName" runat="server" Text="Label"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
