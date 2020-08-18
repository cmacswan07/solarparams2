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
        private Element getLineDiagram(Document doc)
        {
            Element lineDiagram = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance)).Where(x => x.Name == "Sunrise Template - Strings").FirstOrDefault();
            return lineDiagram;
        }

        private List<Element> getConductorLabels(Document doc)
        {
            List<Element> conductorLabels = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance)).Where(x => x.Name == "3").ToList();
            return conductorLabels;
        }

        private Element getPvBreaker(Document doc)
        {
            Element pvBreaker = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance)).Where(x => x.Name == "PV Breaker").FirstOrDefault();
            return pvBreaker;
        }

        private Element getInverterLabel(Document doc)
        {
            Element inverterLabel = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance)).Where(x => x.Name == "sld inverter label").FirstOrDefault();
            return inverterLabel;
        }

        private Element getMainServiceLabel(Document doc)
        {
            Element mainServiceLabel = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance)).Where(x => x.Name == "sld main panel").FirstOrDefault();
            return mainServiceLabel;
        }

        private Element getMainBreakerLabel(Document doc)
        {
            Element mainBreakerLabel = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance)).Where(x => x.Name == "Main Breaker").FirstOrDefault();
            return mainBreakerLabel;
        }

        private Element busbarRule(Document doc)
        {
            Element busbarRule = new FilteredElementCollector(doc).OfClass(typeof(FamilyInstance)).Where(x => x.Name == "120_rule").FirstOrDefault();
            return busbarRule;
        }

        // Methods for getting parameters.
        private IList<Parameter> getOrderedLineDiagramParameters(Element lineDiagram)
        {
            IList<Parameter> orderedParameters = lineDiagram.GetOrderedParameters();
            return orderedParameters;
        }

        private IList<Parameter> getOrderedConductorParameters(Element conductor)
        {
            IList<Parameter> orderedParameters = conductor.GetOrderedParameters();
            return orderedParameters;
        }
    }
}
