using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    private Camera _camera;
    [SerializeField] LayerMask _interactionLayer;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 1000, _interactionLayer))
            {
                InteractiveObject objectHit = hit.transform.GetComponent<InteractiveObject>();
                if (objectHit != null)
                {
                    objectHit.OnClick.Invoke();
                }
            }
        }
    }
}
