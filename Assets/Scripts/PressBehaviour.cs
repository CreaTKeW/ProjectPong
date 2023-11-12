using UnityEngine;

public class PressBehaviour : MonoBehaviour
{
    [SerializeField] private string GitUrl;
    [SerializeField] private string GameUrl;
    private void LinkToGitHub()
    {
        Application.OpenURL(GitUrl);
    }

    private void LinkToGame()
    {
        Application.OpenURL(GameUrl);
    }
}
