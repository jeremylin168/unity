using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour, IHurtable
{
    public float blood=100f;
    public float energy=100f;

    public void Hurt(int damage)
    {
        blood -= damage;
    }

    // Start is called before the first frame update
    void Start()
    {
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
        if(energy>100){
            energy=100;
        }
        else if(energy<0){
            energy=0;
        }      
        
    }
     public void consume_energy(float a){
         energy-=a;
     }
     public void add_energy(float a){
         energy+=a;
     }
     public float get_energy(){
         return energy;
     }
}
