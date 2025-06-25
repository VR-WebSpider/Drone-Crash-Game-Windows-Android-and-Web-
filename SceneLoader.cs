using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadGameStartScene()
    {
        SceneManager.LoadScene("GameStart");
    }
}
