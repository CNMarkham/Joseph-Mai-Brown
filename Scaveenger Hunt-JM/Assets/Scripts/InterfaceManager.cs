using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class InterfaceManager : MonoBehaviour
{
    public GameObject dialogueBox;
    public TMP_Text dialogueText;
    public Image seekImage;
    public GameObject npc;
    public GameObject randomSpawn;

    public Image collectibles; // public images of the collectibles
    public GameObject showSprite; //to show the sprites on the box

    [SerializeField]
    private Sprite[] collectibleSource;

    // Start is called before the first frame update
    void Start()
    {
        dialogueBox.SetActive(false);//sets dialogue box to false
        showSprite.SetActive(false);//sets showsprites to false
        if (Input.GetButton("Submit") && dialogueBox.activeInHierarchy)//checks if gets the button submit and the dialogue box is active
        {
            dialogueBox.SetActive(false); //makes the dialogue box not visible
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Submit"))//if the button is pressed submit than sets it to false
        {
            dialogueBox.SetActive(false);// makes it not seeable
            if(npc.GetComponent<DialogueOpen>().end)//checks if the npc gewts the component from the script dialogue open and checks the var end to see if it is true or not if try than will load the scene 0
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    public void CollectibleUpdate(int item)
    {
        showSprite.SetActive(true); //will set the sprite to true
        collectibles.GetComponent<Image>().sprite = collectibleSource[item];// will get the collectible image
    }

    public void ShowBox(string dialogue, int item)
    {
        dialogueBox.SetActive(true); //makes the dialogue box visible
        dialogueText.text = dialogue; //changes the dialogue text to the dialogue speaking
        seekImage.GetComponent<Image>().sprite = collectibleSource[item];
        if (npc.GetComponent<DialogueOpen>().begin)
        {
            scatterCoins();
        }
    }

    public void scatterCoins()
    {
        randomSpawn.GetComponent<RandomSpawn>().DistributeCollectibles();
        npc.GetComponent<DialogueOpen>().coinsScattered();
    }
}
