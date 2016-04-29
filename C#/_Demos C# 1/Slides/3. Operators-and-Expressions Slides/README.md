<!-- section start -->
<!-- attr: { class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# Operators and Expressions
## Performing Simple Calculations with _C#_
<!-- <img class="slide-image" showInPresentation="true" src="imgs/pic00.png" style="top:40%; left:65%; width:35%; z-index:-1; border-radius:15px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs/pic01.png" style="top:40%; left:25%; width:30%; z-index:-1; border-radius:15px;" /> -->
<div class="signature">
	<p class="signature-course">C# Fundamentals</p>
	<p class="signature-initiative">Telerik Software Academy</p>
	<a href="https://telerikacademy.com" class="signature-link">https://telerikacademy.com</a>
</div>

<!-- section start -->
<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- [Operators in C# and Operator Precedence](#/operators)
- [Arithmetic Operators](#/arithmetic)
- [Logical Operators](#/logical)
- [Bitwise Operators](#/bitwise)
- [Comparison Operators](#/comparison)
- [Assignment Operators](#/assignment)
- [Other Operators](#/other)
- [Implicit and Explicit Type Conversions](#/conversion)
- [Expressions](#/expression)

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic02.png" style="top:24.24%; left:73.92%; width:29.84%; z-index:-1" /> -->

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Operators in _C#_
## Arithmetic, Logical, Comparison, Assignment, Etc. -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic03.png" style="top:65%; left:71.11%; width:20%; z-index:-1; border-radius:15px;" /> -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic04.png" style="top:65%; left:11.23%; width:25%; z-index:-1; border-radius:15px;" /> -->


<!-- attr: { showInPresentation:true } -->
# What is an Operator?
- `Operator` is an operation performed over data at runtime
  - Takes one or more `arguments` (`operands`)
  - Produces a new value
- Operators have `precedence`
  - `Precedence` defines which will be evaluated first
- `Expressions` are sequences of operators and operands that are evaluated to a single value


<!-- attr: { id:'operators', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="operators"></a>Operators in _C#_
- Operators in C# :
  - `Unary` – take one operand
  - `Binary` – take two operands
  - `Ternary` (`?:`) – takes three operands
- Except for the assignment operators, all binary operators are left-associative
- The assignment operators and the conditional operator (`?:`) are right-associative

<!-- <img class="slide-image" showInPresentation="true" src="imgs/pic05.png" style="top:12.34%; left:80%; width:15%; z-index:-1; border-radius:15px;" /> -->

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size: 0.7em' } -->
# Categories of Operators in _C#_

| Category             | Operators                                               |
|:---------------------|:--------------------------------------------------------|
| Arithmetic           | `+ -  * / %  ++ --`                                     |
| Logical              | `&&` <code>&#124;&#124;</code> `^ !`                    |
| Binary               | `&` <code>&#124;</code> `^  ~  << >>`                   |
| Comparison           | `== != < > <= >=`                                       |
| Assignment           | `= += -= *= /= %= &=` <code>&#124;</code>`= ^= <<= >>=` |
| String concatenation | `+`                                                     |
| Type conversion      | `is as typeof`                                          |
| Other                | `. [] () ?: new`                                        |



<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Operators Precedence -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs/pic06.png" style="top:45%; left:32.75%; width:35%; z-index:-1; border-radius:15px;" /> -->

<!-- attr: { showInPresentation:true, style:'font-size: 0.7em' } -->
# Operators Precedence

| Precedence           | Operators                        |
|:---------------------|:---------------------------------|
| Highest              | `()` `.` `[]`                    |
|                      | `++ -- (postfix) new typeof`     |
|                      | `++ -- (prefix) + - (unary) ! ~` |
|                      | `* / %`                          |
|                      | `+ -`                            |
|                      | `<< >>`                          |
|                      | `< > <= >= is as`                |
|                      | `== !=`                          |
| Lower                | `&`                              |

<!-- attr: { showInPresentation:true,hasScriptWrapper:true, style:'font-size: 0.75em' } -->
# Operators Precedence

| Precedence           | Operators                           |
|:---------------------|:------------------------------------|
| Higher               | `^`                                 |
|                      | <code>&#124;</code>                 |
|                      | `&&`                                |
|                      | <code>&#124;&#124;</code>           |
|                      | `?:`                                |
| Lowest               | `= *= /= %= += -= <<= >>= &= ^=` <code>&#124;=</code> |

- Parenthesis operator always has highest precedence
- _Note_: prefer using `parentheses`, even when it seems stupid to do so




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Arithmetic Operators -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic07.png" style="top:45%; left:33%; width:35%; z-index:-1; border-radius:15px;" /> -->


<!-- attr: { id:'arithmetic', showInPresentation:true } -->
# <a id="arithmetic"></a>Arithmetic Operators
- `Arithmetic` operators `+`, `-`, `*` are the same as in math
- `Division` operator `/` if used on integers returns integer (without rounding) or exception
- `Division` operator `/` if used on real numbers returns real number or `Infinity` or `NaN`
- `Remainder` operator `%` returns the remainder from division of integers
- The `special addition` operator `++` increments a variable


<!-- attr: { showInPresentation:true } -->
# Arithmetic Operators – _Example_

```cs
int squarePerimeter = 17;
double squareSide = squarePerimeter / 4.0;
double squareArea = squareSide * squareSide;
Console.WriteLine(squareSide); // 4.25
Console.WriteLine(squareArea); // 18.0625
int a = 5;
int b = 4;
Console.WriteLine( a + b ); // 9
Console.WriteLine( a + b++ ); // 9
Console.WriteLine( a + b ); // 10
Console.WriteLine( a + (++b) ); // 11
Console.WriteLine( a + b ); // 11

Console.WriteLine(12 / 3); // 4
Console.WriteLine(11 / 3); // 3
```



<!-- attr: { showInPresentation:true } -->
<!-- # Arithmetic Operators – _Example_ -->

```cs
Console.WriteLine(11.0 / 3); // 3.666666667
Console.WriteLine(11 / 3.0); // 3.666666667
Console.WriteLine(11 % 3);   // 2
Console.WriteLine(11 % -3);  // 2
Console.WriteLine(-11 % 3);  // -2

Console.WriteLine(1.5 / 0.0);  // Infinity
Console.WriteLine(-1.5 / 0.0); // -Infinity
Console.WriteLine(0.0 / 0.0);  // NaN

int x = 0;
Console.WriteLine(5 / x); // DivideByZeroException
```



<!-- attr: { showInPresentation:true,   } -->
# Arithmetic Operators – Overflow _Examples_

```cs
int bigNum = 2000000000;
int bigSum = 2 * bigNum; // Integer overflow!
Console.WriteLine(bigSum); // -294967296

bigNum = Int32.MaxValue;
bigNum = bigNum + 1;
Console.WriteLine(bigNum); // -2147483648

checked
{
  // This will cause OverflowException
  bigSum = bigNum * 2;
}
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Arithmetic Operators -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/03.%20Operators-and-Expressions/demos/ArithmeticOperators)




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Logical Operators -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic09.png" style="top:42%; left:32%; width:40%; z-index:-1; border-radius:15px;" /> -->


<!-- attr: { id:'logical', showInPresentation:true, hasScriptWrapper: true } -->
# <a id="logical"></a>Logical Operators
- Logical operators take boolean operands and return **boolean** result
- Operator `!` turns `true` to `false` and `false` to `true`
- Behavior of the operators `&&`, `||` and `^` (`1` == `true`, `0` == `false`) :

<!-- attr: { showInPresentation:true, hasScriptWrapper: true } -->
# Logical Operator `||`
|Operation | <code>&#124;&#124;</code>   | <code>&#124;&#124;</code>   | <code>&#124;&#124;</code>   | <code>&#124;&#124;</code>   |
|:---------|:---------------------------:|:---------------------------:|:---------------------------:|:---------------------------:|
| Operand1 | `0`                         | `0`                         | `1`                         | `1`                         |
| Operand2 | `0`                         | `1`                         | `0`                         | `1`                         |
| Result   | `0`                         | `1`                         | `1`                         | `1`                         |

<!-- attr: { showInPresentation:true, hasScriptWrapper: true } -->
# Logical Operator `&&`
|Operation | `&&`    | `&&`    | `&&`    | `&&`    |
|:---------|:-------:|:-------:|:-------:|:-------:|
| Operand1 | `0`     | `0`     | `1`     | `1`     |
| Operand2 | `0`     | `1`     | `0`     | `1`     |
| Result   | `0`     | `0`     | `0`     | `1`     |

<!-- attr: { showInPresentation:true, hasScriptWrapper: true } -->
# Logical Operator `^`
|Operation | `^`     | `^`     | `^`     | `^`     |
|:---------|:-------:|:-------:|:-------:|:-------:|
| Operand1 | `0`     | `0`     | `1`     | `1`     |
| Operand2 | `0`     | `1`     | `0`     | `1`     |
| Result   | `0`     | `1`     | `1`     | `0`     |



<!-- attr: { showInPresentation:true } -->
# Logical Operators – _Example_
- Using the logical operators:

```cs
bool a = true;
bool b = false;
Console.WriteLine(a && b); // False
Console.WriteLine(a || b); // True
Console.WriteLine(a ^ b); // True
Console.WriteLine(!b); // True
Console.WriteLine(b || true); // True
Console.WriteLine(b && true); // False
Console.WriteLine(a || true); // True
Console.WriteLine(a && true); // True
Console.WriteLine(!a); // False
Console.WriteLine((5 > 7) ^ (a == b)); // False
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Logical Operators -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/03.%20Operators-and-Expressions/demos/LogicalOperators)
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic10.png" style="top:45%; left:62%; width:25%; z-index:-1; border-radius:15px;" /> -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic11.png" style="top:45%; left:10.29%; width:28%; z-index:-1; border-radius:15px;" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Bitwise Operators -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic12.png" style="top:45%; left: 35%; width:30%; z-index:-1; border-radius:15px;" /> -->


<!-- attr: { id:'bitwise', showInPresentation:true } -->
# <a id="bitwise"></a>Bitwise Operators
- **Bitwise operator** `~` turns all `0` to `1` and all `1` to `0`
  - Like `!` for boolean expressions but bit by bit
- The operators `|`, `&` and `^` behave like `||`, `&&` and `^` for boolean expressions but bit by bit
- The `<<` and `>>` move the bits (left or right)
- Behavior of the operators `|`, `&` and `^`:

<!-- attr: { showInPresentation:true, hasScriptWrapper: true } -->
# Bitwise Operator `|`
|Operation | <code>&#124;</code>   | <code>&#124;</code>   | <code>&#124;</code>   | <code>&#124;</code>   |
|:---------|:---------------------:|:---------------------:|:---------------------:|:---------------------:|
| Operand1 | `0`                   | `0`                   | `1`                   | `1`                   |
| Operand2 | `0`                   | `1`                   | `0`                   | `1`                   |
| Result   | `0`                   | `1`                   | `1`                   | `1`                   |

<!-- attr: { showInPresentation:true, hasScriptWrapper: true } -->
# Bitwise Operator `&`
|Operation | `&`    | `&`    | `&`    | `&`    |
|:---------|:------:|:------:|:------:|:------:|
| Operand1 | `0`    | `0`    | `1`    | `1`    |
| Operand2 | `0`    | `1`    | `0`    | `1`    |
| Result   | `0`    | `0`    | `0`    | `1`    |

<!-- attr: { showInPresentation:true, hasScriptWrapper: true } -->
# Bitwise Operator `^`
|Operation | `^`     | `^`     | `^`     | `^`     |
|:---------|:-------:|:-------:|:-------:|:-------:|
| Operand1 | `0`     | `0`     | `1`     | `1`     |
| Operand2 | `0`     | `1`     | `0`     | `1`     |
| Result   | `0`     | `1`     | `1`     | `0`     |


<!-- attr: { showInPresentation:true } -->
<!-- # Bitwise Operators -->
- **Bitwise** operators are used on integer numbers (`byte`, `sbyte`, `int`, `uint`, `long`, `ulong`)
- **Bitwise** operators are applied bit by bit
- _Examples_:

```cs
ushort a = 3;                // 00000000 00000011
ushort b = 5;                // 00000000 00000101
Console.WriteLine(a | b);   // 00000000 00000111
Console.WriteLine(a & b);   // 00000000 00000001
Console.WriteLine(a ^ b);   // 00000000 00000110
Console.WriteLine(~a & b);   // 00000000 00000100
Console.WriteLine(a << 1);  // 00000000 00000110
Console.WriteLine(a >> 1);  // 00000000 00000001
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Bitwise Operators – Tips & Tricks
- How to **get the bit** at position `p` in a number `n`?

```cs
int p = 5;
int n = 35;               // 00000000 00100011
int mask = 1 << p;        // 00000000 00100000
int nAndMask = n & mask;  // 00000000 00100000
int bit = nAndMask >> p;  // 00000000 00000001
Console.WriteLine(bit);   // 1
```
<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Bitwise Operators – Tips & Tricks
- How to **set the bit** at position `p` to `0`?

```cs
int p = 5;
int n = 35;                 // 00000000 00100011
int mask = ~(1 << p);       // 11111111 11011111
int result = n & mask;      // 00000000 00000011
Console.WriteLine(result);  // 3
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
<!-- # Bitwise Operators – Tips & Tricks -->
- How to **set the bit** at position `p` to `1`?

```cs
int p = 4;
int n = 35;                 // 00000000 00100011
int mask = 1 << p;          // 00000000 00010000
int result = n | mask;      // 00000000 00110011
Console.WriteLine(result);  // 51
```

- How to **print a binary** number to the console?

```cs
Console.WriteLine(
  Convert.ToString(result, 2).PadLeft(32, '0'));
// 00000000000000000000000000110011
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Bitwise Operators -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/03.%20Operators-and-Expressions/demos/BitwiseOperators)
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic15.png" style="top:45%; left:65%; width:25%; z-index:-1; border-radius: 15px;" /> -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic16.png" style="top:45%; left:9.60%; width:25%; z-index:-1; border-radius: 15px;" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Comparison and Assignment Operators -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic17.png" style="top:55%; left:33%; width:35%; z-index:-1; border-radius: 15px;" /> -->


<!-- attr: { id:'comparison', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="comparison"></a>Comparison Operators
- `Comparison` operators are used to compare variables
  - `==`, `<`, `>`, `>=`, `<=`, `!=`
- `Comparison` operators example:

```cs
int a = 5;
int b = 4;
Console.WriteLine(a >= b); // True
Console.WriteLine(a != b); // True
Console.WriteLine(a == b); // False
Console.WriteLine(a == a); // True
Console.WriteLine(a != ++b); // False
Console.WriteLine(a > b); // False
```

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic18.png" style="top:38.79%; left:75%; width:22.92%; z-index:0; border-radius: 15px;" /> -->


<!-- attr: { id:'assignment', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="assignment"></a>Assignment Operators
- Assignment operators are used to assign a value to a variable ,
  - `=`, `+=`, `-=`, <code>&vert;</code>`=`, ...
- Assignment operators example:

```cs
int x = 6;
int y = 4;
Console.WriteLine(y *= 2); // 8
int z = y = 3; // y=3 and z=3  
Console.WriteLine(z); // 3
Console.WriteLine(x |= 1); // 7
Console.WriteLine(x += 3); // 10
Console.WriteLine(x /= 2); // 5
```

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic19.png" style="top:39.67%; left:75%; width:24.71%; z-index:0; border-radius: 15px;" /> -->


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Comparison and Assignment Operators -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/03.%20Operators-and-Expressions/demos/ComparisonAndAssignmentOperators)

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Other Operators -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic21.png" style="top:45%; left:38%; width:25%; z-index:-1; border-radius: 15px;" /> -->


<!-- attr: { id:'other', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="other"></a>Other Operators
- **String concatenation** operator `+` is used to concatenate strings
- If the second operand is not a string, it is converted to string automatically

```cs
string first = "First";
string second = "Second";
Console.WriteLine(first + second); // FirstSecond
string output = "The number is : ";
int number = 5;
Console.WriteLine(output + number);
// The number is : 5
```

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic22.png" style="top:37.02%; left:80%; width:15%; z-index:0; border-radius: 15px;" /> -->


<!-- attr: { showInPresentation:true } -->
<!-- # Other Operators -->
- Member access operator  `.`  is used to access object members
- Square brackets `[]` are used with arrays indexers and attributes
- Parentheses `(` `)` are used to override the default operator precedence
- Class cast operator `(type)` is used to cast one compatible type to another


<!-- attr: { showInPresentation:true } -->
<!-- # Other Operators -->
- **Conditional** operator `?:` has the form
  - (if `b` is true then the result is `x` else the result is `y`)

```cs
b ? x : y
```

- The `new` operator is used to create new objects
- The `typeof` operator returns `System.Type` object (the reflection of a type)
- The `is` operator checks if an object is compatible with given type



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Other Operators
- **Null-coalescing** operator `??` is used to define a default value for both **nullable** **value** types and **reference** types
  - It returns the left-hand operand if it is not null
    - Otherwise it returns the right operand

```cs
int? x = null;
int y = x ?? -1;
```


```cs
int? x = 1;
int y = x ?? -1;
```

<div class="fragment balloon" style="top:60%; left:33%;">Here the value of y is -1</div>
<div class="fragment balloon" style="top:74%; left:33%;">Here the value of y is 1</div>


<!-- attr: { showInPresentation:true } -->
# Other Operators – _Example_
- Using some other operators:

```cs
int a = 6;
int b = 4;
Console.WriteLine(a > b ? "a > b" : "b >= a"); // a>b
Console.WriteLine((long)a); // 6
int c = b = 3; // b=3; followed by c=3;
Console.WriteLine(c); // 3
Console.WriteLine(a is int); // True
Console.WriteLine((a + b) / 2); // 4
Console.WriteLine(typeof(int)); // System.Int32
int d = new int();
Console.WriteLine(d); // 0
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Other Operators -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/03.%20Operators-and-Expressions/demos/OtherOperators)


<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Implicit and Explicit Type Conversions -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic24.png" style="top:55%; left:38%; width:25%; z-index:-1; border-radius: 15px;" /> -->


<!-- attr: { id:'conversion', showInPresentation:true } -->
# <a id="conversion"></a>Implicit Type Conversion
- **Implicit type conversion**
  - Automatic conversion of value of one data type to value of another data type
  - Allowed when no loss of data is possible
    - "Larger" types can implicitly take values of smaller "types"
  - _Example_:

```cs
int i = 5;
long l = i;
```



<!-- attr: { showInPresentation:true } -->
# Explicit Type Conversion
- **Explicit type conversion**
  - Manual conversion of a value of one data type to a value of another data type
  - Allowed only explicitly by `(type)` operator
  - Required when there is a possibility of loss of data or precision
  - _Example_:

```cs
long l = 5;
int i = (int) l;
```



<!-- attr: { showInPresentation:true, style:'font-size:0.95em' } -->
# Type Conversions – _Example_
- _Example_ of implicit and explicit conversions:

```cs
float heightInMeters = 1.74f; // Explicit conversion
double maxHeight = heightInMeters; // Implicit

double minHeight = (double) heightInMeters; // Explicit

float actualHeight = (float) maxHeight; // Explicit

float maxHeightFloat = maxHeight; // Compilation error!
```


- _Note_: Explicit conversion may be used even if not required by the compiler




<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Type Conversions -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/03.%20Operators-and-Expressions/demos/TypeConversions)




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Expressions -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic26.png" style="top:45%; left:33%; width:35%; z-index:-1; border-radius: 15px;" /> -->


<!-- attr: { id:'expression', showInPresentation:true } -->
# <a id="expression"></a>Expressions
- Expressions are sequences of operators, literals and variables that are evaluated to some value
- _Examples_:

```cs
int r = (150 - 20) / 2 + 5; // r=70
// Expression for calculation of circle area
double surface = Math.PI * r * r;
// Expression for calculation of circle perimeter
double perimeter = 2 * Math.PI * r;
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Expressions -->
- **Expressions** have:
  - `Type` (integer, real, boolean, ...)
  - `Value`
- _Examples_:

```cs
int a = 2 + 3; // a = 5
int b = (a + 3) * (a - 4) + (2 * a + 7) / 4;  // b = 12
bool greater = (a > b) || ((a == 0) && (b == 0));
```

<div class="fragment balloon" style="top:47%; left:41%;">Calculated at compile time.</div>
<div class="fragment balloon" style="top:51%; left:70%;">Calculated at runtime.</div>
<div class="fragment balloon" style="top:59%; left:77%;">Calculated at runtime.</div>


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Expressions -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/03.%20Operators-and-Expressions/demos/Expressions)


<!-- attr: { showInPresentation:true,   } -->
# Summary
- We discussed the **operators** in C#:
  - **Arithmetic**, **logical**, **bitwise**, **comparison**, **assignment** and others
  - **Bitwise calculations**
  - **Operator precedence**
- We learned when to use **implicit** and **explicit** type conversions
- We learned how to use **expressions**


<!-- attr: { showInPresentation:true } -->
# Resources
- Boolean algebra (logic)
  - [Boolen algebra](http://en.wikipedia.org/wiki/Boolean_algebra_%28logic%29)
- Bitwise mask
  - [Bitwise mask](http://en.wikipedia.org/wiki/Mask_%28computing%29)
- Bitwise operation
  - [Bitwise operations](http://en.wikipedia.org/wiki/Bitwise_operation)
- Bit Twiddling Hacks
  - [Bit hacks](http://graphics.stanford.edu/~seander/bithacks.html)

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Operators and Expressions
## Questions? -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Free Trainings @ Telerik Academy
- Fundamentals of C# ProgrammingTrack of Courses
    - [csharpfundamentals.telerik.com](csharpfundamentals.telerik.com)
  - Telerik Software Academy
    - [academy.telerik.com](academy.telerik.com)
  - Telerik Academy @ Facebook
    - [facebook.com/TelerikAcademy](facebook.com/TelerikAcademy)
  - Telerik Academy Learning System
    - [https://telerikacademy.com](https://telerikacademy.com)

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic29.png" style="top:65%; left:75%; width:16.97%; z-index:-1; border-radius: 15px;" /> -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic30.png" style="top:34.35%; left:70%; width:25%; z-index:-1; border-radius: 15px;" /> -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic31.png" style="top:48.92%; left:75.91%; width:10.85%; z-index:-1; border-radius: 15px;" /> -->
