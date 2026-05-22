using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuManager : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private Button backButton;

    [SerializeField] private AudioClip clickSound;
    [SerializeField] private AudioClip hoverSound;
    private void Start()
    {

        // Button Click sounds

        playButton.onClick.AddListener(() =>
        {
            SFXPlayer.Instance.PlaySFX(clickSound);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        });

        settingsButton.onClick.AddListener(() =>
        {
            SFXPlayer.Instance.PlaySFX(clickSound);
        });

        exitButton.onClick.AddListener(() =>
        {
            SFXPlayer.Instance.PlaySFX(clickSound);
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#else
            Application.Quit();
#endif
        });

        backButton.onClick.AddListener(() =>
        {
            SFXPlayer.Instance.PlaySFX(clickSound);
        });

    }

    public void PlayHoverSound()
    {
        SFXPlayer.Instance.PlaySFX(hoverSound);
    }
}
