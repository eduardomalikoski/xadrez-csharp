using System;

namespace XadrezApp.Tabuleiro
{
    public class TabException : Exception
    {
        public TabException(string msg) : base(msg) { }
    }
}