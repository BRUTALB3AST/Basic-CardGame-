using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMechanics : MonoBehaviour
{
[Header("Card Mechanics")]
    public List<Cards> Deck = new List<Cards>();
    public List<Cards> DiscardDeck = new List<Cards>();

    [Header("Card Holder Mechanics")]
    public Transform[] CardHolder;
    public bool[] AvailableHolder;
    public Text DeckSize;
    public Text DiscardDeckSize;
    
    [Header("Audio Mechanics")]
    public AudioSource DrawAudioSource;
    public AudioSource ShuffleAudioSource;
    public AudioClip DrawaudioClip;
    public AudioClip ShuffleAudioClip;

    public GameObject[] HolderImage;

 
    void Update()
    {
        
        DeckSize.text = Deck.Count.ToString();
        DiscardDeckSize.text = DiscardDeck.Count.ToString();
    }

    public void ShuffleDiscardCards()
    {
      if(DiscardDeck.Count >=1 )
      {
        ShuffleAudioSource.clip = ShuffleAudioClip;
        ShuffleAudioSource.Play();

    foreach(Cards cards in DiscardDeck)
    {
        Deck.Add(cards);
    }
    DiscardDeck.Clear();
    }
    }


public void DrawCard()
    {
        if ( Deck.Count >=1)
        {
            Cards Rcard =  Deck[Random.Range(0,Deck.Count)];
            
            for (int i =0; i < AvailableHolder.Length; i++)
            {
                if(AvailableHolder[i] == true)
                {
                    Rcard.gameObject.SetActive(true);
                    Rcard.HandIndex = i;
                    
                    DrawAudioSource.clip = DrawaudioClip;
                    DrawAudioSource.Play();

                    Rcard.transform.position = CardHolder[i].position;
                    AvailableHolder[i] = false;
                    Rcard.CardPlayed = false;

                    HolderImage[i].SetActive(true);
                    Deck.Remove(Rcard);
                    return;
                }
            }
        }
    }

    public void QuitApp()
    {
        Application.Quit();
    }

}
