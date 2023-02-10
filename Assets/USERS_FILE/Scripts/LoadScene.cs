using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadFirstScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
