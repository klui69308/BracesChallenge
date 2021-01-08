using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Valid Expression are such: '(,)' or '[,]' or '{,}' ");
        Console.WriteLine("Please type your expression:");
        string input = Console.ReadLine();
        bool stackResult = CheckValidity(input);

        if (stackResult)
            Console.WriteLine("Expression is Valid.");
        else
            Console.WriteLine("Expression is not valid.");
    }

    private static bool CheckValidity(string customeString)
    {
        Stack<char> openStack = new Stack<char>();
        foreach (char c in customeString)
        {
            switch (c)
            {
                case '{':
                case '(':
                case '[':
                    openStack.Push(c);
                    break;
                case '}':
                    if (openStack.Count == 0 || openStack.Peek() != '{')
                    {
                        return false;
                    }
                    openStack.Pop();
                    break;
                case ')':
                    if (openStack.Count == 0 || openStack.Peek() != '(')
                    {
                        return false;
                    }
                    openStack.Pop();
                    break;
                case ']':
                    if (openStack.Count == 0 || openStack.Peek() != '[')
                    {
                        return false;
                    }
                    openStack.Pop();
                    break;
                default:
                    break;
            }
        }
        return openStack.Count == 0;
    }
}