namespace Calculator__Assignment_
{
    public partial class Form1 : Form
    {
        //creates all the varibles needed for stroing data within the calculator
        public string num1;
        public string num2;
        public int whichNum = 1;
        public string num;
        public string operation;
        public int tempresult;
        public string result;
        public int X;
        public int Y;
        public bool multiCalc = true;

        //function for placing the numbers pressed into a varible for later calculations
        public void input()
        {
            if (multiCalc == true)
            {
                if (whichNum == 1)
                {
                    num1 = num1 + num;
                }
                else if (whichNum == 2)
                {
                    num2 = num2 + num;
                }
            }

        }

        //function to output the users button presses onto the text box
        public void output()
        {
            if (multiCalc == true)
            {
                textBox1.Text = textBox1.Text + num;
            }

        }

        //function for clearing the calculator and restarting it
        public void clearCalc()
        {
            num1 = null;
            num2 = null;
            whichNum = 1;
            num = null;
            operation = null;
            result = null;
            textBox1.Clear();
            multiCalc = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = "1";
            input();
            output();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num = "2";
            input();
            output();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num = "3";
            input();
            output();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num = "4";
            input();
            output();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num = "5";
            input();
            output();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num = "6";
            input();
            output();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num = "7";
            input();
            output();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num = "8";
            input();
            output();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num = "9";
            input();
            output();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            num = "0";
            input();
            output();
        }

        private void addition_Click(object sender, EventArgs e)
        {
            if (operation == null)
            {
                operation = "+";
                textBox1.Text = textBox1.Text + operation;
                whichNum = 2;
                multiCalc = true;
            }
            else
            { }
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            if (operation == null)
            {
                operation = "-";
                textBox1.Text = textBox1.Text + operation;
                whichNum = 2;
                multiCalc = true;
            }
            else
            { }
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            if (operation == null)
            {
                operation = "*";
                textBox1.Text = textBox1.Text + operation;
                whichNum = 2;
                multiCalc = true;
            }
            else
            { }
        }

        private void devision_Click(object sender, EventArgs e)
        {
            if (operation == null)
            {
                operation = "/";
                textBox1.Text = textBox1.Text + operation;
                whichNum = 2;
                multiCalc = true;
            }
            else
            { }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            // converts the numbers that were inputted into ints for calculation
            int X = Int32.Parse(num1);
            int Y = Int32.Parse(num2);

            //chooses which operation to do based on the operation they selected
            switch (operation)
            {
                case "+":
                    tempresult = (X + Y);
                    break;
                case "-":
                    tempresult = (X - Y);
                    break;
                case "*":
                    tempresult = (X * Y);
                    break;
                case "/":
                    tempresult = (X / Y);
                    break;
            }
            //outputs the result of the calculation to the text box as well as clearing the previous text
            result = tempresult.ToString();
            textBox1.Text = result;
            //changes varible data to allow for more numbers to be added to the result of there last equation
            whichNum = 2;
            num1 = result;
            num2 = null;
            operation = null;
            //makes the user click a new operation before they start to press more numbers
            multiCalc = false;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            clearCalc();
        }
    }
}