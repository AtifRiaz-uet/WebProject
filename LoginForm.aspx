<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="DataTables_Assignment.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.1.3/dist/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

    <script src="AdminLoginValidation.js"></script>
    

</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
        <h2>Welcome to ASP MART</h2>

      <div class="form-group row">
            <label for="inputEmail3" class="col-sm-2 col-form-label">Email</label>
            <div class="col-sm-10">
                <input type="email" class="form-control" id="inputEmail3" placeholder="Email">
            </div>
      </div>

        <div class="form-group row">
            <label for="inputPassword3" class="col-sm-2 col-form-label">Password</label>
                <div class="col-sm-10">
                    <input type="password" class="form-control" id="inputPassword3" placeholder="Password">
                </div>
        </div>

        <div class="form-group row">
            <div class="col-sm-10">
                <asp:Button Text="Sign in" runat="server" CssClass="btn btn-primary" OnClientClick="return check()" OnClick="SignIn_Click" />
            </div>
        </div>
    </div>
    </form>
</body>
</html>
