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

namespace XAML_Tip_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double price = 0;
        private int step = 0;
        private double percent = 0;
        private double total = 0;
        public MainWindow()
        {
            InitializeComponent();
            txb_Signifire.Text = "$";
            txb_Textbox.Text = "Please enter the price.";
        }

        private void btn_Compliler_Click(object sender, RoutedEventArgs e)
        {
            if (step == 0)
            {
                try
                {
                    price = Convert.ToDouble(txb_InputBox.Text);
                    txb_Textbox.Text = $"So the price you have is {txb_InputBox.Text}. Alright. Click 'Clear' if its wrong, otherwise please put in the percent you want to tip.";
                    txb_Signifire.Text = "%";
                    step++;
                    txb_InputBox.Text = "";
                }
                catch (SystemException)
                {
                    MessageBox.Show("Invalid Input!!");
                    txb_InputBox.Text = "";
                }
               
            }
            else if (step == 1)
            {
                try
                {
                    percent = Convert.ToDouble(txb_InputBox.Text);
                    percent = Math.Round(percent / 100, 2);
                    total = percent * price;
                    txb_Textbox.Text = $"Okay. When done its {percent} * {price} which comes out to {total} for your tip. Press 'Clear' to use this calculator again. ";
                    step++;
                    txb_InputBox.Text = "";
                }
                catch (SystemException)
                {
                    MessageBox.Show("Invalid Input!!");
                    txb_InputBox.Text = "";
                }
                
            }
            else
            {
                MessageBox.Show("Invalid Input. Please press the clear button!!");
            }
        }

        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            price = 0;
            step = 0;
            percent = 0;
            txb_Signifire.Text = "$";
            txb_Textbox.Text = "Please enter the price.";
            txb_InputBox.Text = "";
        } 
    }
}
