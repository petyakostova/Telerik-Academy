/*  Problem 12. Parse URL
    Write a program that parses an URL address given in the format: 
    [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
    Example:
        URL 	                                                Information
        http://telerikacademy.com/Courses/Courses/Details/212 	[protocol] = http
                                                                [server] = telerikacademy.com
                                                                [resource] = /Courses/Courses/Details/212
 */

using System;

class ParseURL
{
    static void Main()
    {
        // input for faster testing
        string uRL = "http://telerikacademy.com/Courses/Courses/Details/212";
        //// the real input
        //string uRL = Console.ReadLine();

        /* Searching for the respective splitters – two slashes for a protocol and 
         * one slash as a separator between the server and the resource            */

        int indexOfProtocol = uRL.IndexOf("://"); //the start index of the substring "://" in uRL by its first occurrences
        string protocol = uRL.Substring(0, indexOfProtocol); // the substring from 0 with length = indexOfProtocol 
        protocol = "[protocol] = " + protocol;

        //the start index of the substring "/" starting from (indexOfProtocol + 3) in uRL by its first occurrences
        int indexOfServer = uRL.IndexOf("/", indexOfProtocol + 3); 
        string server = uRL.Substring(indexOfProtocol + 3, indexOfServer - indexOfProtocol - 3);
        server = "[server] = " + server;

        string resource = uRL.Substring(indexOfServer);
        resource = "[resource] = " + resource;

        Console.WriteLine(protocol);
        Console.WriteLine(server);
        Console.WriteLine(resource);
    }
}