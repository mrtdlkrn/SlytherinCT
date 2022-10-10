using System;

namespace CT.Entities
{
    public class Car
    {
        public Guid ID { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }

        public string Information { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid MyProperty { get; set; }

    }
}
