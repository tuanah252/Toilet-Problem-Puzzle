using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToiletController : MonoBehaviour
{
    public GameObject[] markings; // Mảng chứa hai GameObjects của hai ô có marking
    public LevelManager Reference;
    private void Update()
    {

            FishController[] allFish = FindObjectsOfType<FishController>();
            bool allFishInMarking = true;

            foreach (FishController fish in allFish)
            {
                if (!fish.isInMarking)
                {
                    allFishInMarking = false;
                    break;
                }
            }

            // Nếu tất cả các con cá đều nằm trong marking, hoàn thành level
            if (allFishInMarking)
            {

                LoadNextLevel();
                allFishInMarking = false;
            }
        
    }

    public void LoadNextLevel() {
        int currentLevel = Reference.Currentlevel;
        
        switch (currentLevel)
        {
            case 1:
                Reference.CompleteLevel1();
                break;
            case 2:
                Reference.CompleteLevel2();
                break;
            case 3:
                Reference.CompleteLevel3();
                break;
        }
    }

}
