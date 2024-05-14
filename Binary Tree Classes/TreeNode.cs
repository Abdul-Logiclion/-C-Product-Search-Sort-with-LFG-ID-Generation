using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2___Random_Numbers_Searching_Sorting
{
    /// <summary>
    /// A class representing a node for a Binary Search Tree aimed at faciliating the search of Product objects
    /// by product id as descibed in Task 2
    /// This class requires no further addition/modification
    /// </summary>
    internal class TreeNode
    {
        public Product Product { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(Product p) { this.Product = p; this.Left = null; this.Right = null; }
    }
}
