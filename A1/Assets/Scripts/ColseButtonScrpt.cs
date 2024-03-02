using UnityEngine;
using UnityEngine.UI;

public class ClosePanelButton : MonoBehaviour
{
    public GameObject panelToClose; // Reference to the panel you want to close

    void Start()
    {
        if (panelToClose == null)
        {
            Debug.LogError("Panel to close is not assigned for ClosePanelButton in " + gameObject.name);
        }
    }

    public void ClosePanel()
    {
        panelToClose.SetActive(false); // Deactivate the panel
    }
}
