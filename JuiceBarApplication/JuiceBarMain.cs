/* Written by Amber Rivera
 * C# Lab 3
 * Juice Bar Application
 * 
 * This application allows a user to order different drinks. Allows for multiple orders. 
 * Utilizes font, color, and about dialogs.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuiceBarApplication
{
    public partial class JuiceBarMain : Form
    {
        public Order order;

        public JuiceBarMain()
        {
            InitializeComponent();
            setDefaults();
            order = new Order(this);
        }

        // Close application.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Close application.
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Show about dialog box.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JuiceBarAboutBox about = new JuiceBarAboutBox();
            about.Show();
        }

        // Clear Form.
        private void btClear_Click(object sender, EventArgs e)
        {
            clear();   
        }

        // Set default Checked status.
        private void setDefaults()
        {
            rbJuice.Checked = true;
            rbFruit.Checked = true;
            rbTwelveOunce.Checked = false;
            rbSixteenOunce.Checked = false;
            rbTwentyOunce.Checked = false;
            tbQuantity.Text = "";
            

        }

        // Unchecks radio buttons passed in.
        private void unCheckRadioButtons(params RadioButton[] information)
        {
            foreach (RadioButton radioButton in information)
            {
                radioButton.Checked = false;
            }
        }

        // Unchecks check boxes passed in.
        private void clearAllCheckBoxes(params CheckBox[] checkBoxes)
        {
            foreach(CheckBox check in checkBoxes)
            {
                check.Checked = false;
            }
        }

        // Shows group boxes based on which main radio button is checked.
        private void rbJuice_CheckedChanged(object sender, EventArgs e)
        {

            if(rbJuice.Checked)
            {
                gbJuice.Visible = true;
                gbSmoothies.Visible = false;
                unCheckRadioButtons(rbPom, rbStrawBanana, rbWheatBerry);
            }

            else
            {
                gbSmoothies.Visible = true;
                gbJuice.Visible = false;
                unCheckRadioButtons(rbFruit, rbVeggie);
            }

        }

        // Calls add to order method.
        private void btAdd_Click(object sender, EventArgs e)
        {
            addToOrder();
        }

        // Calls add to order method.
        private void addToOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addToOrder();
        }

        // Calls checkout method.
        private void btCheckout_Click(object sender, EventArgs e)
        {
            checkout();
        }

        // Calls checkout method.
        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkout();
        }

        // Calls order summary method.
        private void btViewOrderSum_Click(object sender, EventArgs e)
        {
            orderSummary();
        }

        // Calls order summary method.
        private void orderSumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderSummary();
        }

        // Clears form.
        private void clear()
        {
            setDefaults();

            clearAllCheckBoxes(cbCDRem, cbEngBoost, cbVitaPack);

            tbQuantity.Text = "";
        }

        // Adds current drink(s) to order. Uses order class.
        private void addToOrder()
        {
            int quantity;

            if (int.TryParse(Quantity, out quantity))
            {
                if (order.getSize() != 0)
                {
                    order.addToOrder(quantity);
                    order.numDrinks += quantity;
                    Order.totalNumDrinks += quantity;
                    MessageBox.Show(quantity.ToString() + " drinks added to your order.");
                    setDefaults();
                }

                else
                {
                    order.addToOrder(quantity);
                }
            }

            else
            {
                MessageBox.Show("Please enter a quantity.");
                tbQuantity.Focus();
            }
        }

        // Displays order total and number of drinks and reset those values using the Order class.
        private void checkout()
        {
            if (order.getSize() != 0)
            {
                int quantity;

                if (int.TryParse(Quantity, out quantity))
                {
                    order.addToOrder(quantity);
                    order.numDrinks += quantity;
                }
            }
            MessageBox.Show("Thank you for your order!\n\n" + order.ToString());

            order.checkout();
            setDefaults();
        }

        // Displays the number of orders, drinks, and total cost.
        private void orderSummary()
        {

            MessageBox.Show("Number of Orders: " + Order.numOrders.ToString() + "\n" +
                           "Number of Drinks Ordered: " + Order.totalNumDrinks.ToString() + "\n" +
                           "Total Cost: " + Order.totalOrdersPrice.ToString("C"));
        }

        // Allows user to change forecolor.
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialogMain.Color = this.ForeColor; 
            colorDialogMain.ShowDialog();
            this.ForeColor = colorDialogMain.Color;
        }

        // Allows user to change title font.
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialogMain.Font = lblJuiceBarMenu.Font;  
            fontDialogMain.ShowDialog();
            lblJuiceBarMenu.Font = fontDialogMain.Font;	
        }


        // Series of getters and setters for form controls to be used in the Order class.
        public bool RadioButtonJuice
        {
            get { return rbJuice.Checked; }
            set { rbJuice.Checked = value; }
        }

        public bool RadioButtonFruit
        {
            get { return rbFruit.Checked; }
            set { rbFruit.Checked = value; }
        }

        public bool RadioButtonVeggie
        {
            get { return rbVeggie.Checked; }
            set { rbVeggie.Checked = value; }
        }


        public bool RadioButtonSmoothie
        {
            get { return rbSmoothie.Checked; }
            set { rbSmoothie.Checked = value; }
        }


        public bool RadioButtonPom
        {
            get { return rbPom.Checked; }
            set { rbPom.Checked = value; }
        }
        

        public bool RadioButtonStrawBanana
        {
            get { return rbStrawBanana.Checked; }
            set { rbStrawBanana.Checked = value; }
        }


        public bool RadioButtonWheatBerry
        {
            get { return rbWheatBerry.Checked; }
            set { rbWheatBerry.Checked = value; }
        }


        public bool RadioButtonTwelve
        {
            get { return rbTwelveOunce.Checked; }
            set { rbTwelveOunce.Checked = value; }
        }


        public bool RadioButtonSixteen
        {
            get { return rbSixteenOunce.Checked; }
            set { rbSixteenOunce.Checked = value; }
        }


        public bool RadioButtonTwenty
        {
            get { return rbTwentyOunce.Checked; }
            set { rbTwentyOunce.Checked = value; }
        }

        public bool CheckBoxVitaPack
        {
            get { return cbVitaPack.Checked; }
            set { cbVitaPack.Checked = value; }
        }

        public bool CheckBoxEngBoost
        {
            get { return cbEngBoost.Checked; }
            set { cbEngBoost.Checked = value; }
        }

        public bool CheckBoxCDRem
        {
            get { return cbCDRem.Checked; }
            set { cbCDRem.Checked = value; }
        }

        public string Quantity
        {
            get { return tbQuantity.Text; }
            set { tbQuantity.Text = value; }
        }

    }
}
