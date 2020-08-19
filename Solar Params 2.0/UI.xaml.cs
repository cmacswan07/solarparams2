using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace SolarParams2
{
    /// <summary>
    /// Interaction logic for UI.xaml
    /// </summary>
    public partial class UI : Window
    {
        public UI(Document doc, Element lineDiagram)
        {
            InitializeComponent();
            convertToOC(LineDiagram.getOrderedLineDiagramParameters(lineDiagram), paramList);
        }

        private ObservableCollection<Parameter> paramList = new ObservableCollection<Parameter>();

        private ObservableCollection<Parameter> convertToOC(IList<Parameter> lineDiagramParams, ObservableCollection<Parameter> oc)
        {
            foreach(Parameter param in lineDiagramParams)
            {
                oc.Add(param);
            }
            return oc;
        }
    }
}
