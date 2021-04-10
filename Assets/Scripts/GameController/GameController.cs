using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class GameController : MonoBehaviour
{
    [Header("Simple Hazard Control")]
    [Tooltip("Hazard Count, Wait Time and Speed.")]
    public GameObject hazard;

    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;


    [Header("Special Hazard Control")]
    [Tooltip("Special Hazard Count, Wait Time and Speed.")]

    public GameObject specialHazard;

    public Vector3 spawnValuesS;
    public int hazardCountS;
    public float spawnWaitS;
    public float startWaitS;
    public float waveWaitS;

   
    [Header("Game Over Screen")]
    public GameObject GOPanel;


    void Start()
    {
        
        GOPanel.SetActive(false);
        StartCoroutine(SpawnWaves());  //asyncronist operations
        StartCoroutine(SpawnSpecial());
    }


//Spawns regular asteroids.
    IEnumerator SpawnWaves()  
    {

        yield return new WaitForSeconds(startWait); 

        while (true)
        {
            for (int i = 0; i < hazardCount; i++)   /* We are going to loop through this bit of code as long as the hard count is less than 0 
                                                   * and we are incrementing the count each time we cycle through the loop. */
            {
                Vector3 spawnPosition = new Vector3
                (
                    Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z
                 );
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(startWait);

            }
            yield return new WaitForSeconds(waveWait);


        }

    }

//Spawns golden asteroids that are worth more. 

    IEnumerator SpawnSpecial()
    {

        yield return new WaitForSeconds(startWaitS);

        while (true)
        {
            for (int i = 0; i < hazardCountS; i++)   /* We are going to loop through this bit of code as long as the hard count is less than 0 
                                                   * and we are incrementing the count each time we cycle through the loop. */
            {
                Vector3 spawnPositionS = new Vector3
                (
                    Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z
                 );
                Quaternion spawnRotationS = Quaternion.identity;
                Instantiate(specialHazard, spawnPositionS, spawnRotationS);
                yield return new WaitForSeconds(startWaitS);

            }
            yield return new WaitForSeconds(waveWaitS);

        }


    }

    public void GameOver()
    {
        GOPanel.SetActive(true);
    }

  public void Restart()
    {
            SceneManager.LoadScene("AsteroidHarvestNew");      
    }
 

}
