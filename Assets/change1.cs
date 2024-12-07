using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//Unityエンジンのシーン管理プログラムを利用する

public class change1 : MonoBehaviour //changeという名前にします
{
    public void change1_button() //change_buttonという名前にします
    {
        SceneManager.LoadScene("lesson2");//secondを呼び出します
    }
}
