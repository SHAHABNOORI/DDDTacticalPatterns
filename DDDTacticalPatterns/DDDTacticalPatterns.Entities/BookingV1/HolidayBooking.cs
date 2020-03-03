using System;

namespace DDDTacticalPatterns.Entities.BookingV1
{
    public class HolidayBooking
    {
        public HolidayBooking(int travelerId, DateTime firstNight, DateTime lastNight, DateTime booked)
        {
            TravelerId = travelerId;
            FirstNight = firstNight;
            LastNight = lastNight;
            Booked = booked;
            Id = GenerateId(travelerId, firstNight, lastNight, booked);
        }

        public string Id { get; private set; }

        public int TravelerId { get; private set; }

        public DateTime FirstNight { get; private set; }

        public DateTime LastNight { get; private set; }

        public DateTime Booked { get; private set; }

        private string GenerateId(int travelerId, DateTime firstNight, DateTime lastNight, DateTime booked)
        {
            return $"{travelerId}-{ToIdFormat(firstNight)}-{ToIdFormat(lastNight)}-{ToIdFormat(booked)}";
        }

        private string ToIdFormat(DateTime date)
        {
            return date.ToString("yyyy/MM/dd");
        }

    }
}