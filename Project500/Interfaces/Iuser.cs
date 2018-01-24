using System;
using System.Collections.Generic;
using System.Text;
using Entities1;

namespace Interfaces
{
    interface Iuser
    {
        string CheckUserDetails(User user);
        bool CheckUserPassword(string password,string ConfirmPassword);
        string CheckUserLogin(String username, string password);


        
    }
}
