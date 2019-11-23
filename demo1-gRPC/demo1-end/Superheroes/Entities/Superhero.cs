using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Superheroes.Entities
{
    public class Powerstats
    {

        [JsonProperty("intelligence")]
        public int Intelligence { get; set; }

        [JsonProperty("strength")]
        public int Strength { get; set; }

        [JsonProperty("speed")]
        public int Speed { get; set; }

        [JsonProperty("durability")]
        public int Durability { get; set; }

        [JsonProperty("power")]
        public int Power { get; set; }

        [JsonProperty("combat")]
        public int Combat { get; set; }
    }

    public class Appearance
    {

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("race")]
        public string Race { get; set; }

        [JsonProperty("height")]
        public IList<string> Height { get; set; }

        [JsonProperty("weight")]
        public IList<string> Weight { get; set; }

        [JsonProperty("eyeColor")]
        public string EyeColor { get; set; }

        [JsonProperty("hairColor")]
        public string HairColor { get; set; }
    }

    public class Biography
    {

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("alterEgos")]
        public string AlterEgos { get; set; }

        [JsonProperty("aliases")]
        public IList<string> Aliases { get; set; }

        [JsonProperty("placeOfBirth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("firstAppearance")]
        public string FirstAppearance { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("alignment")]
        public string Alignment { get; set; }
    }

    public class Work
    {

        [JsonProperty("occupation")]
        public string Occupation { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }
    }

    public class Connections
    {

        [JsonProperty("groupAffiliation")]
        public string GroupAffiliation { get; set; }

        [JsonProperty("relatives")]
        public string Relatives { get; set; }
    }

    public class Images
    {

        [JsonProperty("xs")]
        public string Xs { get; set; }

        [JsonProperty("sm")]
        public string Sm { get; set; }

        [JsonProperty("md")]
        public string Md { get; set; }

        [JsonProperty("lg")]
        public string Lg { get; set; }
    }

    public class Superhero
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("powerstats")]
        public Powerstats Powerstats { get; set; }

        [JsonProperty("appearance")]
        public Appearance Appearance { get; set; }

        [JsonProperty("biography")]
        public Biography Biography { get; set; }

        [JsonProperty("work")]
        public Work Work { get; set; }

        [JsonProperty("connections")]
        public Connections Connections { get; set; }

        [JsonProperty("images")]
        public Images Images { get; set; }
    }


}
