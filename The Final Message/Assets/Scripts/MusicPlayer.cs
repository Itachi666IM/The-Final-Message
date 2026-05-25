using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    void ManageSingleton()
    {
        int instance = FindObjectsByType<MusicPlayer>(FindObjectsSortMode.None).Length;

        if(instance>1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Awake()
    {
        ManageSingleton();
    }
}
