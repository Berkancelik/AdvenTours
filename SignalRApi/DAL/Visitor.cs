﻿using System;

namespace SignalRApi.DAL
{


    public enum ECity
    {
        İstanbul = 1,
        Ardahan = 2,
        Kars = 3,
        Diyarbakır = 4,
    }

    public class Visitor
    {
        public int Id { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
