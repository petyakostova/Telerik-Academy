# Four digits

## Description
Write a program that takes as input a four-digit number in format **abcd** (e.g. **2011**) and performs the following:
  1. Calculates the sum of the digits (in our example `2 + 0 + 1 + 1 = 4`) and prints it on the console.
  1. Prints on the console the number in reversed order: **dcba** (in our example **1102**) and prints the reversed number.
  1. Puts the last digit in the first position: **dabc** (in our example **1201**) and prints the result.
  1. Exchanges the second and the third digits: **acbd** (in our example **2101**) and prints the result.

## Input
- The input will consist of a single four-digit integer number on a single line.

## Output
- Output the result of each action on a separate line, in the same order as they are explained above:
  - meaning the **sum** comes on the first line, the **reversed** number on the second, and so on.

## Constraints
- The number will always be a valid positiv four-digit integer.
- The number will always start with a digit other than **0**.
- Time limit: **0.1s**
- Memory limit: **8MB**

## Sample tests

|     Input      |             Output          |
|----------------|-----------------------------|
|2011            |4<br/>1102<br/>1201<br/>2101 |
|3333            |12<br/>3333<br/>3333<br/>3333|
|9876            |30<br/>6789<br/>6987<br/>9786|
|1230            |6<br/>321<br/>123<br/>1320   |

## Submission
- Submit your code [here](http://bgcoder.com/Contests/Compete/Index/310#5)
