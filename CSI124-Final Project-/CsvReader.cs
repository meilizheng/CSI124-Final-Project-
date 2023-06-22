using System;
using System.Globalization;
using System.IO;

namespace CSI124_Final_Project_
{
    internal class CsvReader
    {
        private StreamReader sr;
        private CultureInfo invariantCulture;

        public CsvReader(StreamReader sr, CultureInfo invariantCulture)
        {
            this.sr = sr;
            this.invariantCulture = invariantCulture;
        }

        internal object GetRecords<T>()
        {
            throw new NotImplementedException();
        }
    }
}