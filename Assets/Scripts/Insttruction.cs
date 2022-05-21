using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insttruction : MonoBehaviour
{
    [SerializeField]
    private GameObject Instruction;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("InstructionPanelDeactivate", 10f);
    }

    // public void InstructionPanelActive()
    // {
    //     if(Instruction != null)
    //     {
    //    Instruction.SetActive(true);
    //     }
    // }

    public void  InstructionPanelDeactivate()
    {
        if(Instruction !=null)
        {
        Instruction.SetActive(false);
        }
    }

}
