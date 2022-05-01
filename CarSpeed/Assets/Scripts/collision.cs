using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision : MonoBehaviour
{
    public Slider _slide;
    public float _sliderdecrease = 100f;
    //public Collider _collider;
    // Start is called before the first frame update
    //Sound
    public AudioSource CarCrash;
    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "collision")
        {
            _slide.value -= _sliderdecrease;
            CarCrash.PlayOneShot(CarCrash.clip);
        }
    }
}
