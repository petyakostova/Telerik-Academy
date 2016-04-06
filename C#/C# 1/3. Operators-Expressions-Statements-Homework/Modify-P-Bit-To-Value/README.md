# Modify Bit

## Description
We are given an integer number **N** (read from the console), a bit value **v** (read from the console as well) (v = 0 or 1) and a position **P** (read from the console). 
Write a sequence of operators (a few lines of C# code) that modifies **N** to hold the value 
**v** at the position **P** from the binary representation of **N** while preserving all other bits in **N**. Print the resulting number on the console.

## Input
- The input will consist of exactly **3** lines containing the following:
  1. First line - the integer number **N**.
  1. Second line - the position **P**.
  1. Third line - the bit value **v**.

## Output
- Output a single line containing the value of the number **N** with the modified bit.

## Constraints
- **N** will always be a valid 64-bit **unsigned** integer.
- **P** will always be between in the range `[0, 64)`.
- **v** will be always either 0 or 1.
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

|     Input          | Binary representation | Modified value    |    Output      |
|--------------------|-----------------------|-------------------|----------------|
| 5    <br/>2 <br/>0 | 00000000 00000101     | 00000000 00000001 | 1              |
| 0    <br/>9 <br/>1 | 00000000 00000000     | 00000010 00000000 | 512            |
| 15   <br/>1 <br/>1 | 00000000 00001111     | 00000000 00001111 | 15             |
| 5343 <br/>7 <br/>0 | 00010100 11011111     | 00010100 01011111 | 5215           |
| 62241<br/>11<br/>0 | 11110011 00100001     | 11110011 00100001 | 62241          |

## Submission
- Submit your code [here](http://bgcoder.com/Contests/Compete/Index/310#12)
