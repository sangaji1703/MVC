using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using Peran_Bagian_MVC.Model;

namespace Peran_Bagian_MVC.Controller
{
    class PenawaranController
    {
        private List<Item> items;

        public PenawaranController()
        {
            items = new List<Item>();
        }

        public void addItem(Item item)
        {
            this.items.Add(item);
        }

        public List<Item> getItems()
        {
            return this.items;
        }
    }
}
