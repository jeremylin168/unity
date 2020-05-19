using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnemyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public int damage = 10;

    public float speed=20f;
    public float range = 10f;

    private float lifetime;
    public Audio_control Audio;
    void Start()
    {
        lifetime = range / speed;       
    }

    // Update is called once per frame
    void Update()
    {
        lifetime -= Time.deltaTime;
        if (lifetime <= 0f)
        {
            Kill();
        }   
    }
    
    public void Kill()
    {
        Destroy(gameObject);
    }
    public float fire(){
        Audio.PlayGunShot();
        gameObject.SetActive(true);
        return speed;
    }
}
