using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace SolarParams2
{
    public class SetParams
    {
        public static Document document { get; set; }
        public static List<ParamControl> paramControlList { get; set; }

        public static Inverters.Inverter inverter { get; set; }

        public static List<Element> conductorLabels
        {
            get
            {
                return LineDiagram.getConductorLabels(document);
            }
        }



        public static void setParams(List<ParamControl> paramControlList)
        {
            // loop through each param in paramControlList, set new params.

            // set params for each additional family element.
        }
    }
}
