// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ServerBlazorEF.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/kailinwei/Documents/BCIT/COMP3514/SignalR/ServerBlazorEF/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kailinwei/Documents/BCIT/COMP3514/SignalR/ServerBlazorEF/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/kailinwei/Documents/BCIT/COMP3514/SignalR/ServerBlazorEF/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/kailinwei/Documents/BCIT/COMP3514/SignalR/ServerBlazorEF/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/kailinwei/Documents/BCIT/COMP3514/SignalR/ServerBlazorEF/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/kailinwei/Documents/BCIT/COMP3514/SignalR/ServerBlazorEF/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/kailinwei/Documents/BCIT/COMP3514/SignalR/ServerBlazorEF/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/kailinwei/Documents/BCIT/COMP3514/SignalR/ServerBlazorEF/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/kailinwei/Documents/BCIT/COMP3514/SignalR/ServerBlazorEF/_Imports.razor"
using ServerBlazorEF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/kailinwei/Documents/BCIT/COMP3514/SignalR/ServerBlazorEF/_Imports.razor"
using ServerBlazorEF.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kailinwei/Documents/BCIT/COMP3514/SignalR/ServerBlazorEF/Pages/DeletePage.razor"
using ServerBlazorEF.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/kailinwei/Documents/BCIT/COMP3514/SignalR/ServerBlazorEF/Pages/DeletePage.razor"
using ServerBlazorEF.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DeletePage/{studentId:int}")]
    public partial class DeletePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "/Users/kailinwei/Documents/BCIT/COMP3514/SignalR/ServerBlazorEF/Pages/DeletePage.razor"
      
    List<Student> students;

    int studentId;
    string firstName;
    string lastName;
    string school;

  [Parameter]
   public int StudentId { get; set; }

    Student student;

    protected override async Task OnInitializedAsync()
        {
           await Show(StudentId);
        }

    protected async Task load()
        {
            students = await studentService.GetStudentsAsync();
        }
    

    
    protected void ClearFields()
        {
           // studentId = string.Empty;
            firstName = string.Empty;
            lastName = string.Empty;
            school = string.Empty;
        }

    protected async Task Delete()
        {
            await studentService.DeleteStudentAsync(studentId);
            ClearFields();
            await load();
        
            returnToStudentpage();
        }
    
    protected async Task Show(int id)
        {
            student = await studentService.GetStudentByIdAsync(id);
            studentId = student.StudentId;
            firstName = student.FirstName;
            lastName = student.LastName;
            school = student.School;
        }
    
       private void returnToStudentpage()
        {
            NavManager.NavigateTo("/");
        } 


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentService studentService { get; set; }
    }
}
#pragma warning restore 1591
