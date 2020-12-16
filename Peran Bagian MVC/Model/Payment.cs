using System;
using System.Collections.Generic;
using System.Text;

namespace Peran_Bagian_MVC.Model
{
    class Payment
    {
        private double deliveryFee = 0;
        private double promo = 0;
        private double balance = 0;
        private OnPaymentChangedListener paymentCallBack;

        public Payment(OnPaymentChangedListener paymentCallback)
        {
            this.paymentCallBack = paymentCallback;
        }

        public void setBalance (double balance)
        {
            this.balance = balance;
        }

        public double getBalance()
        {
            return this.balance;
        }

        public void setDeliveryFee(double deliveryFee)
        {
            this.deliveryFee = deliveryFee;
        }

        public double getDeliveryFee()
        {
            return this.deliveryFee;
        }

        public double getPromo()
        {
            return this.promo;
        }

        public void setPromo(double promo)
        {
            this.promo = promo;
        }
        public void updateTotal(double subTotal)
        {
            double total = subTotal + deliveryFee - promo;
            this.balance = this.balance - total;
            this.paymentCallBack.onPriceUpdated(subTotal, total, balance);
        }
        
    }
    interface OnPaymentChangedListener
    {
        void onPriceUpdated(double subtTotal, double granTotal, double balance);
    }
}
