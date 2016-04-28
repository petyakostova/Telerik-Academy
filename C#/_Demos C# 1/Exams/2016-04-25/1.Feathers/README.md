<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2016-2017 / C# Fundamentals Exam - 25 April 2016_

# Task 1: Birds and Feathers

## Description

Look at the back of the hall. On the first 3 glass windows(right-to-left) you have the solution of the first task. Grab a pen and paper as fast as you can and go take it.

Okay, done playing games?  
Fine.

You probably didn't find any solutions but you might have saw that the weather outside is pretty warm and sunny. Imagine that you weren't having an exam at this moment, and you were taking a walk in your favorite park. A lot of trees surround you. You hear a bird singing. This is the most miraculous song you have ever heard! You look up and you see tons of birds sitting on the branches, whistling. We all know you are weird as hell, the lights are on but nobody is home, so you start counting the birds in the park. You're obsessed with this task, and for your surprise - at the end of the park, you notice a sign that actually shows the total number of **feathers** of all birds in the park (what? how did they count that). You see another sign, which says - "The person who guesses what is the average feathers count per bird will win a prize of (**continuing his education at the Academy**)". Wow, ain't that a day? You've got all the data required to do an accurate calculation and win the prize.

![Bird](imgs/bird.jpg)

Since this ain't a walking park, let's make it more interesting - **Your task is to find the average feathers count per bird and apply some more calculations** on the result. If the **birds count** is an **even** number - **multiply** the result by the magic number **123123123123**, if the birds count is an **odd** number - **divide** the result by the magic number **317**.

## Input

The input data should be read from the console.  
On the **first console line** you will receive a number **B**, that represents the number of birds in the forest.
On the **second console line** you will receive a number **F**, that represents the total number of bird feathers in the forest.
The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

The output data should be printed on the console.  
On the only output line, print the **average feathers count per bird, modified by the extra given conditions** with **4 digits precision** after the decimal point.

## Constraints
- **B** will be a positive integer between **0** and **80000** inclusive.
- **F** will be a positive integer between **0** and **2000000000** inclusive.
- Allowed memory: **16 MiB**
- Allowed working time for your program: **0.1 seconds**

## Examples

### Input
```
3
125
```

### Output
```
0.1314
```

### Explanation
```
We have 125 feathers and 3 birds, so the average is 41.666666666667 (feathers per bird)
3 is odd, so we divide it by 317
Final result => 41.666666666667/317 => 0.1314
```

### Input
```
1000
450
```

### Output
```
55405405405.3500
```

### Explanation
```
We have 450 feathers and 1000 birds, so the average is 0.45 (feathers per bird)
1000 is even, so we multiply it by 123123123123
Final result => 0.45*123123123123 => 55405405405.3500
```

### Input
```
5000
12425
```

### Output
```
305960960960.6550
```

### Explanation
```
We have 12425 feathers and 5000 birds, so the average is 2.485 (feathers per bird)
5000 is even, so we multiply it by 123123123123
Final result => 2.485*123123123123 => 305960960960.6550
```
### Input
```
1
1
```

### Output
```
0.0032
```

### Explanation
```
We have one feather and one bird, so the average is 1 (feather per bird).
1 is odd, so we divide the result by 317
Final result => 1/317 => 0.0032
```
### Input
```
0
0
```

### Output
```
0.0000
```

### Explanation
```
Since there are no birds and feathers,
the result is always 0, no matter what extra modifications we do to it.
```
