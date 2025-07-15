using System.Data;

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
        // TODO Problem 1 Start
        // Plan of Implementation
        // Creating an double Array of multiples of a number within a given length
        // Using a for loop, each at an index of i.
        // Where the startingNumber times the product of the index plus 1.
        // That is startNumber * (index + 1); return the results
        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
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
        // TODO Problem 2 Start
        // Step 1: Check if the list is null or has less than 2 items (no rotation needed)
        // Step 2: Normalize the amount by using modulo, in case amount == data.Count
        // Step 3: Split the list into two parts:
        //  **** Right part: last 'amount' elements
        //  **** Left part: remaining elements from the beginning
        // Step 4: Concatenate the right part + left part to form the rotated list
        // Step 5: Clear the original list and add the rotated items back into it


        //Checking if Lists is empty or has more than 1 element!
        if (data == null || data.Count < 2)
            return;

        //Normalizing amount using modulo
        amount = amount % data.Count;

        //Splitting lists in 2 parts; Right and Left!
        List<int> rightPart = data.GetRange(data.Count - amount, amount);
        List<int> leftPart = data.GetRange(0, data.Count - amount);

        //Concatenating the 2 parts
        List<int> rotated = new List<int>(rightPart);
        rotated.AddRange(leftPart);

        //Update the Lists with the changes!
        data.Clear();
        data.AddRange(rotated);
    }
}
