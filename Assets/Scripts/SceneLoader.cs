using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void OpenTrainingScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}