using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreService : IScoreService
{
    public int ActualScore = 20;

    public void PlusScore(int sum)
    {
        ActualScore += sum;
    }

    public int GetScore()
    {
        return ActualScore;
    }
}

public interface IScoreService
{
    public void PlusScore(int sum);
    public int GetScore();
}
