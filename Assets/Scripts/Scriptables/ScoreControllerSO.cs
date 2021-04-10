using UnityEngine;

[CreateAssetMenu(menuName = "Scriptables/ScoreController", fileName = "ScoreController_")] 
public class ScoreControllerSO : ScriptableObject
{   //takes care of HOW the score functions and the points get added for each asteroid destroyed. 

    //Asset that exits in the hard drive space. It doesn't update automatically. 

    private int _score;
    private ScoreUI _scoreUI; // ideally there would be an event.

    public int Score => _score; // pointing to _score variable. 

    /// <summary> 
    /// Sets the Score Controller's score to zero.
    /// </summary> 
    public void ResetScore()
    {
        _score = 0;
   }


    /// <summary> 
    /// AddScore receives a score value and adds it to the Score Controller's current score.
    /// </summary> 

    public void AddScore(int scoreValue)
    {

        _score += scoreValue;
        _scoreUI.UpdateScore();

    }

    public void SetUI(ScoreUI uIObject)
    {
        _scoreUI = uIObject;
    }

}
