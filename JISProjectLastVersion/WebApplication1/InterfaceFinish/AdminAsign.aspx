<%@ Page Title="" Language="C#" MasterPageFile="~/InterfaceFinish/Admin.Master" AutoEventWireup="true" CodeBehind="AdminAsign.aspx.cs" Inherits="WebApplication1.InterfaceFinish.WebForm9" %>
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
                                                    
	                        </div>
	                    </div>
						
	                </div>
             
                 
       
         
        
    </form>
</asp:Content>
