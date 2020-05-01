using UnityEngine;
using UnityEngine.SceneManagement;


public class SwitchScene : MonoBehaviour
{
    public AudioSource clickSound;
    public void Switch()
    {
        SceneManager.LoadScene("GameScene");
        clickSound.Play();
    }
}
