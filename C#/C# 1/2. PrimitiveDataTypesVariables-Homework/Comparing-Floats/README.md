# Comparing Floats

## Description
Write a program that safely compares two floating-point numbers (double) with precision `eps = 0.000001`.

_Note: Two floating-point numbers `a` and `b` cannot be compared directly by `a == b` because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant `eps`._

## Input
- On the first line you will receive the first floating-point number
- On the second line you will receive the second floating-point number

_Hint: Use double.Parse(Console.ReadLine()) to read input_

## Output
- Print `true` if the numbers are equal or `false` if they are not

## Constraints
- Time limit: **0.1s**
- Memory limit: **8MB**

## Sample tests

| Input                    | Output (with precision `eps=0.000001`) |                                       Explanation                                     |
|:------------------------:|:--------------------------------------:|:-------------------------------------------------------------------------------------:|
| 5.3<br>6.01              |    false                               | The difference of 0.71 is too big (> eps)                                             |
| 5.00000001<br>5.00000003 |    true                                | The difference `0.00000002 < eps`                                                     |
| 5.00000005<br>5.00000001 |    true                                | The difference `0.00000004 < eps`                                                     |
| -0.0000007<br>0.00000007 |    true                                | The difference `0.00000077 < eps`                                                     |
| -4.999999<br>-4.999998   |    false                               | Border case. The difference `0.000001 == eps`. We consider the numbers are different. |
| 4.999999<br>4.999998     |    false                               | Border case. The difference `0.000001 == eps`. We consider the numbers are different. |

## Submission
- Submit your code [here](http://bgcoder.com/Contests/Compete/Index/313#1)
