using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class energy1 : MonoBehaviour
{
    public float energy;
    public PlayerControll s;

    void OnTriggerStay2D(Collider2D other)
    {
        UnityEngine.Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player")
        {
            s.add_energy(energy);
            Destroy(gameObject);
        }
    }

}
