namespace DsaPlayground;

public static class StringAlgorithms
{
    /*
     * 1.1 Implement an algorithm to determine if a string has all unique characters.
     * What if you cannot use additional data structures?
     */
    public static bool IsUnique(string input)
    {
        /*
         Time Complexity: O(N)
         Space Complexity: O(1) assuming ASCII input
         */
        HashSet<char> hashSet = new HashSet<char>();

        foreach (char c in input)
        {
            if (hashSet.Contains(c))
                return false;
            hashSet.Add(c);
        }

        return true;
    }

    public static bool IsUniqueInPlace(string input)
    {
        /*
         Time Complexity: O(N log N)
         Space Complexity: O(N)
         */
        string sorted = string.Concat(input.OrderBy(c => c));

        for (int i = 1; i < sorted.Length; i++)
        {
            if (sorted[i] == sorted[i - 1])
                return false;
        }

        return true;
    }

    
    /*
     * 1.2 Given two strings, write a method to decide if one is a permutation of the other.
     * We are assuming a permutation is not case sensitive and that there is no whitespace.
     */
    public static bool IsPermutationUsingHashtable(string input1, string input2)
    {
        /*
         * Time Complexity: O(mn)
         * Space Complexity: O(1);
         */
        if (input1.Length != input2.Length)
            return false;
        
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        //Create dictionary for one string
        foreach (char c in input1)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }

        foreach (char c in input2)
        {
            if (charCount.ContainsKey(c))
                charCount[c]--;
            else
                return false;
        }
        
        return charCount.Values.All(c => c == 0);
        
    }
    
    public static bool IsPermutationUsingSorting(string input1, string input2)
    {
        /*
         * Time Complexity: O(N Log N)
         * Space Complexity: O(N);
         */
        if (input1.Length != input2.Length)
            return false;
        
        string sortedInput1 = string.Concat(input1.OrderBy(c => c));
        string sortedInput2 = string.Concat(input2.OrderBy(c => c));
        
        return sortedInput1 == sortedInput2;
    }
    
    /*
     * Write a method to replace all spaces in a string with '%20'. You may assume that string
     * has sufficient space at the end to hold the additional characters, and that you are given the
     * 'true' length of the string.
     */

    public static char[] UrlifyString(char[] input, int length)
    {
        int fullLength = input.Length - 1;
        for (int i = length-1; i >= 0; i--)
        {
            if (input[i] != ' ')
            {
                input[fullLength] = input[i];
                fullLength--;
            }
            else
            {
                input[fullLength] = '0';
                input[fullLength - 1] = '2';
                input[fullLength - 2] = '%';
                fullLength -= 3;
            }
        }

        return input;
    }
}