
using UnityEngine;

public class Asteroid : MonoBehaviour, IScorable
{
    [SerializeField]
    private ScoreControllerSO _scoreController;

    [SerializeField]
    private int _scoreValue;
    public int ScoreValue => _scoreValue;

    public void AddScore()
    {
        _scoreController.AddScore(ScoreValue);

   }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Bullet>() == null) return; // If the object collider with me stop here. 

        AddScore();
        
    }

}
