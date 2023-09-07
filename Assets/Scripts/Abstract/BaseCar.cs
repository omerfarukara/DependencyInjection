using System;
using System.Globalization;
using TMPro;
using UnityEngine;

namespace Abstract
{
    public abstract class BaseCar : ICar
    {
        protected string _carOwner;
        protected string _brand;
        protected string _model;
        protected int _year;
        protected string _price;
             
        public void GetInformation(TextMeshProUGUI text)
        {
            text.text = $"{_carOwner}'s car information\n \n" +
                        $" Brand => {_brand}. \n" +
                        $" Model => {_model}. \n" +
                        $" Year => {_year}. \n" +
                        $" Price => {_price}";
        }
    }
}