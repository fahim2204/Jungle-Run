using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Player player;
    private Vector3 lastPosition;
    private float distance;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        lastPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distance = player.transform.position.x - lastPosition.x;
        //distancey = player.transform.position.y - lastPosition.y;

        transform.position = new Vector3(
            transform.position.x + distance,
            transform.position.y ,
            transform.position.z
            );
        lastPosition = player.transform.position;
    }
}
