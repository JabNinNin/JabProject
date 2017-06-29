<%@ Page Title="" Language="C#" MasterPageFile="~/InterfaceFinish/Manager.Master" AutoEventWireup="true" CodeBehind="ManagerApproval.aspx.cs" Inherits="WebApplication1.InterfaceFinish.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<div class="sidebar-wrapper">
				<ul class="nav">
    <li >
        <a href="ManagerViewTS.aspx">
            <i class="material-icons">view_agenda</i>
            <p>View TimeSheets</p>
        </a>
    </li>
    <li>
        <a href="ManagerCreateTS.aspx">
            <i class="material-icons">note_add</i>
            <p>Create TimeSheets</p>
        </a>
    </li>
    <li class="active">
        <a href="ManagerApproval.aspx">
            <i class="material-icons">check_circle</i>
            <p>Approve TimeSheets</p>
        </a>
    </li>

</ul>
	    	</div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
<div class="col-md-12">
	                        <div class="card">
	                            <div class="card-header" data-background-color="purple">
	                                <h4 class="title">Approve TimeSheets</h4>
	                                <p class="category">You can Approve or Reject All TimeSheets of Status Pending</p>
	                            </div>
	                            <div class="card-content table-responsive">
         
                <table style="width: 100%" class="table">
                  
                        <thead class="text-primary">
                        <%--<th >ID</th>   --%>                     
                        <th >Project</th>                    
                        <th >Name</th>
						<th >Date</th>
                         <th >WorkTime</th>
                        <th >Status</th>
                        <th>Description</th>
                        <th>CheckBox</th> 
                            </thead>
                   <asp:Repeater runat="server" ID="TSApproveList" ClientIDMode="Static" >
                        <ItemTemplate>
                    <tbody>
                       <tr>
                          <%--<td><%#Eval("id") %></td>--%>
	                      <td><%#Eval("Projectname ") %></td>
	                      <td><%#Eval("FristnameLastname") %></td>						
	                      <td><%#Eval("DateTS") %></td>
                          <td><%#Eval("Worktime") %></td>
                           <td class="text-primary"><%#Eval("status") %></td>
                           <td class="col-md-3 "><%#Eval("Description") %></td>

                          
                        <td>
                            <asp:CheckBox ID="CheckBox1" runat="server" />
                            Approve or Reject
                         </td>
                          </tr>
              
                        </tbody></ItemTemplate>
					
                    </asp:Repeater>

                </table>
                                    <asp:DropDownList ID="DropDownList1" runat="server">

                                    </asp:DropDownList>
                                    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="Button1_Click" ></asp:TextBox>
                                    <button type="submit" class="btn btn-primary pull-right"><i class="material-icons">assignment_turned_in</i>Commit Approve</button>
	                                    <div class="clearfix"></div>

	                            </div>
	                        </div>
	                    </div>
        </form >
</asp:Content>
