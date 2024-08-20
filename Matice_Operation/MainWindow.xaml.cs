using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Matice_Operation
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            m1.Text = "";
            m2.Text = "";
            M1.Content = "";
            M2.Content = "";
            res.Content = "";
            op.Content = "";
            size.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            size.Text = "";
            m1.Text = "";
            m2.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            op.Content = btn.Content;
            int[,] m_1 = convertir(m1.Text);
            int[,] m_2 = convertir(m2.Text);
            M1.Content = "";
            M2.Content = "";

            int val = Convert.ToInt32(size.Text);
            for (int i = 0; i < val; i++)
            {
                for (int j = 0; j < val; j++)
                {
                    M1.Content += m_1[i, j] + " ";
                }
                M1.Content += "\n";
            }

            for (int i = 0; i < val; i++)
            {
                for (int j = 0; j < val; j++)
                {
                    M2.Content += m_2[i, j] + " ";
                }
                M2.Content += "\n";
            }
        }
        /// <summary>
        /// Convert the Matrixe from string to integer
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        /*public int[,] convertir(string str)
        {
            int k = Convert.ToInt32(size.Text);
            int[,] array = new int[k, k];
            string[] numbers = str.Split(',');
            string[] numbers2 = new string[k] ;
            


               for (int i = 0; i < k; i++)
            {
               
                
                for (int j = 0; j < k; j++)
                {
                    numbers2.SetValue(numbers[i].Split(' '),i)  ;
                    array[i, j] = Int32.Parse(numbers2[i * k + j]);
                    
                }
                
            }

               /* for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    

                    array[i, j] = Int32.Parse(numbers2[i * k + j]);
                }
            }

            return array;
        }*/
        
        
        public int[,] convertir(string str)
        {

            int k = Convert.ToInt32(size.Text);
            int[,] array = new int[k, k];
            int count = 0;

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {

                    
                    if (str[count] == ',' )
                    {
                       
                            //array[i, j] = Int32.Parse(str[count] + "");
                            count++;
                        j--;
                        
                        
                    }
                    else if (str[count] == ' ')
                    {
                        count++;
                        j--;
                    }
                    
                    else
                    {
                        try
                        {
                        if(str[count+1] != ' ' && str[count + 1] != ',' )
                        {
                            if (str[count + 2] != ' ' && str[count + 2] != ',')
                            {
                                array[i, j] = Int32.Parse(str[count].ToString() + str[count + 1].ToString() + str[count + 2].ToString() );
                                count++;
                                count++;
                                count++;
                            }
                            else
                            {
                                array[i, j] = Int32.Parse(str[count].ToString() + str[count + 1].ToString());
                                count++;
                                count++;
                            }
                        }
                        else
                        {
                                array[i, j] = Int32.Parse(str[count] + "");
                                count++;
                        }
                        }
                        catch (Exception)
                        {
                            array[i, j] = Int32.Parse(str[count] + "");
                            count++;
                        }
                        
                        
                        
                    }
                }
            }
            return array;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int[] convertir_1(string str)
        {

            int k = Convert.ToInt32(size.Text);
            int[] array = new int[k * k];
            int count = 0;

            for (int i = 0; i < k * k; i++)
            {
                if (str[count] != ',')
                {
                    array[i] = Int32.Parse(str[count++] + "");

                    count++;
                }
                else
                {

                    count++;
                }


            }

            return array;
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int k = Convert.ToInt32(size.Text);
            int[,] list = new int[k, k];

            string operateur = Convert.ToString(op.Content);
            switch (operateur)
            {
                case "+": //Addition
                    int[,] m_1 = convertir(m1.Text);
                    int[,] m_2 = convertir(m2.Text);
                    res.Content = "";
                    res.Content += "**************************************************************************\n";
                    for (int i = 0; i < k; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            list[i, j] = Int32.Parse(m_1[i, j] + "") + Int32.Parse(m_2[i, j] + "");
                        }
                    }
                    for (int i = 0; i < k; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            res.Content += list[i, j] + " "; ;
                        }
                        res.Content += "\n";
                    }

                    break;
                case "-": //Substraktion
                    int[,] m_ = convertir(m1.Text);
                    int[,] m__ = convertir(m2.Text);
                    res.Content = "";
                    res.Content += "**************************************************************************\n";
                    for (int i = 0; i < k; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            list[i, j] = Int32.Parse(m_[i, j] + "") - Int32.Parse(m__[i, j] + "");
                        }
                    }
                    for (int i = 0; i < k; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            res.Content += list[i, j] + " "; ;
                        }
                        res.Content += "\n";
                    }

                    break;
                case "*":  // Multiplikation
                    int[,] mm1 = convertir(m1.Text);
                    int[,] mm2 = convertir(m2.Text);
                    res.Content = "";
                    res.Content = "**************************************************************************\n";

                    for (int i = 0; i < k; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            for (int s = 0; s < k; s++)
                            {
                                list[i, j] = list[i, j] + Int32.Parse(mm1[i, s] + "") * Int32.Parse(mm2[s, j] + "");
                            }

                        }
                    }
                    for (int i = 0; i < k; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            res.Content += list[i, j] + " "; ;
                        }
                        res.Content += "\n";
                    }


                    break;
                case "/":
                    int[,] md1 = convertir(m1.Text);
                    int[,] md2 = convertir(m2.Text);
                    res.Content = "";
                    res.Content = "**************************************************************************\n";

                    for (int i = 0; i < k; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            list[i, j] = Int32.Parse(md1[i, j] + "") / Int32.Parse(md2[i, j] + "");
                        }
                    }
                    for (int i = 0; i < k; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            res.Content += list[i, j] + " "; ;
                        }
                        res.Content += "\n";
                    }

                    break;
                case "%":
                    int[,] mmd1 = convertir(m1.Text);
                    res.Content = "";
                    res.Content = "**************************************************************************\n";
                    int val = Int32.Parse(m2.Text + "");
                    for (int i = 0; i < k; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            list[i, j] = Int32.Parse(mmd1[i, j] + "") % val;
                        }
                    }
                    for (int i = 0; i < k; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            res.Content += list[i, j] + " "; ;
                        }
                        res.Content += "\n";
                    }

                    break;
                case "D":
                    Matrix matrix = Matrix.Parse(m1.Text);
                    double det = matrix.Determinant;
                    res.Content = det + "";
                    break;
                    /*case "Inv":

                        Matrix myMatrix = Matrix.Parse(m1.Text);


                        if (myMatrix.HasInverse)
                        {

                            myMatrix.Invert();

                        }
                        else
                        {
                            throw new InvalidOperationException("The matrix is not invertible.");
                        }
                        break;*/
            }

        }

        private void chek_Checked(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            if (chek.IsChecked == true)
            {
                chek1.IsChecked = false;
            }
            else
            {
                chek1.IsChecked = true;
                matrice2.Content = "Number :";
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            Button btn = (Button)sender;
            op.Content = btn.Content;
            int[,] m_1 = convertir(m1.Text);

            M1.Content = "";
            M2.Content = "";

            int val = Convert.ToInt32(size.Text);
            for (int i = 0; i < val; i++)
            {
                for (int j = 0; j < val; j++)
                {
                    M1.Content += m_1[i, j] + " ";
                }
                M1.Content += "\n";
            }

            M2.Content = m2.Text;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            M2.IsEnabled = false;
            matrice2.IsEnabled = false;
            m2.IsEnabled = false;
            Button btn = (Button)sender;
            op.Content = btn.Content;
            int[,] m_1 = convertir(m1.Text);

            M1.Content = "";


            int val = Convert.ToInt32(size.Text);
            for (int i = 0; i < val; i++)
            {
                for (int j = 0; j < val; j++)
                {
                    M1.Content += m_1[i, j] + " ";
                }
                M1.Content += "\n";
            }


        }
    }
}
