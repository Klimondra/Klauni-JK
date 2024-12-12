using TMPro;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PrologDoorCutscene : MonoBehaviour
{

    public Transform playerTrans;
    public Transform triggerPoint;
    public TMP_Text textHint;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textHint.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(triggerPoint.position, playerTrans.position) < 1f)
        {
            textHint.enabled = true;

            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("PrologDoorCutscene");
            }
        }
        else
        {
            textHint.enabled = false;
        }
    }
}
