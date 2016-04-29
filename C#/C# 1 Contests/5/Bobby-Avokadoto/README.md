<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />
#### _Telerik Academy Season 2016-2017 / C# Fundamentals Exam - 26 April 2016_

# Bobi Avokadoto

## Description

**Bobi Avokadoto** loves to comb his hair(and to buy new combs). Bobi's head is represented by an integer **N**. All **C** combs that he can buy are also represented as integers. Bobi can use a comb only if 
his head and the comb don't have any overlapping set(**1**) bits(the **1**s in **N** represent hairs and **0**s represent bald spots and the **1**s in a comb represent the comb's teeth). The best comb 
for Bobi is the comb with most teeth(bits set to **1**) that he can use. Write a program that finds the best comb for Bobi by given **N** and combs, and prints it on the console.

_Example_: let **N** be 17 and the combs be 14, 2, 19 and 10
```
17 is 10001 - Bobi's head
14 is  1110 - comb - Bobi can use 14, because no bits overlap.
2  is    10 - comb - Bobi can use 2, because no bits overlap.
19 is 10011 - comb - Bobi can't use 19, because there are overlapping bits.
```

## Input
- On the first line, you will receive the number **N**.
- On the second line, you will receive the number of combs **C**.
- On each of the next **C** lines, you will receive a single integer representing a comb.

## Output
- On the only output line, print the integer representing the best comb for Bobi.

## Constraints
- All combs and Bobi's head will be valid 32-bit **unsigned** integer numbers integers.
- The input will always be valid and in the described format. There is no need to check it explicitly.
- There will always be at least one comb that Bobi can use. If there are multiple best combs that Bobi can use with the same number of teeth, print the first you read from the console.
- The numbers of combs will never be more than **90000**.
- Time limit: 0.07s
- Memory limit: 16MB

|           Input            |          Output           |
|----------------------------|---------------------------|
| 17<br>3<br>14<br>2<br>17   | 14                        |
| 0<br>2<br>5<br>1024        | 5                         |
| 9<br>4<br>1<br>2<br>3<br>6 | 6                         |
| 2344<br>2<br>23<br>15      | 23                        |
