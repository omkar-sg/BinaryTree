using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeApp
{
    public partial class Form1 : Form
    {
        BinarySearchTree numberTree = new BinarySearchTree();
        Operations operation= new Operations();
        public Form1()
        {
            
            InitializeComponent();
            operation.insertNode += numberTree.Insert;
            operation.viewTree += numberTree.LPR;
        }

        private void insertNodeButton_Click(object sender, EventArgs e)
        {
            //numberTree.Insert();
            var num = Convert.ToInt32(insertNodeTextBox.Text);
            operation.onInsertNode(num);
            MessageBox.Show(insertNodeTextBox.Text + " Inserted");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //numberTree.LPR(numberTree.root);
            operation.onViewTree(numberTree.root);
        }
    }
}
