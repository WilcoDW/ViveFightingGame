using UnityEngine;
using System.Collections;
using BLINDED_AM_ME;

public class NewBehaviourScript : MonoBehaviour {

    public float Durability = 100f; // Incorrect use of sword will result in damage and eventually shattering of blade

    void OnCollisionEnter(Collision col)
    {

        PhysicalProperties prop = col.gameObject.GetComponent<PhysicalProperties>();

        if (prop != null)
        {
            if(col.relativeVelocity.sqrMagnitude > prop.SliceResistance)
            {
                GameObject[] pieces = MeshCut.Cut(col.gameObject, transform.position, transform.right, prop.CapMaterial);
                for (int i = 0; i < pieces.Length; i++)
                {
                    if (!pieces[i].GetComponent<MeshCollider>())
                        pieces[i].AddComponent<MeshCollider>();
                    if (!pieces[i].GetComponent<Rigidbody>())
                        pieces[i].AddComponent<Rigidbody>();
                    if (!pieces[i].GetComponent<PhysicalProperties>())
                        pieces[i].AddComponent<PhysicalProperties>().SetBreakResistance(prop.BreakResistance).SetSliceResistance(prop.SliceResistance).SetCapMaterial(prop.CapMaterial);
                }
            }
        }
        else
        {
            // cant be broken, cant be cut
            Durability -= col.relativeVelocity.sqrMagnitude;
        }

    }

}
