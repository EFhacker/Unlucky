using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HunballManager : MonoBehaviour
{
    private GameObject[] hunballs; // "hunball" を格納する配列

    void Update()
    {
        // "hunball" タグがついたすべてのオブジェクトを取得
        hunballs = GameObject.FindGameObjectsWithTag("hunball");

        // "hunball" の残り個数を表示
        print("3" + hunballs.Length);

        // すべての hunball が回収されたら、クリアシーンに移行
        if (hunballs.Length == 0)
        {
            SceneManager.LoadScene("Clear"); // Clearシーンをロード
        }
    }
}
