using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ffire : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullets,body,player;
    public float bullet_speed;
    private float angle;
    void Start()
    {
        bullet_speed=10f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void fire(){
        angle=body.GetComponent<PlayerRotate>().angle;
        GameObject bullet = Instantiate(bullets,player.transform.localPosition,Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().velocity=new Vector3(Mathf.Cos(angle),Mathf.Sin(angle),0)*bullet_speed;
    }
}
