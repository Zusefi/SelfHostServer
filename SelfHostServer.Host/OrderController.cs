using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostServer.Host
{
    //http://localhost:5009/api/order
    public class OrderController : ApiController
    {
        order[] orders = new order[]
        {
        new order{Id=1,Name="Pizza",Category="Fastfood",Price=100 },
        new order{Id=2,Name="Soup",Category="Food",Price=10 },
        new order{ Id=3,Name="Sandwich",Category="Fastfood",Price=80}
        };
        [HttpGet]
        public IEnumerable<order> GetAllOrders()
        {
            return orders;
        }
    }
    public class order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }


    }
}
