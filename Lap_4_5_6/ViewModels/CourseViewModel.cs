﻿using Lap_4_5_6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lap_4_5_6.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public byte Category { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0},{1}", Date, Time));
        }
    }
}