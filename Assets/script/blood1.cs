using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class blood1 : MonoBehaviour
{
    public float blood;
    public PlayerControll b;


    
    // Start is called before the first frame update
    void OnTriggerStay2D(Collider2D other)
    {
        UnityEngine.Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player")
        {
            b.add_blood(blood);
            Destroy(gameObject);
        }
    }
}
