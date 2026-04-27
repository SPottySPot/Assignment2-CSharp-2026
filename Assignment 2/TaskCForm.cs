using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class TaskCForm : Form
    {
        public TaskCForm()
        {
            InitializeComponent();
        }

        class node
        {
            public int data;
            public node next;
            public node prev;
        }

        node head = null;
        node tail = null;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            head = null;
            tail = null;
            for (int i = 0; i < txtInput.Text.Length; i++)
            {
                node newNode = new node();
                newNode.data = txtInput.Text[i];
                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                } else
                {
                    newNode.prev = head;
                    head.next = newNode;
                    head = newNode;
                }
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Forwards: ";
            node current = tail;
            while (current != null)
            {
                lblResult.Text += (char)current.data;
                current = current.next;
            }
        }

        private void btnBackwards_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Backwards: ";
            node current = head;
            while (current != null)
            {
                lblResult.Text += (char)current.data;
                current = current.prev;
            }
        }
    }
}
