using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_demo.Model;
using Project_demo.Repository;
using Project_demo.Service;

namespace Project_demo.Validator
{
    internal class ValidatorEquipment
    {
        public static List<String> errorsEquipment = new List<String>();
        public static bool isValidData(Equipments Equipment)
        {
            errorsEquipment.Clear();
            checkName(Equipment.Name);
            checkMuscleUsed(Equipment.MuscleUsed);






            if (errorsEquipment.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void checkName(string name)
        {
            if (name == "")
            {
                errorsEquipment.Add("Please enter name of the equipment!");
            }
        }
        private static void checkMuscleUsed(string muscleused)
        {
            if (muscleused == "")
            {
                errorsEquipment.Add("Please enter the muscle used by this equipment!");
            }
        }
        private static void checkDeliveryDate(string deliverydate)
        {
            if (deliverydate == "")
            {
                errorsEquipment.Add("Please enter the delivery date!");
            }
        }
        private static void checkCost(int cost)
        {
            if (cost == 0)
            {
                errorsEquipment.Add("Please enter the cost of the equipment!");
            }
        }
    }
}