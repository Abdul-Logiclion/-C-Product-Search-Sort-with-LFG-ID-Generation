
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2___Random_Numbers_Searching_Sorting
{
    /// <summary>
    /// Class representing a Product object as described in Task 2 of the Assignment.
    /// TODO: Implement methods generateRandomID() and Shuffle()
    /// </summary>
    


    internal class Product
{
    private long id;
    public long Id { get => id; private set => id = value; }

    private string name;
    public string Name { get => name; set => name = value; }

    public Product(string name)
    {
        this.name = name;
        this.id = generateRandomID();
    }

    private long generateRandomID()
    {
        LFG lfg = new LFG();
        long[] randomNumbers = new long[3];
        for (int i = 0; i < 3; i++)
        {
            randomNumbers[i] = lfg.Next(100, 999);
        }
        Shuffle(randomNumbers);
        long productId = randomNumbers[0] * 1000000 + randomNumbers[1] * 1000 + randomNumbers[2];
        return productId;
    }

    private void Shuffle(long[] array)
    {
        Random rng = new Random();
        int n = array.Length;
        for (int i = n - 1; i > 0; i--)
        {
            int j = rng.Next(i);
            long temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
}


}
