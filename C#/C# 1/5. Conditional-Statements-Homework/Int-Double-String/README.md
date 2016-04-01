# Int, Double, String

## Description
Write a program that, depending on the first line of the input, reads an **int**, **double** or **string** variable.
  - If the variable is **int** or **double**, the program increases it by one.
  - If the variable is a **string**, the program appends **&#42;** at the end.
  - Print the result at the console. Use switch statement.

## Input
- On the first line you will receive the type of input as string in the following form:
  - **integer** for **int**
  - **real** for **double**
  - **text** for **string**
- On the second line you will be given the value of the variable.

## Output
- Write a single line on the console - the value transformed according to the rules from the description.
  - Print all **double** variables with exactly 2-digits precision after the floating point. _Example:_ 0.99
  
## Constraints
- The input will always be valid and in the described format.
- All input numbers will be between -1000 and 1000.
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

|     Input       |     Output      |
|-----------------|-----------------|
| integer<br/>2   | 3               |
| real<br/>-2.5   | -1.50           |
| text<br/>gosho  | gosho*          |

## Submission
- Submit your code [here](http://bgcoder.com/Contests/Compete/Index/309#8)
