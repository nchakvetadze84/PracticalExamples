using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExamples
{
    class Reflection
    {
        public static void Init()
        {
            Type type = Type.GetType("PracticalExamples.Account");

            var props = type.GetProperties();
            
            foreach (var propertyInfo in props)
            {
                Console.WriteLine(propertyInfo.Name);
            }

            var methods = type.GetMethods();

            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }


            object obj = Activator.CreateInstance(type);
            MethodInfo mi = type.GetMethod("GetAccHolder");


            var result = mi.Invoke(obj, null);

            Console.WriteLine(result);

            PropertyInfo pi = type.GetProperty("Name");
            pi.SetValue(obj, "James Bond");


            result = mi.Invoke(obj, null);
            Console.WriteLine(result);

            //var res = mi.Invoke(obj, new object[] { true, 2 });

            //Account acc = Activator.CreateInstance<Account>();
        }
    }
}
