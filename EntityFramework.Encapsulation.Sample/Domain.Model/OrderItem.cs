using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Encapsulation.Sample.Domain.Model
{
    public class OrderItem
    {
        #region Fields

        private string _productName { get; set; }
        private long _amount { get; set; }
        private decimal _eachPrice { get; set; }
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        public string ProductName { get { return _productName; } }
        public long Amount { get { return _amount; } }
        public decimal EachPrice { get { return _eachPrice; } }
        public decimal TotalPrice { get { return _amount*_eachPrice; } }
        #endregion

        #region Constructors

        protected OrderItem()
        {
        }

        public OrderItem(string productName, long amount, decimal eachPrice)
        {
            this.Id = Guid.NewGuid();
            _productName = productName;
            _amount = amount;
            _eachPrice = eachPrice;
        }

        #endregion
    }
}
