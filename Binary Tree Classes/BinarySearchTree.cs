using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2___Random_Numbers_Searching_Sorting
{
    /// <summary>
    /// A class representing a Binary Search Tree aimed at facilitating the search of products by product id.
    /// TODO: You are to implement the Build() and Find() methods for this class; additional methods may be added but:
    /// 1. The final result i.e. the sorted array of employees must be returned by the Sort() method provided
    /// 2. Any methods added to this class must be declared as private and called within the Build() or Find() method
    /// </summary>
    internal class BinarySearchTree
    {
        // Points to the top node in the tree
        public TreeNode Root { get; private set; }

        /// <summary>
        /// Builds a Binary Search tree based on the list of products passed as parameter.
        /// It inserts each product in the list into the tree.
        /// 
        /// TODO: Implement this method as described above and in Task 2.
        /// 
        /// </summary>
        /// <param name="productList">List<Product> list of products to be inserted in the tree</param>
        /// <exception cref="NotImplementedException">Thrown when the method is not implemented</exception>
        public void Build(List<Product> productList)
        {
            foreach (var product in productList)
            {
                Insert(product);
            }
        }

        /// <summary>
        /// Searches for a Product with the given id in the tree. If no match is found, null is returned.
        /// 
        /// TODO: Implement this method as described above and in Task 2.
        /// 
        /// </summary>
        /// <param name="productID">long id of product to search for</param>
        /// <returns>Product matching id or null</returns>
        /// <exception cref="NotImplementedException">Thrown when the method is not implemented</exception>
        public Product Find(long productID)
        {
            TreeNode current = Root;
            while (current != null)
            {
                if (productID == current.Product.Id)
                {
                    return current.Product;
                }
                else if (productID < current.Product.Id)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            return null;
        }

        /// <summary>
        /// Inserts a product into the Binary Search Tree.
        /// </summary>
        /// <param name="product">Product to insert</param>
        private void Insert(Product product)
        {
            if (Root == null)
            {
                Root = new TreeNode(product);
            }
            else
            {
                TreeNode current = Root;
                TreeNode parent;
                while (true)
                {
                    parent = current;
                    if (product.Id < current.Product.Id)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = new TreeNode(product);
                            return;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = new TreeNode(product);
                            return;
                        }
                    }
                }
            }
        }
    }
}
