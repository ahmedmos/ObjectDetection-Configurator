using ConfiguratorOD.Helper;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace ConfiguratorOD
{
    /// <summary>
    /// Interaction logic for Step2.xaml
    /// </summary>
    public partial class Step2 : Window
    {
        public Step2()
        {
            InitializeComponent();
        }

        private void btnNextClick(object sender, RoutedEventArgs e)
        {
            if(datasetNameTxt.Text != "" && DatasetFolderPath.Text!="" )
            {
                StaticData.DatasetName = datasetNameTxt.Text;
                StaticData.DatasetPath = DatasetFolderPath.Text;

                Step3 page3 = new Step3();
                page3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dataset Name or Path cant be empty");
            }
        }
    }
}
