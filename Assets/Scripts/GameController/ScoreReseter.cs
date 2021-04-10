using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreReseter : MonoBehaviour
{
    [SerializeField]
    private ScoreControllerSO _scoreController;


    private void Awake()
    {
      Debug.Log("Awake() was called");
       _scoreController.ResetScore();
       
    }


}
