Console.WriteLine("Welcome to Module 3!");

// Introduction to Prompt Engineering

// Prompt Engineering Best Practices
// 1 - Provide clear and specific instructions
// Example: Write a function to filter and return even numbers from a given list

// 2 - Provide context
// Example:
// Write a simple Web API Application using ASP.NET Core.
// The application is about pokemon database management.
// Context: The application should allow users to create, read, update, and delete pokemon.

// 3 - Use step-by-step instructions
// Example:
// There is more than one algorithm to find a specific element in a list.
// One of the most common algorithms is "linear search".
// Step 1: Define the function that takes a list and an element to search
// Step 2: Iterate through each element in the list
// Step 3: If the element is found, return its index
// Step 4: If the element is not found, return -1

// 4 - Use examples to illustrate the expected output
// Example:
// Write a function to calculate the factorial of a number.
// Input: 5
// Output: 120

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