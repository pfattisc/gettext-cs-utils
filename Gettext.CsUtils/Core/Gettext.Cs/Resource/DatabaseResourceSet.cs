﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Globalization;

namespace Gettext.Cs
{
    public class DatabaseResourceSet : ResourceSet
    {
        internal DatabaseResourceSet
           (string dsn, CultureInfo culture)
            : base
            (new DatabaseResourceReader(dsn, culture))
        {
        }

        public override Type GetDefaultReader()
        {
            return typeof(DatabaseResourceReader);
        }
    }

}