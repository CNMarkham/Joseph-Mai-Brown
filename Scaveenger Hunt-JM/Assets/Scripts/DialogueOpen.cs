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
        dialogue = collectibles[clue];// makes a dialogue to say to help find one of the collectibles in start function
        switch(clue){
            case 0:
                dialogue = ("Oh no, I lost my fliming machine for a show, can you help me find it?");
                break;
            case 1:
                dialogue = ("Oh no, I lost my balloons for a party, can you help me find it?");
                break;
            case 2:
                dialogue = ("Oh no, I lost my floaty for the beach I was going to, can you help me find it?");
                break;
            case 3:
                dialogue = ("Oh no, I lost my target for archery class, can you help me find it?");
                break;
            case 4:
                dialogue = ("Oh no, I lost my pipe for smoking, can you help me find it?");
                break;
            case 5:
                dialogue = ("Oh no, I lost my keys for my house, can you help me find it?");
                break;
            case 6:
                dialogue = ("Oh no, I lost my fishes that I caught, can you help me find it?");
                break;
            case 7:
                dialogue = ("Oh no, I lost my bird house that I bought for my birds, can you help me find it?");
                break;
            case 8:
                dialogue = ("Oh no, I lost my airhorn for pranking my friends, can you help me find it?");
                break;
            case 9:
                dialogue = ("Oh no, I lost my birthday cake for my birthday, can you help me find it?");
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!begin && pHolding.Verify())// checks if the begin variable is false and the player if the player collected anything
        {
            checkClue();// if so then will check the clue of what the player is holding
        }
        greeting.Play(0);
        // will get the  interface compoennt and the showbox will sned vales of the dialogue and the clue
        interfaceManager.GetComponent<InterfaceManager>().ShowBox(dialogue, clue); 
    }

    private void checkClue()
    {
        if (pHolding.holdValue == clue)
        {
            dialogue = "You found my" + collectibles[clue] + "! Hooray!";
            end = true;
        }
        else
        {
            dialogue = "No, that's not my" + collectibles[clue] + ".";
        }
    }

    public void coinsScattered()
    {
        begin = false;
    }

}
