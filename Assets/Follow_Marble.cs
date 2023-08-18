using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Marble : MonoBehaviour
{
    public List<GameObject> Marbles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float LowestX = 0;
        float LowestY = 1000000000;
        foreach(GameObject M in Marbles)
        {
            if(M.transform.position.y < LowestY)
            {
                LowestY = M.transform.position.y;
                LowestX = M.transform.position.x;
            }
        }
        transform.position = new Vector3(LowestX, LowestY, transform.position.z);
    }
}
