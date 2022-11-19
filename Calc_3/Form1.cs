namespace Calc_3
{
    public partial class Form1 : Form

    {
        Double resultValue = 0;
        String operation = "";
        bool isOperationPerformed = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if( (textBox1.Text == "0") || (isOperationPerformed ))
                textBox1.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
             if(!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;

            }
            else
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
        }

        private void operator_button(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                buttonEqual.PerformClick();
                operation = button.Text;
                label1.Text = resultValue + " " + operation;
                isOperationPerformed = true;

            }
            else
            {
                operation = button.Text;
                resultValue = Double.Parse(textBox1.Text);
                label1.Text = resultValue + " " + operation;
                isOperationPerformed = true;
            }
        }

        private void End_button(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+" :
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                 
                        textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    
                    break;

                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox1.Text);
            
            label1.Text = " ";
        }
    }
}