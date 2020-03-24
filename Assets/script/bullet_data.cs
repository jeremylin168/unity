using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_data : MonoBehaviour
{
    private float life_time;
    // Start is called before the first frame update
    void Start()
    {
        life_time=5f;
    }

    // Update is called once per frame
    void Update()
    {
        life_time-=Time.deltaTime;
        if(life_time<0){
            Destroy(gameObject);
        } 
    }
}
