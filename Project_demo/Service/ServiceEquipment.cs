using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_demo.Model;
using Project_demo.Validator;
using Project_demo.Repository;

namespace Project_demo.Service
{
    public class ServiceEquipment
    {
        public static bool Add(Equipments Equipment)
        {
            if (ValidatorEquipment.isValidData(Equipment))
            {
                return RepositoryEquipment.addEquipment(Equipment);
            }
            return false;

        }
    }
}
