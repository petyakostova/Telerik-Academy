# Arithmetical expressions

## Description
Write a program that calculates the value of given arithmetical expression.

The expression can contain the following elements only:
- Real numbers, e.g. `5`, `18.33`, `3.14159`, `12.6`
- Arithmetic operators: `+`, `-`, `*`, `/` (standard priorities)
- Mathematical functions: `ln(x)`, `sqrt(x)`, `pow(x,y)`
- Brackets (for changing the default priorities): `(`, `)`

## Input
- On the only line you will receive an expression

## Output
- Print the result of the expression

## Constraints
- The size of the expression will not be more than 10000 symbols
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input                                              | Output |
|:---------------------------------------------------|:-------|
| (3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)            | ~10.6  |
| pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3) | ~21.22 |

_Hint: Use the classical [Shunting-yard algorithm](http://en.wikipedia.org/wiki/Shunting-yard_algorithm) and [Reverse Polish notation](http://en.wikipedia.org/wiki/Reverse_Polish_notation)._

## Submission
- You do not have to submit anything for this problem
