using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace laba9.Models
{
    public class rep
    {
        private static rep repo = new rep();

        public static rep Current
        {
            get
            {
                return repo;
            }
        }
    
        private List<order> data = new List<order> {
            new order { 
                OrderId = 1, Name = "Ipad", Count = 5, Address = "Ленина 89"},
            new order { 
                OrderId = 2, Name = "Iphone 6", Count = 10, Address = "Молодогвардейцев 102"},
            new order { 
                OrderId = 3, Name = "Macbook Air", Count = 1, Address = "Горького 10"},
            new order { 
                OrderId = 4, Name = "Macbook Pro", Count = 2, Address = "Горького 10"},
    };

        public IEnumerable<order> GetAll()
        {
            return data;
        }

        public order Get(int id)
        {
            return data.Where(r => r.OrderId == id).FirstOrDefault();
        }

        public order Add(order item)
        {
            item.OrderId = data.Count + 1;
            data.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            order item = Get(id);
            if (item != null)
            {
                data.Remove(item);
            }
        }

        public bool Update(order item)
        {
            order storedItem = Get(item.OrderId);
            if (storedItem != null)
            {
                storedItem.Name = item.Name;
                storedItem.Count = item.Count;
                storedItem.Address = item.Address;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}