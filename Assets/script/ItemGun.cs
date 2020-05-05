using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGun : ItemUsable
{
    public Bullet bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Use(Vector2 worldPos)
    {
        Bullet firedBullet = Instantiate(bullet, owner.transform.position, Quaternion.Euler(0f, 0f, 
            UtilMath.Atan2(worldPos - (Vector2)owner.transform.position) * Mathf.Rad2Deg));
        firedBullet.Fire();
    }
}
