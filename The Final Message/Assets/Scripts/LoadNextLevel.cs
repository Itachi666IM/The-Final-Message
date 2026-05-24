using DTT.WordConnect;
using DTT.WordConnect.Editor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadNextLevel : MonoBehaviour
{
    private WordConnectLevelSelectHandler levelHandler;

    [SerializeField] private string[] messagesFromGrandma;
    [SerializeField] private TMP_Text messageText;
    [SerializeField] GameObject messageBox;
    int index = 0;
    private string currentMessage;

    private void Awake()
    {
        levelHandler = GetComponent<WordConnectLevelSelectHandler>();
    }

    private void Start()
    {
        FindCurrentConfigIndex();
        DisplayGrandmaMessage();
    }

    private void FindCurrentConfigIndex()
    {
        WordConnectConfigurationData[] allConfigs = levelHandler.allConfigs();
        for (int i = 0; i < allConfigs.Length; i++)
        {
            if (allConfigs[i] == WordConnectManager.Instance.Configuration)
            {
                index = i;
                break;
            }
        }
    }

    private void DisplayGrandmaMessage()
    {
        messageText.text = "";
        currentMessage = messagesFromGrandma[index];
        messageText.text = "Grandma's Message : " + currentMessage;
    }

    public void StartNextLevel()
    {
        if(index+1<levelHandler.allConfigs().Length)
        {
            WordConnectConfigurationData[] allConfigs = levelHandler.allConfigs();
            WordConnectConfigurationData configToLoad = allConfigs[index+1];
            WordConnectManager.Instance.StartGame(configToLoad);
            FindCurrentConfigIndex();
            DisplayGrandmaMessage();
            messageBox.SetActive(false);
        }
        else
        {
            SceneManager.LoadScene("Test");
        }
        
    }
}
