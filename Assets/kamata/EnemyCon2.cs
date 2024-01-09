using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCon2 : MonoBehaviour
{
    public Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.name == "MobileMaleFree1 Variant")
        {
            transform.LookAt(player);

              
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
