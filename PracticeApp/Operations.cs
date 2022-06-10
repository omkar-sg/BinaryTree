using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    public delegate void myhandler(int number);
    public delegate void viewTreeHandler(BinarySearchTree.Node node);
    public class Operations
    {
        public event myhandler insertNode;
        public event viewTreeHandler viewTree;

        public void onInsertNode(int number)
        {
            insertNode?.Invoke(number);
        }

        public void onViewTree(BinarySearchTree.Node node)
        {
            viewTree?.Invoke(node);
        }

    }
}
