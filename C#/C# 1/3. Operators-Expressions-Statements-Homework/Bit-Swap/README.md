# BitSwap

## Description
Write a program first reads 3 numbers **n**, **p**, **q** and **k** and than swaps bits
 `{p, p+1, …, p+k-1}` with bits `{q, q+1, …, q+k-1}` of **n**. 
 Print the resulting integer on the console.


## Input
- On the only four lines of the input you will receive the integers **n**, **p**, **q** and **k** in this order.

## Output
- Output a single value - the value of **n** after the bit swaps.

## Constraints
- The first and the second sequence of bits will never overlap.
- **n** will always be a valid 32-bit positive integer.
- Time limit: **0.1s**
- Memory limit: **8MB**

## Sample tests

|     Input                     |     Binary representation          |  Binary representation after swaps |   Output    |
|-------------------------------|------------------------------------|------------------------------------|-------------|
|1140867093<br/>3<br/>24<br/>3  |01000100 00000000 01000000 00010101 |01000010 00000000 01000000 00100101 |1107312677   |
|4294901775<br/>24<br/>3<br/>3  |11111111 11111111 00000000 00001111 |11111001 11111111 00000000 00111111 |4194238527   |
|2369124121<br/>2<br/>22<br/>10 |10001101 00110101 11110111 00011001 |01110001 10110101 11111000 11010001 |1907751121   |

## Submission
- Submit your code [here](http://bgcoder.com/Contests/Compete/Index/310#14)
