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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Flowerpot.Equations.Domain;
using Flowerpot.Equations.Domain.UnitTests;

namespace Flowerpot.Equations.View
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // TODO Logic Layer (services?)
        // TODO Create NumberBox?
        // TODO Create ViewModels?
        private void GenerateQuadraticFormButton_OnClick(object sender, RoutedEventArgs e)
        {
            var factorA = QuadraticFactorATextBox.Text;
            var factorB = QuadraticFactorBTextBox.Text;
            var factorC = QuadraticFactorCTextBox.Text;

            var equation = new QuadraticEquation(Double.Parse(factorA), Double.Parse(factorB), Double.Parse(factorC));

            QuadraticResult.Text = equation.ToString();
        }

        private void GenerateLinearFormButton_OnClick(object sender, RoutedEventArgs e)
        {
            var factorA = LinearFactorATextBox.Text;
            var factorB = LinearFactorBTextBox.Text;

            var equation = new LinearEquation(Double.Parse(factorA), Double.Parse(factorB));

            LinearResult.Text = equation.ToString();
        }
    }
}
