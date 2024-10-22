using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    
    // Update is called once per frame
    void Update()
    {
        // 키보드
        // float horizontalInput = Input.GetAxisRaw("Horizontal");
        // // float verticalInput = Input.GetAxisRaw("Vertical");
        // Vector3 moveTo = new Vector3(horizontalInput, 0f, 0f);
        // transform.position += moveTo * moveSpeed * Time.deltaTime;

        // Vector3 moveTo = new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        // if(Input.GetKey(KeyCode.LeftArrow)){
        //     transform.position -= moveTo;
        // }
        // else if(Input.GetKey(KeyCode.RightArrow)){
        //     transform.position += moveTo;
        // }

        //마우스
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //스크린 좌표에서 월드 좌표로
        float toX = Mathf.Clamp(mousePos.x, -2.35f, 2.35f);
        transform.position = new Vector3(toX, transform.position.y, transform.position.z);
        
        
        
    }
}