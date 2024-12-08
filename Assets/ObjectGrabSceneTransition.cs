using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class ObjectGrabSceneTransition : MonoBehaviour
{
    // オブジェクトが掴まれたときに呼ばれるイベント
    public void OnGrabbed()
    {
        // 次のシーンに遷移する
        // SceneManager.LoadScene("NextSceneName");
        StartCoroutine(LoadNextScene());
    }

    // シーン遷移のためのコルーチン
    private IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(3f);  // 3秒待機（遷移前に少し待機）
        SceneManager.LoadScene("Tips2");  // 次のシーンの名前を指定
    }
}
