﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Tickets_for_the_tour
{
    public class Ship : Entity
    {
        public string ShipName { get; set; }
        public double Speed { get; set; }
        public int Capacity { get; set; }
        public ICollection<Flight> Flights { get; set; } = new List<Flight>();
        public void Add(string ShipName, double Speed, int Capacity)
        {
            this.ShipName = ShipName;
            this.Speed = Speed;
            this.Capacity = Capacity;
        }
    }
}
