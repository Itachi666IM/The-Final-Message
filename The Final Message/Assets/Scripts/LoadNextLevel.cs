using DTT.WordConnect;
using DTT.WordConnect.Editor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using DTT.WordConnect.Demo;

public class LoadNextLevel : MonoBehaviour
{
    private WordConnectLevelSelectHandler levelHandler;

    [SerializeField] private string[] messagesFromGrandma;
    [SerializeField] private TMP_Text messageText;
    [SerializeField] ResultsUI resultUI;
    int index = 0;
    private string currentMessage;
    private WordConnectConfigurationData[] allConfigs;

    private void Awake()
    {
        levelHandler = GetComponent<WordConnectLevelSelectHandler>();
    }

    private void Start()
    {
        allConfigs = levelHandler.allConfigs();
        WordConnectManager.Instance.Finish += Instance_Finish;
    }

    private void OnDestroy()
    {
        WordConnectManager.Instance.Finish -= Instance_Finish;
    }

    private void Instance_Finish(WordConnectResult obj)
    {
        SetGrandmaMessage();
    }


    private void SetGrandmaMessage()
    {
        messageText.text = "";
        currentMessage = messagesFromGrandma[index];
        messageText.text = "Grandma's Message : " + currentMessage;
    }

    public void StartNextLevel()
    {
        if(index+1<levelHandler.allConfigs().Length)
        {

            WordConnectConfigurationData configToLoad = allConfigs[index+1];
            WordConnectManager.Instance.StartGame(configToLoad);
            index++;
            resultUI.FadeOutUI();
        }
        else
        {
            SceneManager.LoadScene("Test");
        }
        
    }
}
