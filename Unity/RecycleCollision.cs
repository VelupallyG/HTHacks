
using UnityEngine;
using UnityEngine.UI;

public class RecycleCollision : MonoBehaviour
{
    

    void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "TrashCan"){
            Score.scoreValue -=1;
            Destroy(this.gameObject);
            
        }

        if(collisionInfo.collider.tag == "Recycle"){
            Score.scoreValue +=2;
            Destroy(this.gameObject);
            
        }
    }
}
