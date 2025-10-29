using UnityEngine;
using UnityEngine.VFX;


[VFXType(VFXTypeAttribute.Usage.GraphicsBuffer)]
struct AttractorData
{
    public Vector3 position;
    public float force;
    public float range;
    
    public AttractorData(Vector3 position, float force, float range)
    {
        this.position = position;
        this.force = force;
        this.range = range;
    }
}

