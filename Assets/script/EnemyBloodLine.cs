using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBloodLine : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private float bl;
    // Update is called once per frame
    void Update()
    {
        bl=player.GetComponent<AnenyControl>().e_blood;
        transform.localScale=new Vector3((float)2*(bl/100),0.2f,1f);
    }
}
