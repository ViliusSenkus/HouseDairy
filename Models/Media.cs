﻿namespace HouseDairy.Models
{
    public class Media
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<HouseObject>? HouseObjects { get; set; }
    }
}