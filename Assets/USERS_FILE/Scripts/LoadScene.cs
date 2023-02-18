using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadFirstScene()
    {
        print("CALL");
        SceneManager.LoadScene("SampleScene");
    }
}
