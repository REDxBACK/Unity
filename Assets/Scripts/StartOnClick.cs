using UnityEngine;

public class StartOnClick : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("StartOnClick script run. log output");
    }
    

    public void doExitGame()
    {
        Application.Quit();
        Debug.Log("game is closing");
    }
}
