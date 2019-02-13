# CSharpInterviewPracticals
Running code for some most asked in interview for C# Practicals

## In this Solution you can find some good and running C# codes which are mostly asked in interview practicals.

Please **Contribute** and add more files in this repo with solution for any question you faced in Interview. Please update **dev Branch** and create pull request to merge.

Below is the list of **Question** Which i have covered. You can find the respective **File** by the keywords in the questions.

### 1. Binary search tree (BST) is a binary tree where the value of each node is larger or equal to the values in all the nodes in that node's left subtree and is smaller than the values in all the nodes in that node's right subtree.

Write a function that, efficiently with respect to time used, checks if a given binary search tree contains a given value.

For example, for the following tree:
```
n1 (Value: 1, Left: null, Right: null)
n2 (Value: 2, Left: n1, Right: n3)
n3 (Value: 3, Left: null, Right: null)
```
Call to Contains(n2, 3) should return true since a tree with root at n2 contains number 3.

### 2. User interface contains two types of user input controls: TextInput, which accepts all characters and NumericInput, which accepts only digits.

Implement the class TextInput that contains:

Public method void Add(char c) - adds the given character to the current value
Public method string GetValue() - returns the current value
Implement the class NumericInput that:

Inherits TextInput
Overrides the Add method so that each non-numeric character is ignored
For example, the following code should output "10":
```
TextInput input = new NumericInput();
input.Add('1');
input.Add('a');
input.Add('0');
Console.WriteLine(input.GetValue());
```

### 3. A palindrome is a word that reads the same backward or forward.

Write a function that checks if a given word is a palindrome. Character case should be ignored.

For example, IsPalindrome("Deleveled") should return true as character case should be ignored, resulting in "deleveled", which is a palindrome since it reads the same backward and forward.

### 4. Print the below mention structure.

```
*****
***
*
```

### 5. Swap Numbers of 2 Integers without Creating any variable to store any value. Take the Inputs from the User And Print like Below.

```
Enter First No : 10
Enter Second No : 20
Print: Swapped No is 20 and 10
```

### 5. Write a Program or Create a function to remove the duplicate characters from the string. Take the input from the user and display result like Below

```
Enter Enter the String to Remove Duplicate : Sleeping (any string in characters repeat themselves)
Result Sholud be Like: The Result String is : Sleping
```
