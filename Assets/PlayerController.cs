using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // PC�L�[����������.
        float horizontalKeyInput = 0;
        // PC�L�[�c��������.
        float verticalKeyInput = 0;

    }

    // Update is called once per frame
    void Update()
    {
        // PC�L�[���͎擾.
        horizontalKeyInput = Input.GetAxis("Horizontal");
        verticalKeyInput = Input.GetAxis("Vertical");

        Debug.Log(horizontalKeyInput + "." + verticalKeyInput);
    }

    // ---------------------------------------------------------------------
    /// <summary>
    /// �U���{�^���N���b�N�R�[���o�b�N.
    /// </summary>
    // ---------------------------------------------------------------------
    public void OnAttackButtonClicked()
    {
        Debug.Log("�U��!!");
    }
}
