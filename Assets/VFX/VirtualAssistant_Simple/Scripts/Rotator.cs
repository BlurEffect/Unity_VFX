using System.Collections;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float startDelay;
    [SerializeField] private Vector3 rotationOffset;
    [SerializeField] private Vector3 rotationAxis;
    
    [SerializeField] private Transform satellite;
    
    private bool _running;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(C_DelayedStart());
    }

    // Update is called once per frame
    void Update()
    {
        if (!_running)
        {
            return;
        }
        
        satellite.localPosition = rotationOffset;
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime, Space.World);
    }
    
    IEnumerator C_DelayedStart()
    {
        yield return new WaitForSeconds(startDelay);
        _running = true;
    }
}
