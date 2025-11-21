using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoder : MonoBehaviour
{
  public void LoadScene(string sceneName)
  {
    SceneManager.LoadScene(sceneName);
    
  }

  public void QuitGame()
  {

    Application.Quit();

  }
}
