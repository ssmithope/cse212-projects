public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        //Plan:
        //a) Create an array of size 'length'.
        //b) Loop from i = 0 to i < length.
        //c) For each i, calculate number * (i + 1).
        //d) Store the result in the array at index i.
        //e) Return the completed array.

        double[] result = new double[length];

        for (int i = 0; i < length;i++)
        {
            result[i] = number * (i+1);
        
        }
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
       // Plan:
       //a) Get the total number of elements in the list(n).
       //b) Calculate the split point: n - amount.
       //c) Use GetRange to get:
       //   tail = last 'amount' elements
       //   head = first 'n-amount' elements
       //d) Clear the original list.
       //e) Add tail first, then head to rebuild the list.

       int n = data.Count;
       amount = amount % n;

       List<int> tail = data.GetRange(n - amount, amount);
       List<int> head = data.GetRange(0, n - amount);

       data.Clear();
       data.AddRange(tail);
       data.AddRange(head);
    }
}


