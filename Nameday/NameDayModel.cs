using System.Collections.Generic;

namespace Nameday
{
    public class NameDayModel
    {
        public int Month { get; set; }
        public int Day { get; set; }
        public IEnumerable<string> Names { get; }
        public NameDayModel(int month, int day, IEnumerable<string> names)
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
