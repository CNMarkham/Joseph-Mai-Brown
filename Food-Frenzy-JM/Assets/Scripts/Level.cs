using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public enum LevelType
    {
        TIMER,
        OBSTACLE,
        MOVES,
    };

    public GameGrid grid;
    public HUD hud;// makes Hud accessable in any other scripts


    public int score1Star;
    public int score2Star;
    public int score3Star;

    protected LevelType type;

    public LevelType Type
    {
        get { return type; }
    }

    protected int currentScore;

    protected bool didWin;

    // Start is called before the first frame update
    private void Start()
    {
        hud.SetScore(currentScore);// will always make the hud set score to the current score
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void GameWin()
    {
        didWin = true;
        grid.GameOver();
        StartCoroutine(WaitForGridFill());
    }

    public virtual void GameLose()
    {
        didWin = false;
        grid.GameOver();
        StartCoroutine(WaitForGridFill());
    }

    public virtual void OnMove()
    {
        
    }

    public virtual void OnPieceCleared(GamePiece piece)
    {
        //Update Score
        currentScore += piece.score;// will add the piece score to the curent score

        hud.SetScore(currentScore);//makes the new score the current score
    }

    protected virtual IEnumerator WaitForGridFill()
    {
        while (grid.IsFilling)
        {
            yield return 0;
        }

        if (didWin && !grid.IsFilling)// if didwin and gird is filling is not true
        {
            hud.OnGameWin(currentScore);//will call the ongamewin script and make isgameover to true
        }
        else
        {
            hud.OnGameLose();// calls the game lose function
        }
    }
}
