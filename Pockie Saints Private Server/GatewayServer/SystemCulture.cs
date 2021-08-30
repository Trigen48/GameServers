using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace System
{
    static class SystemCulture
    {
        internal static void SetCulture()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ".";
            Thread.CurrentThread.CurrentUICulture.NumberFormat.CurrencyDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator = ".";
        }
    }
}
