﻿namespace ArchitectureSkeleton.Model
{
    public class Product
    {
        public int Id { get; set; }
        public required string No { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
    }
}
