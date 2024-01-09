using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class togeManager : MonoBehaviour
{
    //bulletプレハブ
    public GameObject bullet;
    //弾が生成されるポジションを保有するゲームオブジェクト
    public GameObject bulletPos;
    //弾丸のスピード
    public float speed = 1500f;
    //敵生成時間間隔
    private float interval;
    //経過時間
    private float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //時間間隔を決定する
        interval = 3f;
    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        //スペースが押されたとき

    }
    void OnTriggerStay(Collider col)
    {
        if (time > interval)
        {
            if (col.gameObject.name == "MobileMaleFree1 Variant")
            {
                //ballをインスタンス化して発射
                GameObject createdBullet = Instantiate(bullet) as GameObject;
                createdBullet.transform.position = bulletPos.transform.position;
                //発射ベクトル
                Vector3 force;
                //発射の向きと速度を決定
                force = bulletPos.transform.forward * speed;
                // Rigidbodyに力を加えて発射
                createdBullet.GetComponent<Rigidbody>().AddForce(force);
                //時間リセット
                time = 0;
            }
        }
         
    }
}
