using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectScript : MonoBehaviour
{
    public void OnMouseUp()
    {
        Destroy(gameObject);
    }

}
