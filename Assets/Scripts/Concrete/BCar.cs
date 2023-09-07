using Abstract;
using UnityEngine;

namespace Concrete
{
    public class BCar : BaseCar
    {
        public BCar()
        {
            _carOwner = "Steve";
            _brand = "Seat";
            _model = "Leon FR";
            _year = 2017;
            _price = "1.500.000$";
        }
    }
}
