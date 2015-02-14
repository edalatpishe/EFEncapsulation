using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Encapsulation.Sample.Domain.Model
{
    public class Order
    {
        #region Fields
        private DateTime _createDateTime { get; set; }
        //private string _customerName { get; set; }
        private string _customerName;
        private List<OrderItem> _orderItems { get; set; } 
        #endregion

        #region Properties
        public long Id { get; private set; }
        public DateTime CreateDateTime { get { return _createDateTime; } }
        public string CustomerName { get { return _customerName; } }
        public ICollection<OrderItem> OrderItems { get { return _orderItems; } }

        public decimal TotalPrice
        {
            get { return this._orderItems.Sum(a => a.TotalPrice); }
        }

        #endregion

        #region Constructors

        protected Order()
        {
            
        }

        public Order(long id, DateTime createDateTime, string customerName, List<OrderItem> orderItems = null)
        {
            Id = id;

            SetProperties(createDateTime, customerName, orderItems);
        }
        #endregion

        #region Public Methods
        public void Update(DateTime createDateTime, string customerName)
        {
            SetProperties(createDateTime, customerName, this._orderItems);
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            this._orderItems.Add(orderItem);
        }

        public void RemoveOrderItem(Guid id)
        {
            var item = this._orderItems.FirstOrDefault(a => a.Id == id);
            if (item != null)
                this._orderItems.Remove(item);
        }

        public void RemoveOrderItem(OrderItem item)
        {
            this._orderItems.Remove(item);
        }
        #endregion

        #region Private Methods
        private void SetProperties(DateTime createDateTime, string customerName, List<OrderItem> orderItems)
        {
            if (orderItems == null)
                orderItems = new List<OrderItem>();

            this._orderItems = orderItems;
            _createDateTime = createDateTime;
            _customerName = customerName;
        } 
        #endregion

        
    }
}
