using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public Vector3 mousepos; 

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            GetComponent<ffire>().fire();
        }
        mousepos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mousepos=Input.mousePosition;
    }


}
