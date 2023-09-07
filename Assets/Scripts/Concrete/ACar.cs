using System;
using Abstract;
using UnityEngine;

namespace Concrete
{
    public class ACar : BaseCar
    {
        public ACar()
        {
            _carOwner = "David";
            _brand = "Opel";
            _model = "Astra J";
            _year = 2014;
            _price = "800.000$";
        }
    }
}
