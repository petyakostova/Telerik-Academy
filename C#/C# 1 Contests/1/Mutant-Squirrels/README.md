<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2016-2017 / C# Fundamentals Exam - 25 April 2016_

# Task 1: Mutant Squirrels

## Description

Imagine that you are some kind of a weird **forester**. You have a boss that every second day of the workweek makes you work 12 hour night shifts. Your task as a forester is to keep track of everything that is happening out there in the wild. Your work area has been contaminated with radiation that leaked from the nearby Nuclear power plant. You are not happy from that fact, but you deal with it, because they pay you good money. Since the radiation poisoning did some damage to the animal wildlife and some anomalies are occurring, your boss assigned you a task to **count the number of squirrel tails** (let's be honest, he doesn't like you at all, so he always gives you crappy tasks). Be careful, the radiation caused mutation on some of the squirrels that were close to the Nuclear power plant.

So, you are feeling optimistic about the job. It's a simple task, nothing can go wrong. It's starting to get dark and you are already headed for the mission. You are walking in the shady forest and you notice a perfectly normal squirrel - one head, two eyes, four legs, one tail. You keep walking and **sh*t get serious**. You just saw a squirrel with 10 tails, walking on two legs, playing basketball, with her eyes closed.

![Squirrel](imgs/squirrel.jpg)

Enough with the sweet talks. **Your task is to count the total number of squirrel tails in the forest** and send the results back to your boss, but since you don't like him, and you're about to quit because of what you saw that night - you will forge the results using some **magic numbers**. If the **total tails count** is an **even number** - you will **multiply the result by 376439**. If the total tails count is an **odd number** - you will **divide the result by 7**.

## Input

The input data should be read from the console.  
On the **first console line** you will receive a number **T**, that represents the number of trees in the forest.
On the **second console line** you will receive a number **B**, that represents the number of branches on each tree.  
On the **third console line** you will receive a number **S**, that represents the number of squirrels on each branch.  
On the **fourth and last console line** you will receive a number **N**, that represents the average number of tails for each squirrel.  
The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

The output data should be printed on the console.  
On the only output line, print the **forged total tails count, with precision 3 digits after the decimal point.**

## Constraints
- **T** will be a positive integer between **1** and **100000** inclusive.
- **B** will be a positive integer between **3** and **5000** inclusive.
- **S** will be a positive integer between **5** and **800** inclusive
- **N** will be a positive integer between **1** and **100** inclusive.
- Allowed memory: **16 MiB**
- Allowed working time for your program: **0.1 seconds**

## Examples

### Input
```
5
3
5
1
```

### Output
```
10.714
```

### Explanation
```
5*3*5*1 => 75 tails
75 is odd, so we divide it by 7
final result => 75/7 => 10.714
```

### Input
```
10
10
10
10
```

### Output
```
3764390000.000
```

### Explanation
```
10*10*10*10 = 10000 tails
10000 is even, so we multiply it by 376439
final result => 10000*376439 => 3764390000.000
```

### Input
```
703
7
21
3
```

### Output
```
44289.000
```

### Explanation
```
703*7*21*3 => 310023 tails
310023 is odd, so we divide it by 7
final result => 310023/7 => 44289.000
```
