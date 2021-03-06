﻿using System;

namespace DDDTacticalPatterns.Entities.BookingV2
{
    public class HolidayBooking
    {
        public HolidayBooking(int travelerId, Stay stay, DateTime booked)
        {
            this.TravelerId = travelerId;
            this.Stay = stay;
            this.Booked = booked;
            this.Id = GenerateId(travelerId, stay.FirstNight, stay.LastNight, booked);
        }

        public string Id { get; private set; }

        public int TravelerId { get; private set; }

        public Stay Stay { get; private set; }

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