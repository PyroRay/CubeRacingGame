using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartFromStart : MonoBehaviour
{
    public void LoadTitleLevel()
    {
        SceneManager.LoadScene(0);
    }
}
