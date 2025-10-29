using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.VFX;

public class CustomAttractors : MonoBehaviour
{
    [SerializeField] private CustomAttractor[] attractors;
    [SerializeField] private VisualEffect visualEffect;   
    
    private List<AttractorData> _attractorData;
    private GraphicsBuffer _attractorBuffer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _attractorData = new List<AttractorData>();
        UpdateAttractorData();
        
        int stride = Marshal.SizeOf(typeof(AttractorData));
        _attractorBuffer = new GraphicsBuffer(GraphicsBuffer.Target.Structured, _attractorData.Count, stride); // Up to 1024 shots per frame
        visualEffect.SetGraphicsBuffer("AttractorData", _attractorBuffer);    
    }

    // Update is called once per frame
    void Update()
    {
        UpdateAttractorData();
        _attractorBuffer.SetData(_attractorData);
        
    }

    void UpdateAttractorData()
    {
        _attractorData.Clear();
        foreach (CustomAttractor attractor in attractors)
        {
            _attractorData.Add(new AttractorData(attractor.SatellitePosition, attractor.Force, attractor.Range));
        }
    }
    
    void OnDestroy()
    {
        _attractorBuffer?.Dispose();
    }
}
