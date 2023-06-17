using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

    public RotatorController rotator;
    public PinSpawnPointController spawnser;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void EndGame()
    {
        if (gameHasEnded)
            return;

        rotator.enabled = false;
        spawnser.enabled = false;

        animator.SetTrigger("EndGame");

        gameHasEnded = true;
    }
}
