using UnityEngine;
using UnityEngine.SceneManagement;

public class next_scene1 : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Menu");
    }
}
