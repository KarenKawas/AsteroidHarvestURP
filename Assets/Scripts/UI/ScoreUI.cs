using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//Takes care of Text DISPLAY and UI elements. 

public class ScoreUI : MonoBehaviour
{

    [SerializeField] 
    private ScoreControllerSO _scoreController;

    private TextMeshProUGUI _tmpro;
    

    private void Awake()
    {
      _tmpro = GetComponent<TextMeshProUGUI>(); 
      _scoreController.SetUI(this); //this the UI. 
      UpdateScore();

    }

    public void UpdateScore()
    {
        _tmpro.text = _scoreController.Score.ToString();

    }

}
