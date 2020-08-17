using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPatternDemo
{
    public class LazyBookParserProxy : IBookParser
    {
        private Lazy<BookParser> _bookParser;
        private string _book;

        public LazyBookParserProxy(string book)
        {
            _book = book;
            _bookParser = new Lazy<BookParser>(() => new BookParser(_book));
        }

        public int GetNumberOfChars()
        {
            return _bookParser.Value.GetNumberOfChars();
        }
    }
}
