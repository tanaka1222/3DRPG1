using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtk : MonoBehaviour
{
    public Animator EnemyAnimator;
    bool isEnemyAtk;
    

    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        isEnemyAtk = false;
        EnemyAnimator.SetBool("EnemyAtk", isEnemyAtk);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
                isEnemyAtk = true;
                


        }

    }


}
