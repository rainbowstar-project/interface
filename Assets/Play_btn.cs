using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_btn : MonoBehaviour
{
    public void go_play(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
}
