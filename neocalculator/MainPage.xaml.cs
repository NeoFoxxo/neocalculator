using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace neocalculator;

public partial class MainPage : ContentPage
{
    string first = "";
    string second = "";
    char function;
    double result = 0.0;
    string userInput = "";


 

    public MainPage()
	{
		InitializeComponent();

    }

    private void Backspace_Clicked(object sender, EventArgs e)
    {

        //if number is 0 do nothing
        if (CalculatorDisplay.Text == "0")
        {
            CalculatorDisplay.Text = "0";
            CalculatorDisplay.FontSize = 100;
        }
        //if they divide by zero when backspacing set it to 0
        else if (CalculatorDisplay.Text == "is it 5?")
        {
            CalculatorDisplay.Text = "0";
            CalculatorDisplay.FontSize = 100;
        }
        //remove one character from the display string with backspace
        else
        {
            CalculatorDisplay.Text = CalculatorDisplay.Text.Remove(CalculatorDisplay.Text.Length - 1, 1);

            //if user backspaces to nothing set the display to 0
            if (CalculatorDisplay.Text == "")
            {
                CalculatorDisplay.Text = "0";
                CalculatorDisplay.FontSize = 100;
            }

            userInput = CalculatorDisplay.Text;

        }

    }
    private void Digit0_Clicked(object sender, EventArgs e)
    {
        CalculatorDisplay.Text = "";
        userInput += 0;
        CalculatorDisplay.Text += userInput;

        //make text smaller to fit numbers on screen
        if (CalculatorDisplay.Text.Length == 1)
        {
            CalculatorDisplay.FontSize = 100;
        }
        else if (CalculatorDisplay.Text.Length == 6)
        {
            CalculatorDisplay.FontSize = 80;
        }
        else if (CalculatorDisplay.Text.Length == 8)
        {
            CalculatorDisplay.FontSize = 60;
        }
        else if (CalculatorDisplay.Text.Length == 19)
        {
            CalculatorDisplay.FontSize = 40;
        }
    }
    private void Digit1_Clicked(object sender, EventArgs e)
    {
        CalculatorDisplay.Text = "";
        userInput += 1;
        CalculatorDisplay.Text += userInput;
        //make text smaller to fit numbers on screen
        if (CalculatorDisplay.Text.Length == 1)
        {
            CalculatorDisplay.FontSize = 100;
        }
        else if (CalculatorDisplay.Text.Length == 6)
        {
            CalculatorDisplay.FontSize = 80;
        }
        else if (CalculatorDisplay.Text.Length == 8)
        {
            CalculatorDisplay.FontSize = 60;
        }
        else if (CalculatorDisplay.Text.Length == 19)
        {
            CalculatorDisplay.FontSize = 40;
        }
    }
 
    private void Digit2_Clicked(object sender, EventArgs e)
    {
        CalculatorDisplay.Text = "";
        userInput += 2;
        CalculatorDisplay.Text += userInput;
        //make text smaller to fit numbers on screen
        if (CalculatorDisplay.Text.Length == 1)
        {
            CalculatorDisplay.FontSize = 100;
        }
        else if (CalculatorDisplay.Text.Length == 6)
        {
            CalculatorDisplay.FontSize = 80;
        }
        else if (CalculatorDisplay.Text.Length == 8)
        {
            CalculatorDisplay.FontSize = 60;
        }
        else if (CalculatorDisplay.Text.Length == 19)
        {
            CalculatorDisplay.FontSize = 40;
        }
    }
    private void Digit3_Clicked(object sender, EventArgs e)
    {
        CalculatorDisplay.Text = "";
        userInput += 3;
        CalculatorDisplay.Text += userInput;
        //make text smaller to fit numbers on screen
        if (CalculatorDisplay.Text.Length == 1)
        {
            CalculatorDisplay.FontSize = 100;
        }
        else if (CalculatorDisplay.Text.Length == 6)
        {
            CalculatorDisplay.FontSize = 80;
        }
        else if (CalculatorDisplay.Text.Length == 8)
        {
            CalculatorDisplay.FontSize = 60;
        }
        else if (CalculatorDisplay.Text.Length == 19)
        {
            CalculatorDisplay.FontSize = 40;
        }
    }
    private void Digit4_Clicked(object sender, EventArgs e)
    {
        CalculatorDisplay.Text = "";
        userInput += 4;
        CalculatorDisplay.Text += userInput;
        //make text smaller to fit numbers on screen
        if (CalculatorDisplay.Text.Length == 1)
        {
            CalculatorDisplay.FontSize = 100;
        }
        else if (CalculatorDisplay.Text.Length == 6)
        {
            CalculatorDisplay.FontSize = 80;
        }
        else if (CalculatorDisplay.Text.Length == 8)
        {
            CalculatorDisplay.FontSize = 60;
        }
        else if (CalculatorDisplay.Text.Length == 19)
        {
            CalculatorDisplay.FontSize = 40;
        }
    }
    private void Digit5_Clicked(object sender, EventArgs e)
    {
        CalculatorDisplay.Text = "";
        userInput += 5;
        CalculatorDisplay.Text += userInput;
        //make text smaller to fit numbers on screen
        if (CalculatorDisplay.Text.Length == 1)
        {
            CalculatorDisplay.FontSize = 100;
        }
        else if (CalculatorDisplay.Text.Length == 6)
        {
            CalculatorDisplay.FontSize = 80;
        }
        else if (CalculatorDisplay.Text.Length == 8)
        {
            CalculatorDisplay.FontSize = 60;
        }
        else if (CalculatorDisplay.Text.Length == 19)
        {
            CalculatorDisplay.FontSize = 40;
        }
    }
    private void Digit6_Clicked(object sender, EventArgs e)
    {
        CalculatorDisplay.Text = "";
        userInput += 6;
        CalculatorDisplay.Text += userInput;
        //make text smaller to fit numbers on screen
        if (CalculatorDisplay.Text.Length == 1)
        {
            CalculatorDisplay.FontSize = 100;
        }
        else if (CalculatorDisplay.Text.Length == 6)
        {
            CalculatorDisplay.FontSize = 80;
        }
        else if (CalculatorDisplay.Text.Length == 8)
        {
            CalculatorDisplay.FontSize = 60;
        }
        else if (CalculatorDisplay.Text.Length == 19)
        {
            CalculatorDisplay.FontSize = 40;
        }
    }
    private void Digit7_Clicked(object sender, EventArgs e)
    {
        CalculatorDisplay.Text = "";
        userInput += 7;
        CalculatorDisplay.Text += userInput;
        //make text smaller to fit numbers on screen
        if (CalculatorDisplay.Text.Length == 1)
        {
            CalculatorDisplay.FontSize = 100;
        }
        else if (CalculatorDisplay.Text.Length == 6)
        {
            CalculatorDisplay.FontSize = 80;
        }
        else if (CalculatorDisplay.Text.Length == 8)
        {
            CalculatorDisplay.FontSize = 60;
        }
        else if (CalculatorDisplay.Text.Length == 19)
        {
            CalculatorDisplay.FontSize = 40;
        }
    }
    private void Digit8_Clicked(object sender, EventArgs e)
    {
        CalculatorDisplay.Text = "";
        userInput += 8;
        CalculatorDisplay.Text += userInput;
        //make text smaller to fit numbers on screen
        if (CalculatorDisplay.Text.Length == 1)
        {
            CalculatorDisplay.FontSize = 100;
        }
        else if (CalculatorDisplay.Text.Length == 6)
        {
            CalculatorDisplay.FontSize = 80;
        }
        else if (CalculatorDisplay.Text.Length == 8)
        {
            CalculatorDisplay.FontSize = 60;
        }
        else if (CalculatorDisplay.Text.Length == 19)
        {
            CalculatorDisplay.FontSize = 40;
        }
    }
    private void Digit9_Clicked(object sender, EventArgs e)
    {
        CalculatorDisplay.Text = "";
        userInput += 9;
        CalculatorDisplay.Text += userInput;
        //make text smaller to fit numbers on screen
        if (CalculatorDisplay.Text.Length == 1)
        {
            CalculatorDisplay.FontSize = 100;
        }
        else if (CalculatorDisplay.Text.Length == 6)
        {
            CalculatorDisplay.FontSize = 80;
        }
        else if (CalculatorDisplay.Text.Length == 8)
        {
            CalculatorDisplay.FontSize = 60;
        }
        else if (CalculatorDisplay.Text.Length == 19)
        {
            CalculatorDisplay.FontSize = 40;
        }
    }
    private void Multiply_Clicked(object sender, EventArgs e)
    {
        CalculatorDisplay.Text = "0";
        function = '*';
        first = userInput;
        userInput = "";
    }
    private void Minus_Clicked(object sender, EventArgs e)
    {
        CalculatorDisplay.Text = "0";
        function = '-';
        first = userInput;
        userInput = "";
    }
    private void Divide_Clicked(object sender, EventArgs e)
    {
        CalculatorDisplay.Text = "0";
        function = '/';
        first = userInput;
        userInput = "";
    }
    private void Add_Clicked(object sender, EventArgs e)
    {
        CalculatorDisplay.Text = "0";
        function = '+';
        first = userInput;
        userInput = "";
    }
    private void Equals_Clicked(object sender, EventArgs e)
    {
        second = userInput;

        double firstNum, secondNum;

        //if first number is empty make it 0
        if (first == "")
        {
            first = "0";
        }

        //if second number is empty make it 0
        if (second == "")
        {
            second = "0";
        }

        firstNum = Convert.ToDouble(first);
        secondNum = Convert.ToDouble(second);
        //plus
        if (function == '+')
        {
            result = firstNum + secondNum;

            string joe = result.ToString();

            //make text smaller to fit numbers on screen
            if (joe.Length <= 1)
            {
                CalculatorDisplay.FontSize = 100;
                CalculatorDisplay.Text = result.ToString();

            }
            else if (joe.Length <= 6)
            {
                CalculatorDisplay.FontSize = 80;
                CalculatorDisplay.Text = result.ToString();
            }
            else if (joe.Length <= 8)
            {
                CalculatorDisplay.FontSize = 60;
                CalculatorDisplay.Text = result.ToString();
            }
            else if (joe.Length <= 19)
            {
                CalculatorDisplay.FontSize = 40;
                CalculatorDisplay.Text = result.ToString();
            }
        }
        //minus
        else if (function == '-')
        {
            result = firstNum - secondNum;

            string joe = result.ToString();

            //make text smaller to fit numbers on screen
            if (joe.Length <= 1)
            {
                CalculatorDisplay.FontSize = 100;
                CalculatorDisplay.Text = result.ToString();

            }
            else if (joe.Length <= 6)
            {
                CalculatorDisplay.FontSize = 80;
                CalculatorDisplay.Text = result.ToString();
            }
            else if (joe.Length <= 8)
            {
                CalculatorDisplay.FontSize = 60;
                CalculatorDisplay.Text = result.ToString();
            }
            else if (joe.Length <= 19)
            {
                CalculatorDisplay.FontSize = 40;
                CalculatorDisplay.Text = result.ToString();
            }
        }
        //divide
        else if (function == '/')
        {
            if (secondNum == 0)
            {
                CalculatorDisplay.Text = "is it 5?";
            }
            else
            {
                result = firstNum / secondNum;
                string joe = result.ToString();

                //make text smaller to fit numbers on screen
                if (joe.Length <= 1)
                {
                    CalculatorDisplay.FontSize = 100;
                    CalculatorDisplay.Text = result.ToString();

                }
                else if (joe.Length <= 6)
                {
                    CalculatorDisplay.FontSize = 80;
                    CalculatorDisplay.Text = result.ToString();
                }
                else if (joe.Length <= 8)
                {
                    CalculatorDisplay.FontSize = 60;
                    CalculatorDisplay.Text = result.ToString();
                }
                else if (joe.Length <= 19)
                {
                    CalculatorDisplay.FontSize = 40;
                    CalculatorDisplay.Text = result.ToString();
                }
            }
        }
        //multiply
        else if (function == '*')
        {
            result = firstNum * secondNum;
            string joe = result.ToString();

            //make text smaller to fit numbers on screen
            if (joe.Length <= 1)
            {
                CalculatorDisplay.FontSize = 100;
                CalculatorDisplay.Text = result.ToString();

            }
            else if (joe.Length <= 6)
            {
                CalculatorDisplay.FontSize = 80;
                CalculatorDisplay.Text = result.ToString();
            }
            else if (joe.Length <= 8)
            {
                CalculatorDisplay.FontSize = 60;
                CalculatorDisplay.Text = result.ToString();
            }
            else if (joe.Length <= 19)
            {
                CalculatorDisplay.FontSize = 40;
                CalculatorDisplay.Text = result.ToString();
            }
        }
    }
    private void Clear_Clicked(object sender, EventArgs e)
    {
        first = "";
        second = "";
        userInput = "";
        result = 0.0;
        CalculatorDisplay.Text = "0";
        CalculatorDisplay.FontSize = 100;
    }

}