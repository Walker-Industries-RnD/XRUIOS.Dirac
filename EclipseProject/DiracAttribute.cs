using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace EclipseProject
{
    [AttributeUsage(AttributeTargets.Method)]
    public class SeaOfDirac : Attribute
    {
        public string Name { get; }
        public string[]? ParameterNames { get; }        // optional, for documentation or mapping
        public Type[] ParameterTypes { get; }              // store the exact types expected
        public Type ReturnType { get; }                    // store the return type

        public SeaOfDirac(string name, string[]? parameters, Type returnType, params Type[] parameterTypes)
        {
            Name = name;
            ParameterNames = parameters;
            ReturnType = returnType;
            ParameterTypes = parameterTypes;
        }
    }

}
