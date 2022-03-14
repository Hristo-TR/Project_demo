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
    public class ServiceMembers
    {
        public static bool Add(Members Members)
        {
            if (ValidatorMembers.isValidData(Members))
            {
                return RepositoryMembers.addMember(Members);
            }
            return false;

        }
       
    }
}
