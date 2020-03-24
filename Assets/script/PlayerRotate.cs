using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public GameObject mannager,player;
    public float angle;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        pos=mannager.GetComponent<gamemanager>().mousepos;
        angle=Mathf.Atan2(pos.y-player.transform.position.y,pos.x-player.transform.position.x);
        transform.rotation = Quaternion.Euler(0f,0f,angle* Mathf.Rad2Deg);
    }

}
