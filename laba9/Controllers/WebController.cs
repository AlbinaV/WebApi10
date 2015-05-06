using System;
using System.Collections.Generic;
using System.Web.Http;
using laba9.Models;


namespace laba9.Controllers
{
    namespace WebServices.Controllers
    {
        public class WebController : ApiController
        {
            private rep repo = rep.Current;

            public IEnumerable<order> GetAllOrders()
            {
                return repo.GetAll();
            }

            public order GetOrder(int id)
            {
                return repo.Get(id);
            }

             [HttpPost]
            public order CreateOrder(order item)
            {
                return repo.Add(item);
            }


             [HttpPut]
            public bool UpdateOrder(order item)
            {
                return repo.Update(item);
            }

            public void DeleteReservation(int id)
            {
                repo.Remove(id);
            }
        }
    }
}