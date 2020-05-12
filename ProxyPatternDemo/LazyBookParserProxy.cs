using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPatternDemo
{
    public class LazyBookParserProxy : IBookParser
    {
        private BookParser _bookParser = null;
        private string _book;

        public LazyBookParserProxy(string book)
        {
            _book = book;
        }

        public int GetNumberOfChars()
        {
            if (null == _bookParser)
                _bookParser = new BookParser(_book);
            return _bookParser.GetNumberOfChars();
        }
    }
}
