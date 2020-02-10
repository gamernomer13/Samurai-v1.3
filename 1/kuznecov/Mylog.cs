using System;
using System.Collections.Generic;
using System.Text;

namespace laba3_4.kuznecov
{

    class MyLog : Core.LogAbstract<MyLog>, Core.LogInterface
    {
        static public void log(string s)
        {
            Instance()._log_(s);
        }
        public void _log_(string s)
        {
            _log.Add(s);
        }
        static public void write()
        {
            Instance()._write();

        }

        override public void _write()
        {
            for (int i = 0; i < _log.Count; i++)
            {
                Console.WriteLine(_log[i]);
            }
        }
    }
}
