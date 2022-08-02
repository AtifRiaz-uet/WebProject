<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DataTables_Assignment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Admin Page</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.1.3/dist/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js" 
        integrity="sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4=" 
        crossorigin="anonymous"></script>
    <link rel="stylesheet" type="text/css"
        href="//cdn.datatables.net/1.10.7/css/jquery.dataTables.min.css" />
    <script src="//cdn.datatables.net/1.10.7/js/jquery.dataTables.min.js">
    </script>
    <script src="admin.js"></script>

</head>
<body style="background-color:antiquewhite;">

<form id="form1" runat="server">
    <div class="text-center pt-5 font-weight-bold ">

         <br />
         <h1>Welcome ADMIN</h1>
        <h3>ITEMS Table</h3>
    </div>
    <div style="float:right" runat="server">
        <asp:Button runat="server" Text="Create New Accountant" CssClass="btn btn-primary btn-lg" OnClick="NewAcc_Click" />
        <br />
        <br />

    </div>

            <div id="showDiv_edit" style="display:none" class="text-center pt-5 font-weight-bold bg-light">
                <br />
                <asp:Label ID="Label_Name" runat="server" Text="Name"></asp:Label>&nbsp;
                <asp:TextBox ID="TextBox_Name" runat="server"></asp:TextBox>&nbsp;

                <asp:Label ID="Label_Address" runat="server" Text="ID"></asp:Label>&nbsp;
                <asp:TextBox ID="TextBox_Id" runat="server" Text="Optional"></asp:TextBox>&nbsp;&nbsp;&nbsp;

                <asp:Label ID="Label1" runat="server" Text="Price"></asp:Label>&nbsp;
                <asp:TextBox ID="TextBox_Price" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;

                <button type="button"   onclick="EditItem()"  class="btn btn px-3">UPDATE</button>&nbsp;&nbsp;&nbsp;
                <button type="button"   onclick="edit_hidediv()"  class="btn btn px-3">CANCEL</button>
                <br />
                <br />
            </div>
            
            <div id="showDiv_add" style="display:none" class="text-center pt-5 font-weight-bold bg-light">
                <br />

                <asp:Label ID="LabelID" runat="server" Text="Customer ID"></asp:Label>

                <asp:TextBox ID="newID" Type="number" runat="server"></asp:TextBox>

                <asp:Label ID="LabelName" runat="server" Text="Customer Name"></asp:Label>&nbsp;
                <asp:TextBox ID="newName" Type="text" runat="server"></asp:TextBox>&nbsp;
                <asp:Label ID="LabelAddress" runat="server" Text="Customer Address"></asp:Label>&nbsp;
                <asp:TextBox ID="newAddress" Type="text" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                 <button id="Button_add" type="button"   onclick="addCustomer()"  class="btn btn-secondary m-1 px-3">ADD</button>&nbsp;&nbsp;&nbsp;  
                <button id="Button_cancel" type="button"   onclick="addCustomer_hidediv()"  class="btn btn-secondary m-1 px-3">CANCEL</button>
                
            </div>

    <div>        
            <table  id="datatable" class="table" >
                <thead>
                <tr>
                    <th>Name</th>
                    <th>ID</th>
                    <th>Price</th>
                    <th>Edit</th>
                </tr>
                </thead>
            </table>
    </div>
</form>
</body>
</html>
