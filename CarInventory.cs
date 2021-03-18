// Name: Devanshi Patel
// Student ID: 100805084
// Date: March 17, 2021
// Description: This application will take car inputs like make, model, year, price and it will ask if it is new or not. Then it will do the 
// validation and display all the information in a listView.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInventory
{
    public partial class FormCarInventory : Form
    {
        private List<CarClass> carList = new List<CarClass>();
        private bool isAutomated = false;
        private int selectedIndex = -1;

        public FormCarInventory()
        {
            InitializeComponent();
        }


        #region "Event Handlers"

        /// <summary>
        /// When the form loads, it will show at the starting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLoad (object sender, EventArgs e)
        {
            CarClass devanshi = new CarClass("Hyundai", "Accent", 2009, 8000, true);
            CarClass car1 = new CarClass("Honda", "Accord", 2017, 5000, false);
            CarClass car2 = new CarClass("Volkswagon", "Beatle", 2000, 9000, true);

            // It will add all the object to the list
            carList.Add(devanshi);
            carList.Add(car1);
            carList.Add(car2);

            PopulateListView(carList);

        }


        /// <summary>
        /// It will execute when enter button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickEnterButton(object sender, EventArgs e)
        {
           
            labelResult.Text = String.Empty;

            if (IsCarValid(comboBoxMakeInput.Text, textBoxModelInput.Text, Convert.ToInt32(comboBoxYearInput.Text), textBoxPriceInput.SelectionLength))
            {

                CarClass newCarToAdd = new CarClass(comboBoxMakeInput.Text, textBoxModelInput.Text, Convert.ToInt32(comboBoxYearInput.Text), Convert.ToDecimal(textBoxPriceInput.Text), checkBoxNew.Checked);

                if (selectedIndex >= 0)
                {
                    carList[selectedIndex] = newCarToAdd;
                }

                else
                {
                    carList.Add(newCarToAdd);
                    labelResult.Text += "It worked!";
                }

                PopulateListView(carList);
                

                SetDefaults();
            }
        }


        /// <summary>
        /// It will set form to the default 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickResetButton(object sender, EventArgs e)
        {
            SetDefaults();
        }


        /// <summary>
        /// It closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickExitButton(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// It will write the car's properties in input controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarSelected (object sender, EventArgs e)
        {
            if (listViewCarInputs.Items.Count > 0 && listViewCarInputs.FocusedItem != null)
            {

                comboBoxMakeInput.Text = listViewCarInputs.FocusedItem.SubItems[1].Text;
                textBoxModelInput.Text = listViewCarInputs.FocusedItem.SubItems[2].Text;
                comboBoxYearInput.Text = listViewCarInputs.FocusedItem.SubItems[3].Text;
                textBoxPriceInput.Text = listViewCarInputs.FocusedItem.SubItems[4].Text;
                checkBoxNew.Checked = listViewCarInputs.FocusedItem.Checked;

                selectedIndex = listViewCarInputs.FocusedItem.Index;

            }

            else
            {
                selectedIndex = -1;
            }
        }


        /// <summary>
        /// It will not let the user change the checkBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreventCheck (object sender, ItemCheckEventArgs e)
        {
            if (!isAutomated)
            {
                e.NewValue = e.CurrentValue;
            }
        }
        #endregion


        #region "Functions"


        /// <summary>
        /// It will populate the data in the listView
        /// </summary>
        /// <param name="carList"></param>
        private void PopulateListView (List<CarClass> carList)
        {
            listViewCarInputs.Items.Clear();

            foreach (CarClass newCar in carList)
            {
                ListViewItem carItem = new ListViewItem();

                isAutomated = true;
               
                carItem.Checked = newCar.NewStatus;
                carItem.SubItems.Add(Convert.ToString(newCar.Id));
                carItem.SubItems.Add(newCar.Make);
                carItem.SubItems.Add(newCar.Model);
                carItem.SubItems.Add(Convert.ToString(newCar.Year));
                carItem.SubItems.Add(Convert.ToString(newCar.Price.ToString("$,#,0.00")));

                

                listViewCarInputs.Items.Add(carItem);

                isAutomated = false;

            }
        }


        /// <summary>
        /// Sets all the inputs or labels to its default
        /// </summary>
        private void SetDefaults()
        {
            comboBoxMakeInput.SelectedIndex = -1;
            textBoxModelInput.Clear();
            comboBoxYearInput.SelectedIndex = -1;
            textBoxPriceInput.Clear();
            checkBoxNew.Checked = false;
            listViewCarInputs.SelectedItems.Clear();
            labelResult.Text = String.Empty;
            selectedIndex = -1;

            comboBoxMakeInput.Focus();
        }


        /// <summary>
        /// Validates the input
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        private bool IsCarValid(string make, string model, int year, decimal price)
        {
            bool isValid = true;

            if (make == String.Empty)
            {
                isValid &= false;
                labelResult.Text += "You must select the car manufacturer.";
            }

            if (model == String.Empty)
            {
                isValid &= false;
                labelResult.Text += "You must enter the car model.";
            }

            
            if (decimal.TryParse(textBoxPriceInput.Text, out price))
            {
                if (price <= 0)
                {
                    isValid &= false;
                    labelResult.Text += "You must enter positive price.";
                }
            }

            else
            {
                isValid &= false;
                labelResult.Text += "You must enter the car's price.";
            }

            return isValid;
        }
        #endregion
    }
}
