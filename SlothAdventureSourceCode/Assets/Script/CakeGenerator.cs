using UnityEngine;
using System.Collections;

public class CakeGenerator : MonoBehaviour {

    //cake
    public ObjectPooler cakePool;
    public float distanceBetweetCake;

    //genarate cake
	public void spawCake(Vector3 startPosition)
    {
        GameObject cake1 = cakePool.GetPooledObject();
        cake1.transform.position = startPosition;
        cake1.SetActive(true);
    }
}
