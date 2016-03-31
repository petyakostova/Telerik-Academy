# Company info

## Description
*	A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
*	Write a program that reads the information about a company and its manager and prints it back on the console.

|       info          |            input           |
|---------------------|----------------------------|
| Company name:       | Telerik Academy            |
| Company address:    | 31 Al. Malinov, Sofia      |
| Phone number:       | +359 888 55 55 555         |
| Fax number:         |                            |
| Web site:           | http://telerikacademy.com/ |
| Manager first name: | Nikolay                    |
| Manager last name:  | Kostov                     |
| Manager age:        | 25                         |
| Manager phone:      | +359 2 981 981             |

## Input
- You will each piece of information about the company on a separate line, in the same order as in the example
  1. Company name
  1. Company address
  1. Phone number
  1. Fax number
  1. Web site
  1. Manager first name
  1. Manager last name
  1. Manager age
  1. Manager phone

## Output
- Print the information the same way as shown in the sample test. Make sure that you print "(no fax)" if an empty line is passed as fax number.

## Constraints
- The input will always be in the described format
- Only the fax number field can be empty, all other fields will have be least one symbol
- Time limit: **0.1s**
- Memory limit: **8MB**

## Sample tests

|            input           |output|
|----------------------------|------|
| Telerik Academy<br />31 Al. Malinov, Sofia<br />+359 888 55 55 555<br /><br />http://telerikacademy.com/<br />Nikolay<br />Kostov<br />25<br />+359 2 981 981|Telerik Academy<br />Address: 31 Al. Malinov, Sofia<br />Tel. +359 888 55 55 555<br />Fax: (no fax)<br />Web site: http://telerikacademy.com/<br />Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)|

## Submission
- Submit your code [here](http://bgcoder.com/Contests/Compete/Index/311#1)
