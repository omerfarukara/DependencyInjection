using Abstract;
using TMPro;
using UnityEngine;

namespace Concrete
{
    public class TestScript : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI aCarText;
        [SerializeField] private TextMeshProUGUI bCarText;

        public void GetInformation()
        {
            Car aCar = new Car(new ACar());
            Car bCar = new Car(new BCar());
            
            aCar.GetInformation(aCarText);
            bCar.GetInformation(bCarText);
        }
    }
}
