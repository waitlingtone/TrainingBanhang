using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda.MainProject
{
    public interface ItemView:IView
    {
        List<Item> Items { get; set; }
        Item CurrentItem { get; }
    }
}
