<%@ Page Title="" Language="C#" MasterPageFile="~/InterfaceFinish/Manager.Master" AutoEventWireup="true" CodeBehind="ManagerViewTS.aspx.cs" Inherits="WebApplication1.InterfaceFinish.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="sidebar-wrapper">
				<ul class="nav">
    <li class="active">
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
    <li>
        <a href="ManagerApproval.aspx">
            <i class="material-icons">check_circle</i>
            <p>Approve TimeSheets</p>
        </a>
    </li>

</ul>
	    	</div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="col-md-12">
	                        <div class="card">
	                            <div class="card-header" data-background-color="purple">
	                                <h4 class="title">Simple Table</h4>
	                                <p class="category">Here is a subtitle for this table</p>
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
                        
                            </thead>
                   <asp:Repeater runat="server" ID="TSConList" ClientIDMode="Static" >
                        <ItemTemplate>
                    <tbody>
                       <tr>
                          <%--<td><%#Eval("id") %></td>--%>
	                      <td><%#Eval("Projectname ") %></td>
	                      <td><%#Eval("FristnameLastname") %></td>						
	                      <td><%#Eval("DateTS") %></td>
                          <td><%#Eval("Worktime") %></td>
                           <td class="text-primary"><%#Eval("status") %></td>
                           <td ><%#Eval("Description") %></td>
                          </tr>
              
                        </tbody></ItemTemplate>
					
                    </asp:Repeater>

                </table>

	                            </div>
	                        </div>
	                    </div>
     <div class="col-md-12">
	                        <div class="card card-plain">
	                            <div class="card-header" data-background-color="purple">
	                                <h4 class="title">Table on Plain Background</h4>
	                                <p class="category">Here is a subtitle for this table</p>
	                            </div>
	                            <div class="card-content table-responsive">
	                                <table class="table table-hover">
	                                    <thead>
	                                        <th>ID</th>
	                                    	<th>Name</th>
	                                    	<th>Salary</th>
	                                    	<th>Country</th>
	                                    	<th>City</th>
	                                    </thead>
	                                    <tbody>
	                                        <tr>
	                                        	<td>1</td>
	                                        	<td>Dakota Rice</td>
	                                        	<td>$36,738</td>
	                                        	<td>Niger</td>
	                                        	<td>Oud-Turnhout</td>
	                                        </tr>
	                                        <tr>
	                                        	<td>2</td>
	                                        	<td>Minerva Hooper</td>
	                                        	<td>$23,789</td>
	                                        	<td>Curaçao</td>
	                                        	<td>Sinaai-Waas</td>
	                                        </tr>
	                                        <tr>
	                                        	<td>3</td>
	                                        	<td>Sage Rodriguez</td>
	                                        	<td>$56,142</td>
	                                        	<td>Netherlands</td>
	                                        	<td>Baileux</td>
	                                        </tr>
	                                        <tr>
	                                        	<td>4</td>
	                                        	<td>Philip Chaney</td>
	                                        	<td>$38,735</td>
	                                        	<td>Korea, South</td>
	                                        	<td>Overland Park</td>
	                                        </tr>
	                                        <tr>
	                                        	<td>5</td>
	                                        	<td>Doris Greene</td>
	                                        	<td>$63,542</td>
	                                        	<td>Malawi</td>
	                                        	<td>Feldkirchen in Kärnten</td>
	                                        </tr>
	                                        <tr>
	                                        	<td>6</td>
	                                        	<td>Mason Porter</td>
	                                        	<td>$78,615</td>
	                                        	<td>Chile</td>
	                                        	<td>Gloucester</td>
	                                        </tr>
	                                    </tbody>
	                                </table>
	                            </div>
	                        </div>
	                    </div>
</asp:Content>
