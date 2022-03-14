using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_demo.Model
{
    public class Equipments
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string MuscleUsed { get; set; }
        public string DeliveryDate { get; set; }
        public int Cost { get; set; }

        public Equipments(string name, string description, string muscleused, string deliverydate, int cost)
        {
            this.Name = name;
            this.Description = description;
            this.MuscleUsed = muscleused;
            this.DeliveryDate = deliverydate;
            this.Cost = cost;
        }
    }
}
