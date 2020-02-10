﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core

{
    abstract class LogAbstract<T>
         where T : LogAbstract<T>, new()
    {
        protected static T i = new T();


        public static T Instance()
        {
            return i;
        }


        protected List<string> _log = new List<string>();

        abstract public void _write();
    }
}
