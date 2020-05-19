using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Item item;
    public PlayerControll PlayerEnergy;

    public float energy_consume=5,energy_regen=5;
    private float t;

    private Rigidbody2D pl;
    public float speed;
    private float ospeed;
    private float x,y,sq;
    // Start is called before the first frame update
    void Start()
    {
        ospeed=speed;
        pl=GetComponent<Rigidbody2D>();
        sq=Mathf.Sqrt(2);
    }

    // Update is called once per frame
    void Update()
    {
        x=Input.GetAxisRaw("Horizontal")*ospeed;
        y=Input.GetAxisRaw("Vertical")*ospeed;
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
        if(Input.GetKey(KeyCode.LeftShift)){
            if(PlayerEnergy.get_energy()>0){
            ospeed=2*speed;
            PlayerEnergy.consume_energy(energy_consume*Time.deltaTime);
            }
            else{
                t=1;
                ospeed=speed;
            }

            
        }
        else{
            ospeed=speed;
            if(t<0){
                PlayerEnergy.add_energy(energy_regen*Time.deltaTime);
            }
            else{
                t-=Time.deltaTime;
            }

        }
        
    }
}
