public class LevelMoves : Level
{
    public int numMoves;
    public int targetScore;

    private int movesUsed = 0;

    // Start is called before the first frame update
    void Start()
    {
        type = LevelType.MOVES;

        hud.SetLevelType(type);//calls the set level type function
        hud.SetScore(currentScore);//calls set score which checks levels and current score
        hud.SetTarget(targetScore);//calls set target to the target and shows target score
        hud.SetRemaining(numMoves);//calls the set remaining which shows remaining moves

    }

    public override void OnMove()
    {
        base.OnMove();

        movesUsed++;// adds one to the movews used

        hud.SetRemaining(numMoves - movesUsed); // calls the remaining function and makes it the moves left as a subtracts the moves available from the moves used // also upadte the moves every time

        if(numMoves - movesUsed == 0)
        {
            if(currentScore >= targetScore)
            {
                GameWin();
            }
            else
            {
                GameLose();
            }
        }
    }
}
