using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class BirdSceneTransition : MonoBehaviour
{
    public string nextSceneName = "Tips2"; // 次に遷移するシーン名を直接指定

    void Update()
    {
        // コントローラーの入力をチェック
        if (CheckControllerTriggerPressed())
        {
            Debug.Log("Trigger pressed! Transitioning to the next scene...");
            SceneManager.LoadScene(nextSceneName);
        }
    }

    private bool CheckControllerTriggerPressed()
    {
        // メインまたはセカンダリートリガーの入力をチェック
        bool primaryTrigger = Input.GetAxis("Oculus_CrossPlatform_PrimaryIndexTrigger") > 0.1f;
        bool secondaryTrigger = Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.1f;

        return primaryTrigger || secondaryTrigger;
    }
}
