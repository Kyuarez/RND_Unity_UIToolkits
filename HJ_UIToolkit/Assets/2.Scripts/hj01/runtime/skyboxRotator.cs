using UnityEngine;

public class skyboxRotator : MonoBehaviour
{
    Material m_Sky;
    float degree;

    private void Awake()
    {
        m_Sky = RenderSettings.skybox;
    }

    private void Update()
    {
        if(m_Sky != null)
        {
            degree += Time.deltaTime;   
            if (degree >= 360f)
            {
                degree = 0f;
            }
            m_Sky.SetFloat("_Rotation", degree);
        }
    }
}
