﻿using System;
using System.ComponentModel.Annotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarChart.Models
{
    public class CelestialObject
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int? OrbitedObject { get; set; }

        [NotMapped]
        public List<CelestialObject> Satellites { get; set; }

        public TimeSpan OrbitalPeriod { get; set; }
    }



}
