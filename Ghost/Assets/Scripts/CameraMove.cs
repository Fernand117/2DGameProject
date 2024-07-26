using UnityEngine;
public class CameraMove : MonoBehaviour
{
    bool IS_DPRESSED;
    bool IS_APRESSED;
    public float moveSpeed = 5f; // Velocidad de movimiento de la c�mara

    // Start is called before the first frame update
    void Start()
    {
        IS_APRESSED = false;
        IS_DPRESSED = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) IS_DPRESSED = true;
        if (Input.GetKeyDown(KeyCode.A)) IS_APRESSED = true;

        if (Input.GetKeyUp(KeyCode.D)) IS_DPRESSED = false;
        if (Input.GetKeyUp(KeyCode.A)) IS_APRESSED = false;

        if (IS_DPRESSED) gameObject.transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        if (IS_APRESSED) gameObject.transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}
