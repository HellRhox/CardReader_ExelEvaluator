using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; // needed for getting access to a Ecxel file
using System.Reflection;
using System.Collections;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        private bool debugemode = false; // global var to set the debuge on or of if needed
        private ErrorDialog Dialog = new ErrorDialog(); // self written error dialogform
        private string pathSample = @"C:\Autofill\Muster.xlsx"; // the path of the example that get´s filed with the data. best to be in the same place as the exe at the end.
        private string debuge = @"debuge.txt"; // Path of where the debuge file is to be saved. should be somting like /debuge.txt or /log.txt.

        public Form1()
        {
            InitializeComponent();
        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //Handling the debugemode kinda
        {
            CheckBox debuge = (CheckBox)this.CB_Debuge; // getting the CheckBoxe into the code
            if (debuge.Checked == false)  // if not checked
            {
                debugemode = false; // set debugemode to false/off
            }
            else // else
                debugemode = true; // set debugemode to true/on
            if (debugemode == true)
            {
                System.IO.File.WriteAllText(this.debuge, "debugemode Initialisiert " + DateTime.Now.ToString("hh:mm:ss dd.MM.yyyy") + "\n"); // Creates a file if it does not exist or overwirtes an existing one. also printing a line into the file that the debuge mode was started
            }
        }

        private void debugeToolStripMenuItem_Click(object sender, EventArgs e) //Handling the menuitem to activate the possibility to activate the debugemode 
        {
            CheckBox debuge = (CheckBox)this.CB_Debuge; // getting the checkbox into the programm
            if (debuge.Visible == false)
            {
                debuge.Visible = true; // set´s the vidibility of the checkbox to true so the user can see it
                debuge.Checked = false; // set´s that the checkbox isn´t checked on the start
            }
            else
            {
                debuge.Visible = false;
                debuge.Checked = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)  // Handling the menuitem to stop the programm 
        {
            Application.Exit(); // Ends the programm
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e) //dead function
        {
            //sorry :(
        }

        private void BT_Brows1_Click(object sender, EventArgs e)
        {
            OF_Source.FileName = "";
            OF_Source.FilterIndex = 1; // set´s the filter to start with the first entry. in this case the .xlsx files.
            OF_Source.ShowDialog(); //opens a dialog for the .xlsx file to set the path of that file.
            LB_SourceOne.Text = OF_Source.FileName;//writes the path into the label so the user can see that it is set.

        }

        private void LB_Source1_Click(object sender, EventArgs e) // dead function 
        {
            // sorry again :(
        }

        private void BT_SourceTwo_Click(object sender, EventArgs e)
        {
            OF_Source.FileName = "";
            OF_Source.FilterIndex = 2; // set´s the filter to start with the second entry. in this case the .txt files.
            OF_Source.ShowDialog(); //opens a dialog to set the path for the .txt file 
            LB_SourceTwo.Text = OF_Source.FileName; // writes that path into a label so the user can see that he/she changed the path/set a path.
        }

        private void BT_Destination_Click(object sender, EventArgs e)
        {
            SF_Destination.ShowDialog(); // Opens a dialog to set the path where the new file is to be saved.
            LB_Destination.Text = SF_Destination.FileName; // writting the path into a label so the user can see where he/she set the path.
        }

        private void BT_autofill_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button bt = (System.Windows.Forms.Button)sender; //getting the button that caused the event back to change it or do stuff with it
            string path = LB_SourceOne.Text;   //testing varriable with the path of an excel file 

            var excelApp = new Excel.Application(); // generating an object from Excel.Aplication to get access
            excelApp.Visible = false; // setting the excel application to run in the background 

            if (System.IO.File.Exists(path)) // see if the file that is in the path exists if not jumps to the else
            {
                try  // exception handling 
                {
                    // Sourcefiles
                    var workBook = excelApp.Workbooks.Open(path);  //opening a excelfile
                    Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet; // getting the activ worksheet 
                    var range = workSheet.UsedRange; // getting the range of what range is used inside the spredsheet


                    //Destinationfiles
                    Excel.Workbook destWorkBook = excelApp.Workbooks.Open(pathSample); //opens an excelfile
                    Excel.Worksheet destWorkSheet = (Excel.Worksheet)excelApp.ActiveSheet; // get´s the activ worksheet
                    Excel.Range destRange = destWorkSheet.UsedRange; // getting the range of the use inside the sheet

                    // % only for debuging purposes
                    if (debugemode == true)
                        using (System.IO.StreamWriter file =
                                                       new System.IO.StreamWriter(debuge, true))
                        {
                            file.WriteLine("Die angegebene Datei wurde gefunden");// is appanding a line to the debugefile
                        }
                            // %

                    for (int j = 1; j <= range.Columns.Count; j++) // jumping the columns
                        for (int i = 1; i <= range.Rows.Count; i++) // jumping the rows
                        {
                            if (i < 3)
                                continue; // ignoring every cell befor the fifth where our date should be
                            

                            //Magnet
                            if ((range.Cells[i, j] as Excel.Range).Value2 != null)  // checks if there is a value inside the specifc cell if not there is no print happening
                            {
                                if (debugemode == true) // % only for debuging purposes
                                    using (System.IO.StreamWriter file =
                                                                   new System.IO.StreamWriter(debuge, true))
                                    {
                                        file.WriteLine((range.Cells[i/*rows*/, j/*columns*/] as Excel.Range).Value2); // Writes the data into a .txt file if in debuge mode.
                                    }
                                        //%
                                destRange.Cells[i + 66, 2] = range.Cells[i, j]; //writes the Data from the source sheet to the destination sheet.
                            }
                            if (i == 17)
                            {                                
                                i = range.Rows.Count;
                                j = range.Columns.Count;
                            }
                        }

                    //Chip
                    string temp; // temporary string to read the lines and cut the strings into pices
                    ArrayList TimeLines = new ArrayList(); //an array that holds the 31 pairs of timestamps

                    System.IO.StreamReader readFile = new System.IO.StreamReader(LB_SourceTwo.Text);

                    while ((temp = readFile.ReadLine()) != null) // Reads the file line by line until EOF or an error that returns null
                    {
                        if (temp.Contains("ATR") || temp.Contains("ICC") || temp.Contains("TERM"))
                        {
                            if ((temp = trim(temp))!=null)
                            {
                                TimeLines.Add(temp);
                            }
                            else
                                break; 
                        }
                    }
                    // % only for debuging purpuses
                    if (debugemode == true)
                    {
                        using (System.IO.StreamWriter file =
                           new System.IO.StreamWriter(debuge, true))
                        {
                            file.WriteLine("Log eingelesen");
                        }
                            for (int j = 0; j < TimeLines.Count; j++)
                            {
                                using (System.IO.StreamWriter file =
                               new System.IO.StreamWriter(debuge, true))
                                {
                                    file.WriteLine(TimeLines[j]);
                                }
                            }
                    }
                    //%

                    for (int l = 27; l < 62; l++)
                    {
                        if (l < 54)
                        {
                            destRange.Cells[l, 10] = TimeLines[l - 26];
                        }
                        // Chip customer data
                        else if (l > 53 && l < 56)
                        {
                            if (l == 54)
                            {
                                double timePin = (range.Cells[26, 1].Value2) - (range.Cells[25, 1].Value2);
                                destRange.Cells[l, 8] = timePin;
                            }
                            else
                            {
                                double value = (range.Cells[28, 1].Value2) - (range.Cells[27, 1].Value2);
                                destRange.Cells[l, 8] = value;
                            }
                        }
                        else if (l > 55 && l < 58)
                        {
                            destRange.Cells[l, 10] = TimeLines[l - 29];
                        }
                        // Chip customer data
                        else if (l == 58)
                        {
                            double latenz = (range.Cells[30, 1].Value2) - (range.Cells[29, 1].Value2);
                            destRange[l, 9] = latenz;
                        }
                        else if (l < 62)
                        {
                            destRange.Cells[l, 10] = TimeLines[l - 31];
                        }
                        else
                            break;
                    }
                    // Chip customer data
                    if (debugemode == true)
                        using (System.IO.StreamWriter file =
                                                       new System.IO.StreamWriter(debuge, true))
                        {
                            file.WriteLine("Chip Transaktion data customer"); // appends a line to the debuge file
                        }
                    for (int countCount = 6; countCount < 15; countCount++)
                    {
                        if (countCount == 6)
                        {
                            if ((range.Cells[countCount + 16].value.ToString().Equals("1890"))||(range.Cells[countCount + 16].value.ToString().Equals("13490")))
                            {
                                destRange.Cells[countCount, 2] = range.Cells[countCount + 18, 1];
                                if (debugemode == true)
                                    using (System.IO.StreamWriter file =
                                           new System.IO.StreamWriter(debuge, true))
                                    {
                                        file.WriteLine(range.Cells[countCount + 16].value.ToString()); // appends a line to the debuge file
                                    }
                            }
                            else
                            {
                                destRange.Cells[countCount, 2] = range.Cells[countCount + 16, 1];
                                destRange.Cells[countCount + 12, 1] = range.Cells[countCount + 18, 1];
                                if (debugemode == true)
                                    using (System.IO.StreamWriter file =
                                           new System.IO.StreamWriter(debuge, true))
                                    {
                                        file.WriteLine(range.Cells[countCount + 16].value.ToString()); // appends a line to the debuge file
                                    }
                            }
                            if (debugemode == true)
                                using (System.IO.StreamWriter file =
                                                               new System.IO.StreamWriter(debuge, true))
                                {
                                    file.WriteLine(range.Cells[countCount + 18, 1].Value2 + "" + range.Cells[countCount + 18, 2].Value2); // appends a line to the debuge file
                                }
                             countCount++;
                        }
                        else
                        {
                            destRange.Cells[countCount, 2] = range.Cells[countCount + 23, 1];
                            if (debugemode == true)
                                using (System.IO.StreamWriter file =
                           new System.IO.StreamWriter(debuge, true))
                                {
                                    file.WriteLine(range.Cells[countCount + 23, 1].Value2); // appends a line to the debuge file
                                }
                        }
                    }

                    destWorkBook.SaveAs(LB_Destination.Text);// saves the new .xlsx file  where the user specified it to.
                    excelApp.Quit();

                }
                catch (Exception ex) // Catches any exception or error that may occure
                {
                    if (debugemode == true)
                        // % only for debuging purposes
                        using (System.IO.StreamWriter file =
                                                       new System.IO.StreamWriter(debuge, true))
                        {
                            file.WriteLine(ex.Message+"\n"+ex.StackTrace);
                        }
                    // %
                    Dialog.ShowDialog(); //opens the error dialog if somthing failed
                    excelApp.Quit(); // closes the excel prozecces running in the backround
                }
            }
            else
            {
                Dialog.ShowDialog(); //opens the dialog if the specified file should not exist
                if (debugemode == true)
                    // % only for debuging purpuses
                    using (System.IO.StreamWriter file =
                               new System.IO.StreamWriter(debuge, true))
                    {
                        file.WriteLine("Die ausgewählte Excel-Datei wurde nicht gefunden");
                    }
            } 

           
        }

        private void musterFestlegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OF_Muster.ShowDialog();
            pathSample=OF_Muster.FileName;
            LB_Muster.Text = "Muster Unter: " + pathSample;
        }

        public string trim(string s) // cut´s down the strings from the .txt
        {
            string temp = s;
            int k = 0;
            temp = temp.Trim(); // getting rid of the front running spaces and the padding on the back
            while (k < temp.Length - 1 && temp[k] != ']') // getting the index of where the first cut need´s to be made
            {
                k++;      //counting the index so we get to the above char in the string
            }
            temp = temp.Substring(k + 1);  // cutting away the first part so we start with the timestamps themeselfs
            k = 0; // setting the counter back to zero for the next line that get´s throug this part o town
            temp=temp.Trim();
            if (debugemode == true)
            {
                // % only for debuging purpuses
                using (System.IO.StreamWriter file =
                           new System.IO.StreamWriter(debuge, true))
                {
                    file.WriteLine(temp);
                }
            }
            if (temp.Length > 8)
            {
                if ((char.IsNumber(temp[1])))
                {
                    temp = temp.Trim();
                    if (debugemode == true)
                    {
                        // % only for debuging purpuses
                        using (System.IO.StreamWriter file =
                                   new System.IO.StreamWriter(debuge, true))
                        {
                            file.WriteLine(temp);
                        }
                    }
                    int i = 0;
                    while(temp[i]!='.')
                    {
                        i++;
                    }
                    temp = temp.Substring(0, 8); // cutting away the rest from the back so be gone hex jibberish
                    temp = temp.Substring(0, i) + temp.Substring(i+1);
                    return temp.Trim();//cutting away all padding spaces and saving the timestamppairs into the array
                }
            }
            return null;
        }

        private void OF_Source_FileOk(object sender, CancelEventArgs e)
        {

        }


    }
}
// Yannick Bayard
