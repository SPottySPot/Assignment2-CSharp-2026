using System;
using System.Windows.Forms;

namespace Assignment_2
{
    //**************************************************************
    // Programmer:       Sterling - CIT301495
    // Date:             27/04/2026
    // Software:         Visual Studio 2022
    // Platform:         Windows 11
    // Purpose:          Main form and menu for Assignment 2 tasks A-D
    // Acknowledgements: The in class code based on the weekly sessions.
    //**************************************************************

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        //opens a new form and displays an image using the programmed instructions
        private void btnTaskA_Click(object sender, EventArgs e)
        {
            TaskAForm taskAForm = new TaskAForm();
            taskAForm.Show();
        }

        //opens a new form and takes a drag and dropped image and displays it
        private void btnTaskB_Click(object sender, EventArgs e)
        {
            TaskBForm taskBForm = new TaskBForm();
            taskBForm.Show();
        }

        //opens a new form that takes an input word and puts it in a linked list and can display it forwards and backwards
        private void btnTaskC_Click(object sender, EventArgs e)
        {
            TaskCForm taskCForm = new TaskCForm();
            taskCForm.Show();
        }

        //opens a new form and takes a users input on different car attributes and creates a nested class and displays the information
        private void btnTaskD_Click(object sender, EventArgs e)
        {
            TaskDForm taskDForm = new TaskDForm();
            taskDForm.Show();
        }

        //displays a message box with the required message
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sterling, CIT301495, AT2");
        }

        //quits the program
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
