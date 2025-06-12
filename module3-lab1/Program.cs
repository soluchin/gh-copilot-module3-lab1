Console.WriteLine("Welcome to Module 3!");

// Introduction to Prompt Engineering
// Principals 4s
// 1. Single -> Focus on one task at a time
// 2. Specific -> Explicit and detail
// 3. Short -> Keep it concise
// 4. Surround -> Provide context, limitations and examples

// Prompt Engineering Best Practices
// 1 - Provide clear and specific instructions
// Example: Write a function to filter and return even numbers from a given list

// 2 - Provide context and detail
// Example:
// Write a function that return the value of n vibonacci number
// Context: Dont use recursion, use a loop instead
// Limitations: The function should handle negative inputs by returning -1

// 3 - Use step-by-step instructions
// Example:
// There is more than one algorithm to find a specific element in a list.
// One of the most common algorithms is "linear search".
// Step 1: Define the function that takes a list and an element to search
// Step 2: Iterate through each element in the list
// Step 3: If the element is found, return its index
// Step 4: If the element is not found, return -1
int LinearSearch(int[] list, int element)
{
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] == element)
        {
            return i; // Element found, return index
        }
    }
    return -1; // Element not found
}

// 4 - Use examples to illustrate the expected output
// Example:
// Write a function to calculate the factorial of a number.
// Input: 5
// Output: 120
int Faktorial(int n)
{
    // Jika input kurang dari 0, kembalikan -1 // created by copilot
    if (n < 0) return -1;
    // Inisialisasi hasil dengan 1 // created by copilot
    int hasil = 1;
    // Hitung faktorial dengan perulangan // created by copilot
    for (int i = 2; i <= n; i++)
    {
        hasil *= i;
    }
    // Kembalikan hasil faktorial // created by copilot
    return hasil;
}

// 5 - Provide another function as an example
String FunctionXYZ(string input)
{
    string[] words = input.Split(' ');
    for (int i = 0; i < words.Length; i++)
    {
        words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
    }
    return string.Join(" ", words);
}
// Write similar function to FunctionXYZ but using LINQ
String FunctionXYZLinq(string input)
{
    return string.Join(" ", input.Split(' ').Select(word => char.ToUpper(word[0]) + word.Substring(1)));
    // Fungsi untuk menghitung faktorial dari sebuah angka // created by copilot

}