using UnityEngine;
using System.Collections;

public class BulletGenerator : MonoBehaviour {
    public GameObject BulletobjectPrefab;

    // Use this for initialization
    void Start () {
	if (Input.GetMouseButtonDouwn(0))
        {
            GameObject igaguri =
                Instantiate(BulletobjectPrefab) as GameObjct;
            Bulletobject.GetComponent<Bullet>().shoot(
                new Vector3(0,200,2000));
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
