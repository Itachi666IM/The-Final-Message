using System.Collections;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class FinalSceneManager : MonoBehaviour
{
    [Header("Top Row")]
    [SerializeField] private Animator dontText;
    [SerializeField] private Animator be1Text;
    [SerializeField] private Animator sadText;
    [SerializeField] private Animator iText;
    [SerializeField] private Animator amText;
    [SerializeField] private Animator goneText;
    [SerializeField] private Animator be2Text;
    [SerializeField] private Animator happyText;
    [SerializeField] private Animator weText;
    [SerializeField] private Animator wereText;

    [Header("Bottom Row")]
    [SerializeField] private Animator togetherText;
    [SerializeField] private Animator forText;
    [SerializeField] private Animator soText;
    [SerializeField] private Animator longText;

    [SerializeField] private Animator wordParent;
    [SerializeField] private GameObject teardrop1;
    [SerializeField] private GameObject teardrop2;

    private void Start()
    {
        StartCoroutine(PlayAnimations());
    }

    private IEnumerator PlayAnimations()
    {
        // Top Row
        dontText.SetTrigger("drop");
        yield return new WaitForSeconds(1f);
        be1Text.SetTrigger("drop");
        yield return new WaitForSeconds(1f);
        sadText.SetTrigger("drop");
        yield return new WaitForSeconds(1f);
        iText.SetTrigger("drop");
        yield return new WaitForSeconds(1f);
        amText.SetTrigger("drop");
        yield return new WaitForSeconds(1f);
        goneText.SetTrigger("drop");
        yield return new WaitForSeconds(1f);
        be2Text.SetTrigger("drop");
        yield return new WaitForSeconds(1f);
        happyText.SetTrigger("drop");
        yield return new WaitForSeconds(1f);
        weText.SetTrigger("drop");
        yield return new WaitForSeconds(1f);
        wereText.SetTrigger("drop");
        yield return new WaitForSeconds(1f);

        //Bottom Row
        togetherText.SetTrigger("rise");
        yield return new WaitForSeconds(1f);
        forText.SetTrigger("rise");
        yield return new WaitForSeconds(1f);
        soText.SetTrigger("rise");
        yield return new WaitForSeconds(1f);
        longText.SetTrigger("rise");
        yield return new WaitForSeconds(1f);

        //Cry
        wordParent.SetTrigger("cry");
        yield return new WaitForSeconds(1f);
        teardrop1.SetActive(true);
        yield return new WaitForSeconds(1f);
        teardrop2.SetActive(true);

        yield return new WaitForSeconds(2f);
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
            Application.Quit();
#endif

    }
}
