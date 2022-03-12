// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Bookstore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/matthewmazankowski/Desktop/Mission/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/matthewmazankowski/Desktop/Mission/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/matthewmazankowski/Desktop/Mission/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/matthewmazankowski/Desktop/Mission/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/matthewmazankowski/Desktop/Mission/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/matthewmazankowski/Desktop/Mission/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/orders")]
    public partial class Orders : OwningComponentBase<IOrderRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "/Users/matthewmazankowski/Desktop/Mission/Bookstore/Bookstore/Pages/Admin/Orders.razor"
       

    public IOrderRepository repo => Service;

    public IEnumerable<Order> AllOrders { get; set; }
    public IEnumerable<Order> UncollectedOrders { get; set; }
    public IEnumerable<Order> CollectedOrders { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        AllOrders = await repo.Orders.ToListAsync();
        UncollectedOrders = AllOrders.Where(x => !x.OrderReceived);
        CollectedOrders = AllOrders.Where(x => x.OrderReceived);
    }

    public void CollectOrder(int id) => UpdateOrder(id, true);
    public void ResetOrder(int id) => UpdateOrder(id, false); 

    private void UpdateOrder (int id, bool ordered)
    {
        Order o = repo.Orders.FirstOrDefault(x => x.OrderId == id);
        o.OrderReceived = ordered;
        repo.SaveOrder(o); 
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
