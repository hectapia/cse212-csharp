    /// <summary>
    /// The words parameter contains a list of two character 
    /// words (lower case, no duplicates). Using sets, find an O(n) 
    /// solution for displaying all symmetric pairs of words.  
    ///
    /// For example, if <c>words</c> was: <c>[am, at, ma, if, fi]</c>, we would display:
    /// <code>
    /// am &amp; ma
    /// if &amp; fi
    /// </code>
    /// The order of the display above does not matter. <c>at</c> would not 
    /// be displayed because <c>ta</c> is not in the list of words.
    ///
    /// As a special case, if the letters are the same (example: 'aa') then
    /// it would not match anything else (remember the assumption above
    /// that there were no duplicates) and therefore should not be displayed.
    /// </summary>
    /// <param name="words">An array of 2-character words (lowercase, no duplicates)</param>


public class DisplaySymmetricPairs {

    public static void DisplayPairs(string[] pairs) {
        HashSet<string> pairSet = new HashSet<string>();
        List<string> symmetricPairs = new List<string>();

        foreach (string pair in pairs) {
            if (pair.Length != 2) {
                continue;
            }

            string reversed = new string(pair.Reverse().ToArray());

            if (pairSet.Contains(reversed) && pair != reversed) {
                symmetricPairs.Add($"{pair} & {reversed}");
                pairSet.Remove(reversed);
            } else {
                pairSet.Add(pair);
            }
        }

        if (symmetricPairs.Count > 0) {
            Console.WriteLine(string.Join(", ", symmetricPairs));
        } else {
            Console.WriteLine("Without symmetric pairs.");
        }
    }
}    