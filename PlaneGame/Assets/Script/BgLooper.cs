using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgLooper : MonoBehaviour
{
    public int obstacleCount = 0;
    public Vector3 obstaclePosition  = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Obstacle[] obstacles = GameObject.FindObjectsOfType<Obstacle>(); //게임 내에 존재하는 모든 obstacle를 찾아준다. 
        //연산량이 많기 때문에 start나 Awake에서 한번만 연산을 진행하여 찾을때 사용한다. 업데이트에서 사용할시에 프레임 드랍이 발생할 수 있다. 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
