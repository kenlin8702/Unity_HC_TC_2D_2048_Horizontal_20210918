
using UnityEngine;

public class LearnArray : MonoBehaviour
{

    public int[] scores;

    public float[] attacks = new float[3];

    public string[] props = { "����", "�Ť�", "ī�G" };
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < props.Length; i++) {
            print(props[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
