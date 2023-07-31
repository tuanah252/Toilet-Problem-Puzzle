using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ToiletController : MonoBehaviour
{
    public GameObject[] markings; // Mảng chứa hai GameObjects của hai ô có marking
    private bool isLevelComplete = false; // Biến kiểm tra xem level đã hoàn thành chưa

    private void Update()
    {
        if (!isLevelComplete)
        {
            // Duyệt qua tất cả các con cá trong scene
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
                isLevelComplete = true;
                LoadNextLevel();
                // Thực hiện các hành động khi level hoàn thành ở đây
            }
        }
    }
    private void LoadNextLevel()
{
    // Lấy index của scene hiện tại
    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

    // Nếu đã ở màn chơi cuối cùng, quay lại màn chơi đầu tiên (màn chơi có index là 0)
    if (currentSceneIndex == SceneManager.sceneCountInBuildSettings - 1)
    {
        SceneManager.LoadScene(0);
    }
    else
    {
        // Nếu không phải màn chơi cuối cùng, chuyển đến màn chơi tiếp theo
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}

}
