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
        public UI(Element lineDiagram)
        {
            InitializeComponent();
            this.DataContext = this;
            paramList = LineDiagram.getOrderedLineDiagramParameters(lineDiagram).ToList<Parameter>();
            Console.WriteLine(myItemsControl);
        }

        public static List<Parameter> paramList { get; set; }

        private class ParamControl
        {
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
}
