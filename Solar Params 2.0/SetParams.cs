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

        public static int mainPanelValue { get; set; }

        public static int mainBreakerValue { get; set; }

        public static int newExistingValue { get; set; }
        
        public static List<Element> conductorLabels
        {
            get
            {
                return LineDiagram.getConductorLabels(document);
            }
        }

        public static Element pvBreaker
        {
            get
            {
                return LineDiagram.getPvBreaker(document);
            }
        }

        public static Element inverterLabel
        {
            get
            {
                return LineDiagram.getInverterLabel(document);
            }
        }

        public static Element mainServiceLabel
        {
            get
            {
                return LineDiagram.getMainServiceLabel(document);
            }
        }

        public static Element mainBreakerLabel
        {
            get
            {
                return LineDiagram.getMainBreakerLabel(document);
            }
        }

        public static Element busbarRule
        {
            get
            {
                return LineDiagram.getBusbarRule(document);
            }
        }


        public static void setParams()
        {
            // loop through each param in paramControlList, set new params.

            // set params for each additional family element.
        }
    }
}
