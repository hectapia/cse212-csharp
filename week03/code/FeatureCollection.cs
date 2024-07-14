 
    // Add code in FeatureCollection.cs to describe the JSON using classes and properties 
    // on those classes so that the call to Deserialize above works properly.
      
    
    public class FeatureCollection
    {
        public List<Feature> Features { get; set; }
    }

    public class Feature
    {
        public Properties Properties { get; set; }
    }

    public class Properties
    {
        public decimal Mag { get; set; }
        public string Place { get; set; }
    }