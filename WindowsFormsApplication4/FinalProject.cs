using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class frmFinalProject : Form
    {
        public frmFinalProject()
        {
            InitializeComponent();
        }

        private void lblInputandOutput_Click(object sender, EventArgs e)
        {
            /*Dealing with variables
             * 
             */

            lblResult.display = ("yay you clicked on the button");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            /*Dealing with string.format
          * 
          */

            const double PST_RATE = 0.08;
            const double GST_RATE = 0.05;

            double coffeePrice = 1.80;
            int numCoffees;
            double subTotal;
            double taxes;
            double finalTotal;

            numCoffees = Convert.ToInt32(txtCoffeeImput.Text);
            subTotal = numCoffees * coffeePrice;
            taxes = subTotal = (PST_RATE + GST_RATE);
            finalTotal = subTotal + taxes;

            string mystring = "zeppelin";

            lblDisplay.Text = (mystring.Length).ToString();
            lblDisplay.Text += "\n" + mystring.Substring(4);
            lblDisplay.Text += "\n" + mystring.Substring(3, 1);
            lblDisplay.Text += "\n" + mystring.IndexOf('1');
            lblDisplay.Text += "\n\n PST is" + PST_RATE;
            lblDisplay.Text += "\n" + "GST is" + GST_RATE;
            lblDisplay.Text += "\n" + "coffee costs $" + coffeePrice;
            lblDisplay.Text += "\n" + "your total is $" + finalTotal;
        }

        private void btnSecondButton_Click(object sender, EventArgs e)
        {
            /*
             * In this section we are dealing with methods
             */

            displayName();

            displayBirthday();

            displayFact();

        }

        public static void displayName()
        {

            System.out.println("my name is abbey");

        }

        public static void displayBirthday()
        {

            System.out.println("09/08/1999");
        }

        public static void displayFact()
        {

            System.out.println("i like writing books");
        }

        private void btnButton1_Click(object sender, EventArgs e)
        {
            /**
             * In this section we are dealing with arrays
             */

            int[] Myarray = { 13, 17, 20, 2, 6, 8, -3, 10 };
            int index = -1;
            int minimum;
            int userValue;

            //to iterate through an array, we use a for loop!
            // i is the current index we are looking at in the array
            // i will continue until it is as large as the length 
            // of the array 
            for (int i = 0; i < Myarray.length; i++)
            {

                //this will display all values 
                System.out.println(Myarray[i] + "   ");
            }
            //this code gets the value you want to search from the user
            System.out.println();
            System.out.println("what vlaue do you want the index of?");
            userValue = userInput.nextInt();

            //to search for something you have to look at every element 
            //of the array. this is accomplished by looping through
            //all elements
            for (int i = 0; i < Myarray.length; i++)
            {
                if (Myarray[i] == userValue)
                {
                    index = i;
                }
            }

            if (index == -1)
            {
                System.out.println("this is not in the array!");
            }
            else
            {
                System.out.println(userValue + " is at index " + index);
            }

        }   /**
		* Finding the minimum value of the array
		*/

        minimum = Myarray[0];
	
	//to find the minimum value of the array, we have to
	//search through every element of the array and see if
	//the current value is smaller than the previous value
	
	for(int i = 0; i<Myarray.length; i++){
		
		//checks whether the current element is less then minimum
		if(Myarray[i] < minimum){
			
			//if yes, change minimum to the current element
			minimum = Myarray[i];
				
		}

}
system.out.println("the minimum value is: " + minimum);
        }

        private void btnButton3_Click(object sender, EventArgs e)
        {

        }

        private void lblStringFormat_Click(object sender, EventArgs e)
        {

        }

        private void lblCommenting_Click(object sender, EventArgs e)
        {

        }
    }
}
