<!-- section start -->
<!-- attr: { class:'slide-title', showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
# Conditional Statements
## Implementing Control Logic in C*#*
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic01.png" style="top:45%; left:6.55%; width:20.83%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic03.png" style="top:56%; left:50%; width:40%; z-index:-1; border-radius: 15px" /> -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic04.png" style="top:12.06%; left:6.55%; width:15.07%; z-index:-1; border-radius: 15px" /> -->




<!-- section start -->
<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
# Table of Contents
- [Comparison and Logical Operators](#/operators)
- [The `if` Statement](#/if)
- [The `if-else` Statement](#/ifelse)
- [Nested `if` Statements](#/nestedif)
- [The `switch-case` Statement](#/switch)

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic05.png" style="top:25.56%; left:77.66%; width:25.56%; z-index:-1; border-radius: 15px; border: 3px solid yellowgreen" /> -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic06.png" style="top:55%; left:5%; width:30%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
<!-- # Comparison and Logical Operators -->

<!-- attr: { id:'operators', showInPresentation:true, hasScriptWrapper:false, style:'font-size: 38px' } -->
# <a id="operators"></a>Comparison Operators
| Operator      | C# Notation   |
| ------------- |:-------------:|
| Equals        | `==`          |
| Not Equals    | `!=`          |
| Greater than  | `>`           |
| Greater than or equal | `>=`  |
| Less than     | `<`           |
| Less than or equal | `<=`     |

- _Example_:

```cs
bool result = 5 <= 6;
Console.WriteLine(result); // outputs True
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
# Logical Operators
| **Logical Operator**      | C# Notation   |
| ------------------------- |:-------------:|
| **AND**                   | `&&`          |
| **NOT**                   | `!`           |
| **OR**                    | <code>&#124;&#124;</code> |
| **XOR (Exclusive OR)**    | `^`           |

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
# De Morgan Laws
- De Morgan laws
  - `!!A` equals `A`
  - `!(A || B)` equals `!A && !B`
  - `!(A && B)` equals `!A || !B`

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic08.png" style="top:55.54%; left:60%; width:32.94%; z-index:-1" /> -->

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
<!-- # `if` and `if-else`
## Implementing Conditional Logic -->


<!-- attr: { id:'if', showInPresentation:true, hasScriptWrapper:false, style:'font-size: 42px' } -->
# <a id="if"></a>The `if` Statement
- The most simple conditional statement
- Enables you to test for a condition
- Branch to different parts of the code depending on the result
- The simplest form of an `if` statement:

```cs
if (condition)
{
    statements;
}
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
# Condition and Statement
- The condition can be:
  - Boolean variable
  - Boolean logical expression
  - Comparison expression
- The condition cannot be integer variable (like in C / C++ or JavaScript)
- The statement can be:
  - Single statement ending with a semicolon
  - Block enclosed in braces

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic10.png" style="top:13.22%; left:81.46%; width:24.64%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 42px' } -->
# How It Works?
- The condition is evaluated
  - If it is `true`, the statement is executed
  - If it is `false`, the statement is skipped

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/block-schema.png" style="top:35%; left:20%; width:55%; z-index:-1" /> -->

<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 42px' } -->
# The `if` Statement – _Example_

```cs
static void Main()
{
    Console.WriteLine("Enter two numbers.");

    int biggerNumber = int.Parse(Console.ReadLine());
    int smallerNumber = int.Parse(Console.ReadLine());

    // condition
    if (smallerNumber > biggerNumber)
    {
        // statement
        biggerNumber = smallerNumber;
    }

    Console.WriteLine("The greater number is: {0}",
                                        biggerNumber);
}
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
<!-- # The `if` Statement -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/05.%20Conditional-Statements/demos/IfStatementExample)

<!-- attr: { id:'ifelse', showInPresentation:true, hasScriptWrapper:false, style:'font-size: 42px' } -->
# <a id="ifelse"></a>The `if-else` Statement
- More complex and useful conditional statement
- Executes one branch if the condition is `true`, and another if it is `false`
- The simplest form of an `if-else` statement:

```cs
if (expression)
{
    statement1;
}
else
{
    statement2;
}
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 42px' } -->
# How It Works ?
- The condition is evaluated
  - If it is `true`, the first statement is executed
  - If it is `false`, the second statement is executed

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/if-else-block-schema.png" style="top:35%; left:15%; width:70%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 42px' } -->
# `if-else` Statement – _Example_
- Checking a number if it is odd or even

```cs
string s = Console.ReadLine();
int number = int.Parse(s);

if (number % 2 == 0)
{
    Console.WriteLine("This number is even.");
}
else
{
    Console.WriteLine("This number is odd.");
}
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
<!-- # The `if-else` Statement -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/05.%20Conditional-Statements/demos/IfElseStatement)

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
<!-- # Nested `if` Statements
## Creating More Complex Logic -->

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic15.png" style="top:55%; left:27.5%; width:45%; z-index:-1" /> -->


<!-- attr: { id:'nestedif', showInPresentation:true, hasScriptWrapper:false, style:'font-size: 42px' } -->
# <a id="nestedif"></a>Nested `if` Statements
- `if` and `if-else` statements can be `nested`, i.e. used inside another `if` or `else` statement
- Every `else` corresponds to its closest preceding `if`

```cs
if (expression)
{
    if (expression)
    {
        statement;
    }
    else
    {
        statement;
    }
}
else
    statement;
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 42px' } -->
# Nested `if` – Good Practices
- Always use `{ … }` blocks to avoid ambiguity
  - Even when a single statement follows
- Avoid using more than three levels of nested `if` statements
- Put the case you normally expect to process first, then write the unusual cases
- Arrange the code to make it more readable


<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 42px' } -->
# Nested `if` Statements – _Example_

```cs
if (first == second)
{
    Console.WriteLine(
        "These two numbers are equal.");
}
else
{
    if (first > second)
    {
        Console.WriteLine(
            "The first number is bigger.");
    }
    else
    {
        Console.WriteLine("The second is bigger.");
    }
}
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
<!-- # Nested `if` Statements -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/05.%20Conditional-Statements/demos/NestedIf)

<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 42px' } -->
# Multiple `if-else-if-else-…`
- Sometimes we need to use another `if`-construction in the `else` block
  - Thus `else if` can be used:

```cs
int ch = 'X';
if (ch == 'A' || ch == 'a')
{
    Console.WriteLine("Vowel [ei]");
}
else if (ch == 'E' || ch == 'e')
{
    Console.WriteLine("Vowel [i:]");
}
else if  …
else …
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
<!-- # Multiple `if-else` Statements -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/05.%20Conditional-Statements/demos/MultipleIfElse)

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic17.png" style="top:52%; left:30%; width:40%; z-index:-1" /> -->

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
<!-- # Switch-case
## Making Several Comparisons at Once -->

<!-- attr: { id:'switch', showInPresentation:true, hasScriptWrapper:false, style:'font-size: 42px' } -->
# <a id="switch"></a>The `switch-case` Statement
- Selects for execution a statement from a list depending on the value of the `switch` expression

```cs
switch (day)
{
	case 1: Console.WriteLine("Monday"); break;
	case 2: Console.WriteLine("Tuesday"); break;
	case 3: Console.WriteLine("Wednesday"); break;
	case 4: Console.WriteLine("Thursday"); break;
	case 5: Console.WriteLine("Friday"); break;
	case 6: Console.WriteLine("Saturday"); break;
	case 7: Console.WriteLine("Sunday"); break;
	default: Console.WriteLine("Error!"); break;
}
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 42px' } -->
# How `switch-case` Works?
- The expression is evaluated
- When one of the constants specified in a case label is equal to the expression
  - The statement that corresponds to that `case` is executed
- If no `case` is equal to the expression
  - If there is `default` case, it is executed
  - Otherwise the control is transferred to the end point of the `switch` statement


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
<!-- # The `switch-case` Statement -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/05.%20Conditional-Statements/demos/SwitchStatement)


<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 42px' } -->
# Using `switch`: Rules
- Variables types like `string`, `enum` and integral types can be used for `switch` expression
- The value `null` is permitted as a case label constant
- The keyword `break` exits the switch statement
- "No fall through" rule – you are obligated to use `break` after each case  
- Multiple labels that correspond to the same statement are permitted


<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 42px' } -->
# Multiple Labels – _Example_

```cs
switch (animal)
{
    case "dog" :
        Console.WriteLine("MAMMAL");
        break;
    case "crocodile" :
    case "tortoise" :
    case "snake" :
        Console.WriteLine("REPTILE");
        break;
    default :
        Console.WriteLine("There is no such animal!");
        break;
}
```

- You can use multiple labels to execute the same statement in more than one case


<!-- section start -->
<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
<!-- # Multiple Labels in a `switch-case` -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/05.%20Conditional-Statements/demos/MultipleLabels)

<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 42px' } -->
# Using `switch` – Good Practices
- There must be a separate `case` for every normal situation
- Put the normal case first
  - Put the most frequently executed cases first and the least frequently executed last
- Order cases alphabetically or numerically
- In `default` use case that cannot be reached under normal circumstances


<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 42px' } -->
# Summary
- Comparison and logical operators are used to compose logical conditions
- The conditional statements `if` and `if-else` provide conditional execution of blocks of code
  - Constantly used in computer programming
  - Conditional statements can be nested
- The `switch` statement easily and elegantly checks an expression for a sequence of values


<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:false, style:'font-size: 42px' } -->
<!-- # Conditional Statements
## Questions? -->

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/q3.png" style="top:43.21%; left:82.34%; width:19.97%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/q1.png" style="top:55%; left:42.10%; width:24.25%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/q2.png" style="top:43.20%; left:8.19%; width:23.14%; z-index:-1" /> -->

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Free Trainings @ Telerik Academy
- Fundamentals of C# Programming Track of Courses
    - [csharpfundamentals.telerik.com](csharpfundamentals.telerik.com)
  - Telerik Software Academy
    - [telerikacademy.com](https://telerikacademy.com)
  - Telerik Academy @ Facebook
    - [facebook.com/TelerikAcademy](https://facebook.com/TelerikAcademy)
  - Telerik Academy Learning System
    - [telerikacademy.com](https://telerikacademy.com)
