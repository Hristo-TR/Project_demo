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
    public class ServiceStaff
    {
        
            public static bool Add(Staff Staff)
            {
                if (ValidatorStaff.isValidData(Staff))
                {
                    return RepositoryStaff.addStaff(Staff);
                }
                return false;

            }

        }
    
}
