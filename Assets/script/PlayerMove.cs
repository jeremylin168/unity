using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Item item;

    private Rigidbody2D pl;
    public float speed=1;
    private float x,y,sq;
    // Start is called before the first frame update
    void Start()
    {
        speed=1;
        pl=GetComponent<Rigidbody2D>();
        sq=Mathf.Sqrt(2);
    }

    // Update is called once per frame
    void Update()
    {
        x=Input.GetAxisRaw("Horizontal")*speed;
        y=Input.GetAxisRaw("Vertical")*speed;
        if(x!=0&&y!=0){
            x/=sq;
            y/=sq;
        }
        pl.velocity=new Vector2(x,y);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (item is ItemUsable iu)
            {
                iu.Use(UtilInput.GetCursorWorldPos());
            }
        }
    }
}
