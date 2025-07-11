using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Tốc độ di chuyển
    private float maginX = 0.5f, maginY = 0.5f;
    private float smoothSpeed = 10f;

    // Tốc độ nghiêng
    private float maxTilt = 40f;
    private float titleSpeed = 15f;
    private float currentTilt = 0f;
    private float tiltSensitivity = 80f;

    void Update()
    {

        var wordPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        wordPoint.z = 0;

        // Lấy tọa độ đầu và cuối của screen
        var min = Camera.main.ViewportToWorldPoint(new Vector3(0, 0));
        var max = Camera.main.ViewportToWorldPoint(new Vector3(1, 1));

        wordPoint.x = Mathf.Clamp(wordPoint.x, min.x + maginX, max.x - maginX);
        wordPoint.y = Mathf.Clamp(wordPoint.y, min.y + maginY, max.y - maginY);

        // Di chuyển 1 đối tượng giữa 2 tọa độ, có tốc độ di chuyển
        transform.position = Vector3.Lerp(transform.position, wordPoint, smoothSpeed * Time.deltaTime);

        // Tạo độ nghiêng   
        var detalX = wordPoint.x - transform.position.x;

        float targetTilt = Mathf.Clamp(detalX * tiltSensitivity, -maxTilt, maxTilt);

        currentTilt = Mathf.Lerp(currentTilt, targetTilt, titleSpeed * Time.deltaTime);

        transform.rotation = Quaternion.Euler(0f, currentTilt, 0f);

    }

}





































