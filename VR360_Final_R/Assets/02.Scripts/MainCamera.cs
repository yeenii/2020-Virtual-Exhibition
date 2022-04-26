using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Camera[] subCameras;

    public void MoveCamera(int index)
    {
        Vector3 new_position = subCameras[index].transform.position;
        Vector3 new_rotation = subCameras[index].transform.eulerAngles;
        transform.position = new_position;
        transform.eulerAngles = new_rotation;
    } 
    // Start is called before the first frame update
    private void Start()
    {
        MoveCamera(0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
