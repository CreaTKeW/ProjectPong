using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public void MoveToScene(int sceneID)
    {        
        SceneManager.LoadScene(sceneID);       
    }
}
