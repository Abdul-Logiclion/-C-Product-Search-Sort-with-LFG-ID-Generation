using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_2___Random_Numbers_Searching_Sorting
{
    internal class ProductManager
    {
        private List<Product> productCatalog = new List<Product>();
        public List<Product> ProductCatalog { get => productCatalog; private set => productCatalog = value; }

        public ProductManager(List<Product> productList) 
        { 
            this.productCatalog = productList;
        }

        public List<Product> SortProducts()
        {
            // Create a priority queue with Product objects, ordering by Id
            PriorityQueue<Product, long> priorityQueue = new PriorityQueue<Product, long>(new LongComparer());

            // Add all products to the priority queue
            foreach (var product in productCatalog)
            {
                priorityQueue.Enqueue(product, product.Id);
            }

            // Create a sorted list from the priority queue
            var sortedCatalog = new List<Product>();
            while (priorityQueue.Count > 0)
            {
                sortedCatalog.Add(priorityQueue.Dequeue());
            }

            return sortedCatalog;
        }

        public Product SearchProduct(long id)
        {
            // Create a binary search tree to facilitate searching
            BinarySearchTree bst = new BinarySearchTree();
            // Build the binary search tree from the product catalog
            bst.Build(productCatalog);

            // Search for the product by id using the binary search tree
            return bst.Find(id);
        }
    }

    internal class LongComparer : IComparer<long>
    {
        public int Compare(long x, long y)
        {
            return x.CompareTo(y);
        }
    }
}
