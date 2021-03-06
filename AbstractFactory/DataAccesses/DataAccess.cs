﻿using AbstractFactory.Departments;
using AbstractFactory.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;

namespace AbstractFactory.DataAccesses
{
    internal class DataAccess
    {
        private static readonly string AssemblyName = "AbstractFactory";

        private static readonly string db = ConfigurationManager.AppSettings["DB"];

        public static IUser GetUser()
        {
            string className = AssemblyName + "." + "Users" + "." + db + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDepartment GetDepartment()
        {
            string className = AssemblyName + "." + "Departments" + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}