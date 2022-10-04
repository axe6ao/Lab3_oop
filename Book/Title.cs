using System;

namespace Book
{
    public class Title : BookAttribute
    {
        public Title(string content, ConsoleColor color) : base(content, color)
        {
        }
    }
}