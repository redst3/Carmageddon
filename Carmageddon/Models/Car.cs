﻿using Carmageddon.Forms.Prototype;

namespace Carmageddon.Forms.Models
{
    public abstract class Car : IPrototype
    {
        public enum CarSize
        {
            Small,
            Medium,
            Big,
        }

        public int Health { get; set; }
        public int Length { get; set; }
        public string Image { get; set; }

        public (int, int, string) GetInfo()
        {
            return (Health, Length, Image);
        }

        public Car MakeCopy()
        {
            return (Car)this.MemberwiseClone();
        }
    }
}
