using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Author:          Connor Stanford
 * CLID:            cxs0290
 * Class:           CMPS 358
 * Assignment:      project #1
 * Due Date:        Tuesday, 13 October 2015, 11:55 PM
 * Description:     A calculator program with a GUI that also accepts user input from the keyboard and numberpad. I tried my best to make this
 *                  unbreakable. If you can break it, please let me know what you did.
 */

namespace p1_cxs0290
{
    public partial class Calculator : Form
    {
        private Stack<double> numberStack = new Stack<double> { };
        // Stack that holds the numbers to perform operations on.

        private Stack<string> operatorStack = new Stack<string> { };
        // Stack that holds strings that represent different operators. ie: " +, -, *, / " 

        private string currentNumber = null;
        /* CurrentNumber is a string that is later parsed into a double to perfrom
         * operations on. Every time a numeric button is pressed, the the string is
         * concatenated onto the existing string in currentNumber. When an operator button is
         * is pressed, the string in currentNumber is parsed and pushed onto the numberStack,
         * and is reset to null. */

        private bool previousButtonEnteredIsOperator = false;
        /* previousButtonEnteredIsOperator is used to check if the user enters two operators in a row.
         * If so, the operator that is currently on the operatorStack is popped off, and the new operator takes its place.
         * for example: if the user enters: " 10 + - 5 ", the calculator interprets the first operator as a mistake, so the calculation
         * performed would be 10 - 5 = 5; */
        public Calculator()
        {
            InitializeComponent();
            CalculatorScreen.KeyPress += new KeyPressEventHandler(keypressed);  // Handles input from keyboard to calculator screen.
        }

        private string[] checkIfNumberArray = new string[] {"0","1","2","3","4","5","6","7","8","9"};
        // Used in keypressed() to verify that user input from the keyboard or numberpad is a valid input. 

        private string[] checkIfOperatorArray = new string[] { "+", "-", "*", "/" };
        // Used in keypressed() verify that user input from the keyboard or numberpad is a valid input. 

        private void keypressed(object o, KeyPressEventArgs e)
        {   // Directs user input from the keyboard or numberpad to CalculatorScreen.

            if (checkIfNumberArray.Contains(e.KeyChar.ToString()))
            {   // If the keyboard/numberpad input is a number or period, currentNumber is updated and onNumberButtonClick() is called. 
                currentNumber += e.KeyChar.ToString();
                onNumberButtonClick();
            }
            else if (checkIfOperatorArray.Contains(e.KeyChar.ToString()))
            {   // If the keyboard/numberpad input is a valid operator, onOperatorClick() is called.
                correctOperatorStackIf_previousButtonEnteredIsOperator();
                onOperatorClick(e.KeyChar.ToString());
            }
            else if (e.KeyChar.ToString() == ".")
            {   /* If the keyboard/numberpad input is a period, DecimalButton_Click() is called. 
                 * "." is not in checkIfNumberArray because multiple rules apply to "." as an input. 
                 * DecimalButton_Click() handles said rules. */
                DecimalButton_Click(o, e);
            }
            else if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
            {   // If the keyboard/numberpad input is the return key, doCalculation() is called. 
                doCalculation();
            }
            else if (e.KeyChar == (char)Keys.Back)
            {   // If the keyboard/numberpad input is the backspace key, BackSpaceButton_Click() is called. 
                BackSpaceButton_Click(o, e);
            }
        }

      

        private void ExitButton_Click(object sender, EventArgs e)
        {   // Exit Button in upper right hand corner exits the application.
            Application.Exit();
        }

        private void onNumberButtonClick()
        {   // Used only to update CalculatorScreen on the event that a numeric button press occurs.
            CalculatorScreen.Clear();
            CalculatorScreen.Paste(currentNumber);
            previousButtonEnteredIsOperator = false;
            previousButtonEnteredIs_PlusMinusButton = false;
            focusOnCalculatorScreen();
        }

        // Each numeric button click method below concatenates its number to the string in currentNumber, then calls onNumberButtonClick().
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            currentNumber += "0";
            onNumberButtonClick();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            currentNumber += "1";
            onNumberButtonClick();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            currentNumber += "2";
            onNumberButtonClick();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            currentNumber += "3";
            onNumberButtonClick();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            currentNumber += "4";
            onNumberButtonClick();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            currentNumber += "5";
            onNumberButtonClick();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            currentNumber += "6";
            onNumberButtonClick();
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            currentNumber += "7";
            onNumberButtonClick();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            currentNumber += "8";
            onNumberButtonClick();
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            currentNumber += "9";
            onNumberButtonClick();
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            try     // Checks currentNumber for "." - if currentNumber is Null, an exception is thrown. 
            {
                if (currentNumber.Contains("."))
                {   // Ensures that the user cannot enter two seperate decimal places.
                    focusOnCalculatorScreen();
                    return;         
                }
                else
                {
                    currentNumber += ".";
                    onNumberButtonClick();
                    focusOnCalculatorScreen();
                }
            }
            catch (NullReferenceException)
            {   
                currentNumber += "0.";
                onNumberButtonClick();
                focusOnCalculatorScreen();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {   // Resets Calculator to original state. 
            CalculatorScreen.Clear();
            operatorStack.Clear();
            numberStack.Clear();
            currentNumber = null;
            previousButtonEnteredIs_PlusMinusButton = false;
            previousButtonEnteredIsOperator = false;
            focusOnCalculatorScreen();
        }

        private void Clear_DropDownMenuItem_Click(object sender, EventArgs e)
        {   // Simply calls ClearButton_Click() to restore Calculator to original state. 
            ClearButton_Click(sender, e);
        }

        private void BackSpaceButton_Click(object sender, EventArgs e)
        {
            if (currentNumber == null || previousButtonEnteredIs_PlusMinusButton == true || CalculatorScreen.TextLength == 0) 
                /* Does not allow you to backspace if the number is null, if the text on screen is the result of 
                 * performed calculations, or if there is no text on the screen. */
            {
                focusOnCalculatorScreen();
                return;
            }
            currentNumber = currentNumber.Remove(currentNumber.Length - 1); // Removes the last item in string currentNumber.
            CalculatorScreen.Clear();                                       // The screen is cleared.  
            CalculatorScreen.Paste(currentNumber);                          // The screen is updated with the current string in currentNumber.
            focusOnCalculatorScreen();
        }

        private bool previousButtonEnteredIs_PlusMinusButton = false;
        /* Set to true when the user hits the PlusMinusButton.
         * Used to ensure that the user cannot delete the negative sign on the CalculatorScreen. */

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            previousButtonEnteredIs_PlusMinusButton = true;
            if (previousButtonEnteredIsOperator == true)
            {   // if the previous button entered is an operator, the calculator does not allow a change.
                focusOnCalculatorScreen();
                return;
            }

            if (currentNumber == null)
            {
                /* If the result of an operation is displayed on the screen, currentNumber is set to null. If this is the case, currentNumber 
                 * is set to the text currently displayed on the screen. */

                if (CalculatorScreen.Text == "Cannot divide by zero")
                {   // If the text on screen is "Cannot divide by zero", we do not want to set currentNumber to CalculatorScreen.Text.
                    focusOnCalculatorScreen();
                    return;
                }
                else
                    currentNumber = CalculatorScreen.Text;
            }
            try
            {   // Handles exception that occurs if user hits the plusMinus button before anything is entered on the screen.

                double temp = double.Parse(currentNumber);  // Temp is set to currentNumber

                temp = (-1) * temp;     // Temp is multiplied by -1 to negate the number. 
                currentNumber = temp.ToString();    // currentNumber is set to temp.
                CalculatorScreen.Clear();
                CalculatorScreen.Paste(currentNumber);
                numberStack.Pop();  // The stack is popped is remove the old number on the stack.
                numberStack.Push(double.Parse(currentNumber));  // The old number is replaced by the new, negated, currentNumber.
                focusOnCalculatorScreen();
            }
            catch { focusOnCalculatorScreen(); return; };
        }

        /* Each operator button method below first checks if the user clicked two operation buttons in a row, and corrects the 
         * operatorStack if so. After, the onOperatorClick method is called. */
        private void PlusButton_Click(object sender, EventArgs e)
        {
            correctOperatorStackIf_previousButtonEnteredIsOperator();
            onOperatorClick("+");
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            correctOperatorStackIf_previousButtonEnteredIsOperator();
            onOperatorClick("-");
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            correctOperatorStackIf_previousButtonEnteredIsOperator();
            onOperatorClick("*");
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            correctOperatorStackIf_previousButtonEnteredIsOperator();
            onOperatorClick("/");
        }

        // onOperatorClick method handles what the calculator should do after the user enters " +, -, *, / " 
        private void onOperatorClick(string operatorSymbol)
        {
            if (CalculatorScreen.TextLength == 0)
            {   // Handles exception that would occur iff the user's first input was an operator. 
                try { double checkIfNumberStackIsEmpty = numberStack.Peek(); }  // Checks if the numberStack is empty.
                // Only return if the numberStack is empty. If the numberstack is not empty, then the very first input is not an operator.
                catch { return; };
            }


            previousButtonEnteredIsOperator = true; /* Sets bool to true so that if two operators are entered in a row, a correction to the
                                                     * operatorStack occurs. */

            previousButtonEnteredIs_PlusMinusButton = false;

            try
            {
                /* This first checks if there is an operator currently in the operatorStack. If so we attempt to do a calculation.
                 * ie: if the user enters " 5 + 5 + " after the second plus operation is entered a calculation is occured and the
                 * calculator screen displays " 10 ". After the calculation is performed, the new " + " operator is pushed onto the stack. */
                string checkIfOperatorStackIsEmpty = operatorStack.Peek();
                doCalculation();
                operatorStack.Push(operatorSymbol);
                focusOnCalculatorScreen();
                return;
            }
            catch { };
            operatorStack.Push(operatorSymbol); // If there is no operator currently on the the stack, the current operator is pushed onto the stack. 

            try { numberStack.Push(double.Parse(currentNumber)); }  /* Attempts to push the currentNumber onto the stack. However,  if
                                                                     * a calculation has just been performed, the currentNumber is already on
                                                                     * the stack. If this is the case, a NullReferenceException is handled. */
            catch { };
            currentNumber = null;   // Sets the currentNumber to null so a new string representing a new number can be formed. 
            focusOnCalculatorScreen();
        }


        private void EqualsButton_Click(object sender, EventArgs e)
        {
            doCalculation(); // EqualsButton simply calls doCalculation();
        }


        public void doCalculation()
        {   // doCalculation() performs all mathematical operations and displays the output to CalculatorScreen.

            if (CalculatorScreen.TextLength == 0)   // If there is nothing on the screen, no operation can be performed. 
                return;

            try
            {
                string checkIfOperatorStackIsEmpty = operatorStack.Peek();  // If the operatorStack is empty, a calculation cannot be done.
                double checkIfNumberStackIsEmpty = numberStack.Peek();  // If the numberStack is empty, a calculation cannot be done. 

                // Basic infix notation operations to perform the calculations. 
                string operation = operatorStack.Pop();          // Pops operator off of stack to be used in switch statement. 
                double first = numberStack.Pop();
                double second = double.Parse(currentNumber.ToString());

                // The switch statement handles all mathmatical operations that may be performed. //
                switch (operation)
                {
                    case "+": currentNumber = (first + second).ToString();
                        numberStack.Push(double.Parse(currentNumber));
                        break;
                    case "-": currentNumber = (first - second).ToString();
                        numberStack.Push(double.Parse(currentNumber));
                        break;
                    case "*": currentNumber = (first * second).ToString();
                        numberStack.Push(double.Parse(currentNumber));
                        break;
                    case "/": if (second == 0)
                              { // Check for division by zero.
                                CalculatorScreen.Clear();
                                CalculatorScreen.Paste("Cannot divide by zero");
                                currentNumber = null;
                                focusOnCalculatorScreen();
                                return;
                              }
                        currentNumber = (first / second).ToString();
                        numberStack.Push(double.Parse(currentNumber));
                        break;
                }
                CalculatorScreen.Clear();
                CalculatorScreen.Paste(currentNumber);
                currentNumber = null;
                focusOnCalculatorScreen();
            }

            catch { focusOnCalculatorScreen(); return; };
        }

        private void correctOperatorStackIf_previousButtonEnteredIsOperator()
        {
            /* previousButtonEnteredIsOperator is used to check if the user enters two operators in a row.
             * If so, the operator that is currently on the operatorStack is popped off, and the new operator takes its place.
             * for example: if the user enters: " 10 + - 5 ", the calculator interprets the first operator as a mistake, so the calculation
             * performed would be 10 - 5 = 5; */
            try
            {   /* If the user would enter an operator followed by a sequence a numbers, used the backspace button to delete all the numbers
                 * on the screen, and then entered another operator, a NullReferenceException would occur here. In the event the exception 
                 * occurs, correctOperatorStackIf_previousButtonEnteredIsOperator() does nothing. 
                 */
                if (previousButtonEnteredIsOperator == true || CalculatorScreen.TextLength == 0)
                {
                    operatorStack.Pop();
                    return;
                }
            }
            catch { return; }
        }


        private void Quit_DropDownMenuItem_Click(object sender, EventArgs e)
        {   // Clicking quit on dropdown menu exits application.
            Application.Exit();
        }

        private void focusOnCalculatorScreen()
        {   /* Forces focus on CalculatorScreen so that if the user's next input is from the keyboard or numberpad,
             * it is registered on the CalculatorScreen. */

            CalculatorScreen.Focus();
            CalculatorScreen.Select();
            CalculatorScreen.SelectionLength = 0;   // Prevents text on CalculatorScreen from being highlighted. For Aethestics only. 
        }



    }
}
