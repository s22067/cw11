// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace cw11.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\norbe\source\repos\Nowy folder\APBD\Task11\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\norbe\source\repos\Nowy folder\APBD\Task11\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\norbe\source\repos\Nowy folder\APBD\Task11\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\norbe\source\repos\Nowy folder\APBD\Task11\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\norbe\source\repos\Nowy folder\APBD\Task11\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\norbe\source\repos\Nowy folder\APBD\Task11\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\norbe\source\repos\Nowy folder\APBD\Task11\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\norbe\source\repos\Nowy folder\APBD\Task11\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\norbe\source\repos\Nowy folder\APBD\Task11\_Imports.razor"
using cw11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\norbe\source\repos\Nowy folder\APBD\Task11\_Imports.razor"
using cw11.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\norbe\source\repos\Nowy folder\APBD\Task11\_Imports.razor"
using cw11.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\norbe\source\repos\Nowy folder\APBD\Task11\_Imports.razor"
using cw11.Repository;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students/{ID:int}")]
    public partial class StudentDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\norbe\source\repos\Nowy folder\APBD\Task11\Pages\StudentDetails.razor"
       
    [Parameter]
    public int ID { get; set; }
    private Student student;

    protected override void OnInitialized()
    {
        student = repository.GetStudent(ID);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService repository { get; set; }
    }
}
#pragma warning restore 1591
