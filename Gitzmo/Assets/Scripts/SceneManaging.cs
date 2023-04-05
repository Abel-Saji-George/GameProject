using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManaging : MonoBehaviour
{
   public string sceneName;
   public void GoNextScene(string sceneName )
   {
    SceneManager.LoadScene(sceneName);
   }
}
