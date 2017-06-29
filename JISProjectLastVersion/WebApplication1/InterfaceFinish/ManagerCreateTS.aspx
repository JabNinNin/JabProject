<%@ Page Title="" Language="C#" MasterPageFile="~/InterfaceFinish/Manager.Master" AutoEventWireup="true" CodeBehind="ManagerCreateTS.aspx.cs" Inherits="WebApplication1.InterfaceFinish.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server"><div class="sidebar-wrapper">
  
   
        
				<ul class="nav">
    <li >
        <a href="ManagerViewTS.aspx">
            <i class="material-icons">view_agenda</i>
            <p>View TimeSheets</p>
        </a>
    </li>
    <li class="active">
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
    <form id="form1" runat="server">
<div class="col-md-12">
	                        <div class="card">
	                            <div class="card-header" data-background-color="purple">
	                                <h4 class="title">Create Timesheet</h4>
	                                <p class="category">Create NewTimesheet and ComeBack to create timesheet to reject</p>
	                            </div>
	                            <div class="card-content table-responsive">
	                                   <div class="row">
                                           <div class="col-md-3">
                                                    <div class="form-group label-floating">
                                                            
                                                        <asp:DropDownList ID="DropDownList1" runat="server" Cssclass="form-control"  DataSourceID ="SqlDataSource1" DataTextField="projectname" DataValueField="projectname" >
                                                            </asp:DropDownList>
                                                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionString %>" SelectCommand="select [project].projectname from Assign 
Inner Join [project] ON [project].[id] =  [Assign].[project_id]where ([employee_id] = @id)">
                                                                <SelectParameters>
                                                                    <asp:SessionParameter Name="id" SessionField="userid" Type="Int32" />
                                                                </SelectParameters>
                                                        </asp:SqlDataSource>
                                                                            </div>
                                               </div>
                                           <div class="col-md-3">
                                                    <div class="form-group label-floating">
                                                             
                                                                    <div class="demo ">
                

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
                                           
                                           <div class="col-md-3">
                                                    <div class="form-group label-floating">
                                                             
                                                     <p id="datepairExample01">
                    
                    <input type="text" class="time start form-control" placeholder="StartTime"/> 
                    
                                        </p>
                                                         <script src="http://jonthornton.github.io/Datepair.js/dist/datepair.js"></script>
            <script src="http://jonthornton.github.io/Datepair.js/dist/jquery.datepair.js"></script>
            <script>
                $('#datepairExample01 .time').timepicker({
                    'showDuration': true,
                    'timeFormat': 'g:ia'
                });

                $('#datepairExample01 .date').datepicker({
                    'format': 'm/d/yyyy',
                    'autoclose': true
                });

                $('#datepairExample01').datepair();
            </script>
                                            
                                                                             </div>
                                                                            </div>
                                           <div class="col-md-3">
                                                    <div class="form-group label-floating">
                                                             
                                                                    
                                                           <p id="datepairExample02">
                    
                    <input type="text" class="time end form-control" placeholder="EndTime" /> 
                    
                                        </p>
                                                         <script src="http://jonthornton.github.io/Datepair.js/dist/datepair.js"></script>
            <script src="http://jonthornton.github.io/Datepair.js/dist/jquery.datepair.js"></script>
            <script>
                $('#datepairExample02 .time').timepicker({
                    'showDuration': true,
                    'timeFormat': 'g:ia'
                });

                $('#datepairExample02 .date').datepicker({
                    'format': 'm/d/yyyy',
                    'autoclose': true
                });

                $('#datepairExample02').datepair();
            </script>
                                            
                                                                             </div>
                                                                            </div>
                                         </div>
    
                                    <div class="row">
	                                        <div class="col-md-12">
	                                            <div class="form-group">
													<div class="form-group label-floating">
									    				<label class="control-label">Add Description on here</label>
								    					<textarea class="form-control" rows="3"></textarea>
		                        					</div>
	                                            </div>
	                                        </div>
	                                    </div>
<asp:Button ID="Button1" runat="server" Text="Button" />
	                                    <button type="submit" class="btn btn-primary pull-right">Add row TimeSheet</button>
	                                    <div class="clearfix"></div>
	                            </div>

	                        </div>
	                    </div>
    </form>
</asp:Content>
