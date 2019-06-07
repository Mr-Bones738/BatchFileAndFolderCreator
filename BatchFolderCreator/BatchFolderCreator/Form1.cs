using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* T O D O 
 * BEFORE I FORGET THAAAT
 * 
 * 1. Sanity checks so stupid users don't crash it.
 * That's it.
 * Quick disclaimer: if this code causes eye or brain damage, I take no responsibility.
 */ 
namespace BatchFolderCreator
{
    public partial class Form1 : Form
    {
        private enum states{
            FOLDER,
            FILE,
        };
        private bool customFormat;
        private states currentState;
        private string path;
        private int count;
        private string name;
        public Form1(string[] args)
        {
            InitializeComponent();
            currentState = states.FOLDER;
            customFormat = false;
            try
            {
                path = args[0]; // Attempt to set the path variable for easy access.
            }
            catch (IndexOutOfRangeException) // If it fails because there are no arguments
            {
                MessageBox.Show(@"This application is not meant to be launched on its own. It is meant to be used with a right click context menu or command line argument.
Application will now exit."); //Tell em why
                Environment.Exit(950); // Exit with status code 950. this is highly unique so that I always know why.
            }
        }

        private void btnOk_Click(object sender, EventArgs e) // This is called when the OK button is clicked.
        {
            if (FilePathHasInvalidChars(txtName.Text)){
                MessageBox.Show("Your file name contains invalid characters.");
                return;
            }
            if (txtName.Text == "" || txtCount.Text == "" || !int.TryParse(txtCount.Text,out count)) // If either box is empty or the "Count" box contains not only numbers
            {
                MessageBox.Show("Error! Make sure you put only numbers in the count box and that all text boxes are filled..."); // Don't do a thing.
            }
            else // I wrote most of this under the influence.
            {
                if(customFormat && !txtName.Text.Contains("*")) // If the user has chosen custom syntax but has not put any asterisks in
                {
                    MessageBox.Show("You have selected custom formatting but do not have an asterisk (*) in the Name field. Please deselect custom formatting or add one.");
                    return;
                }
                name = txtName.Text;
                if (currentState == states.FOLDER)
                {
                    for (int i = 1; i <= count; i++)
                    {
                        string folderName;
                        if (!customFormat)
                        { 
                            folderName = name + " (" + i + ")";
                        }
                        else
                        {
                            folderName = name.Replace("*", i.ToString());
                        }
                        string newFolderPath = path + @"\" + folderName;
                        System.IO.Directory.CreateDirectory(newFolderPath);
                    }
                } else if (currentState == states.FILE)
                {
                    for (int i = 1; i <= count; i++)
                    {
                        string newFilePath;
                        if (!customFormat)
                        {
                            string ext = System.IO.Path.GetExtension(name);
                            string justName = System.IO.Path.GetFileNameWithoutExtension(name);
                            string fileName = justName + " " + i;
                            newFilePath = path + @"\" + fileName + ext;
                        }
                        else
                        {
                            string fileName = name.Replace("*", i.ToString());
                            newFilePath = path + @"\" + fileName;
                        }
                        
                        System.IO.File.Create(newFilePath); // Create the file.
                    }
                }
                Application.Exit(); // On completion, exit. This is meant to be a shell extension, after all.
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            currentState = states.FOLDER;
        }

        private void rbFiles_CheckedChanged(object sender, EventArgs e)
        {
            currentState = states.FILE;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                customFormat = true;
            } else
            {
                customFormat = false;
            }
        }

        private void lblFormatHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Very basic help information for the little question mark next to the tickbox.
        {
            MessageBox.Show("With this option enabled, rather than add the number to the end of the files created, allows you to put the number wherever you want.");
            MessageBox.Show("All instances of asterisks (*) in the \"Name\" field will be replaced with the number of the file");
        }
        private bool FilePathHasInvalidChars(string path)
        {
            return (!string.IsNullOrEmpty(path) && path.IndexOfAny(System.IO.Path.GetInvalidPathChars()) >= 0);
        }
    }
}
