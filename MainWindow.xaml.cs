using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void button(object sender, RoutedEventArgs e)
        {
            double number1, number2, number3;
            List<double> primes = new List<double>();


            bool success1 = double.TryParse(textBox1.Text, out number1);
            bool success2 = double.TryParse(textBox2.Text, out number2);
            bool success3 = double.TryParse(textBox3.Text, out number3);



            if (!success1 || !success2 || !success3)
            {
                MessageBox.Show("請輸入整數", "輸入錯誤");
            }
            else if (number1 < 0)
            {
                MessageBox.Show($"輸入數值小於0，請重新輸入", "輸入錯誤");
            }
            else if (number2 < 0)
            {
                MessageBox.Show($"輸入數值小於0，請重新輸入", "輸入錯誤");
            }
            else if (number3 < 0)
            {
                MessageBox.Show($"輸入數值小於0，請重新輸入", "輸入錯誤");
            }
            else
            {

                if (number1 + number2 > number3 && number1 + number3 > number2 && number2 + number3 > number1)
                {

                    label4.Background = Brushes.Green;
                    //Label stringContent = new Label();
                    label4.Content = ($"邊長{number3},{number1},{number2}可構成三角形");

                }
                else
                {
                    label4.Background = Brushes.Red;
                    //Label stringContent = new Label();
                    label4.Content = ($"邊長{number3},{number1},{number2}不可構成三角形");

                }
             }


            ListTriangle(primes, number1,number2,number3);

            

        }

        private void ListTriangle(List<double> Myprimes, double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b  &&  b == c)
                {

                    string Triangle = "因邊長a=b,且b=c ,所以可構成等邊三角形\n\n" +
                        
                        "無法構成等腰三角形\n\n" +
                        
                        "無法構成直角三角形"; 
                            
                    
                    textblock.Text = Triangle;
                }
                else if (a == b || b == c || c == a)
                {

                    string Triangle = "無法構成等邊三角形\n\n" +

                        "邊長a=b,或b=c , c=a 滿足其一即可構成等腰三角形\n\n" +

                        "無法構成直角三角形";


                    textblock.Text = Triangle;
                }
                else if (a * a + b * b == c * c || b * b + c * c == a * a || c* c + a * a == b * b )
                {

                    string Triangle = "無法構成等邊三角形\n\n" +

                        "無法構成等腰三角形\n\n" +

                        "邊長a*a+b*b=c*c , 或b*b+c*c=a*a , c*c+a*a=b*b 滿足其一即可構成直角三角形\n\n" +
                        
                        ($"{a}*{a}+{b}*{b}={c*c}\n\n" +
                        
                        $"{b}*{b}+{c}*{c}={a*a}\n\n" +
                        
                        $"{c}*{c}+{a}*{a}={b*b}\n\n") ;


                    textblock.Text = Triangle;
                }
                else 
                {
                    
                    
                    string Triangle = "無法構成等邊三角形\n\n" +

                         "無法構成等腰三角形\n\n" +

                         "無法構成直角三角形";


                    textblock.Text = Triangle;


                }


            }
            else
            {
                string Triangle = "無法構成三角形,故無法測試結果\n\n";



                textblock.Text = Triangle;
            }

            

        }
    }
}
