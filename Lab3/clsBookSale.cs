using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class clsBookSale
    {
        string strTitle;
        int intQuantity;
        decimal dePrice;
        static decimal deSalesTotal = 0;
        static int intSalesCount = 0;
        const float sngDISCOUNT_RATE = 0.1F;
        bool blnDiscount;

        public string Title
        {
            get
            {
                return strTitle;
            }
            set
            {
                strTitle = value; 
            }
        }

        public int Quantity
        {
            get
            {
                return intQuantity;
            }
            set
            {
                if (value > 0)
                    intQuantity = value;
                else throw new Exception("Quantity must be greater than 0");
            }
        }

        public decimal Price
        {
            get
            {
                return dePrice;
            }
            set
            {
                if (value >= 0)
                    dePrice = value;
                else throw new Exception("Price must be greater or equal 0");
            }
        }

        public static decimal SalesTotal
        {
            get
            {
                return deSalesTotal;
            }
        }

        public static int SalesCount
        {
            get
            {
                return intSalesCount;
            }
        }

        public bool Discount
        {
            get
            {
                return blnDiscount;
            }
            set
            {
                blnDiscount = value;
            }
        }

        public virtual decimal DiscountAmount()
        {
            decimal decDiscountAmount;
            if (blnDiscount)
            {
                decDiscountAmount = intQuantity * dePrice * Convert.ToDecimal(sngDISCOUNT_RATE);
            }
            else
            {
                decDiscountAmount = 0M;
            }
            return decDiscountAmount;
        }

        public decimal NetDue()
        {
            decimal decNetDue = ExtendedPrice() - DiscountAmount();
            deSalesTotal += decNetDue;
            intSalesCount += 1;
            return decNetDue;
        }

        public decimal ExtendedPrice()
        {
            decimal deExtendedPrice = intQuantity * dePrice;
            return deExtendedPrice;
        }

        public clsBookSale(string title, int quantity, decimal price, bool discount)
        {
            this.Title = title;
            this.Quantity = quantity;
            this.Price = price;
            this.Discount = discount;
        }


    }

    class clsStudentBookSale : clsBookSale
    {
        bool blnStudentDiscount;
        const float sngSTUDENT_DISCOUNT_RATE = 0.15F;
        public bool StudentDiscount
        {
            get
            {
                return blnStudentDiscount;
            }
            set
            {
                blnStudentDiscount = value;
            }
        }

        public clsStudentBookSale(string title, int quantity, decimal price, bool discount, bool student)
            : base(title, quantity, price, discount)
        {
            blnStudentDiscount = student;
        }
        public override decimal DiscountAmount()
        {
            decimal decDiscountAmount;

            decDiscountAmount = base.DiscountAmount();

            if (StudentDiscount)
            {
                decDiscountAmount += ExtendedPrice() * Convert.ToDecimal(sngSTUDENT_DISCOUNT_RATE);
            }

            return decDiscountAmount;
        }
    }

}
