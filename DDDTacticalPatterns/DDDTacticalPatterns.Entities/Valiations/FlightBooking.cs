﻿using System;

namespace DDDTacticalPatterns.Entities.Valiations
{
    public class FlightBooking
    {

        private bool _confirmed = false;

        public FlightBooking(Guid id, DateTime departureDate, Guid customerId)
        {
            if (id == null)
                throw new Exception("Id Missing");
            if (departureDate == null)
                throw new Exception("Departure Date Missing");
            if (customerId == null)
                throw new Exception("Customer Id Missing");
            Id = id;
            DepartureDate = departureDate;
            CustomerId = customerId;
        }

        public Guid Id { get; private set; }

        public DateTime DepartureDate { get; private set; }

        public Guid CustomerId { get; private set; }

        public void Reschedule(DateTime newDeparture)
        {
            if (_confirmed) throw new Exception("Could not change Depature Date after confermation");
            DepartureDate = newDeparture;
        }

        public void Confirm()
        {
            _confirmed = true;
        }
    }
}