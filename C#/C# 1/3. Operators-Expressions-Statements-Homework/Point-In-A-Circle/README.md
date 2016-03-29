# Point in a circle

## Description
Write a program that reads the coordinates of a point **x** and **y** 
and using an expression checks if given point **(x,  y)** is inside a circle `K({0, 0}, 2)` - the center has coordinates **(0, 0)** and the circle has radius **2**. 
The program should then print **"yes DISTANCE"** if the point is inside the circle or **"no DISTANCE"** if the point is outside the circle.
  - In place of **DISTANCE** print the distance from the beginning of the coordinate system - **(0, 0)** - to the given point.

## Input
- You will receive exactly two lines, the first containing the **x** coordinate, the second containing the **y** coordinate.

## Output
- Output a single line in the format described above. The distance should be always printed with _2-digit precision_ after the floating point.

## Constraints
- The numbers **x** and **y** will always be valid floating point numbers in the range `(-1000, 1000)`
- Time limit: **0.1s**
- Memory limit: **8MB**

## Sample tests

|     Input      |    Output     |
|----------------|---------------|
|0<br/>1         |true           |
|-2<br/>0        |true           |
|-1<br/>2        |false          |
|1.5<br/>-1      |true           |
|-1.5<br/>-1.5   |false  |
|100<br/>-30     |false  |
|0<br/>0         |true   |
|0.2<br/>-0.8    |true   |
|0.9<br/>-1.93   |false  |
|1<br/>1.655     |true   |

## Submission
- Submit your code [here](http://bgcoder.com/Contests/Compete/Index/310#6)
