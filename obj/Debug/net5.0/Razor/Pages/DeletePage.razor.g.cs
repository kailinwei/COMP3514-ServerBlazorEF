#pragma checksum "/Users/kailinwei/Documents/BCIT/COMP3514/SignalR/ServerBlazorEF/Pages/DeletePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d106d0b6f866006bcaab5e9e279a46c8adac3e91"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h2> Delete Page</h2>\n\n  ");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "placeholder", "First Name");
            __builder.AddAttribute(3, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "/Users/kailinwei/Documents/BCIT/COMP3514/SignalR/ServerBlazorEF/Pages/DeletePage.razor"
                                          firstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstName = __value, firstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "<br>\n  ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "placeholder", "Last Name");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "/Users/kailinwei/Documents/BCIT/COMP3514/SignalR/ServerBlazorEF/Pages/DeletePage.razor"
                                         lastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastName = __value, lastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "<br>\n  \n  ");
            __builder.OpenElement(11, "select");
            __builder.AddAttribute(12, "placeholder", "School");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "/Users/kailinwei/Documents/BCIT/COMP3514/SignalR/ServerBlazorEF/Pages/DeletePage.razor"
                                       school

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => school = __value, school));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(15, "option");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n     ");
            __builder.OpenElement(17, "option");
            __builder.AddContent(18, "Medicine");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n     ");
            __builder.OpenElement(20, "option");
            __builder.AddContent(21, "Nursing");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n     ");
            __builder.OpenElement(23, "option");
            __builder.AddContent(24, "Computing");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n     ");
            __builder.OpenElement(26, "option");
            __builder.AddContent(27, "Science");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n     ");
            __builder.OpenElement(29, "option");
            __builder.AddContent(30, "Mining");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n\n    ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "/Users/kailinwei/Documents/BCIT/COMP3514/SignalR/ServerBlazorEF/Pages/DeletePage.razor"
                       Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "class", "btn btn-warning");
            __builder.AddContent(35, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n  ");
            __builder.OpenElement(37, "p");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "/Users/kailinwei/Documents/BCIT/COMP3514/SignalR/ServerBlazorEF/Pages/DeletePage.razor"
                        returnToStudentpage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Back to home page");
            __builder.CloseElement();
            __builder.CloseElement();
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