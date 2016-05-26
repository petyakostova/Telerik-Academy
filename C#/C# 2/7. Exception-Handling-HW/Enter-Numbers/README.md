# Enter numbers

## Description
Write a method `ReadNumber(int start, int end)` that enters an integer number in a given range `( start, end )`.
  - If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters `10` numbers:	`a1, a2, ..., a10`, such that `0 < a1 < ... < a10 < 100`

## Input
- You will receive 10 lines of input, each consisted of an integer number
  - `a1`
  - `a2`
  - `...`
  - `a10`

## Output
- Print `0 < a1 < ... < a10 < 100`
  - Or `Exception` if the above inequality is not true

## Constraints
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input  | Output |
|:------:|:------:|
| 5<br>7<br>15<br>29<br>46<br>47<br>60<br>70<br>89<br>98 | 0 < 5 < 7 < 15 < 29 < 46 < 47 < 60 < 70 < 89 < 98 < 100 |
| 87<br>10<br>29<br>28<br>43<br>58<br>95<br>41<br>2<br>46 | Exception |
| 5<br>11<br>20<br>27<br>49<br>41<br>52<br>81<br>89<br>99 | Exception |

## Submission
- Submit your code [here](http://bgcoder.com/Contests/Compete/Index/321#1)
