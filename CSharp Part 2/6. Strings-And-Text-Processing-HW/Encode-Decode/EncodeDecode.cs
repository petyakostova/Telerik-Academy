/*  Problem 7. Encode/decode
    Write a program that encodes and decodes a string using given encryption key (cipher).
    The key consists of a sequence of characters.
    The encoding/decoding is done by performing XOR (exclusive or) operation 
    over the first letter of the string with the first of the key, the second – with the second, etc.
    When the last key character is reached, the next is the first.
 */
/* Note: Example for faster testing:
                                        Input:                  Output:
                                        text: Test              5↕▬   
                                        cipher code: "ab"       \u0035\u0007\u0012\u0016
                                                                Test
 */

using System;
using System.Text;

class EncodeDecode
{
    static void Main()
    {
        // for faster testing:
        string text = "Test";
        string key = "ab";

        //// the real input
        //Console.Write("Enter a string:");
        //string text = Console.ReadLine();
        //Console.Write("Enter an encryption key (cipher):");
        //string key = Console.ReadLine();

        StringBuilder encryption = EnDeCryption(text, key);

        Console.WriteLine("\nThe result of encryption is:");
        Console.WriteLine(encryption);              // print the result of encryption

        Console.WriteLine("The result of encryption as a series of Unicode escape characters \\xxxx is:");
        foreach (var ch in encryption.ToString())   
        {
            Console.Write("\\u{0:x4}", (int)ch);    // print the result of encryption as a series of Unicode escape characters \xxxx
        }        
        
        string encryptText = encryption.ToString();

        StringBuilder decryption = EnDeCryption(encryptText, key);

        Console.WriteLine("\n\nThe result of decryption is:");
        Console.WriteLine("{0}\n", decryption); 
    }

    private static StringBuilder EnDeCryption(string message, string cipher)
    {
        StringBuilder enDeCrypt = new StringBuilder();

        for (int i = 0; i < message.Length; i++)
        {
            enDeCrypt.Append((char)(message[i] ^ cipher[i % cipher.Length]));
        }
        return enDeCrypt;
    }
}