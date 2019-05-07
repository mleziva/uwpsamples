using System.Collections.Generic;

namespace Nameday
{
    public class MainPageData
    {
        public string Greeting { get; set; } = "Helloo WORLD!";
        public List<NamedayModel> Namedays { get; set; }
        public MainPageData()
        {
            Namedays = new List<NamedayModel>();
            for (int month = 1; month <= 12; month++)
            {
                Namedays.Add(new NamedayModel(month, 1, new string[] { "Adam" }));
                Namedays.Add(new NamedayModel(month, 24, new string[] { "Eve", "Andrew" }));
            }
        }
    }
}
