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
    [SerializeField] private Animator envelopeAnimator;
    private void Start()
    {

        // Button Click sounds

        playButton.onClick.AddListener(() =>
        {
            SFXPlayer.Instance.PlaySFX(clickSound);
            envelopeAnimator.SetTrigger("play");
            playButton.gameObject.SetActive(false);
            settingsButton.gameObject.SetActive(false);
            exitButton.gameObject.SetActive(false);
            Invoke("PlayStoryScene", 2f);
            
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

    private void PlayStoryScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
