﻿namespace Domain.Entities;

public class StartupCategory : BaseEntity
{
    public required string Name { get; set; }
    public required string Description { get; set; }
}