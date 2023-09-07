using Abstract;
using TMPro;
using UnityEngine;

namespace Concrete
{
    public class Car : MonoBehaviour
    {
        private ICar _iCar;

        public Car(ICar iCar)
        {
            _iCar = iCar;
        }
        
        public void GetInformation(TextMeshProUGUI text)
        {
            _iCar.GetInformation(text);
        }
    }
}
