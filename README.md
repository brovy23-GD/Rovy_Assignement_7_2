<p align="center">
  <img src="banner.png" width="100%" alt="Rovy Assignment 7.2 Banner" />
</p>

<p align="center">
  <img src="https://img.shields.io/badge/build-passing-brightgreen?style=for-the-badge" alt="Build Passing" />
  <img src="https://img.shields.io/badge/language-C%23-239120?style=for-the-badge&logo=c-sharp" alt="Language C#" />
  <a href="https://github.com/brovy23-GD/Rovy_Assignement_7_2">
    <img src="https://img.shields.io/github/last-commit/brovy23-GD/Rovy_Assignement_7_2?style=for-the-badge" alt="Last Commit" />
  </a>
  <a href="https://github.com/brovy23-GD/Rovy_Assignement_7_2">
    <img src="https://img.shields.io/github/repo-size/brovy23-GD/Rovy_Assignement_7_2?style=for-the-badge" alt="Repo Size" />
  </a>
  <img src="https://img.shields.io/badge/license-MIT-blue?style=for-the-badge" alt="License MIT" />
</p>

# Rovy Assignment 7.2

C# console application featuring three core algorithm and data structure exercises completed as part of MSSA coursework: Merge Sort, Reverse Vowels, and Anagram Checker. This project demonstrates recursive problem solving, string manipulation, array-based frequency counting, and clean class-based organization in C#.

## Project Highlights

- Built in C# with separate classes for each algorithm to improve readability, maintainability, and modular design.
- Demonstrates core technical skills including recursion, divide-and-conquer sorting, two-pointer traversal, array manipulation, and algorithm analysis.
- Uses a console-driven workflow through Program.cs to run and test each algorithm from one entry point.

## Algorithms Included

### 1) Merge Sort

Implements the classic divide-and-conquer sorting algorithm by recursively splitting the array, sorting each half, and merging the results into a sorted output.

Concepts demonstrated:

- Recursion
- Divide and conquer
- Array traversal
- Temporary merge buffers
- Time complexity analysis

Complexity:

- Time: O(n log n)
- Space: O(n)

### 2) Reverse Vowels

Reverses only the vowels in a string using a two-pointer approach, moving inward from both ends and swapping vowels while leaving other characters unchanged.

Concepts demonstrated:

- Two-pointer technique
- String-to-array conversion
- In-place character swapping
- Conditional traversal

Complexity:

- Time: O(n)
- Space: O(1) extra space (excluding character array conversion)

### 3) Anagram Checker

Determines whether two strings are anagrams by counting character frequency with a fixed-size array and verifying both strings contain the same letters in the same quantities.

Concepts demonstrated:

- Frequency arrays
- Character normalization
- Input validation
- Efficient comparison without sorting

Complexity:

- Time: O(n)
- Space: O(1)

## Tech Stack

- C#
- .NET / Visual Studio
- Console application
- Algorithms and Data Structures fundamentals

## Project Structure

```text
Rovy_Assignement_7_2/
|-- Program.cs
|-- MergeSort.cs
|-- ReverseVowels.cs
|-- AnagramChecker.cs
`-- README.md
```

## UML Class Diagram

```mermaid
classDiagram
    class Program {
        +Main()
    }

    class MergeSort {
        +Sort(int[] arr)
        -MergeSortRecursive(int[] arr, int left, int right)
        -Merge(int[] arr, int left, int mid, int right)
    }

    class ReverseVowels {
        +Process(string s) string
    }

    class AnagramChecker {
        +IsAnagram(string s, string t) bool
    }

    Program --> MergeSort
    Program --> ReverseVowels
    Program --> AnagramChecker
```

## Algorithm Flowcharts

### 1) Merge Sort Flowchart

```mermaid
flowchart TD
    A[Start] --> B[Input array]
    B --> C{Array length <= 1?}
    C -->|Yes| D[Return array]
    C -->|No| E[Split array into left and right]
    E --> F[Recursively sort left half]
    F --> G[Recursively sort right half]
    G --> H[Merge sorted halves]
    H --> I[Return merged array]
```

### 2) Reverse Vowels Flowchart

```mermaid
flowchart TD
    A[Start] --> B[Convert string to char array]
    B --> C[Set left = 0, right = n - 1]
    C --> D{left < right?}
    D -->|No| E[Return char array as string]
    D -->|Yes| F{Is left char a vowel?}
    F -->|No| G[Increment left]
    G --> C
    F -->|Yes| H{Is right char a vowel?}
    H -->|No| I[Decrement right]
    I --> C
    H -->|Yes| J[Swap left and right chars]
    J --> K[Increment left, decrement right]
    K --> C
```

### 3) Anagram Checker Flowchart

```mermaid
flowchart TD
    A[Start] --> B[Input strings s and t]
    B --> C{Lengths equal?}
    C -->|No| D[Return false]
    C -->|Yes| E[Initialize frequency array of size 26]
    E --> F[Count characters in s]
    F --> G[Subtract counts using characters in t]
    G --> H{Any count not zero?}
    H -->|Yes| I[Return false]
    H -->|No| J[Return true]
```

## Trace Tables

### 1) Merge Sort Trace Table Example

Input

```text
[4][5][6][7]
```

| Step | Left Half   | Right Half | Action              |
|------|-------------|------------|---------------------|
| 1    | [5, 2]      | [9, 1]     | Split               |
| 2    | [5] [2]     | [9] [1]    | Split to base case  |
| 3    | [5, 2]      | [9, 1]     | Merge each pair     |
| 4    | [2, 5]      | [1, 9]     | Sorted halves       |
| 5    | [2, 5, 1, 9] |            | Final merge         |
| 6    | [1, 2, 5, 9] |            | Final sorted output |

### 2) Reverse Vowels Trace Table Example

Input

```text
hello
```

| Step | Left | Right | Left Char | Right Char | Action            | Result |
|------|------|-------|-----------|------------|-------------------|--------|
| 1    | 0    | 4     | h         | o          | Right vowel found |        |
| 2    | 1    | 4     | e         | o          | Swap e and o      | holle  |
| 3    | 2    | 3     | l         | l          | Move pointers     | holle  |
| 4    | 2    | 2     | -         | -          | Stop              | holle  |

### 3) Anagram Checker Trace Table Example

Input

```text
s = "anagram"
t = "nagaram"
```

| Step | Char | Count Change | Notes                     |
|------|------|--------------|---------------------------|
| 1    | a    | +1           | Count from s              |
| 2    | n    | +1           |                           |
| 3    | a    | +1           |                           |
| 4    | g    | +1           |                           |
| 5    | r    | +1           |                           |
| 6    | a    | +1           |                           |
| 7    | m    | +1           |                           |
| 8    | n    | -1           | Subtract from t           |
| 9    | a    | -1           |                           |
| 10   | g    | -1           |                           |
| 11   | a    | -1           |                           |
| 12   | r    | -1           |                           |
| 13   | m    | -1           |                           |
| 14   | a    | -1           | All counts return to zero |

## Time and Space Complexity Summary

| Algorithm       | Time Complexity | Space Complexity | Notes                                   |
|----------------|-----------------|------------------|-----------------------------------------|
| Merge Sort     | O(n log n)      | O(n)             | Uses extra arrays during merge          |
| Reverse Vowels | O(n)            | O(1)             | Two-pointer technique, in-place swap    |
| Anagram Checker| O(n)            | O(1)             | Fixed-size frequency array (26 letters) |

## How to Run

1. Open the solution in Visual Studio.
2. Build the project.
3. Run the application.
4. Follow the console prompts to:
   - Enter numbers for Merge Sort.
   - Enter a string for Reverse Vowels.
   - Enter two strings for Anagram Checker.

## Sample Output

### Merge Sort

Input

```text
5 2 9 1
```

Output

```text
1, 2, 5, 9
```

### Reverse Vowels

Input

```text
hello
```

Output

```text
holle
```

### Anagram Checker

Input

```text
anagram
nagaram
```

Output

```text
true
```

## What This Project Shows

This project showcases my ability to write organized, beginner-to-intermediate C# code with a focus on algorithmic thinking, readability, and problem decomposition. It also reflects my MSSA training in foundational software development concepts such as recursion, string processing, array operations, and clean separation of concerns across classes.

## Next Improvements

Planned enhancements for future iterations:

- Add input validation for invalid or empty console entries.
- Support punctuation and whitespace handling in the anagram checker.
- Add unit tests for each algorithm.
- Improve console formatting for a cleaner user experience.
- Refactor repeated logic into helper methods where appropriate.

## Version

v1.0.0

Initial release featuring three complete algorithm implementations with documentation and console-based execution flow.

## License

MIT License
