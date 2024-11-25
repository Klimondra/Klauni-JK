using UnityEngine;
using UnityEngine.SceneManagement;

public class playBtn : MonoBehaviour
{
    public void ButtonPressed()
    {
        SceneManager.LoadScene("Sceny/UI-Sceny/Start-cutscene");
    }
}
