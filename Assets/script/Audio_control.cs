using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_control : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource Gun_shot;

    public void PlayGunShot(){
        Gun_shot.Play();
    }
}
