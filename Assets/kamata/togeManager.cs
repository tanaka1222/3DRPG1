using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class togeManager : MonoBehaviour
{
    //bullet�v���n�u
    public GameObject bullet;
    //�e�����������|�W�V������ۗL����Q�[���I�u�W�F�N�g
    public GameObject bulletPos;
    //�e�ۂ̃X�s�[�h
    public float speed = 1500f;
    //�G�������ԊԊu
    private float interval;
    //�o�ߎ���
    private float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //���ԊԊu�����肷��
        interval = 3f;
    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        //�X�y�[�X�������ꂽ�Ƃ�

    }
    void OnTriggerStay(Collider col)
    {
        if (time > interval)
        {
            if (col.gameObject.name == "MobileMaleFree1 Variant")
            {
                //ball���C���X�^���X�����Ĕ���
                GameObject createdBullet = Instantiate(bullet) as GameObject;
                createdBullet.transform.position = bulletPos.transform.position;
                //���˃x�N�g��
                Vector3 force;
                //���˂̌����Ƒ��x������
                force = bulletPos.transform.forward * speed;
                // Rigidbody�ɗ͂������Ĕ���
                createdBullet.GetComponent<Rigidbody>().AddForce(force);
                //���ԃ��Z�b�g
                time = 0;
            }
        }
         
    }
}
