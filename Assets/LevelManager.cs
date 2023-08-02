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
    private Vector3 ov11StartPosition;
    private Vector3 ov12StartPosition;
    private Vector3 ov21StartPosition;
    private Vector3 ov22StartPosition;
    private Vector3 ov23StartPosition;
    private Vector3 ov31StartPosition;
    private Vector3 ov32StartPosition;
    private Vector3 ov33StartPosition;

    private void Start()
    {
        // Ẩn các đối tượng của các level trừ level 1 khi bắt đầu game
        level1Objects.SetActive(true);
        level2Objects.SetActive(false);
        level3Objects.SetActive(false);
        ov11StartPosition = ov11.transform.position;
        ov12StartPosition = ov12.transform.position;
        ov21StartPosition = ov21.transform.position;
        ov22StartPosition = ov22.transform.position;
        ov23StartPosition = ov23.transform.position;
        ov31StartPosition = ov31.transform.position;
        ov32StartPosition = ov32.transform.position;
        ov33StartPosition = ov33.transform.position;

        
    }

    public void CompleteLevel1()
    {
        // Ẩn level 1, hiện level 2
        Currentlevel = 2;
        level1Objects.SetActive(false);
        level2Objects.SetActive(true);
        ov11.transform.position = ov11StartPosition;
        ov12.transform.position = ov12StartPosition;
    }

    public void CompleteLevel2()
    {
        // Ẩn level 2, hiện level 3
        Currentlevel = 3;
        level2Objects.SetActive(false);
        level3Objects.SetActive(true);
        ov21StartPosition = ov21.transform.position;
        ov22StartPosition = ov22.transform.position;
        ov23StartPosition = ov23.transform.position;
    }
    public void CompleteLevel3()
    {
        Currentlevel = 1;
        level1Objects.SetActive(true);
        level2Objects.SetActive(false);
        level3Objects.SetActive(false);
        ov31StartPosition = ov31.transform.position;
        ov32StartPosition = ov32.transform.position;
        ov33StartPosition = ov33.transform.position;
    }

    // Tương tự bạn có thể viết các hàm để chuyển đổi sang các level khác (ví dụ, từ level 3 đến level 1).

}