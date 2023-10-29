﻿using System;
using System.Collections.Generic;

namespace RentalCar.Entities;

public partial class Service
{
    public int Id { get; set; }

    public int RentalId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Rental Rental { get; set; } = null!;
}
