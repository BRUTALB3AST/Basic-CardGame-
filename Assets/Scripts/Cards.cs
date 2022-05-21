using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards : MonoBehaviour
{
    public bool CardPlayed;
    public int HandIndex;
    private GameMechanics L_AvailableHolders;
    // Start is called before the first frame update
    void Start()
    {
        L_AvailableHolders =FindObjectOfType<GameMechanics>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(CardPlayed == false)
        {
            transform.position += Vector3.forward * 5;
            CardPlayed = true;
            L_AvailableHolders.AvailableHolder[HandIndex] = true;
            Invoke("Discard",2f);
        }
    }


    public void Discard()
    {
        L_AvailableHolders.DiscardDeck.Add(this);
        gameObject.SetActive(false);
    }
}
