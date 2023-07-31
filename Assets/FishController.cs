using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishController : MonoBehaviour
{
    public bool isInMarking = false;
     // Biến kiểm tra xem con cá có đang nằm trong marking hay không

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Khi con cá va chạm với toilet object và có thẻ "Marking"
        if (collision.gameObject.CompareTag("Marking"))
        {
            isInMarking = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Khi con cá rời khỏi toilet object có thẻ "Marking"
        if (collision.gameObject.CompareTag("Marking"))
        {
            isInMarking = false;
        }
    }
}
