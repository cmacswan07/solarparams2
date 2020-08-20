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
            // Initialize component
            InitializeComponent();

            // Set DataContext
            this.DataContext = this;

            // Get ordered parameters from document line diagram.
            paramList = LineDiagram.getOrderedLineDiagramParameters(lineDiagram).ToList<Parameter>();

            // Create a list of Parameter controls.
            paramControlList = new List<ParamControl>();

            foreach(Parameter param in paramList)
            {
                if (!param.IsReadOnly)
                {
                    ParamControl paramControl = new ParamControl(param);
                    paramControlList.Add(paramControl);
                }
            }
        }

        public static List<Parameter> paramList { get; set; }

        public static List<ParamControl> paramControlList { get; set; }

        public static List<Inverters.Inverter> inverterList
        {
            get
            {
                return Inverters.inverterList;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
