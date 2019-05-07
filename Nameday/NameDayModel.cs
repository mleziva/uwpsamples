using System.Collections.Generic;

namespace Nameday
{
    public class NamedayModel
    {
        public int Month { get; set; }
        public int Day { get; set; }
        public IEnumerable<string> Names { get; }
        public NamedayModel(int month, int day, IEnumerable<string> names)
        {
            Month = month;
            Day = day;
            Names = names;
        }
        public string NamesAsString
        {
            get { return string.Join(", ", Names); }
        }
    }
}
