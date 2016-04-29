<img src="https://raw.githubusercontent.com/TelerikAcademy/Common/master/logos/telerik-header-logo.png" />

#### _Telerik Academy Season 2016-2017 / C# Fundamentals Exam - 26 April 2016_

# Task 5: Conductors

## Description

Do you know that the new price for a public transport ticket in Sofia is **1.60**lv? Because of that, a lot of people try to cheat and reuse an already perforated ticket. So the 
honorable order of the **Conductors** decided that they need binary tickets that will be perforated via software. Little did they know that good programmers don't like to pay **1.60**lv 
and can cheat their new system. 

A binary ticket **N** is represented by the bits of a 32-bit integer. Each conductor has a perforating device, which is represented by the bits of another 32-bit integer **P**. The device with number **P** perforates 
the ticket **N** by replacing all bits occurrences of the bits of **P** in **N**'s bits with **0**s, starting from right to left. This means that the rightmost occurrence is replaced first, than the new rightmost and so on.

1. Let **N** = 469 and **P** = 5, then **N** = 111010101 and **P** = 101 in binary numeral system
1. The device searches for the rightmost occurrence of the bits of **P** in the bits of **N** - 111010**101**
1. The device sets the matching bits to 0 and **N** becomes 111010**000**
1. The device then searching again for occurrence of the bits of **P** in **N**'s bits - 11**101**0000
1. The device sets the matching bits to 0 and **N** becomes 11**000**0000 - 384
1. There are no more matching bits in **N**, therefore the device won't perforate **N** anymore

**Pezo** is not a good programmer, but he is a **gratischia**, who happens to know about this trick. **Pezo** wants you to write a program that simulates the process for him. He will give you 
a perforating device **P** as a number. Then he will provide you with exactly **M** tickets which you should perforate as described above. After perforating a ticket completely, print it on the console.

## Input
- On the first line, you will receive the number **P**.
- On the second line, you will receive the number **M**.
- On each of the next **M** lines, you will receive a single integer value - a ticket for perforating.

## Output
- For every input ticket, print the result of the perforation.

## Constraints
- **All** input numbers will be valid positive 32-bit integer(i.e. _int_ type).
- The input will always be valid and in the described format. There is no need to validate it explicitly.
- Memory limit: **24MB**
- Time limit: **0.16s**

## Sample tests

|               Input                  |       Output      |                                                                    Explanation                                                                                  |
|--------------------------------------|-------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|
| 5<br>2<br>469<br>13                  | 384<br>8          | 469 is described in the example. 13 in binary is 1101. The first 3 bits <br>of 13 match the bits of 5, therefore they get perforated, leaving only the 4th bit. |
| 3<br>4<br>15<br>14<br>13<br>7        | 0<br>8<br>1<br>4  | **P** = 3 = 11(bin). <br>15 = 1111 -> 1100 -> 0000 -> 0<br>14 = 1110 -> 1000 -> 8<br>13 = 1101 -> 0001 -> 1<br>7 = 111 -> 100 -> 4                              |
| 2<br>2<br>1<br>10                    | 1<br>0            | **P** = 2 = 10(bin). <br>1 = 1 -> 1 -> 1<br>10 = 1010 -> 1000 -> 0 -> 0                                                                                         |