using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string NameScene;
    public void LoadFirstScene()
    {
        print("CALL");
        SceneManager.LoadScene(NameScene);
    }
}
