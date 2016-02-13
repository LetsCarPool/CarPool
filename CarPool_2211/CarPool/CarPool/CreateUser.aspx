<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CreateUser.aspx.cs" Inherits="CreateUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 98%;
        }
        .style2
        {
            width: 141px;
        }
        .style3
        {
            width: 141px;
            height: 40px;
        }
        .style4
        {
            height: 40px;
        }
        .style5
        {
            width: 141px;
            height: 30px;
        }
        .style6
        {
            height: 30px;
        }
        .style7
        {
            width: 141px;
            height: 34px;
        }
        .style8
        {
            height: 34px;
        }
        .style9
        {
            width: 141px;
            height: 35px;
        }
        .style10
        {
            height: 35px;
        }
        .style11
        {
            width: 141px;
            height: 41px;
        }
        .style12
        {
            height: 41px;
        }
        .style13
        {
            width: 141px;
            height: 31px;
        }
        .style14
        {
            height: 31px;
        }
        .style15
        {
            width: 141px;
            height: 39px;
        }
        .style16
        {
            height: 39px;
        }
        .style21
        {
            width: 291px;
            height: 30px;
        }
        .style22
        {
            width: 291px;
            height: 40px;
        }
        .style23
        {
            width: 291px;
            height: 34px;
        }
        .style24
        {
            width: 291px;
            height: 35px;
        }
        .style25
        {
            width: 291px;
            height: 41px;
        }
        .style26
        {
            width: 291px;
            height: 31px;
        }
        .style27
        {
            width: 291px;
            height: 39px;
        }
        .style30
        {
            width: 291px;
        }
        .style31
        {
            width: 291px;
            height: 46px;
        }
        .style32
        {
            width: 141px;
            height: 46px;
        }
        .style33
        {
            height: 46px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table class="style1">
        <tr>
            <td class="style21">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </td>
            <td class="style5">
                &nbsp;</td>
            <td class="style6">
                <asp:Label ID="lblEnterDetails" runat="server" Font-Size="Medium" 
                    SkinID="skin3" Text="Enter your details"></asp:Label>
            </td>
        </tr>
     </table>
    <asp:UpdatePanel ID="upMainDetails" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
   
     <table class="style1">
        <tr>
            <td class="style22">
                &nbsp;</td>
            <td class="style3">
                <asp:Label ID="lblFirstName" runat="server" SkinID="Skin2" Text="First Name"></asp:Label>
            </td>
            <td class="style4">
                <asp:TextBox ID="txtFirstName" runat="server" MaxLength="15"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" 
                    ControlToValidate="txtFirstName" ErrorMessage="Please Enter the FirstName" 
                    ToolTip="Please Enter the FirstName" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revFirstName" runat="server" 
                    ControlToValidate="txtFirstName" 
                    ErrorMessage="First Name should contain only alphabets" 
                    ToolTip="First Name should contain only alphabets" 
                    ValidationExpression="[a-zA-Z]*" Font-Names="Times New Roman" 
                    Font-Size="X-Small" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style22">
                &nbsp;</td>
            <td class="style3">
                <asp:Label ID="lblLastName" runat="server" SkinID="Skin2" Text="Last Name"></asp:Label>
            </td>
            <td class="style4">
                <asp:TextBox ID="txtLastName" runat="server" MaxLength="15"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revLastName" runat="server" 
                    ControlToValidate="txtLastName" EnableTheming="True" 
                    ErrorMessage="Last Name should contain only alphabets" 
                    ToolTip="Last Name should contain only alphabets" 
                    ValidationExpression="[a-zA-Z]*" ForeColor="Red">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style23">
                &nbsp;</td>
            <td class="style7">
                <asp:Label ID="lblEmployeeId" runat="server" SkinID="Skin2" Text="Employee Id"></asp:Label>
            </td>
            <td class="style8">
                <asp:TextBox ID="txtEmpId" runat="server" MaxLength="10"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvEmpId" runat="server" 
                    ControlToValidate="txtEmpId" ErrorMessage="Please Enter the EmployeeId" 
                    ToolTip="Please Enter the EmployeeId" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revEmpId" runat="server" 
                    ControlToValidate="txtEmpId" ErrorMessage="EmpId should contain only numbers" 
                    ToolTip="EmpId should contain only numbers" 
                    ValidationExpression="\d*" Font-Names="Times New Roman" 
                    Font-Size="X-Small" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <%--<tr>
            <td class="style24">
                &nbsp;</td>
            <td class="style9">
                <asp:Label ID="lblUserId" runat="server" SkinID="Skin2" Text="User Id"></asp:Label>
            </td>
            <td class="style10">
                <asp:TextBox ID="txtUserId" runat="server" MaxLength="25"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvUserId" runat="server" 
                    ControlToValidate="txtUserId" ErrorMessage="Please Enter the UserId" 
                    ToolTip="Please Enter the UserId">*</asp:RequiredFieldValidator>
            </td>
        </tr>--%>
        <tr>
            <td class="style25">
                &nbsp;</td>
            <td class="style11">
                <asp:Label ID="lblPassword" runat="server" SkinID="Skin2" Text="Password"></asp:Label>
            </td>
            <td class="style12">
                <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" MaxLength="15"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPwd" runat="server" 
                    ControlToValidate="txtPwd" ErrorMessage="Please enter the password" 
                    ToolTip="Please enter the password" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        </table>
         </ContentTemplate>
    </asp:UpdatePanel>
        
       <table class="style1">
        <tr>
            <td class="style26">
                &nbsp;</td>
            <td class="style13">
                <asp:Label ID="lblRePassword" runat="server" SkinID="Skin2" 
                    Text="Retype Password"></asp:Label>
            </td>
            <td class="style14">
                        <asp:UpdatePanel ID="upRePwd" runat="server"  UpdateMode="Conditional">
                            <ContentTemplate>
                                <asp:TextBox ID="txtRePwd" runat="server" MaxLength="15" TextMode="Password" 
                                    Width="131px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvRePwd" runat="server" 
                                    ControlToValidate="txtRePwd" ErrorMessage="Please Retype  the password" 
                                    ToolTip="Please Retype  the password" ForeColor="Red">*</asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="cmvRePwd" runat="server" ControlToCompare="txtPwd" 
                                    ControlToValidate="txtRePwd" ErrorMessage="Password doesnot match" 
                                    ToolTip="Password doesnot match" Font-Names="Times New Roman" 
                                    Font-Size="X-Small" ForeColor="Red"></asp:CompareValidator>
                            </ContentTemplate>
                        </asp:UpdatePanel>
            </td>
        </tr>
         </table>
    <asp:UpdatePanel ID="upLastDetails" runat="server"  UpdateMode="Conditional">
    <ContentTemplate>
    
     <table class="style1">
        <tr>
            <td class="style27">
                &nbsp;</td>
            <td class="style15">
                <asp:Label ID="lblMobileNo" runat="server" SkinID="Skin2" Text="Mobile Number"></asp:Label>
            </td>
            <td class="style16">
                <asp:TextBox ID="txtMobileNo" runat="server" MaxLength="10"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revMobileNo" runat="server" 
                    ControlToValidate="txtMobileNo" ErrorMessage="Mobile number not in format" 
                    ToolTip="Mobile number not in format" ValidationExpression="\d{10}" 
                    ForeColor="Red">*</asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="rfvContactNumber" runat="server" 
                    ControlToValidate="txtMobileNo" ErrorMessage="Please enter a Contact number." 
                    Font-Size="X-Small" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="revContactNum" runat="server" 
                    ControlToValidate="txtMobileNo" ErrorMessage="revContactNumber" 
                    Font-Size="X-Small" ForeColor="Red" ValidationExpression="^9\d{9}$">Please enter a Valid 10 Digit Mobile Number</asp:RegularExpressionValidator>
            </td>
        </tr>
         <tr>
          <td class="style27">
                &nbsp;</td>
                <td >
                    <asp:Label ID="EmailId" runat="server" Text="Email Id"></asp:Label>
                </td>
                <td >
                    
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
             
                  
                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
                        ControlToValidate="txtEmail" ErrorMessage="Please enter a Email Id" 
                        ForeColor="Red" Font-Size="X-Small"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="revEmailId" runat="server" 
                        ControlToValidate="txtEmail" ErrorMessage="Please enter a Valid Email Id" 
                        ForeColor="Red" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        Font-Size="X-Small">Please enter a Valid Email Id</asp:RegularExpressionValidator>
                    
                </td>
            </tr>
        <tr>
            <td class="style24">
            </td>
            <td class="style9">
                <asp:Label ID="lblLocation" runat="server" SkinID="Skin2" 
                    Text="Seating Location"></asp:Label>
            </td>
            <td class="style10">
                <asp:TextBox ID="txtLocation" runat="server" MaxLength="30"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style31">
                &nbsp;</td>
            <td class="style32">
                <asp:Label ID="lblCity" runat="server" SkinID="Skin2" Text="City"></asp:Label>
            </td>
            <td class="style33">
                        <asp:DropDownList ID="ddlCity" runat="server" 
    Width="129px" CausesValidation="True">
                            <asp:ListItem Value="-1">--Select--</asp:ListItem>
                            <asp:ListItem Value="0">Bangalore</asp:ListItem>
                            <asp:ListItem Value="1">Bhubaneshwar</asp:ListItem>
                            <asp:ListItem Value="2">Chandigarh</asp:ListItem>
                            <asp:ListItem Value="3">Chennai</asp:ListItem>
                            <asp:ListItem Value="4">Hyderabad</asp:ListItem>
                            <asp:ListItem Value="5">Managlore</asp:ListItem>
                            <asp:ListItem Value="6">Mysore</asp:ListItem>
                            <asp:ListItem Value="7">Pune</asp:ListItem>
                            <asp:ListItem Value="8">Trivandrum</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvCity" runat="server" 
                            ControlToValidate="ddlCity" ErrorMessage="Please Select the city" 
                            InitialValue="-1" ToolTip="Please Select the city">*</asp:RequiredFieldValidator>
            </td>
        </tr>
         </table>
         </ContentTemplate>
    </asp:UpdatePanel>
     <table class="style1">

        <tr>
            <td class="style30">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server"  UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:Button ID="btnCreate" runat="server" onclick="btnCreate_Click" 
                            Text="Register" Width="75px" class="btnStyle" BackColor="Black" />
                        <asp:Label ID="lblVerify" runat="server"></asp:Label>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td class="style30">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

