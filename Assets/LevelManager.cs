using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject level1Objects;
    public GameObject level2Objects;
    public GameObject level3Objects;
    public int Currentlevel = 1;
    public GameObject ov11;
    public GameObject ov12;
    public GameObject ov21;
    public GameObject ov22;
    public GameObject ov23;
    public GameObject ov31;
    public GameObject ov32;
    public GameObject ov33;
    public GameObject ov11StartPosition;
    public GameObject ov12StartPosition;
    public GameObject ov21StartPosition;
    public GameObject ov22StartPosition;
    public GameObject ov23StartPosition;
    public GameObject ov31StartPosition;
    public GameObject ov32StartPosition;
    public GameObject ov33StartPosition;

    private void Start()
    {
        // Ẩn các đối tượng của các level trừ level 1 khi bắt đầu game
        level1Objects.SetActive(true);
        level2Objects.SetActive(false);
        level3Objects.SetActive(false);
        ov11.transform.position = ov11StartPosition.transform.position;
        ov12.transform.position = ov12StartPosition.transform.position;
    }

    public void CompleteLevel1()
    {
        // Ẩn level 1, hiện level 2

        Currentlevel = 2;

        level1Objects.SetActive(false);
        level2Objects.SetActive(true);
        ov21.transform.position = ov21StartPosition.transform.position;
        ov22.transform.position = ov22StartPosition.transform.position;
        ov23.transform.position = ov23StartPosition.transform.position;

    }

    public void CompleteLevel2()
    {
        // Ẩn level 2, hiện level 3
        Currentlevel = 3;

        level2Objects.SetActive(false);
        level3Objects.SetActive(true);
        ov31.transform.position = ov31StartPosition.transform.position;
        ov32.transform.position = ov32StartPosition.transform.position;
        ov33.transform.position = ov33StartPosition.transform.position;

    }
    public void CompleteLevel3()
    {
        Currentlevel = 1;

        level1Objects.SetActive(true);
        level2Objects.SetActive(false);
        level3Objects.SetActive(false);
        ov11.transform.position = ov11StartPosition.transform.position;
        ov12.transform.position = ov12StartPosition.transform.position;
    }

    // Tương tự bạn có thể viết các hàm để chuyển đổi sang các level khác (ví dụ, từ level 3 đến level 1).

}