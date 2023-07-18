using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // PCキー横方向入力.
        float horizontalKeyInput = 0;
        // PCキー縦方向入力.
        float verticalKeyInput = 0;

    }

    // Update is called once per frame
    void Update()
    {
        // PCキー入力取得.
        horizontalKeyInput = Input.GetAxis("Horizontal");
        verticalKeyInput = Input.GetAxis("Vertical");

        Debug.Log(horizontalKeyInput + "." + verticalKeyInput);
    }

    // ---------------------------------------------------------------------
    /// <summary>
    /// 攻撃ボタンクリックコールバック.
    /// </summary>
    // ---------------------------------------------------------------------
    public void OnAttackButtonClicked()
    {
        Debug.Log("攻撃!!");
    }
}
