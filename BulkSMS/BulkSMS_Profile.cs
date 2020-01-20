using System;
using System.Collections.Generic;

namespace BulkSMS
{
    public class Credits
    {
        public double balance { get; set; }
        public int limit { get; set; }
        public bool isTransferAllowed { get; set; }
    }

    public class Quota
    {
        public int remaining { get; set; }
        public int size { get; set; }
    }

    public class OriginAddresses
    {
        public bool isFullControlAllowed { get; set; }
        public List<string> allowed { get; set; }
    }

    public class Company
    {
        public string name { get; set; }
        public string taxReference { get; set; }
    }

    public class Address
    {
        public List<string> street { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
    }

    public class Commerce
    {
        public string bankPaymentReference { get; set; }
        public Address address { get; set; }
    }

    public class Profile
    {
        public string id { get; set; }
        public string username { get; set; }
        public string honorific { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string site { get; set; }
        public string legacySite { get; set; }
        public DateTime created { get; set; }
        public string timezone { get; set; }
        public Credits credits { get; set; }
        public Quota quota { get; set; }
        public OriginAddresses originAddresses { get; set; }
        public Company company { get; set; }
        public Commerce commerce { get; set; }
    }
}
