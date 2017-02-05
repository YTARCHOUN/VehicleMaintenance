﻿
namespace VehicleMaintenance.Domain.Common
{
    public class Address : IEntity
    {
        public int Id { get; set; }

        public string StreetNumber { get; set; }

        public string StreetName { get; set; }

        public string PostalCode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }
}
