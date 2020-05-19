using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour
{
    // Start is called before the first frame updatepublic GameObject player;
    private float En;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        En=player.GetComponent<PlayerControll>().energy;
        transform.localScale=new Vector3((float)2*(En/100),0.2f,1f);
    }
}
