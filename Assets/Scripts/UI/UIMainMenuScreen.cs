using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMainMenuScreen : MonoBehaviour
{
    [SerializeField] private string LevelSceneName;
    [SerializeField] private NumberOfMapsData NumberOfMapsData; 
    [SerializeField] private int MaxNumberOfMaps;
    [SerializeField] private TMPro.TMP_Text NumberOfMapsText;
    
    private int numberOfMaps = 10;

    private void Start()
    {
        OnUpdateNumberOfMapsDisplay();
    }

    private void OnUpdateNumberOfMapsDisplay()
    {
        NumberOfMapsText.text = numberOfMaps.ToString();
    }
    
    public void OnSubtractMapAmount()
    {
        numberOfMaps = Mathf.Max(numberOfMaps - 1, 1);
        OnUpdateNumberOfMapsDisplay();
    }
    
    public void OnAddMapAmount()
    {
        numberOfMaps = Mathf.Min(numberOfMaps + 1, MaxNumberOfMaps);
        OnUpdateNumberOfMapsDisplay();
    }
    
    public void OnPlayButtonClick()
    {
        #if UNITY_EDITOR
        Debug.Log("Testing play");
        #endif
        NumberOfMapsData.NumberOfMaps = numberOfMaps;
        SceneManager.LoadScene(LevelSceneName);
    }

    public void OnBackButton()
    {
        Application.Quit();
    }
}
