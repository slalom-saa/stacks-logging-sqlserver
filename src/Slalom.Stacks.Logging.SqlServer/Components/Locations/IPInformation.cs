/* 
 * Copyright (c) Stacks Contributors
 * 
 * This file is subject to the terms and conditions defined in
 * the LICENSE file, which is part of this source code package.
 */

namespace Slalom.Stacks.Logging.SqlServer.Components.Locations
{
    public class IPInformation
    {
        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public string Isp { get; set; }

        public string IPAddress { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Postal { get; set; }
    }
}