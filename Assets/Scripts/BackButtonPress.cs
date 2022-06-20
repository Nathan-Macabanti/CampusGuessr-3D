using UnityEngine;
using UnityEngine.Events;

public class BackButtonPress : MonoBehaviour
{
    [SerializeField] private UnityEvent OnBackButtonPress;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnBackButtonPress.Invoke();
        }
    }
}
