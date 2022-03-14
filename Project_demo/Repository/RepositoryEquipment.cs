using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Project_demo.Model;

namespace Project_demo.Repository
{
    public class RepositoryEquipment
    {
        public static bool addEquipment(Equipments Equipment)
        {
            String dbInfo = "server=localhost;userid=root;password=;database=project_demo";

            MySqlConnection db = new MySqlConnection(dbInfo);

            db.Open();

            string sql = "INSERT INTO equipment (EquipmentName,Description,MuscleUsed,DeliveryDate,Cost) VALUES (@EquipmentName,@Description,@MuscleUsed,@DeliveryDate,@Cost)";
            MySqlCommand command = new MySqlCommand(sql, db);

            command.Parameters.AddWithValue("EquipmentName", Equipment.Name);
            command.Parameters.AddWithValue("Description", Equipment.Description);
            command.Parameters.AddWithValue("MuscleUsed", Equipment.MuscleUsed);
            command.Parameters.AddWithValue("DeliveryDate", Equipment.DeliveryDate);
            command.Parameters.AddWithValue("Cost", Equipment.Cost);
          

            command.ExecuteNonQuery();
            db.Close();

            return true;
        }
    }
}
