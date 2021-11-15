using bitis.mode;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bitisdemo.Pages
{
    public class DisplayProductBase : ComponentBase
    {
        [Parameter]
        public Product Product { get; set; }

        [Parameter]
        public bool ShowFooter { get; set; }
    }
}