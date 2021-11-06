using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirplaneReservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        // this ArrayList stores the Seat objects 
        ArrayList SeatList = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
            // set current date on the form  
            labelDate.Text = DateTime.Now.ToString("dd MMMM yyyy");

            String classType;
            String position;

            // initialise the Seat objects in First class
            for (int row = 0; row < 5; row++)
            {
                classType = "First";
                char label = 'A';
                for (int seat = 0; seat < 4; seat++)
                {
                    if (label == 'A' || label == 'D')
                        position = "Window";
                    else position = "Aisle";

                    SeatList.Add(new Seat("" + (row+1) + label, classType, position));
                    label++;
                }               
            }
            // initialise the Seat Objects in Economy class 
            for (int row = 5; row < 35; row++)
            {
                classType = "Economy";
                char label = 'A';
                for (int seat = 0; seat < 6; seat++)
                {
                    if (label == 'A' || label == 'F')
                        position = "Window";
                    else if (label == 'B' || label == 'E')
                        position = "Middle";
                    else position = "Aisle";

                    SeatList.Add(new Seat("" + (row+1) + label, classType, position));
                    label++;
                }
            }
            
            // bind the datagrid to seatArray array
            dataGridView1.DataSource = SeatList;
        }
        
        // on selecting checkBoxFirst
        // comboBoxPosition displays 2 values - window and aisle
        // numericUpDown displays 2 values - 1 or 2 persons
        private void checkBoxFirst_CheckedChanged(object sender, EventArgs e)
        {
            // deselect checkBoxEconomy
            checkBoxEconomy.Checked = false;

            // create the datasource for comboBoxPosition and add values to it 
            Dictionary<String, String> comboSource = new Dictionary<String, String>();
            comboSource.Add("Window", "Window");
            comboSource.Add("Aisle", "Aisle");           
            comboBoxPosition.DataSource = new BindingSource(comboSource, null);
            comboBoxPosition.DisplayMember = "Value";
            comboBoxPosition.ValueMember = "Key";

            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 2;
            numericUpDown1.Increment = 1;
        }

        // on selecting checkBoxEconomy
        // comboBoxPosition displays 3 values - window, middle and aisle
        // numericUpDown displays 3 values - 1, 2 or 3 persons
        private void checkBoxEconomy_CheckedChanged(object sender, EventArgs e)
        {
            // deselect checkBoxFirst 
            checkBoxFirst.Checked = false;

            Dictionary<String, String> comboSource = new Dictionary<String, String>();
            comboSource.Add("Window", "Window");
            comboSource.Add("Middle", "Middle");
            comboSource.Add("Aisle", "Aisle");
            comboBoxPosition.DataSource = new BindingSource(comboSource, null);
            comboBoxPosition.DisplayMember = "Value";
            comboBoxPosition.ValueMember = "Key";

            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 3;
            numericUpDown1.Increment = 1;
        }

        /* on clicking Find a Match and Reserve, the system tries and matches free seats with passenger's selections
         * if free seats are found, '?' appears on the passenger's name cell 
         * for the passenger to manually add their names and the reservation status cell changes to RESERVED 
         * if not free seats are found, a message will be displayed 
         */ 
        private void buttonReservation_Click(object sender, EventArgs e)
        {
            string selectedClass = "";
            if (this.checkBoxFirst.Checked == true)
                selectedClass = "First";
            if (this.checkBoxEconomy.Checked == true)
                selectedClass = "Economy";

            string selectedPositionType = this.comboBoxPosition.SelectedValue.ToString();

            int numberOfPasseneger = Convert.ToInt32(this.numericUpDown1.Value);

            if(selectedClass == "First")
            {
                for (int rowIndex = 0; rowIndex < 20; rowIndex++)
                {
                    string currentPositionType = (String)dataGridView1.Rows[rowIndex].Cells[2].Value;
                    string currentPassengerName = (String)dataGridView1.Rows[rowIndex].Cells[4].Value;

                    // conditions validation: look for 1 free seat at the selected position
                    if (numberOfPasseneger == 1 && currentPositionType == selectedPositionType && currentPassengerName == null)
                    {
                        dataGridView1.Rows[rowIndex].Cells[4].Value = "?";
                        break;
                    }
                    // conditions validation: look for 2 seats free and adjacent
                    if (numberOfPasseneger == 2 && (dataGridView1.Rows[rowIndex].Cells[2].Value != dataGridView1.Rows[rowIndex+1].Cells[2].Value))
                    {
                        if(dataGridView1.Rows[rowIndex].Cells[4].Value == null && dataGridView1.Rows[rowIndex+1].Cells[4].Value == null)
                        {
                            dataGridView1.Rows[rowIndex].Cells[4].Value = "?";
                            dataGridView1.Rows[rowIndex+1].Cells[4].Value = "?";
                            break;
                        }                            
                    }
                    // display message if no free seats found
                    if (rowIndex == 19 && currentPassengerName != null)
                    {
                        string caption = "No seats available";
                        string message = "Sorry no match found. First class is fully booked!";
                        DialogResult result = MessageBox.Show(message, caption); 
                    }
                }
            }

            if (selectedClass == "Economy" && numberOfPasseneger == 1)
            {
                for (int rowIndex = 20; rowIndex < 200; rowIndex++)
                {
                    string currentPositionType = (String)dataGridView1.Rows[rowIndex].Cells[2].Value;
                    string currentPassengerName = (String)dataGridView1.Rows[rowIndex].Cells[4].Value;

                    // conditions validation: look for 1 free seat at the selected position
                    if (currentPositionType == selectedPositionType && currentPassengerName == null)
                    {
                        dataGridView1.Rows[rowIndex].Cells[4].Value = "?";
                        break;
                    }
                    // display message if no free seats found
                    if (rowIndex == 199 && currentPassengerName != null)
                    {
                        string caption = "No seats available";
                        string message = "Sorry no match found. Try change seat position";
                        DialogResult result = MessageBox.Show(message, caption);
                    }
                }
            }

            if (selectedClass == "Economy" && numberOfPasseneger == 2)
            {
                for (int rowIndex = 20; rowIndex < 199; rowIndex++)
                {
                    // conditions validation: look for 2 seats free and adjacent
                    // one of the 2 seats must be Window but not the other
                    if (selectedPositionType == "Window")
                    {
                        if ((dataGridView1.Rows[rowIndex].Cells[2].Value != dataGridView1.Rows[rowIndex + 1].Cells[2].Value) &&
                            ((string)dataGridView1.Rows[rowIndex].Cells[2].Value == "Window" || (string)dataGridView1.Rows[rowIndex + 1].Cells[2].Value == "Window") &&
                            (dataGridView1.Rows[rowIndex].Cells[4].Value == null && dataGridView1.Rows[rowIndex + 1].Cells[4].Value == null))
                        {
                            dataGridView1.Rows[rowIndex].Cells[4].Value = "?";
                            dataGridView1.Rows[rowIndex + 1].Cells[4].Value = "?";
                            break;
                        }
                    }
                    // conditions validation: look for 2 seats free and adjacent
                    // one of the 2 seats must be Middle
                    else if (selectedPositionType == "Middle")
                    {
                        if ((dataGridView1.Rows[rowIndex].Cells[2].Value != dataGridView1.Rows[rowIndex + 1].Cells[2].Value) &&
                            dataGridView1.Rows[rowIndex].Cells[4].Value == null && dataGridView1.Rows[rowIndex + 1].Cells[4].Value == null)
                        {
                            dataGridView1.Rows[rowIndex].Cells[4].Value = "?";
                            dataGridView1.Rows[rowIndex + 1].Cells[4].Value = "?";
                            break;
                        }
                    }
                    // conditions validation: look for 2 seats free and adjacent
                    // one of the 2 seats must be Aisle but not the other
                    else if (selectedPositionType == "Aisle")
                    {
                        if ((dataGridView1.Rows[rowIndex].Cells[2].Value != dataGridView1.Rows[rowIndex + 1].Cells[2].Value) &&
                            ((string)dataGridView1.Rows[rowIndex].Cells[2].Value == "Aisle" || (string)dataGridView1.Rows[rowIndex + 1].Cells[2].Value == "Aisle") &&
                            (dataGridView1.Rows[rowIndex].Cells[4].Value == null && dataGridView1.Rows[rowIndex + 1].Cells[4].Value == null))
                        {
                            dataGridView1.Rows[rowIndex].Cells[4].Value = "?";
                            dataGridView1.Rows[rowIndex + 1].Cells[4].Value = "?";
                            break;
                        }
                    }
                    string currentPassengerName = (String)dataGridView1.Rows[rowIndex].Cells[4].Value;
                    // display message if no free seats found
                    if (rowIndex == 198 && currentPassengerName != null)
                    {
                        string caption = "No seats available";
                        string message = "Sorry no match found. Try reduce number of passengers.";
                        DialogResult result = MessageBox.Show(message, caption);
                    }
                }
            }

            if (selectedClass == "Economy" && numberOfPasseneger == 3)
            {
                for (int rowIndex = 20; rowIndex < 198; rowIndex++)
                {
                    // conditions validation: look for 3 seats free and adjacent  
                    if ((dataGridView1.Rows[rowIndex].Cells[2].Value != dataGridView1.Rows[rowIndex + 1].Cells[2].Value) &&
                        (dataGridView1.Rows[rowIndex + 1].Cells[2].Value != dataGridView1.Rows[rowIndex + 2].Cells[2].Value) &&
                        dataGridView1.Rows[rowIndex].Cells[4].Value == null &&
                        dataGridView1.Rows[rowIndex + 1].Cells[4].Value == null &&
                        dataGridView1.Rows[rowIndex + 2].Cells[4].Value == null)
                    {
                        dataGridView1.Rows[rowIndex].Cells[4].Value = "?";
                        dataGridView1.Rows[rowIndex + 1].Cells[4].Value = "?";
                        dataGridView1.Rows[rowIndex + 2].Cells[4].Value = "?";
                        break;
                    }
                    string currentPassengerName = (String)dataGridView1.Rows[rowIndex].Cells[4].Value;
                    // display message if no free seats found
                    if (rowIndex == 197 && currentPassengerName != null)
                    {
                        string caption = "No seats available";
                        string message = "Sorry no match found. Try reduce number of passengers.";
                        DialogResult result = MessageBox.Show(message, caption);
                    }
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = SeatList;
        }

        // on clicking Save Reservation Details reservation details are serialized, saved to a file
        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            // create and open a file called Reservation.txt to write into it 
            FileStream fs = new FileStream("Reservation.txt", FileMode.OpenOrCreate, FileAccess.Write);
            // serialize the SeatList using BinaryFormatter in order to write its values into the newly created file
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, SeatList);
            //close the FileStream resource 
            fs.Close();

            MessageBox.Show("Reservation details have been saved.");
        }

        // on clicking Load Reservation Details reservation details are de-serialized, loaded from a file
        private void buttonDeSerialize_Click(object sender, EventArgs e)
        {
            try
            {
                // open a file called Reservation.txt to read from it
                FileStream fs = new FileStream("Reservation.txt", FileMode.Open, FileAccess.Read);
                // deserialize the SeatList using BinaryFormat in order to read its values from the file
                BinaryFormatter bf = new BinaryFormatter();
                SeatList = (ArrayList)bf.Deserialize(fs);
                fs.Close();

                //refresh the datagridview
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = SeatList;

                MessageBox.Show("Reservation details have been loaded.");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error in reading the file.");
            }
        }

        // on click, sort the SeatList by Passenger Name using Icomparable
        private void buttonSortByPassengerName_Click(object sender, EventArgs e)
        {
            SeatList.Sort();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = SeatList;
        }

        // on click, sort the SeatList by Seat Number using IComparer 
        private void buttonSortBySeatNumber_Click(object sender, EventArgs e)
        {
            SeatList.Sort(Seat.sortBySeatNumber());
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = SeatList;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // change the colour and the value displayed in the column ReservationStatus
        // based on the value of the column PassengerName
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < 200; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value != null)
                {
                    dataGridView1.Rows[i].Cells[3].Value = "RESERVED";
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    dataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.White;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[3].Value = "AVAILABLE";
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Green;
                    dataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.White;
                }
            }
        }
    }
}