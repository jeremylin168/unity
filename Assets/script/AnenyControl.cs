using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnenyControl : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMove playerpos;
    public GameObject AnBody;
    public float speed;
    private Rigidbody2D AnRig;
    private float x,sq,angle;
    private Vector3 pos;
    void Start()
    {
        AnRig=GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        pos=playerpos.pos();
        angle=Mathf.Atan2(pos.y-transform.position.y,pos.x-transform.position.x);
        AnBody.GetComponent<Transform>().transform.rotation = Quaternion.Euler(0f,0f,angle* Mathf.Rad2Deg);

        AnRig.velocity= new Vector2(Mathf.Cos(angle)*speed,Mathf.Sin(angle)*speed);
    }
}
