using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusManager : MonoBehaviour
{
    public GameObject Main;
    public int HP;
    public int MaxHP;
    public Image HPGage;

    public GameObject Effect;
    //public AudioSource audioSource;
    //public AudioClip HitSE;

    public string TagName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(HP <= 0)
        {
            HP = 0;
            var effect = Instantiate(Effect);
            effect.transform.position = transform.position;
            Destroy(effect, 5);
            Destroy(Main);
        }

        float percent = (float)HP / MaxHP;
        HPGage.fillAmount = percent;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == TagName)
        {
            Damage();

        }
    }

    void Damage()
    {
        //AudioSource.PlayOneShot(HitSE);
        HP--;
    }
}
