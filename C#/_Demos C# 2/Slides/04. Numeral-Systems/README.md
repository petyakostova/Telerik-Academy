<!-- section start -->
<!-- attr: {  class:'slide-title', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Numeral Systems
## Binary, Decimal and Hexadecimal Numbers

<!-- <img class="slide-image" showInPresentation="true" src="imgs/hex-fingers.png" style="top:45%; left:60%; width:45%; z-index:-1" /> -->

<div class="signature">
	<p class="signature-course">C# Advanced</p>
	<p class="signature-initiative">Telerik Software Academy</p>
	<a href="https://telerikacademy.com" class="signature-link">https://telerikacademy.com</a>
</div>

<!-- section start -->
<!-- attr: {  showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Table of Contents
- [Numeral Systems](#numerals)
  - [Binary and Decimal Numbers](#binarydecimal)
  - [Hexadecimal Numbers](#hexadecimal)
  - [Conversion between Numeral Systems](#conversions)
- [Representation of Numbers](#representation)
  - [Positive and Negative Integer Numbers](#positivenegative)
  - [Floating-Point Numbers](#floats)
- [Text Representation](#textrepresentation)

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic03.png" style="top:13.88%; left:80.47%; width:24.79%; z-index:-1" /> -->

<!-- section start -->
<!-- attr: { id:'numerals', class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# <a id="numerals"></a> Numeral Systems
<!-- ## Conversion between Numeral Systems -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic04.png" style="top:55%; left:14.00%; width:22%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic05.png" style="top:55%; left:61.75%; width:25%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
<!-- # Decimal Numbers -->
- Decimal numbers (base 10)
  - Represented using 10 numerals: `0`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`
- Each position represents a power of 10:

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/dec-nums.png" style="top:40%; left:5%; width:90%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic06.png" style="top:80%; left:76.16%; width:28.69%; z-index:-1" /> -->


<!-- attr: { id:'binarydecimal', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# <a id="binarydecimal"></a> Binary Numeral System
- Binary numbers are represented by sequence of bits (smallest unit of information – 0 or 1)
  - Bits are easy to represent in electronics

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic07.png" style="top:40%; left:1.87%; width:102.26%; z-index:-1" /> -->



<!-- attr: {  showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Binary Numbers
- Binary numbers (base 2)
  - Represented by 2 numerals:  `0` and `1`
- Each position represents a power of 2:

  <!-- <img class="slide-image" showInPresentation="true"  src="imgs/bin-nums.png" style="top:45%; left:5%; width:90%; z-index:-1" /> -->


<!-- attr: {  showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Binary to Decimal Conversion
- Multiply each numeral by its exponent:

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/bin-2-dec.png" style="top:25%; left:5%; width:90%; z-index:-1" /> -->

<!-- attr: {  showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
# Decimal to Binary Conversion
- Divide by 2 and append the reminders in reversed order:
- 500/2  = 250 (0)
- 250/2  = 125 (0)
- 125/2  = 62  (1)
-  62/2  = 31  (0)
-  31/2  = 15  (1)
-  15/2  = 7   (1)
-   7/2  = 3   (1)
-   3/2  = 1   (1)
-   1/2  = 0   (1)

<p style="font-size: 46px; color: orange; position: absolute; top: 35%; left: 50%;">500<sub>d</sub> = 111110100<sub>b</sub></p>


<!-- attr: { id:'hexadecimal',  showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
# <a id="hexadecimal"></a>  Hexadecimal Numbers
- Hexadecimal numbers (base 16)
  - Represented using 16 numerals: `0`, `1`, `2`, ... `9`, `A`, `B`, `C`, `D`, `E` and `F`
- Usually prefixed with `0x`

| **Hex digits value** |               |              |               |
|:--------------------:|:-------------:|:------------:|:-------------:|
| 0 &rarr; 0x0         | 8 &rarr; 0x8  | 4 &rarr; 0x4 | 12 &rarr; 0xC |
| 1 &rarr; 0x1         | 9 &rarr; 0x9  | 5 &rarr; 0x5 | 13 &rarr; 0xD |
| 2 &rarr; 0x2         | 10 &rarr; 0xA | 6 &rarr; 0x6 | 14 &rarr; 0xE |
| 3 &rarr; 0x3         | 11 &rarr; 0xB | 7 &rarr; 0x7 | 15 &rarr; 0xF |


<!-- attr: {  showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Hexadecimal Numbers
- Each position represents a power of 16:

  <!-- <img class="slide-image" showInPresentation="true"  src="imgs/hex-nums.png" style="top:25%; left:5%; width:95%; z-index:-1" /> -->


<!-- attr: { id:'conversions',  showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
# <a id="conversions"></a>  Hexadecimal to Decimal Conversion
- Multiply each digit by its exponent

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/hex-2-dec.png" style="top:35%; left:5%; width:80%; z-index:-1" /> -->


<!-- attr: {  showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Decimal to Hexadecimal Conversion
- Divide by 16 and append the reminders in reversed order
- 500/16 = 31 (4) 	
- 31/16  = 1 (F)
- 1/16   = 0 (1) 	
<p style="font-size: 46px; color: orange; position: absolute; top: 35%; left: 50%;">500<sub>d</sub> = 1F4<sub>hex</sub></p>


<!-- attr: {  showInPresentation:true, hasScriptWrapper:true, style:'font-size: 40px' } -->
# Binary to Hexadecimal (and reverse) Conversion
- The conversion from binary to hexadecimal (and back) is straightforward: each hex digit corresponds to a sequence of 4 binary digits:

| **0 - 3** | **4 - 7** | **8 - B** | **C - F** |
|:--------:|:--------:|:--------:|:--------:|
|0x0 = 0000|0x4 = 0100|0x8 = 1000|0xC = 1100|
|0x1 = 0001|0x5 = 0101|0x9 = 1001|0xD = 1101|
|0x2 = 0010|0x6 = 0110|0xA = 1010|0xE = 1110|
|0x3 = 0011|0x7 = 0111|0xB = 1011|0xF = 1111|




<!-- section start -->
<!-- attr: {  class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
<!-- # Numbers Representation
## Positive and Negative Integers and Floating-Point Numbers -->


<!-- attr: { id:'representation', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# <a id="representation"></a> Representation of Integers
- A `short` is represented by 16 bits
  - 100	= **2**<sup>`6`</sup> + **2**<sup>`5`</sup> + **2**<sup>`2`</sup> = 00000000 01100100
- An `int` is represented by 32 bits  
  - 65545 = **2**<sup>`16`</sup> + **2**<sup>`3`</sup> + **2**<sup>`0`</sup> = 00000000 00000001 00000000 00001001
- A `char` is represented by 16 bits
  - '0'	= 48 = **2**<sup>`5`</sup> + **2**<sup>`4`</sup> =	= 00000000 00110000


<!-- attr: { id:'positivenegative',  showInPresentation:true, hasScriptWrapper:true, style:'' } -->
<a id="positivenegative"></a>  
# Positive and Negative Numbers
- A number's sign is determined by the`Most Significant Bit` (MSB)
  - Only in signed integers: `sbyte`, `short`, `int`, `long`
  - Leading `0` means positive number
    - Leading `1` means negative number
  - _Example_: (8 bit numbers)
    - `0XXXXXXX`<sub>b</sub> > 0	e.g. 00010010b = 18
    - `00000000`<sub>b</sub> = 0
    - `1XXXXXXX`<sub>b</sub> < 0	e.g. 10010010b = -110


<!-- attr: {  showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Positive and Negative Numbers
- The largest positive 8-bit `sbyte` number:
  - **127** = (**2**<sup>`7`</sup> - 1) = 01111111<sub>b</sub>
- The smallest negative 8-bit number:
  - **-128** = (**-2**<sup>`7`</sup>) = 10000000<sub>b</sub>
- The largest positive 32-bit `int` number:
  - **2 147 483 647** (**2**<sup>`31`</sup> - 1) = 01111…11111<sub>b</sub>
- The smallest negative 32-bit number:
  - **-2 147 483 648** (**-2**<sup>`31`</sup>) = 10000…00000<sub>b</sub>


<!-- attr: {  showInPresentation:true, hasScriptWrapper:true, style:'font-size: 40px' } -->
# Representation of 8-bit Numbers
- Positive 8-bit numbers have the format <!-- .element: class="" style="width: 70%" --> **0** XXXXXXX
  - Their value is the decimal of their last 7 bits (XXXXXXX)
- Negative 8-bit numbers have the format <!-- .element: class="" style="width: 70%" --> **1** YYYYYYY
  - Their value is 128 (2<sup>7</sup>) minus (-) the decimal of YYYYYYY
  - 10010010<sub>b</sub> = 2<sup>7</sup> – 10010<sub>b</sub> = 128 - 18 = -110

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/table.png" style="top:10%; left:70%; width:30%; z-index:-1" /> -->

<!-- attr: { id:'floats',  showInPresentation:true, hasScriptWrapper:true, style:'font-size: 42px' } -->
# <a id="floats"></a>  Floating-Point Numbers
- Floating-point numbers representation (according to the IEEE 754 standard*):
<br/>
<br/>
<br/>
<br/>
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/ieee-754-float.png" style="top:25%; left:0%; width:95%; z-index:-1" /> -->

- Example: `-21.15625` -> **sign \* 2<sup>exponent</sup> \* mantissa**


<!-- <img class="slide-image" showInPresentation="true"  src="imgs/ieee-754-float-example.png" style="top:60%; left:0%; width:90%; z-index:-1" /> -->



<!-- section start -->
<!-- attr: {  class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
<!-- # Text Representation in Computer Systems -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic22.png" style="top:55%; left:32%; width:35%; z-index:-1" /> -->


<!-- attr: { id:'textrepresentation', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# <a id="textrepresentation"></a> How Computers Represent Text Data?
- `Text encoding` is a system that uses binary numbers (1 and 0) to represent characters
  -  Letters, numerals, symbols etc.
- In the `ASCII` encoding each character consists of 8 bits (one byte) of data
  - ASCII is used in nearly all personal computers
- In the `Unicode` (`UTF-16`) encoding each character consists of 16 bits (two bytes)
  - Can represent many alphabets



<!-- attr: {  showInPresentation:true, hasScriptWrapper:true, style:'font-size: 40px' } -->
# Character Codes – ASCII Table


| Binary code | Decimal code | Character |
|:-----------:|:------------:|:---------:|
| `01000001`  | `65`         | `A`       |
| `01000010`  | `66`         | `B`       |
| `01000011`  | `67`         | `C`       |
| `01000100`  | `68`         | `D`       |
| `00100011`  | `35`         | `#`       |
| `01100000`  | `48`         | `0`       |
| `00110001`  | `49`         | `1`       |
| `01111110`  |`126`         | `~`       |

<!-- attr: {  showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Strings of Characters
- Strings are sequences of characters
  - Null-terminated (like in C)
  <br />
  <br />
  <br />


  - Represented by array
  <br />
  <br />
  <br />


- Characters in the strings can be:
  - `8 bit` (`ASCII` / `windows-1251` / …)
  - `16 bit` (`UTF-16`)

<!-- <img class="slide-image" showInPresentation="true" src="imgs/string-arr.png" style="top:53%; width: 65%; z-index: -1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs/null-term-string.png"  style="top:30%; width: 65%; z-index: -1" /> -->


  <!-- attr: { class:'slide-section', showInPresentation: true, hasScriptWrapper: true, style:'font-size: 42px' } -->
  <!-- # C# Numeral Systems
  ## Questions? -->

  <!-- attr: { showInPresentation: true, hasScriptWrapper: true} -->
  # Free Training @ Telerik Academy

  - Fundamentals of C# Programming Track of Courses
      - [csharpadvanced](http://academy.telerik.com/student-courses/programming/csharp-programming-part-2/about)
    - Telerik Software Academy
      - [telerikacademy.com](https://telerikacademy.com)
    - Telerik Academy @ Facebook
      - [facebook.com/TelerikAcademy](https://facebook.com/TelerikAcademy)
    - Telerik Academy Learning System
      - [telerikacademy.com](https://telerikacademy.com)
