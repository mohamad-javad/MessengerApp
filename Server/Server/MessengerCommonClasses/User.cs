using System;


namespace Server
{
    [Serializable]
    public class User : IDisplayable
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string UserName { get; set; }

        public object GetSpecificatios()
        {
            return this;
        }
    }

}

