using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLE.S
{/// <summary>
/// single responsibility principle
/// </summary>
   public  class UserService
    {
        Salary _salary = null;
        MailMessage _mailMessage = null;
        public UserService() {
           
        }
        #region violating SRP
        //we are forcfully assingning salary ,email details on user service class then what is righ.?
        public void PushUserDetails()
        {
            //step 1 push user details
            //step 2 push salary details
            _salary.PushUserSalaryDetails();
            //step 3 send email
            _mailMessage.PushUserDetailsBySendEmail();
        }
       
        
        #endregion
        //solution is create seperate class for salary and email send
    }
}
