# Replace tags

## Description
Write a program that replaces in a HTML document given as string all the tags `<a href="URL">TEXT</a>` with corresponding markdown notation `[TEXT](URL)`.

## Input
- On the only input line you will receive a string

## Output
- Print the string with replaced tags

## Constraints
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:------|:-------|
| `<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>` | `<p>Please visit [our site](http://academy.telerik.com) to choose a training course. Also visit [our forum](www.devbg.org) to discuss the courses.</p>` |

## Submission
- Submit your code [here](http://bgcoder.com/Contests/Compete/Index/320#8)
