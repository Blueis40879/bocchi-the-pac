using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("REAL game");
    }
}
