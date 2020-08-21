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

        public static Element acDiscoLabel
        {
            get
            {
                return LineDiagram.getAcDiscoLabel(document);
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
            // loop through each param in LineDiagram paramControlList, set new params.
            foreach(ParamControl paramControl in paramControlList)
            {
                if (paramControl.parameter.StorageType.Equals(StorageType.Integer))
                {
                    paramControl.setIntParameter(Convert.ToInt32(paramControl.newParamValue));
                }

                if (paramControl.parameter.StorageType.Equals(StorageType.Double))
                {
                    paramControl.setDoubleParameter(Convert.ToDouble(paramControl.newParamValue));
                }
            }

            // set params for inverter.
            inverterLabel.GetParameters("Inverter Make").FirstOrDefault().Set(inverter.Make);
            inverterLabel.GetParameters("Inverter Model").FirstOrDefault().Set(inverter.Model);
            inverterLabel.GetParameters("Inverter Watts").FirstOrDefault().Set(inverter.Wattage);
            inverterLabel.GetParameters("Max AC Output Current").FirstOrDefault().Set(inverter.Output);
            inverterLabel.GetParameters("Max DC Input Current").FirstOrDefault().Set(inverter.Input);

            // set AC Disconnect params.
            if (inverter.Output * 1.25 <= 30)
            {
                acDiscoLabel.GetParameters("Disco Rating").FirstOrDefault().Set(30);
            }
            else
            {
                acDiscoLabel.GetParameters("Disco Rating").FirstOrDefault().Set(60);
            }

            // set params for main panel.
            mainServiceLabel.GetParameters("Main Breaker").FirstOrDefault().Set(mainBreakerValue);
            mainServiceLabel.GetParameters("Main Busbar").FirstOrDefault().Set(mainPanelValue);
            mainServiceLabel.GetParameters("New").FirstOrDefault().Set(newExistingValue);

            // set params for main breaker label in drawing
            mainBreakerLabel.GetParameters("breaker_size").FirstOrDefault().Set(mainBreakerValue);

            // set params for PV breaker.
            pvBreaker.GetParameters("breaker_size").FirstOrDefault().Set(inverter.Breaker);

            // Set 120% rule parameters.
            busbarRule.GetParameters("Busbar").FirstOrDefault().Set(mainPanelValue);
            busbarRule.GetParameters("Main Breaker").FirstOrDefault().Set(mainBreakerValue);
            busbarRule.GetParameters("PV Breaker").FirstOrDefault().Set(inverter.Breaker);

            // set conductors values.
            foreach (Element conductorLabel in conductorLabels)
            {
                conductorLabel.GetParameters("AMPS").FirstOrDefault().Set(inverter.Output);
            }
        }
    }
}
