﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float blood=100f;
    // Start is called before the first frame update
    void Start()
    {
        blood=100f;
    }

    // Update is called once per frame
    void Update()
    {
        if(blood>100){
            blood=100;
        }
        else if(blood<0){
            blood=0;
        }
        
    }
}
