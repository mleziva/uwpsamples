using System.Collections.Generic;

namespace Nameday
{
    public class MainPageData
    {
        public string Greeting { get; set; } = "Helloo WORLD!";
        public List<NameDayModel> Namedays { get; set; }
        public MainPageData()
        {
            Namedays = new List<NameDayModel>();
            for (int month = 1; month <= 12; month++)
            {
                Namedays.Add(new NameDayModel(month, 1, new string[] { "Adam" }));
                Namedays.Add(new NameDayModel(month, 24, new string[] { "Eve", "Andrew" }));
            }
        }
    }
}
