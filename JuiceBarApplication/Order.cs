/* Written by Amber Rivera
 * C# Lab 3
 * Juice Bar Application
 * 
 * This class is used to calculate the price of a drink, keep track of the total cost
 * of the order, the number of drinks for the order, as well as the total cost of 
 * all orders created and the total number of drinks ordered. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuiceBarApplication
{
    public class Order
    {
        // Constants for prices.
        public const double TWELVEPRICE = 3.00, SIXTEENPRICE = 3.50, TWENTYPRICE = 4.00, ADDPRICE = 2.50;

        // orderPrice = price of current order.
        public double orderPrice = 0;
        // totalOrdersPrice = cost of all orders placed.
        public static double totalOrdersPrice = 0;

        // numDrinks = number of drinks in the current order.
        public int numDrinks = 0; 
        // totalNumDrinks = total number of drinks ordered.
        public static int totalNumDrinks, numOrders;


        JuiceBarMain juicebar;

        public Order(JuiceBarMain juicebar)
        {
            this.juicebar = juicebar;
        }

        // This method adds the price of the currently selected drink to the price of the order.
        public void addToOrder(int quantity)
        {
            int size = getSize();
            orderPrice += getCostAdditives();

            switch(size)
            {
                case 0:
                    MessageBox.Show("Please choose a size for your drink.");
                    break;
                case 12:
                    orderPrice += TWELVEPRICE * quantity;
                    break;

                case 16:
                    orderPrice += SIXTEENPRICE * quantity;
                    break;

                case 20:
                    orderPrice += TWENTYPRICE * quantity;
                    break;
            }

        }


        //Returns the size of the drink ordered as an int.
        public int getSize()
        {
            int size = 0;
            
            if(juicebar.RadioButtonTwelve)
            {
                size = 12;
            }

            else if(juicebar.RadioButtonSixteen)
            {
                size = 16;
            }

            else if(juicebar.RadioButtonTwenty)
            {
                size = 20;
            }

            return size;
        }

        // Returns the cost of any selected additives as a double.
        public double getCostAdditives()
        {
            int num = 0;
            double cost = 0;

            if(juicebar.CheckBoxVitaPack)
            {
                num++;
            }

            if(juicebar.CheckBoxEngBoost)
            {
                num++;
            }

            if(juicebar.CheckBoxCDRem)
            {
                num++;
            }

            cost = num * ADDPRICE;

            return cost;
        }

        // This method add this order's price and drinks to total and reset price and drinks.
        public void checkout()
        {
            totalOrdersPrice += orderPrice;
            totalNumDrinks += numDrinks;

            numDrinks = 0;
            orderPrice = 0;
            numOrders++;
        }

        // Override ToString() to display number of drinks and total order cost.
        public override String ToString()
        {
            String output = "";

            output += numDrinks + " drinks ordered.\n";
            output += "Total: " + orderPrice.ToString("C");

            return output;
        }


    }
}
