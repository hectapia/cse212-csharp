public static class Divisors {
    /// <summary>
    /// Entry point for the Divisors class
    /// </summary>
    public static void Run() {
        List<int> list = FindDivisors(80);
        Console.WriteLine("<List>{" + string.Join(", ", list) + "}"); // <List>{1, 2, 4, 5, 8, 10, 16, 20, 40, 80}
        List<int> list1 = FindDivisors(35);
        Console.WriteLine("<List>{" + string.Join(", ", list1) + "}"); // <List>{1, 5, 7, 35}
    }

    /// <summary>
    /// Create a list of all divisors for a number including 1
    /// and excluding the number itself. Modulo will be used
    /// to test divisibility.
    /// </summary>
    /// <param name="number">The number to find the divisor</param>
    /// <returns>List of divisors</returns>
    private static List<int> FindDivisors(int number) {
        List<int> results = new List<int>();
        List<string> totalList = new List<string>();
            for (int i = 1; i <= number; ++i) {
                if (number % i == 0) {
                    results.Add(i);
                    totalList.Add("Divisor " + i.ToString());
                } else {
                    totalList.Add("Not divisor " + i.ToString());
                }
            }

            foreach(var item in totalList)
            {
            Console.WriteLine(item);
            }

        return results;
    }
}