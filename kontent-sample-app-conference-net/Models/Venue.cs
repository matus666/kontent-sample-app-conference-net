// This code was generated by a kontent-generators-net tool 
// (see https://github.com/Kentico/kontent-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using Kentico.Kontent.Delivery;

namespace KenticoKontentModels
{
    public partial class Venue
    {
        public const string Codename = "venue";
        public const string LocationCodename = "location";
        public const string NearbyAttractionsCodename = "nearby_attractions";
        public const string ImageCodename = "image";
        public const string AddressCodename = "address";
        public const string DescriptionCodename = "description";
        public const string MapSourceCodename = "map_source";
        public const string LinkCodename = "link";
        public const string NameCodename = "name";

        public IEnumerable<TaxonomyTerm> Location { get; set; }
        public IEnumerable<object> NearbyAttractions { get; set; }
        public IEnumerable<Asset> Image { get; set; }
        public IRichTextContent Address { get; set; }
        public IRichTextContent Description { get; set; }
        public string MapSource { get; set; }
        public string Link { get; set; }
        public string Name { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}