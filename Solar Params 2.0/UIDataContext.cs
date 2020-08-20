using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace SolarParams2
{
    class UIDataContext
    {
        public UIDataContext(Element lineDiagram)
        {
            paramList = LineDiagram.getOrderedLineDiagramParameters(lineDiagram).ToList<Parameter>();
        }

        public List<Parameter> paramList = new List<Parameter>();
    }
}
