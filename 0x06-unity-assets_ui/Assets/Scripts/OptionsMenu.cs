using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("lastSceneLoaded"));
    }
}
