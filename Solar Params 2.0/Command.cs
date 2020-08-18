using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;

namespace SolarParams2
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // Get uiApp.
            UIApplication uiApp = commandData.Application;

            // Get UI document.
            UIDocument uiDoc = uiApp.ActiveUIDocument;

            // Get current document.
            Document currentDoc = uiDoc.Document;


            return Result.Succeeded;
        }
    }
}
