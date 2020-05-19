using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 10;
    public float speed = 20f;
    public float range = 10f;

    public float lifetime;

    public Rigidbody2D rigidbody2d;
    public Audio_control Audio;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameObject.activeSelf) return;

        lifetime -= Time.deltaTime;
        if (lifetime <= 0f)
        {
            Kill();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<IHurtable>() is IHurtable hurtable)
        {
            hurtable.Hurt(damage);
            Kill();
        }
    }

    protected void Kill()
    {
        Destroy(gameObject);
    }

    public void Fire()
    {
        Audio.PlayGunShot();
        gameObject.SetActive(true);
        lifetime = range / speed;
        Debug.Log(gameObject.name);
        rigidbody2d.velocity = UtilMath.Polar2Vector2(speed, transform.rotation.eulerAngles.z * Mathf.Deg2Rad);
    }
}
