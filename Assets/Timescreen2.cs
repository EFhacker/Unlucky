using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeScreen2 : MonoBehaviour
{
    [SerializeField] private float displayDuration = 10f; // 表示する時間
    [SerializeField] private string nextSceneName = "lesson2"; // 次のシーン名

    private void Start()
    {
        // 指定時間後に次のシーンを読み込む
        Invoke("LoadNextScene", displayDuration);
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
