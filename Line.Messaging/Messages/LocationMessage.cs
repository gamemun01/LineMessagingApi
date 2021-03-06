﻿namespace Line.Messaging
{
    /// <summary>
    /// Location
    /// https://developers.line.me/en/docs/messaging-api/reference/#location
    /// </summary>
    public class LocationMessage : ISendMessage
    {
        public MessageType Type { get; } = MessageType.Location;

        /// <summary>
        /// Title
        /// Max: 100 characters
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Address
        /// Max: 100 characters
        /// </summary>
        public string Address { get; }

        /// <summary>
        /// Latitude
        /// </summary>
        public decimal Latitude { get; }

        /// <summary>
        /// Longitude
        /// </summary>
        public decimal Longitude { get; }
        
        public LocationMessage(string title, string address, decimal latitude, decimal longitude)
        {
            Title = title;
            Address = address;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
