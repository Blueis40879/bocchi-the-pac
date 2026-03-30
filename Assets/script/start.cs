using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public void LoadCurrentScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("REAL game");
        Time.timeScale = 1;
    }
}
