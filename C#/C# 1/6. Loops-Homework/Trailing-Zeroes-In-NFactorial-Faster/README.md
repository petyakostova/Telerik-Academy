## Explanation of Trailing Zeroes in N!

The simple method (first calculate factorial of number, then count trailing 0s in the result) can cause overflow for a slightly bigger numbers as factorial of a number is a big number. 

The idea is to consider prime factors of a factorial n. A trailing zero is always produced by prime factors 2 and 5. If we can count the number of 5s and 2s, our task is done. We can easily observe that the number of 2s in prime factors is always more than or equal to the number of 5s. So if we count 5s in prime factors, we are done. 

### How to count total number of 5s in prime factors of n!? 

A simple way is to calculate floor(n/5). For example, 7! has one 5; 10! has two 5s. But there is one more thing to consider. Numbers like 25, 125, etc have more than one 5. For example if we consider 28!, we get one extra 5 and number of 0s become 6. 

Handling this is simple, first divide n by 5 and remove all single 5s, then divide by 25 to remove extra 5s and so on. Following is the summarized formula for counting trailing 0s.

### Trailing 0s in N! = Count of 5s in prime factors of N! = 
###                  `= Floor(n/5) + Floor(n/25) + Floor(n/125) + ....`