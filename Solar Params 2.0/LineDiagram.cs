using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;

namespace SolarParams2
{
    class LineDiagram
    {
        // Filtered Element Collectors.
        public static Element getLineDiagram(Document doc)
        {
            Element lineDiagram = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance)).Where(x => x.Name == "Sunrise Template - Strings").FirstOrDefault();
            return lineDiagram;
        }

        public static List<Element> getConductorLabels(Document doc)
        {
            List<Element> conductorLabels = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance)).Where(x => x.Name == "3").ToList();
            return conductorLabels;
        }

        public static Element getPvBreaker(Document doc)
        {
            Element pvBreaker = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance)).Where(x => x.Name == "PV Breaker").FirstOrDefault();
            return pvBreaker;
        }

        public static Element getInverterLabel(Document doc)
        {
            Element inverterLabel = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance)).Where(x => x.Name == "sld inverter label").FirstOrDefault();
            return inverterLabel;
        }

        public static Element getMainServiceLabel(Document doc)
        {
            Element mainServiceLabel = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance)).Where(x => x.Name == "sld main panel").FirstOrDefault();
            return mainServiceLabel;
        }

        public static Element getMainBreakerLabel(Document doc)
        {
            Element mainBreakerLabel = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance)).Where(x => x.Name == "Main Breaker").FirstOrDefault();
            return mainBreakerLabel;
        }

        public static Element getBusbarRule(Document doc)
        {
            Element busbarRule = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance)).Where(x => x.Name == "120_rule").FirstOrDefault();
            return busbarRule;
        }

        // Methods for getting parameters.
        public static IList<Parameter> getOrderedLineDiagramParameters(Element lineDiagram)
        {
            IList<Parameter> orderedParameters = lineDiagram.GetOrderedParameters();
            return orderedParameters;
        }

        public static IList<Parameter> getOrderedConductorParameters(Element conductor)
        {
            IList<Parameter> orderedParameters = conductor.GetOrderedParameters();
            return orderedParameters;
        }
    }
}
