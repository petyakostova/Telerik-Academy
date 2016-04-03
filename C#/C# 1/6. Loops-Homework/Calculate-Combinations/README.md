# Calculate 3!

## Description
In combinatorics, the number of ways to choose **N** different members out of a group of **N** different elements 
(also known as the number of combinations) is calculated by the following formula:
<img src="https://cloud.githubusercontent.com/assets/3619393/5626060/89cc780e-958e-11e4-88d2-0e1ff7229768.png" alt="formula" style="width: 7%"/>
For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates `N! / (K! * (N - K)!)` for given **N** and **K**. 
  - _Try to use only two loops._

## Input
- On the first line, there will be only one number - **N**
- On the second line, there will also be only one number - **K**

## Output
- On the only output line, write the result of the calculation for the provided **N** and **K**

## Constraints
- 1 < **K** < **N** < 100
  - _Hint: overflow is possible_
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

|     Input      |     Output     |
|----------------|----------------|
| 3 <br/>2       | 3              |
| 4 <br/>2       | 6              |
| 10<br/>6       | 210            |
| 52<br/>5       | 2598960        |

## Submission
- Submit your code [here](http://bgcoder.com/Contests/Compete/Index/312#6)
