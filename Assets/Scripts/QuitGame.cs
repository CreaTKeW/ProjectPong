using UnityEngine;

public class QuitGame : MonoBehaviour
{
    private void OnApplicationQuit()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;

        #else
        Application.Quit();
        #endif
    }
}
