using UnityEngine;
using System.Collections;

public class MonsterMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject _monster;
    public static int moveSpeed = 3;
    public Vector3 aiDirection = Vector3.forward;

	// Update is called once per frame
	void Update()
	{
        transform.position += Vector3.forward * Time.deltaTime * moveSpeed;
        _monster.SetActive(true);
        Invoke("Disappear", 10);

	}

    private void Disappear() {
        _monster.SetActive(false);
    }
 
}
