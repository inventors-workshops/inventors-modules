<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResourceType.aspx.cs" Inherits="Inventors_Workshop.ResourceType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Textbox ID="Textbox1" runat="server" 
                DataKeyNames="ResourceTypeID" ItemType="Inventors_Workshop.Models.ResourceType" 
                SelectMethod="ShowResourceType">
        </asp:Textbox>
        
        <asp:Listview ID="TypeOfResource" runat="server" 
                DataKeyNames="ResourceTypeID" ItemType="Inventors_Workshop.Models.ResourceType" 
                SelectMethod="ShowResourceType">
        
            <ItemTemplate>
                <asp:Label ID="ListofName" runat="server" Text='<%# Item.Name %>'></asp:Label>
           </ItemTemplate>

        </asp:Listview>
    </div>
    </form>
</body>
</html>
