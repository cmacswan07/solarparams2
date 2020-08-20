using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;

namespace SolarParams2
{
    public class ParamControl
    {
        public ParamControl(Parameter param)
        {
            parameter = param;
        }

        public Parameter parameter { get; set; }

        public string asValueString
        {
            get
            {
                return parameter.AsValueString();
            }
        }

        public void setIntParameter(int value)
        {
            parameter.Set(value);
        }

        public void setDoubleParameter(double value)
        {
            parameter.Set(value);
        }
    }
}

