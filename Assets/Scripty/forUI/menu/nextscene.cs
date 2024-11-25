using UnityEngine;
using UnityEngine.SceneManagement;

public class next_scene : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Settings");
    }
}
