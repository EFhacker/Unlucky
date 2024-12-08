using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HunballChecker : MonoBehaviour
{
    [SerializeField] private float delayBeforeTransition = 3f; // 次のシーンに遷移するまでの遅延時間
    [SerializeField] private string nextSceneName = "Tips1"; // 次のシーン名

    private void Update()
    {
        // "hunball" タグのオブジェクトがすべて破壊されているか確認
        GameObject[] hunballs = GameObject.FindGameObjectsWithTag("hunball");
        if (hunballs.Length == 0)
        {
            // すべて破壊されていれば次のシーンへの遷移を開始
            StartCoroutine(TransitionToNextScene());
        }
    }

    private IEnumerator TransitionToNextScene()
    {
        // 遅延時間を待つ
        yield return new WaitForSeconds(delayBeforeTransition);

        // 次のシーンに遷移
        SceneManager.LoadScene(nextSceneName);
    }
}
