using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueOpen : MonoBehaviour
{

    public string dialogue;
    public GameObject interfaceManager;
    public PlayerHolding pHolding;
    public bool begin = true;
    public bool end = false;
    private string[] collectibles;
    private int clue;

    private AudioSource greeting;

    // Start is called before the first frame update
    void Start()
    {
        greeting = GetComponent<AudioSource>();
        collectibles = new string[] { "film", "balloons", "life saver", "bull's eye", "pipe", "key", "fish", "birdhouse", "red airhorn", "magic hat" };
        createClue();
    }

    public void createClue()
    {
        clue = Random.Range(0, 9);
        searchDialogue();
    }

    public void searchDialogue()// function ssearch dialogue
    {
        dialogue = "Hi! Can you help me find my" + collectibles[clue] + "?";// makes a dialogue to say to help find one of the collectibles in start function
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!begin && pHolding.Verify())
        {
            checkClue();
        }
        greeting.Play(0);
        interfaceManager.GetComponent<InterfaceManager>().ShowBox(dialogue, clue); // will get the  interface compoennt and the showbox will sned vales of the dialogue and the clue
    }

    private void checkClue()
    {
        if (pHolding.holdValue == clue)
        {
            end = true;
        }
        else
        {

        }
    }

    public void coinsScattered()
    {
        begin = false;
    }

}
