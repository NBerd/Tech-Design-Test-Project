using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadSceneById(int sceneId) 
    {
        SceneManager.LoadScene(sceneId);
    }

    public void ExitGame() 
    {
        Application.Quit();
    }
}