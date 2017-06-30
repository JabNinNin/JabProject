<%@ Page Title="" Language="C#" MasterPageFile="~/InterfaceFinish/Admin.Master" AutoEventWireup="true" CodeBehind="AdminAddMembers.aspx.cs" Inherits="WebApplication1.InterfaceFinish.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <form  runat="server">
        
        <div class="row">
            <div class="col-md-3">
                <div class="form-group label-floating">
                    <label class="control-label">Employee ID</label>
                    <input id="Employee_id" runat="server" type="text" class="form-control" />
                </div>
            </div>
            <div class="col-md-4">
                <div class="form-group label-floating">
                    <label class="control-label">Username</label>
                    <input id="Username" runat="server" type="text" class="form-control" />
                </div>
            </div>
            <div class="col-md-5">
                <div class="form-group label-floating">
                    <%--	<label class="control-label">Email address</label>
													<input type="email" class="form-control" />--%>
                    <label class="control-label">Password</label>
                    <input id="Password" runat="server" type="text" class="form-control" />
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-4">
                <div class="form-group label-floating">
                    <label class="control-label">First Name</label>
                    <input id="FirstName" runat="server" type="text" class="form-control" />
                </div>
            </div>
            <div class="col-md-4">
                <div class="form-group label-floating">
                    <label class="control-label">Last Name</label>
                    <input id="LastName" runat="server" type="text" class="form-control" />
                </div>
            </div>
            <div class="col-md-4">
                <div class="form-group label-floating">
                    <label class="control-label">Telephone Number</label>
                    <input id="TelephoneNumber" runat="server" type="text" class="form-control" />
                </div>
            </div>
        </div>

        <div class="row">

            <div class="col-md-6">
                <div class="form-group label-floating">
                    <label class="control-label">Email address</label>
                    <input id="EmailAddress" runat="server" type="email" class="form-control" />
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group label-floating">
                    <select id="positiondroupdown" class="form-control " runat="server">
                        <option value="All Position">All Position </option>
                        <option value="Managing Director">Managing Director</option>
                        <option value="Delivery Service Manager">Delivery Service Manager</option>
                        <option value="Technical Consultan">Technical Consultant</option>
                        <option value="Consultant">Consultant </option>
                        <option value="Financial Officer">Financial Officer </option>
                        <option value="Project  Coordinator">Project  Coordinator </option>

                    </select>
                </div>
            </div>



        </div>
        <div class="col-md-4">
            <div class="form-group label-floating">
                <label class="control-label">fileTest</label>
                <input id="TestText" runat="server" type="text" class="form-control" />
            </div>
        </div>

                
                <asp:FileUpload ID="FileUploadControl" runat="server"  />

                <asp:Label runat="server" ID="StatusLabel" Text="Upload status: " />


        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

        <asp:Button ID="UpdateProfile" runat="server" Text="Update Profile" type="submit" CssClass="btn btn-primary pull-right" OnClick="UpdateProfile_Click" />


    </form>
    
</asp:Content>
