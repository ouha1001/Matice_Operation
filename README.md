This code appears to be a WPF (Windows Presentation Foundation) application in C#. It is designed to perform matrix operations like addition, subtraction, multiplication, division, modulus and determinant calculation.

The UI (User Interface) has various input fields to enter two matrices (or a single matrix and a number) and select the operation to perform. The result of the operation is displayed in a designated area of the UI.

Here's a brief rundown of how this code works:

* The constructor MainWindow() initializes the components of the UI.

* The Button_Click methods handle the various button clicks on the UI. These include clearing the fields, performing the selected operation, and more.

* The convertir and convertir_1 methods convert the input string into a 2D integer array, which represents the matrix.

* The Button_Click_3 method performs the selected operation based on the content of the operator button. It handles addition, subtraction, multiplication, division, modulus and determinant calculation.

* The CalculateDeterminant method calculates the determinant of a square matrix.

* The chek_Checked method toggles the UI between two modes - matrix operation and number operation.

* The Button_Click_4 and Button_Click_5 methods handle special cases for modulus and determinant calculation.






![Matrice_App](https://github.com/user-attachments/assets/aab88f92-045e-4132-ac79-2903f5357bb0)
