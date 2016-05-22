/*  12. Parse URL
    Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] 
    and extracts from it the [protocol], [server] and [resource] elements.
    Input: On the only line you will receive an address
    Output: Print the protocol, server and resource as shown below
    Sample tests:
                Input 	                                                Output
                http://telerikacademy.com/Courses/Courses/Details/212 	[protocol] = http
                                                                        [server] = telerikacademy.com
                                                                        [resource] = /Courses/Courses/Details/212
                https://github.com/gentoo/gentoo.git 	                [protocol] = https
                                                                        [server] = github.com
                                                                        [resource] = /gentoo/gentoo.git
 */

using System;

class ParseURL
{
    static void Main()
    {
        string uRL = Console.ReadLine();

        /* Searching for the respective splitters – two slashes for a protocol and 
         * one slash as a separator between the server and the resource            */

        //the start index of the substring "://" in uRL by its first occurrences
        int indexOfProtocol = uRL.IndexOf("://");

        // the substring from 0 with length=indexOfProtocol
        // string string.Substring(int startIndex, int length);
        string protocol = uRL.Substring(0, indexOfProtocol);

        //the start index of the substring "/" starting from (indexOfProtocol + 3) in uRL by its first occurrences => int string.IndexOf(String value, int startIndex);
        int indexOfServer = uRL.IndexOf("/", indexOfProtocol + 3);

        // string string.Substring(int startIndex, int length);
        string server = uRL.Substring(indexOfProtocol + 3, indexOfServer - indexOfProtocol - 3);

        // string string.Substring(int startIndex);
        string resource = uRL.Substring(indexOfServer);

        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }
}