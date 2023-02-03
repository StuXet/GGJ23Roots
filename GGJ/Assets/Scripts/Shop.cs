using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject[] prefabsToActivate;
    public float xPos;
    public float speed = 1.0f;

    private bool moving = false;

    private void Update()
    {
        if (moving)
        {
            Debug.Log("shop");
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(xPos, transform.position.y, transform.position.z), speed * Time.deltaTime);

            if (transform.position.x == xPos)
            {
                moving = false;

                foreach (var prefab in prefabsToActivate)
                {
                    prefab.SetActive(true);
                }
            }
        }
    }

    public void StartMoving()
    {
        moving = true;
    }
}
