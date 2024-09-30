<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="PAGE_Default" EnableEventValidation="true" EnableViewState="true" %>

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
                    <td>EID</td>
                    <td>
                        <asp:TextBox ID="txteid" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>ENAME</td>
                    <td>
                        <asp:TextBox ID="txtename" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>DESIGNATION</td>
                    <td>
                        <asp:TextBox ID="txtdesg" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>PROFIE PICTURE</td>
                    <td>
                        <asp:FileUpload ID="fileUpload1" runat="server" /></td>
                </tr>
                <tr>
                    <td>SALARY</td>
                    <td>
                        <asp:TextBox ID="txtsalary" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>MOBILE</td>
                    <td>
                        <asp:TextBox ID="txtmob" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>EMAIL</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>DEPARTMENT</td>
                    <td>
                        <asp:TextBox ID="txtdept" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>POST</td>
                    <td>
                        <asp:TextBox ID="txtpost" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>EMP NO</td>
                    <td>
                        <asp:TextBox ID="txtempno" runat="server"></asp:TextBox></td>
                </tr>

            </table>
            <br />

            <asp:Button ID="BTN_SUBMIT" runat="server" Text="SUBMIT" OnClick="btnsubmit_Click" />
            <asp:Button ID="BTN_UPDATE" runat="server" Text="UPDATE" OnClick="btnupdate_Click" />
            <asp:Button ID="BTN_RESET" runat="server" Text="RESET" OnClick="btnresete_Click" />

            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
            <br />
            <asp:Label ID="lblmsg" runat="server" Text="Label"></asp:Label>
            <br />

            <asp:GridView ID="GridView1" runat="server" OnRowDataBound="GridView1_RowDataBound">
                <Columns>
                    <asp:TemplateField HeaderText="Update">
                        <ItemTemplate>
                            <asp:Button ID="btnUpdate" runat="server" Text="Update" CommandName="Update" CommandArgument='<%# Eval("EID") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Delete">
                        <ItemTemplate>
                            <asp:Button ID="btnDelete" runat="server" Text="Delete" CommandName="Delete" CommandArgument='<%# Eval("EID") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
