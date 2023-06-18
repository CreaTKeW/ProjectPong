using UnityEngine;

public class PressBehaviour : MonoBehaviour
{
    public string GitUrl;
    public string GameUrl;
    public void LinkToGitHub()
    {
        Application.OpenURL(GitUrl);
    }

    public void LinkToGame()
    {
        Application.OpenURL(GameUrl);
    }
}
