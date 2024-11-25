using UnityEngine;
using UnityEngine.SceneManagement;

public class skipCutsceneBtn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void skipCutsceneToProlog()
    {
        SceneManager.LoadScene("Prolog");
    }
}
