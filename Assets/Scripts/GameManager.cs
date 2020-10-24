using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
  bool gameHasEnded = false;
  public float delayRestart = 1f;

  public GameObject completeLevelUI;

  public void EndGame()
  {
    if (!gameHasEnded)
    {
      gameHasEnded = true;
      Debug.Log("Game Over!");
      Invoke("Restart", delayRestart);
    }
  }

  public void CompleteLevel()
  {
    completeLevelUI.SetActive(true);
    Debug.Log("Level Completed!");
  }

  void Restart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}
