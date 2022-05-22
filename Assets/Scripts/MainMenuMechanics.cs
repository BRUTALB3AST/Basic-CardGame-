using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMechanics : MonoBehaviour
{
    [SerializeField]
    private GameObject MainMenuPanel;
    
    public void  PanelDeactivate()
    {
        MainMenuPanel.SetActive(false);
       
    }

}
