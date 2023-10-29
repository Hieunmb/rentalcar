﻿using System;
using System.Collections.Generic;

namespace RentalCar.Entities;

public partial class DrivingLicense
{
    public int Id { get; set; }

    public int UsersId { get; set; }

    public string Icon { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual User Users { get; set; } = null!;
}
