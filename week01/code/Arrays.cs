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
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // MY COMENTS HERE: 
        // I have to return something, in this case a double[]. So I need to create an array to return the values that will be added.
        // I'm receving two parameters, a number to calculate the multiples and a length number to my array.
        // I need to create a for loop to iterate "length" times
        // For each iteration I have to make a multiply operation with the number and the index of the array. Have to add 1 because the list index starts in 0.6,
        // And then add the value to the specific index of the array.
        double[] list = new double[length];

        for (int i = 0; i < length; i++)
        {
             list[i] = number * (i + 1);

        }
        return list; // replace this return statement with your own
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
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // MY COMENTS HERE: 
        // I noticed that this is a Void method, so I don't need to return something here
        // Rotate to the right is basically cut the array and put the amount of numbers informed to the beginning of the list and write the rest until the end
        // First: take the values I want to move and create and list for them
        // Second: take the remaining values and put them in another list
        // Clear the List data
        // Add the new created lists into one List Data with the rotate numbers
        List<int> data1 = data.GetRange(data.Count - amount, amount);
        List<int> data2 = data.GetRange(0, data.Count - amount);

        data.Clear();
        data.AddRange(data1);
        data.AddRange(data2);

    }
}
