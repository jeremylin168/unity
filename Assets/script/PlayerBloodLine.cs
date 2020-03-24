using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBloodLine : MonoBehaviour
{
    public GameObject player;
    private float bl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bl=player.GetComponent<PlayerControll>().blood;
        transform.localScale=new Vector3((float)2*(bl/100),0.2f,1f);
    }
}
