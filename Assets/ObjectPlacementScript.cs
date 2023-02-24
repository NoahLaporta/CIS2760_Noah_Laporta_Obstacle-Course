using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacementScript : MonoBehaviour
{

    [SerializeField]
    public GameObject[] placeableObject;
    [SerializeField]
    private LayerMask layerMask;
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo, Mathf.Infinity, layerMask))
        {
            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(placeableObject[0], hitInfo.point, Quaternion.identity);
            }
        }
    }

}
