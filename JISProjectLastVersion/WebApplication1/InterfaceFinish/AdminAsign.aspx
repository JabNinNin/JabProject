<%@ Page Title="" Language="C#" MasterPageFile="~/InterfaceFinish/Admin.Master" AutoEventWireup="true" CodeBehind="AdminAsign.aspx.cs" Inherits="WebApplication1.InterfaceFinish.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
         <div class="card-header" data-background-color="purple">
	                                <h4 class="title">Assign</h4>
									<p class="category">Assign or view all assigned</p>
	                            </div>
        <div class="card-content">
        <div class="row">
	                    <div class="col-md-12">
	                        <div class="card">
	                            <div class="card-header" data-background-color="purple">
	                                <h4 class="title">ASsign Project</h4>
									<p class="category">Assign project to employee </p>
	                            </div>
	                            <div class="card-content">    
                                     <div class="row">	                                    	                                        
	                                     <div class="col-md-4">
	                                            <div class="form-group">
	                                                <div class="form-group label-floating">
									    				<label class="control-label">Should Your Project</label>
                                                        <asp:dropdownlist id="ProjectNameDD" runat="server" DataSourceID="SqlDataSource1" DataTextField="projectname" DataValueField="id" CssClass="form-control"></asp:dropdownlist>
		                        					    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionString %>" SelectCommand="SELECT [projectname], [id] FROM [project]"></asp:SqlDataSource>
		                        					</div>
	                                            </div>
	                                        </div>
                                         <div class="col-md-4">
	                                            <div class="form-group">
	                                                <div class="form-group label-floating">
									    				<label class="control-label">Should Your Employee</label>
                                                        <asp:dropdownlist ID="EmployeeDD" runat="server" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="id" CssClass="form-control"></asp:dropdownlist>
		                        					    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:connectionString %>" SelectCommand="SELECT [firstname]+'    ' +[lastname] as Name,[id]  FROM [userprofile]"></asp:SqlDataSource>
		                        					</div>
	                                            </div>
	                                        </div>
                                         <div class="col-md-4">
	                                            <div class="form-group">
	                                                <div class="form-group label-floating">
									    				<label class="control-label">Complate Description</label>
                                                        <asp:textbox id="descip" Cssclass="form-control" runat="server"></asp:textbox>
		                        					</div>
	                                            </div>
	                                        </div> 
                                       <asp:Button ID="Button1" runat="server" Text="commit " class="btn btn-primary pull-right" OnClick="InsertProject"  />
	                                   <asp:Button class="btn btn-primary pull-right" runat="server"  ID="btnwqwqe"  Text="Save Change"  OnClick="btnwqwqe_Click"/>
	                                    <div class="clearfix"></div>
	                                
	                                    </div>
	                                    
	                                   
	                            </div>   
                                
	                            <div class="card-header" data-background-color="purple">
	                                <h4 class="title">View Assigned</h4>
									<p class="category">Edit or Delect</p>
	                            </div>
	                            <div class="card-content">
	                                
	                                    <div class="row">
                                           
                                            <div class="col-md-3">
												<div class="form-group label-floating">
													<select id="uu" class="form-control ">
                                                  <option value="0">Projectname</option>
                                                  <option value="1">Employee</option>
                                                  <option value="2">Desciption</option>
                                                  
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
                                        <div class="row " style="min-height:500px">
                                            
                                            <table id="Loop" style="width: 100%" class="table">
                                                
                  
                        <thead class="text-primary">                                            
                        <tr ><th >Project </th>                                        
                        <th >Employee</th>
                        <th>Description</th>
                        </tr> 
                        
                            </thead>
                   <asp:Repeater runat="server" ID="TSConList" ClientIDMode="Static"  OnItemCommand="rptLogList_ItemCommand"  >
                        <ItemTemplate>
                    <tbody>
                       <tr>
                         
	                      <td><%#Eval("ProjectName_sw") %></td>
                           <td><%#Eval("Employee_sw") %></td>
                           <td ><%#Eval("Description_sw") %></td>
                           <td><asp:Button class="btn btn-warning pull-right" runat="server" ID="btnReview" CommandArgument='<%#Eval("id") %>' Text="Edit" commandname="EditCommand" />
                                   </td>
                           <td><asp:Button class="btn btn-danger pull-right" runat="server"  ID="btnAssign" CommandArgument='<%#Eval("id") %>' Text="Delete" commandname="DeleteComand"/>
                          </td>
                               </tr>
              
                        </tbody></ItemTemplate>
					
                    </asp:Repeater>
                 </table>
	                                    </div>

	                                  
                                    
	                                    <div class="clearfix"></div>
                                    <asp:textbox id="jio" runat="server"  Visible="false"></asp:textbox></div>
                                    
                                    
                                   
	                              
	                        </div>
                                                    
	                        </div>
	                    </div>
				</div>		
	               
             
                 
       
         
        
    
</asp:Content>
