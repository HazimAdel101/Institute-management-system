using System;
using System.Collections.Generic;
using System.Text;

namespace Institute_project
{
    class connection_to_db
    {
        static string name_server = Environment.MachineName;
        public string conn = @" Data Source=" + name_server + ";Initial catalog=Registration;Integrated Security=True;MultipleActiveResultSets = True;";


    }
}
