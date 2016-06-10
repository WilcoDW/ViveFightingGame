using UnityEngine;
using System.Collections;

public class PhysicalProperties : MonoBehaviour
{

    public float BreakResistance;
    public float SliceResistance;
    public Material CapMaterial;

    public PhysicalProperties SetBreakResistance(float v)
    {
        BreakResistance = v;
        return this;
    }

    public PhysicalProperties SetSliceResistance(float v)
    {
        SliceResistance = v;
        return this;
    }

    public PhysicalProperties SetCapMaterial(Material v)
    {
        CapMaterial = v;
        return this;
    }

}
