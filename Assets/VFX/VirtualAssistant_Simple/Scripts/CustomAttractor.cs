using UnityEngine;
using UnityEngine.VFX;





public class CustomAttractor : MonoBehaviour
{
    [SerializeField] private float attractionForce;
    [SerializeField] private float range;
    [SerializeField] private Transform satellite;

    public float Force => attractionForce;
    public float Range => range;
    public Vector3 SatellitePosition => satellite.position;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
