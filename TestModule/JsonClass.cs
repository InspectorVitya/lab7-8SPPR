using System;
using System.Collections.Generic;
namespace JsonClass
{
    public class Waypoint
    {
        public string hint { get; set; }
        public double distance { get; set; }
        public List<double> location { get; set; }
        public string name { get; set; }
    }

    public class Leg
    {
        public List<object> steps { get; set; }
        public double weight { get; set; }
        public double distance { get; set; }
        public string summary { get; set; }
        public double duration { get; set; }
    }

    public class Route
    {
        public List<Leg> legs { get; set; }
        public string weight_name { get; set; }
        public string geometry { get; set; }
        public double weight { get; set; }
        public double distance { get; set; }
        public double duration { get; set; }
    }

    public class RootObject
    {
        public string code { get; set; }
        public List<Waypoint> waypoints { get; set; }
        public List<Route> routes { get; set; }
    }
}
