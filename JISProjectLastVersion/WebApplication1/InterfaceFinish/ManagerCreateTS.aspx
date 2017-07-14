<%@ Page Title="" Language="C#" MasterPageFile="~/InterfaceFinish/Manager.Master" AutoEventWireup="true" CodeBehind="ManagerCreateTS.aspx.cs" Inherits="WebApplication1.InterfaceFinish.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server"><div class="sidebar-wrapper">
  
   <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        
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
                                                            
                                                        <asp:DropDownList ID="DropDownList1" runat="server" Cssclass="form-control"  DataSourceID ="SqlDataSource1" DataTextField="projectname" DataValueField="project_id" >
                                                            </asp:DropDownList>
                                                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionString %>" SelectCommand="select [project].projectname ,[Assign].project_id from Assign 
Inner Join [project] ON [project].[id] =  [Assign].[project_id]where ([employee_id] = @id)" >
                                                                <SelectParameters>
                                                                    <asp:SessionParameter Name="id" SessionField="userid" Type="Int32" />
                                                                </SelectParameters>
                                                        </asp:SqlDataSource>
                                                                            </div>
                                               </div>
                                           <div class="col-md-2">
                                                    <div class="form-group label-floating">
                                                             
                                                                    <div class="demo ">
                

                <p id="datepairExample">
                    <input id="DateTS" runat="server" type="text"  placeholder="Date"/>
                   
                    <asp:TextBox ID="DateTS2" runat="server" class="date start form-control " ></asp:TextBox>

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
                                                             
                                                     <p id="datepairExample01">
                    
                    <input type="text" id="starttime" runat="server" class="time start form-control" placeholder="StartTime"/> 
                    
                                        </p>
                                                         <script src="http://jonthornton.github.io/Datepair.js/dist/datepair.js"></script>
            <script src="http://jonthornton.github.io/Datepair.js/dist/jquery.datepair.js"></script>
            <script>
                $('#datepairExample01 .time').timepicker({
                    'showDuration': true,
                    'timeFormat': 'H:i '
                });

                $('#datepairExample01 .date').datepicker({
                    'format': 'm/d/yyyy',
                    'autoclose': true
                });

                $('#datepairExample01').datepair();
            </script>
                                            
                                                                             </div>
                                                                            </div>
                                           <div class="col-md-2">
                                                    <div class="form-group label-floating">
                                                             
                                                                    
                                                           <p id="datepairExample02">
                    
                    <input type="text" runat="server" id="endtime" class="time end form-control" placeholder="EndTime" /> 
                    
                                        </p>
                                                         <script src="http://jonthornton.github.io/Datepair.js/dist/datepair.js"></script>
            <script src="http://jonthornton.github.io/Datepair.js/dist/jquery.datepair.js"></script>
            <script>
                $('#datepairExample02 .time').timepicker({
                    'showDuration': true,
                    'timeFormat': 'H:i'
                });

                $('#datepairExample02 .date').datepicker({
                    'format': 'm/d/yyyy',
                    'autoclose': true
                });

                $('#datepairExample02').datepair();
            </script>
                                            
                                                                             </div>
                                                                            </div>
                                           <div class="col-md-3">
                                                    <div class="form-group label-floating">
                                                        <asp:TextBox ID="TextBox1"  CssClass="form-control" runat="server" ReadOnly="true" ></asp:TextBox>
                                                        
                                                                            </div>
                                               </div>
                                         </div>
    
                                    <div class="row">
	                                        <div class="col-md-12">
	                                            <div class="form-group">
													<div class="form-group label-floating">
									    				<label class="control-label">Add Desciption on here</label>
								    					<textarea id="Desciption" runat="server" class="form-control" rows="3"></textarea>
		                        					<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                                                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                                                    
                                                    
                                                    </div>
	                                            </div>
	                                        </div>
	                                    </div>
                                        
	                                    <asp:Button type="submit" ID="uu" runat="server" class="btn btn-primary pull-right" CssClass="btn btn-primary pull-right" Text="Add row Timesheets" OnClick="Unnamed_Click"/>
	                                    <div class="clearfix">
                                            <%--<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="projectname" DataValueField="id">
                                            </asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:connectionString %>" SelectCommand="select [project].projectname ,Assign.id from Assign Inner Join [project] ON [project].[id] = [Assign].[project_id]WHERE ([employee_id] = @employee_id)">
                                                <SelectParameters>
                                                    <asp:Parameter Name="employee_id" />
                                                </SelectParameters>
                                            </asp:SqlDataSource>--%>
                                       </div>
	                            </div>

	                        </div>
	                    </div>
    </form>
</asp:Content>
