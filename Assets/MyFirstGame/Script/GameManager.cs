
using UnityEngine;
using UnityEngine.SceneManagement;

class GameManager : MonoBehaviour
{
    [SerializeField] string sceneName = "UNSET!!!";
    public void ReloadScene()
    {
        SceneManager.LoadScene(sceneName);

    }
}
