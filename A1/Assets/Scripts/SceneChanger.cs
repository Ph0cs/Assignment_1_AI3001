using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private string sceneName;
    //name of the scene to load
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
