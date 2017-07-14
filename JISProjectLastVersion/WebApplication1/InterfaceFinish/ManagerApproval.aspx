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
	                            <div class="card-content table-responsive" style="min-height:500px;">
          
                <table  id="Loop" style="width: 100% ;" class="table ">
                    <asp:TextBox ID="TBtest1" runat="server"></asp:TextBox>
                        <thead class="text-primary">
                            <tr> <th >ID</th>                
                        <th >Project</th>                    
                        <th >Name</th>
						<th >Date</th>
                         <th >WorkTime</th>
                        <th >Status</th>
                        <th>Description</th>
                        <th>Approval</th></tr> 
                            </thead>
                   <asp:Repeater runat="server" ID="TSApproveList" ClientIDMode="Static" OnItemCommand="rptLogList_ItemCommand" >
                        <ItemTemplate>
                    <tbody>
                       <tr>
                          <td><%#Eval("id") %></td>
	                      <td><%#Eval("Projectname ") %></td>
	                      <td><%#Eval("FristnameLastname") %></td>						
	                      <td><%#Eval("DateTS") %></td>
                          <td><%#Eval("Worktime") %></td>
                           <td class="text-primary col-md-3"><%#Eval("status") %></td>
                           <td class="col-md-3 "><%#Eval("Description") %></td>

                          
                           <td><asp:Button class="btn btn-success pull-right" runat="server" ID="btnApprove" CommandArgument='<%#Eval("id") %>' Text="Approve" commandname="ApproveCommand"  OnClientClick="this.disabled=true:"/>
                          </td>
                           <td><asp:Button class="btn btn-danger pull-right" runat="server"  ID="btnReject" CommandArgument='<%#Eval("id") %>' Text="Reject" commandname="RejectCommand" OnClientClick="this.disabled=true;"/></td>
                          </tr>
              
                        </tbody></ItemTemplate>
					
                    </asp:Repeater>

                </table>
                                     <div class="row">
                                           
                                            <div class="col-md-3">
												<div class="form-group label-floating">
													<select id="uu" class="form-control ">
                                                  <option value="0">Projectname</option>
                                                  <option value="1">EmployeeName</option>
                                                  <option value="2">Date</option>
                                                  <option value="3">Worktime</option>
                                                  <option value="4">status</option>
                                                  <option value="5">Description</option>
                                                  
                                            </select>
												</div>
	                                        </div>
                                            <div class="col-md-2">
												<div class="form-group label-floating">													
												 <div class="demo form-group label-floating ">
                                                     <input type="text" id="myInput" onkeyup="myFunction(uu.value)" placeholder="Search for names.." title="Type in a name" onkeydown = "return (event.keyCode!=13);" class="form-control " />
                                                 </div>
												</div>
	                                        </div>
                                             <div class="col-md-2">
												<div class="form-group label-floating">													
												 <div class="demo form-group label-floating ">
                                                     <button type="button" class="btn btn-success btn-sm " onclick="sortTable(uu.value)" ><i class="material-icons">pageview</i>Sort</button>
                                                 </div>
												</div>
	                                        </div>
	                                    </div>
                                    <button type="submit" class="btn btn-primary pull-right"><i class="material-icons">assignment_turned_in</i>Commit Approve</button>
	                                    <div class="clearfix"></div>

	                            </div>
	                        </div>
	                    </div>
        </form >
</asp:Content>
