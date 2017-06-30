<%@ Page Title="" Language="C#" MasterPageFile="~/InterfaceFinish/Admin.Master" AutoEventWireup="true" CodeBehind="AddminAddProject.aspx.cs" Inherits="WebApplication1.InterfaceFinish.WebForm1" %>
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
	                                <form >
	                                    <div class="row">	                                    
	                                        <div class="col-md-3">
												<div class="form-group label-floating">
													<label class="control-label">ProjectName</label>
													<input type="text" class="form-control" />
												</div>
	                                        </div>
                                            <div class="col-md-2">
												<div class="form-group label-floating">
													
												 <div class="demo form-group label-floating ">
                

                <p id="datepairExample">
                    <input type="text" class="date start form-control " placeholder="Date"/>
                    
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
                    
                    <input type="text" class="date end form-control " placeholder="Date"/>
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
								    					<textarea class="form-control" rows="3"></textarea>
		                        					</div>
	                                            </div>
	                                        </div>
	                                    </div>
	                                    
	                                    

	                                    <button type="submit" class="btn btn-primary pull-right">commit</button>
	                                    <div class="clearfix"></div>
	                                </form>
	                            </div>                            
	                        </div>
                            <div class="card">
	                            <div class="card-header" data-background-color="purple">
	                                <h4 class="title">EditProject</h4>
									<p class="category">Complete edit or delect your Project</p>
	                            </div>
	                            <div class="card-content">
	                                <form>
	                                    <div class="row">
	                                        <div class="col-md-5">
												<div class="form-group label-floating">
													<label class="control-label">Company (disabled)</label>
													<input type="text" class="form-control" disabled>
												</div>
	                                        </div>
	                                        <div class="col-md-3">
												<div class="form-group label-floating">
													<label class="control-label">Username</label>
													<input type="text" class="form-control" >
												</div>
	                                        </div>
	                                        <div class="col-md-4">
												<div class="form-group label-floating">
													<label class="control-label">Email address</label>
													<input type="email" class="form-control" >
												</div>
	                                        </div>
	                                    </div>

	                                  

	                                    <div class="clearfix"></div>
	                                </form>
	                            </div>                            
	                        </div>
	                    </div>
						
	                </div>
             
                 
       
        
        
    </form>
</asp:Content>
