﻿using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Application.Common.Interfaces
{
    public interface IBookingRepository : IRepository<Booking>
    {
        void Update(Booking entity);

        void UpdateStatus(int bookingId, string orderStatus);

        void UpdateStripePaymentID(int bookingId, string sessionId, string paymentIntentId);
    }
}
