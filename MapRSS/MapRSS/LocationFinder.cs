using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BingMapsRESTToolkit;

namespace MapRSS
{
    class LocationFinder
    {
        // http://dev.virtualearth.net/REST/v1/Locations/US/{adminDistrict}/{postalCode}/{locality}/{addressLine}?includeNeighborhood={includeNeighborhood}&include={includeValue}&maxResults={maxResults}&key={BingMapsKey}
        string url = "http://dev.virtualearth.net/REST/v1/Locations/US/WA/Redmond/1%20Microsoft%20Way?output=xml&key={BingMapsKey}";
        Dictionary<string, Coordinate> locations = new Dictionary<string, Coordinate>();

        public LocationFinder() { }

        public Coordinate GetCoordinate(string name)
        {
            if (locations.ContainsKey(name))
            {
                return locations[name];
            }
            else
            {
                return null;
            }
        }
        public async Task FindLocationAsync(string name)
        {
            await findLocationAsync(name);
        }
        private async Task findLocationAsync(string locationName)
        {
            string query = "http://dev.virtualearth.net/REST/v1/Locations/US/" + locationName + "/1%20Microsoft%20Way?output=xml&key={BingMapsKey}";
            var request = new GeocodeRequest()
            {
                Query = locationName,
                IncludeIso2 = true,
                IncludeNeighborhood = false,
                MaxResults = 25,
                BingMapsKey = "lEg2OjlSbq6LfeITGyN4~_iy0J4FoblaHaRnWIeKqDA~AggLxClK2WO0qhcMzp-AOBpH9hvMmFQJ3LdowU0WYcmo8JV_-hyVxBTQHRe2gF_a"
            };

            //Process the request by using the ServiceManager.
            var response = await request.Execute();

            if (response != null &&
                response.ResourceSets != null &&
                response.ResourceSets.Length > 0 &&
                response.ResourceSets[0].Resources != null &&
                response.ResourceSets[0].Resources.Length > 0)
            {
                var result = response.ResourceSets[0].Resources[0] as BingMapsRESTToolkit.Location;
                Coordinate coord = new Coordinate(result.Point.Coordinates[0], result.Point.Coordinates[1]);
                locations.Add(locationName, coord);
            }
        }

    }
}
