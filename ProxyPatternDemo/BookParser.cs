using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPatternDemo
{
    public class BookParser:IBookParser
    {

        private string _book;
        public BookParser(string book)
        {
            _book = book;
        }

        public int GetNumberOfChars()
        {
            return _book.Length;
        }
    }
}
