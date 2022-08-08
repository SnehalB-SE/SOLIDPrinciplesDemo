using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciplesDemo
{
    public class OrderProcessor
    {
        private readonly OrderValidator orderValidator;
        private readonly IOrderSaver[] orderSaver;
        private readonly OrderNotificationSender orderNotificationSender;

        /// IOrderSaver[] : If u want to save in multiple databases

        //Diff. parts of Order Processing:
        //Validation
        //Save /*Requirement to save data in db as well as in cashe for faster access
        //Notification

        //public void Validate() { }
        //public void Save(string order) { }
        //public void SendNotification() { }


        public OrderProcessor(OrderValidator orderValidator, IOrderSaver[] orderSaver, OrderNotificationSender orderNotificationSender)
        {
            this.orderValidator = orderValidator;
            this.orderSaver = orderSaver;
            this.orderNotificationSender = orderNotificationSender;
        }
        public void Process()
        {
            orderValidator.Validate();
            foreach (var order in orderSaver)
            {
                order.Save(null);
            }
            orderNotificationSender.SendNotification();
        }
    }
    public class OrderValidator
    {
        public void Validate() { }
    }
    public interface IOrderSaver
    {
        void Save(string order);
    }
    public interface IOrderDeleter
    {
        void Delete(int id);
    }
    public interface IOrderReader 
    { 
        void Read(int id);
    }
    public class DbOrderSaver : IOrderSaver
    {
        public void Save(string order) { }
        //public void SaveCache(string order) { }  //Open-Close Principle
    }
    public class CacheOrdersaver : IOrderSaver
    {
        public void Save(string order)
        {
            throw new NotImplementedException();
        }
    }
    public class OrderNotificationSender
    {
        public void SendNotification() { }
    }
}

