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
    private float x,sq,angle,t;
    private Vector3 pos;
    public AnemyBullet Anemy_bullet;

    public float fire_rate;
    void Start()
    {
        AnRig=GetComponent<Rigidbody2D>();
        t=fire_rate;

    }

    // Update is called once per frame
    void Update()
    {
        pos=playerpos.pos();
        angle=Mathf.Atan2(pos.y-transform.position.y,pos.x-transform.position.x);
        AnBody.GetComponent<Transform>().transform.rotation = Quaternion.Euler(0f,0f,angle* Mathf.Rad2Deg);
        AnRig.velocity= new Vector2(Mathf.Cos(angle)*speed,Mathf.Sin(angle)*speed);
        if(t<0){
            fire();
            t=fire_rate;
        }
        t-=Time.deltaTime;

    }
    private void fire(){
        
        AnemyBullet b=Instantiate(Anemy_bullet,transform.localPosition+new Vector3(Mathf.Cos(angle),Mathf.Sin(angle),0),Quaternion.identity);
        float bullet_speed = b.fire();
        b.GetComponent<Rigidbody2D>().velocity=new Vector2(Mathf.Cos(angle)*bullet_speed,Mathf.Sin(angle)*bullet_speed);
        

    }
}
