using UnityEngine;

public class Atividade08R : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        var text = "Inverter string";
        
        var reversed = string.Create(text.Length, text, (chars, state)

            => { var pos = 0; for (int i = state.Length - 1; i >= 0; i--)

            { chars[pos++] = state[i]; } });

        print(reversed);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}

