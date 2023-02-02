﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnestX.Models
{
    public class OnBoardingModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }
        public string Image { get; set; }

        public OnBoardingModel(string title, string description, int value, string image)
        {
            Title = title;
            Description = description;
            Value = value;
            Image = image;
        }
    }
}
