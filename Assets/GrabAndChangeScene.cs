using System.Collections;
using System.Collections.Generic;
using UnityEngine;  // UnityEngine名前空間をインポート
using UnityEngine.SceneManagement;  // シーン管理のために必要
using UnityEngine.XR.Interaction.Toolkit;  // XR Interaction Toolkitのために必要

public class GrabAndChangeScene : MonoBehaviour
{
    public string nextSceneName = "Tips2";  // 次のシーン名を直接設定
    public float delayTime = 3f;  // シーン遷移までの遅延時間（3秒）

    private bool isGrabbed = false;  // オブジェクトが掴まれているかどうか

    void Start()
    {
        // XRGrabInteractable コンポーネントを取得し、イベントを設定
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.onSelectEntered.AddListener(OnGrabbed);  // 掴んだ時
        grabInteractable.onSelectExited.AddListener(OnReleased); // 離した時
    }

    // オブジェクトが掴まれた時に呼ばれる
    private void OnGrabbed(XRBaseInteractor interactor)
    {
        // 掴まれた時に遅延後のシーン遷移を開始
        isGrabbed = true;
        Invoke("ChangeScene", delayTime);  // 3秒後にシーン遷移
    }

    // オブジェクトが離された時に呼ばれる
    private void OnReleased(XRBaseInteractor interactor)
    {
        // 掴んでいる状態をリセット
        isGrabbed = false;
    }

    // シーン遷移
    void ChangeScene()
    {
        if (isGrabbed)
        {
            // 3秒後にシーン遷移
            SceneManager.LoadScene(nextSceneName);  // 次のシーンに遷移
        }
    }
}
