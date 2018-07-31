﻿using System;
using TrackApartmentsApp.Domain.Models;

namespace TrackApartmentsApp.Domain.Sinks.Conditions
{
    public class EmailCondition : IEmailCondition
    {
        public bool IsValid(Apartment flat)
        {
            var isNew = new IsNewSpecification(1);
            var isOwner = new IsOwnerSpecification();
            var priceLower = new PriceLowerSpecification(400);

            return isNew
                .And(isOwner)
                .And(priceLower)
                .IsSatisfiedBy(flat);
        }
    }
}
