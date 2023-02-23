using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    public void ReastartLevel()
    {
        SceneManager.LoadScene("StartScene");
    }
}
