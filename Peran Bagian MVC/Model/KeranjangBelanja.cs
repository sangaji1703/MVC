using System;
using System.Collections.Generic;
using System.Text;

namespace Peran_Bagian_MVC.Model
{
    class KeranjangBelanja
    {
        List<Item> itemBelanja;
        Payment payment;
        OnKeranjangBelanjaChangedListener callback;

        public  KeranjangBelanja(Payment payment, OnKeranjangBelanjaChangedListener callback)
        {
            this.payment = payment;
            this.itemBelanja = new List<Item>();
            this.callback = callback;
        }

        public List<Item> getItems()
        {
           return this.itemBelanja;
        }

        public void addItem(Item item)
        {
            this.itemBelanja.Add(item);
            this.callback.addItemSucceed();
            calculateSubTotal();
        }

        public void removeItem(Item item)
        {
            this.itemBelanja.Remove(item);
            this.callback.removeItemSucceed();
            calculateSubTotal();
        }

        private void calculateSubTotal()
        {
            double subTotal = 0;
            foreach (Item item in itemBelanja)
            {
                subTotal += item.price;
            }
            payment.updateTotal(subTotal);
        }
        
    }
    interface OnKeranjangBelanjaChangedListener
    {
        void removeItemSucceed();
        void addItemSucceed();
    }
}
