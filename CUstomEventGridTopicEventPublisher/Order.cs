using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEventGridTopicEventPublisher
{
    internal class Order
    {
        public int OrderId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quality { get; set; }
    }
}
