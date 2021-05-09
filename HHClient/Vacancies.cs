using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHClient
{
    public class Rootobject
    {
        public int? per_page { get; set; }
        public Item[] items { get; set; }
        public int? page { get; set; }
        public int? pages { get; set; }
        public int? found { get; set; }
        public string clusters { get; set; }
        public string arguments { get; set; }
    }

    public class Item
    {
        public Salary salary { get; set; }
        public string name { get; set; }
        public Insider_Interview insider_interview { get; set; }
        public Area area { get; set; }
        public string url { get; set; }
        public string published_at { get; set; }
        public string[] relations { get; set; }
        public Employer employer { get; set; }
        public Contacts contacts { get; set; }
        public bool? response_letter_required { get; set; }
        public Address address { get; set; }
        public string sort_point_distance { get; set; }
        public string alternate_url { get; set; }
        public string apply_alternate_url { get; set; }
        public Department department { get; set; }
        public Type type { get; set; }
        public string id { get; set; }
        public bool? has_test { get; set; }
        public string response_url { get; set; }
        public Snippet snippet { get; set; }
        public Schedule schedule { get; set; }
        public Counters counters { get; set; }
    }

    public class Salary
    {
        public int? to { get; set; }
        public int? from { get; set; }
        public string currency { get; set; }
        public bool? gross { get; set; }
    }

    public class Insider_Interview
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Area
    {
        public string url { get; set; }
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Employer
    {
        public Logo_Urls logo_urls { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string alternate_url { get; set; }
        public string id { get; set; }
        public bool? trusted { get; set; }
    }

    public class Logo_Urls
    {
        public string _90 { get; set; }
        public string _240 { get; set; }
        public string original { get; set; }
    }

    public class Contacts
    {
        public string name { get; set; }
        public string email { get; set; }
        public Phone[] phones { get; set; }
    }

    public class Phone
    {
        public string country { get; set; }
        public string city { get; set; }
        public string number { get; set; }
        public string comment { get; set; }
    }

    public class Address
    {
        public string city { get; set; }
        public string street { get; set; }
        public string building { get; set; }
        public string description { get; set; }
        public float? lat { get; set; }
        public float? lng { get; set; }
        public Metro_Stations[] metro_stations { get; set; }
    }

    public class Metro_Stations
    {
        public string station_id { get; set; }
        public string station_name { get; set; }
        public string line_id { get; set; }
        public string line_name { get; set; }
        public float? lat { get; set; }
        public float? lng { get; set; }
    }

    public class Department
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Type
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Snippet
    {
        public string requirement { get; set; }
        public string responsibility { get; set; }
    }

    public class Schedule
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Counters
    {
        public int? responses { get; set; }
    }

}
