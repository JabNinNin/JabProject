﻿<%@ Page Title="" Language="C#" MasterPageFile="~/InterfaceFinish/Admin.Master" AutoEventWireup="true" CodeBehind="AddminAddProject.aspx.cs" Inherits="WebApplication1.InterfaceFinish.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
       
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
													<input id="Projectname" runat="server" type="text" class="form-control" />
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
                    <input id="enddate" runat="server" type="text" class="date end form-control control-label " placeholder="Date"/>
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
	                                         <div class="col-md-5">
	                                            <div class="form-group">
	                                                <label>About Me</label>
													<div class="form-group label-floating">
									    				<label class="control-label"> Lamborghini Mercy, Your chick she so thirsty, I'm in that two seat Lambo.</label>
								    					<textarea id="description" runat="server"  class="form-control" rows="3"></textarea>
		                        					</div>
	                                            </div>
	                                        </div>
	                                    </div>
	                                    
	                                    
<asp:Button ID="Button1" runat="server" Text="commit " class="btn btn-primary pull-right" OnClick="InsertProject" />
	                                   
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
	                                        <table style="width: 100%" class="table">
                  
                        <thead class="text-primary">                                            
                        <th >Project</th>                                          
                        <th >StartDate</th>
                        <th >EndDate</th>
                        <th>Description</th>
                        
                            </thead>
                   <asp:Repeater runat="server" ID="TSConList" ClientIDMode="Static" >
                        <ItemTemplate>
                    <tbody>
                       <tr>
                         
	                      <td><%#Eval("Projectname ") %></td>
                           <td><%#Eval("StartDate ") %></td>
                           <td><%#Eval("EndDate ") %></td>
                           <td ><%#Eval("Description") %></td>
                          </tr>
              
                        </tbody></ItemTemplate>
					
                    </asp:Repeater>

                </table>
	                                    </div>

	                                  

	                                    <div class="clearfix"></div>
	                                
	                            </div>                            
	                        </div>
	                    </div>
						
	                </div>
             
                 
       
        
        
    </form>
</asp:Content>
