using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;

namespace Lab_11._2.Models
{
    public enum Drink
    {
        Cappuccino,
        Espresso,
        IcedCoffee,
        Latte,
        ColdBrewCoffee,
        FrappéCoffee,
        CafféMocha,
        Carajillo
    }

    public enum Size
    {
        Short,
        Tall,
        Grande,
        Venti
    }

    public class WebOrder
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StreetAddress1 { get; set; }

        public string StreetAddress2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }
    }
}