using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_View
{
    public partial class treeViewForm : Form
    {
        string substringDirectory;//store last part of full path name

        public treeViewForm()
        {
            InitializeComponent();
        }

        public void PopulateTreeView(string directoryValue, TreeNode parentNode)
        {
            string[] directoryArray = Directory.GetDirectories(directoryValue);

            try
            {
                //check to see if any subdirectories are present
                if (directoryArray.Length != 0)
                {
                    //for each subdirectories, create new treenode, 
                    //add as a child of current node and recursively
                    //populate child nodes with subdirectories
                    foreach (string directory in directoryArray)
                    {
                        //obtain last part of path name from the full path 
                        //name by calling the GetFileNameWithoutExtension
                        //method of class path
                        substringDirectory = Path.GetFileNameWithoutExtension(directory);

                        //create treenode for current directory
                        TreeNode myNode = new TreeNode(substringDirectory);

                        //add current directory node to parent node
                        parentNode.Nodes.Add(myNode);

                        //recursively populate every subdirectories
                        PopulateTreeView(directory, myNode);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Access denied");
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            //clear all nodes
            directoryTreeView.Nodes.Clear();

            //check if the directory entered by user exists
            //if it does, then fill in the TreeView
            //if not display error messages
            if (Directory.Exists(inputTextBox.Text))
            {
                //add full path name to directoryTreeView
                directoryTreeView.Nodes.Add(inputTextBox.Text);

                //insert subfolder
                PopulateTreeView(inputTextBox.Text, directoryTreeView.Nodes[0]);
            }
            //display error MessageBox if directory not found
            else
            {
                MessageBox.Show(inputTextBox.Text + " could not be found.", "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
