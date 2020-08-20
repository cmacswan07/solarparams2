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
            paramControlList = new List<ParamControl>();

            foreach(Parameter param in paramList)
            {
                ParamControl paramControl = new ParamControl(param);
                paramControlList.Add(paramControl);
            }

            Console.WriteLine("Blooper");
        }

        public static List<Parameter> paramList { get; set; }

        public static List<ParamControl> paramControlList { get; set; }

    }
}
