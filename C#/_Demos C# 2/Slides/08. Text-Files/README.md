<!-- section start -->
<!-- attr: { class:'slide-title', showInPresentation:true, hasScriptWrapper: true } -->
# Text Files
## Reading and Writing Text Files
<img class="slide-image" src="imgs/pic00.png" style="top:52.89%; left:69.53%; width:33.89%; z-index:-1" />
<img class="slide-image" src="imgs/pic01.png" style="top:50.96%; left:91.69%; width:16.03%; z-index:-1" />
<img class="slide-image" src="imgs/pic02.png" style="top:53.67%; left:49.19%; width:17.08%; z-index:-1" />
<img class="slide-image" src="imgs/pic03.png" style="top:18%; left:5%; width:19.55%; z-index:-1" />
<div class="signature">
	<p class="signature-course">C# Advanced</p>
	<p class="signature-initiative">Telerik Software Academy</p>
	<a href="https://telerikacademy.com" class="signature-link">https://telerikacademy.com</a>
</div>




<!-- section start -->
<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- What is Stream?
  - Stream Basics
- Reading Text Files
  - The `StreamReader` Class
- Writing Text Files
  - The `StreamWriter` Class
- Handling I/O Exceptions

<img class="slide-image" src="imgs/pic06.png" style="top:57.30%; left:76.72%; width:27.18%; z-index:-1; border-radius: 15px" />

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# What Is Stream?
## Streams Basic Concepts

<img class="slide-image" src="imgs/pic08.png" style="top:52%; left:35.79%; width:30%; z-index:-1; border-radius: 15px" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# What is Stream?
- Stream is the natural way to transfer data in the computer world
- To read or write a file, we open a stream connected to the file and access the data through the stream
<img class="slide-image" src="imgs/pic09.png" style="top:53.82%; left:24.33%; width:55.54%; z-index:-1" />
<img class="slide-image" src="imgs/pic10.png" style="top:48.68%; left:3.74%; width:25.00%; z-index:-1" />
<img class="slide-image" src="imgs/pic11.png" style="top:47.60%; left:79.20%; width:25.00%; z-index:-1" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Streams Basics
- Streams are used for reading and writing data into and from devices
- Streams are **ordered sequences of bytes**
  - Provide consecutive access to its elements
- Different types of streams are available to access different data sources:
  - File access, network access, memory streams and others
- Streams are open before using them and closed after that




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Reading Text Files
<img class="slide-image" src="imgs/pic12.png" style="top:42%; left:37.16%; width:35.81%; z-index:-1" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# The `StreamReader` Class
- `System.IO.StreamReader`
  - The easiest way to read a text file
  - Implements methods for reading text lines and sequences of characters
  - Constructed by file name or other stream
    - Can specify the text encoding
    - For Cyrillic use **UTF8**
  - Works like `Console.Read()` / `ReadLine()` but over text files


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# StreamReader Methods
- `new StreamReader(fileName)`
  - Constructor for creating reader from given file
- `StreamReader.ReadLine()`
  - Reads a single text line from the stream
  - Returns `null` when end-of-file is reached
- `StreamReader.ReadToEnd()`
  - Reads all the text until the end of the stream
- `StreamReader.Close()`
  - Closes the stream reader


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Reading a Text File
- Reading a text file and printing its content to the console:

```cs
StreamReader reader = new StreamReader("test.txt");
string fileContents = reader.ReadToEnd();
Console.WriteLine(fileContents);
streamReader.Close();
```

- Specifying the text encoding:

```cs
StreamReader reader = new StreamReader(
    "file-with-cyrillic.txt", Encoding.UTF8;
// Read the file contents here ...
reader.Close();
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size: 0.8em' } -->
# Using `StreamReader` – Practices
- The `StreamReader` instances should always be closed by calling the `Close()` method
  - Otherwise system resources can be lost
- In C# the preferable way to close streams and readers is by the `using` construction:

```cs
using (<stream object>)
{
   // Use the stream here. It will be closed at the end
}
```

  - It automatically calls the `Close()` **after the using** construction is completed


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Reading a Text File – _Example_
- Read and display a text file line by line:

```cs
string filename = "somefile.txt";
StreamReader reader = new StreamReader(filename);
using (reader)
{
    int lineNumber = 0;
    string line = reader.ReadLine();
    while (line != null)
    {
        lineNumber++;
        Console.WriteLine("Line {0}: {1}",
					lineNumber, line);
        line = reader.ReadLine();
    }
}
```


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
# Reading Text Files
## [Demo]()

<img class="slide-image" src="imgs/pic14.png" style="top:52%; left:36.85%; width:30%; z-index:-1; border-radius: 15px" />


<!-- section start -->

<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Writing Text Files
## Using the StreamWriter Class

<img class="slide-image" src="imgs/pic15.png" style="top:52%; left:27.82%; width:45%; z-index:-1; border-radius: 15px" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size: 0.8em' } -->
# The `StreamWriter` Class
- `System.IO.StreamWriter`
  - Similar to `StreamReader`, but instead of reading, it provides writing functionality
- Constructed by file name or other stream

```cs
StreamWriter streamWriter = new StreamWriter(filename);
```

  - Can define encoding

  	- For Cyrillic use **UTF8**:

```cs
StreamWriter streamWriter =
	new StreamWriter(filename, false, Encoding.UTF8);
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# StreamWriter Methods
- `StreamWriter.Write()`
  - Writes string or other object to the stream
  - Like `Console.Write()`
- `StreamWriter.WriteLine()`
  - Like `Console.WriteLine()`
- `StreamWriter.Flush()`
  - Flushes the internal buffers to the hard drive
    - Or the stream
- `StreamWriter.AutoFlush`
  - Flush the internal buffer after each writing

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Writing to a Text File – _Example_
- _Exampel:_ Create text file named "**numbers.txt**" and print in it the numbers from `1` to `20` (one per line):

```cs
StreamWriter streamWriter =
    new StreamWriter("numbers.txt");
using (streamWriter)
{
    for (int number = 1; number <= 20; number++)
    {
        streamWriter.WriteLine(number);
    }
}
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
# Writing Text Files
## [Demo]()

<img class="slide-image" src="imgs/pic17.png" style="top:52%; left:30.75%; width:40%; z-index:-1; border-radius: 15px" />


<!-- section start -->

<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Reading and Writing Text Files: _Examples_


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size: 0.8em' } -->
# Counting Word Occurrences – _Example_
- Counting the number of occurrences of the word "**foundme**" in a text file:

```cs
StreamReader streamReader =
 new StreamReader(@"..\..\somefile.txt");
int count = 0;
string text = streamReader.ReadToEnd();

int index = text.IndexOf("foundme", 0);
while (index != -1)
{
   count++;
   index = text.IndexOf("foundme", index + 1);
}

Console.WriteLine(count);
```

<div class="fragment balloon" style="top:68.30%; left:67.88%; width:31.44%">What is missing in this code?</div>


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
# Counting Word Occurrences
## [Demo]()
<!-- <img class="slide-image" src="imgs/pic23.png" style="top:52%; left:21.89%; width:55%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size: 0.9em' } -->
# Reading Subtitles – _Example_

- We are given a standard movie subtitles file:

```txt
.....

{2757}{2803} Allen, Bomb Squad, Special Services...
{2804}{2874} State Police and the FBI!
{2875}{2963} Lieutenant! I want you to go to St. John's Emergency...
{2964}{3037} in case we got any walk-ins from the street.
{3038}{3094} Kramer, get the city engineer!
{3095}{3142} I gotta find out a damage report. It's very important.
{3171}{3219} Who the hell would want to blow up a department store?

.....
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-style: 0.8em' } -->
# Fixing Subtitles – _Example_
- Read subtitles file and fix it’s timing:

```cs
try
{
  var streamReader = new StreamReader("source.sub");
  var streamWriter = new StreamWriter("fixed.sub");

  string line;
  while ((line = streamReader.ReadLine()) != null)
  {
    streamWriter.WriteLine(FixLine(line));
  }
}
finally
{
  streamReader.Close();
  streamWriter.Close();
}
```

<div class="fragment balloon" style="top:66%; left:48%; width:43.20%">**FixLine(line)** perform fixes on the time offsets: multiplication or/and addition with constant</div>


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
# Fixing Movie Subtitles
## [Demo]()

<img class="slide-image" src="imgs/pic24.png" style="top:52%; left:30%; width:42%; z-index:-1; border-radius: 15px" />

<!-- section start -->

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size: 0.9em' } -->
# Summary
- Streams are the main I/O mechanism in .NET
- The `StreamReader` class and `ReadLine()` method are used to read text files
- The `StreamWriter` class and `WriteLine()` method are used to write text files
- Always put file handling in `using(…)` block
- Exceptions are unusual events or error conditions
  - Can be handled by `try-catch-finally` blocks

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Text Files
## Questions?


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Free Trainings @ Telerik Academy
- C# Programming @ Telerik Academy
  - [csharpfundamentals.telerik.com](csharpfundamentals.telerik.com)
- Telerik Software Academy
  - [academy.telerik.com](academy.telerik.com)
- Telerik Academy @ Facebook
  - [facebook.com/TelerikAcademy](facebook.com/TelerikAcademy)
- Telerik Software Academy Forums
    - [forums.academy.telerik.com](https://telerikacademy.com/Forum/Home)
<img class="slide-image" src="imgs/pic26.png" style="top:60.37%; left:92.39%; width:13.45%; z-index:-1" />
<img class="slide-image" src="imgs/pic27.png" style="top:30.85%; left:68.14%; width:36.30%; z-index:-1" />
<img class="slide-image" src="imgs/pic28.png" style="top:46.32%; left:95.14%; width:10.85%; z-index:-1" />

<!-- img class="slide-image" src="imgs/pic29.png" style="top:13.00%; left:92.85%; width:13.01%; z-index:-1" /> -->
