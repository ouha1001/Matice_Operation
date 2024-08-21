﻿using System;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Matice_Operation
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion


        #region 
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


                    if (str[count] == ',')
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
                            if (str[count + 1] != ' ' && str[count + 1] != ',')
                            {
                                if (str[count + 2] != ' ' && str[count + 2] != ',')
                                {
                                    array[i, j] = Int32.Parse(str[count].ToString() + str[count + 1].ToString() + str[count + 2].ToString());
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
        public int[,] convertir_1(string str)
        {
            int k = Convert.ToInt32(size.Text);
            int[,] array = new int[k, k];
            int count = 0;

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {


                    if (str[count] == ',')
                    {

                        //array[i, j] = Int32.Parse(str[count] + "");
                        count++;
                        j--;


                    }
                    else if (str[count] != ',')
                    {
                        count++;
                        j--;
                    }

                    else
                    {
                        try
                        {
                            if (str[count + 1] != ' ' && str[count + 1] != ',')
                            {
                                if (str[count + 2] != ' ' && str[count + 2] != ',')
                                {
                                    array[i, j] = Int32.Parse(str[count].ToString() + str[count + 1].ToString() + str[count + 2].ToString());
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
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int k = Convert.ToInt32(size.Text);

            int[,] list = new int[k, k];

            string? operateur = Convert.ToString(op.Content);
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
                    int[,] matrixe1 = convertir(m1.Text);
                    int determinant = CalculateDeterminant(matrixe1);
                    
                    res.Content = determinant + "";
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

        private static int[,] GetMinor(int[,] matrix, int col)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] minor = new int[rows - 1, cols - 1];

            int i = 0, j = 0;

            for (int row = 1; row < rows; row++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (c != col)
                    {
                        minor[i, j] = matrix[row, c];
                        j++;
                    }
                }
                i++;
                j = 0;
            }

            return minor;
        }

        public static int CalculateDeterminant(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows != cols)
            {
                throw new Exception("The matrix must be square!");
            }

            if (rows == 2)
            {
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            else
            {
                int result = 0;

                for (int i = 0; i < cols; i++)
                {
                    int[,] minor = GetMinor(matrix, i);
                    result += (i % 2 == 1 ? -1 : 1) * matrix[0, i] * CalculateDeterminant(minor);
                }

                return result;
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
        #endregion
    }
}