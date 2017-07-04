<%@ Page Title="" Language="C#" MasterPageFile="~/InterfaceFinish/Admin.Master" AutoEventWireup="true"  CodeBehind="AdminAddProject.aspx.cs" Inherits="WebApplication1.InterfaceFinish.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
         <div class="card-header" data-background-color="purple">
	                                <h4 class="title">ADD Profile</h4>
									<p class="category">Complete your Employee profile</p>
	                            </div>
        <div class="card-content">
        <div class="row">
	                    <div class="col-md-12">
	                        <div class="card">
	                            <div class="card-header" data-background-color="purple">
	                                <h4 class="title">Add Project</h4>
									<p class="category">Add new project for asign work and feture</p>
	                            </div>
	                            <div class="card-content">
	                                
	                                    <div class="row">	                                    
	                                        <div class="col-md-3">
												<div class="form-group label-floating">
													<label class="control-label">ProjectName</label>
													<input id="Projectname" runat="server" type="text" class="form-control" onkeydown = "return (event.keyCode!=13);" />
												</div>
	                                        </div>
                                            <div class="col-md-2">
												<div class="form-group label-floating">
													
												 <div class="demo form-group label-floating ">
                

                <p id="datepairExample">
                    <label class="control-label">Start Project</label>
                    <input id="startdate" type="text" runat="server" class="date start form-control control-label " placeholder="Date"/>
                    
                </p>
            </div>

         
            <script>
                $('#datepairExample .time').timepicker({
                    'showDuration': true,
                    'timeFormat': 'g:ia'
                });

                $('#datepairExample .date').datepicker({
                    'format': 'm/d/yyyy',
                    'autoclose': true
                });

               
            </script>
												</div>
	                                        </div>
                                            <div class="col-md-2">
												<div class="form-group label-floating">
													 <div class="demo form-group label-floating ">
                

                <p id="datepairExample1">
                    <label class="control-label">End Project</label>
                    <input id="enddate" runat="server" type="text" class="date end form-control control-label " placeholder="Date" />
                </p>
            </div>

         
            <script>
                $('#datepairExample1 .time').timepicker({
                    'showDuration': true,
                    'timeFormat': 'g:ia'
                });

                $('#datepairExample1 .date').datepicker({
                    'format': 'm/d/yyyy',
                    'autoclose': true
                });


            </script>
												</div>
	                                        </div>
	                                        <div class="col-md-3">
	                                            <div class="form-group">
	                                                <div class="form-group label-floating">
									    				 <asp:DropDownList ID="DropDownList1" runat="server"  AutoPostBack="True" CssClass="form-control "  OnSelectedIndexChanged="Setinform">
                                                            <asp:ListItem Text="Daily">Daily</asp:ListItem>
                                                            <asp:ListItem Text="Weekly">Weekly</asp:ListItem>
                                                            <asp:ListItem Text="Mountly">Mountly</asp:ListItem>
                                                            <asp:ListItem Text="Manual" >Manual</asp:ListItem>
                                                        </asp:DropDownList>
                                                        
		                        					</div>
	                                            </div>
	                                        </div>
                                            <div class="col-md-2">
	                                            <div class="form-group">
	                                                <div class="form-group label-floating">
									    				 <asp:TextBox ID="Countday" runat="server" CssClass="form-control"></asp:TextBox>
		                        					</div>
	                                            </div>
	                                        </div>
	                                    </div>
                                     <div class="row">	                                    	                                        
	                                         <div class="col-md-12">
	                                            <div class="form-group">
	                                                <div class="form-group label-floating">
									    				<label class="control-label">You must complete description of this project</label>
								    					<textarea id="Textarea1" runat="server"  class="form-control" rows="3"></textarea>
		                        					</div>
	                                            </div>
	                                        </div>
	                                    </div>
	                                    
	                                    
                                       <asp:Button ID="Button1" runat="server" Text="commit " class="btn btn-primary pull-right" OnClick="InsertProject" />
	                                   <asp:Button class="btn btn-primary pull-right" runat="server"  ID="btnwqwqe" OnClick="btnwqwqe_Click" Text="Save Change" />
	                                    <div class="clearfix"></div>
	                                
	                            </div>                            
	                        </div>
                            <div class="card">
	                            <div class="card-header" data-background-color="purple">
	                                <h4 class="title">EditProject</h4>
									<p class="category">Complete edit or delect your Project</p>
	                            </div>
	                            <div class="card-content">
	                                
	                                    <div class="row">
                                           
                                            <div class="col-md-3">
												<div class="form-group label-floating">
													<select id="uu" class="form-control ">
                                                  <option value="0">Projectname</option>
                                                  <option value="1">StartDate</option>
                                                  <option value="2">EndDate</option>
                                                  <option value="3">Desciption</option>
                                                  <option value="4">Information</option>
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
                        <tr  ><th >Project </th>                                        
                        <th >StartDate</th>
                        <th >EndDate</th>
                        <th>Description</th>
                        <th>Infomation</th></tr> 
                        
                            </thead>
                   <asp:Repeater runat="server" ID="TSConList" ClientIDMode="Static"  OnItemCommand="rptLogList_ItemCommand"  >
                        <ItemTemplate>
                    <tbody>
                       <tr>
                         
	                      <td><%#Eval("Projectname ") %></td>
                           <td><%#Eval("StartDate ") %></td>
                           <td><%#Eval("EndDate ") %></td>
                           <td ><%#Eval("Description") %></td>
                           <td >Every <%#Eval("Information") %>  </td>
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
             
                 
       
         
        
    </form>
</asp:Content>
