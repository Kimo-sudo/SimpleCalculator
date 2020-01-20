using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int times = 0;
        public int a = 0;
        public int b = 0;
        public int result = 0;
        public string op = "";

        public MainWindow()
        {
            InitializeComponent();

        }


        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.NumPad1)
                button1.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            else if (e.Key == Key.NumPad2)
                button2.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            else if (e.Key == Key.NumPad3)
                button3.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            else if (e.Key == Key.NumPad4)
                button4.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            else if (e.Key == Key.NumPad5)
                button5.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            else if (e.Key == Key.NumPad6)
                button6.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            else if (e.Key == Key.NumPad7)
                button7.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            else if (e.Key == Key.NumPad8)
                button8.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            else if (e.Key == Key.NumPad9)
                button9.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            else if (e.Key == Key.NumPad0)
                button0.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            else if (e.Key == Key.Add)
                PlusButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            else if (e.Key == Key.Subtract)
                MinusButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            else if (e.Key == Key.Divide)
                DivideButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            else if (e.Key == Key.Multiply)
                MultiplyButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            else if (e.Key == Key.OemComma || e.Key == Key.Decimal)
                buttonComma.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            else if (e.Key == Key.Back)
                ClearEverything.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            else if (e.Key == Key.PageDown || e.Key == Key.Enter)
                RunButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {

            error.Text = "";
            Button buttonSelect = (Button)sender;
            if (buttonSelect != buttonComma)
            {
                display.Text += buttonSelect.Content.ToString();
            }
            else
            {
                if (display.Text.Contains(','))
                {
                    error.Text = "Comma kan slechts 1x";
                }
                else { display.Text += buttonSelect.Content.ToString(); }
            }
            e.Handled = true;

        }
        private void ClearEverything_Click(object sender, RoutedEventArgs e)
        {
            display.Text = "";
            e.Handled = true;
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {

            if (display.Text.Length != 0)
            {

                display.Text = display.Text.Remove(display.Text.Length - 1);
            }
            else { }
            e.Handled = true;

        }

        private void RunButton_Click(object sender, RoutedEventArgs e)
        {
            b = Int32.Parse(display.Text);
            switch (op)
            {
                case "/":
                    display.Text = (a / b).ToString();
                    break;
                case "-":
                    display.Text = (a - b).ToString();
                    break;
                case "+":
                    display.Text = (a + b).ToString();
                    break;
                case "*":
                    display.Text = (a * b).ToString();
                    break;
                default:
                    break;
            }
            e.Handled = true;
        }

        private void MinusButton_Click_1(object sender, RoutedEventArgs e)
        {

            if (display.Text != "")
            {
                a = Int32.Parse(display.Text);
                display.Text = "";
                op = "-";
            }
            e.Handled = true;
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            if (display.Text != "")
            {
                a = Int32.Parse(display.Text);
                display.Text = "";
                op = "+";
            }
            e.Handled = true;
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            if (display.Text != "")
            {
                a = Int32.Parse(display.Text);
                display.Text = "";
                op = "*";
            }
            e.Handled = true;
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            if (display.Text != "")
            {
                a = Int32.Parse(display.Text);
                display.Text = "";
                op = "/";
            }
            e.Handled = true;
        }


    }
}
