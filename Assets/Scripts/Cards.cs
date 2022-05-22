using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards : MonoBehaviour
{
    public bool CardPlayed;
    public int HandIndex;
    private GameMechanics L_AvailableHolders;

[SerializeField]
    private GameObject[] L_HolderImage;

    [SerializeField]
    private AudioSource PikupCardSource;
    [SerializeField]
    private AudioClip PickupCardClip; 
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

            PikupCardSource.clip = PickupCardClip;
            PikupCardSource.Play();

            L_AvailableHolders.AvailableHolder[HandIndex] = true;

            DiableHolderImage();

            Invoke("Discard",2f);
        }
    }


public void DiableHolderImage()
{
    for (int i =0; i < L_AvailableHolders.AvailableHolder.Length; i++)
    {
        L_HolderImage[HandIndex].SetActive(false);
    }
}
    public void Discard()
    {
        L_AvailableHolders.DiscardDeck.Add(this);
        gameObject.SetActive(false);
    }
}
