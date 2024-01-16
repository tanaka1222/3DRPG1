using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMG : MonoBehaviour
{
	//　スタートボタンを押したら実行する
	public void StartGame()
	{
		SceneManager.LoadScene(1);
	}
	public void Quit()
	{
     #if UNITY_EDITOR
	   UnityEditor.EditorApplication.isPlaying = false;
     #else
      Application.Quit();
     #endif
	}
}
