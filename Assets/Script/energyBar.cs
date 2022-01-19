using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class energyBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public void SetMaxHealth(int health)
    {
        
        slider.value = health;

    }
        public void SetHealth(int health)
        {
            slider.value =health;

        }
    
}
