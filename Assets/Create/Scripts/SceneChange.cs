using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }

    public void ChangeToGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ChangeToCubeScene()
    {
        SceneManager.LoadScene("CubeScene");
    }
}
