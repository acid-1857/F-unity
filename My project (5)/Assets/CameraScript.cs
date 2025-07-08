using UnityEngine;
using UnityEngine.InputSystem;

public class CameraScript : MonoBehaviour
{
    [SerializeField] GameObject mainCamera;      //���C���J�����i�[�p
    [SerializeField] GameObject subCamera;       //�T�u�J�����i�[�p 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�T�u�J�������A�N�e�B�u�ɂ���
        subCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //�X�y�[�X�L�[��������Ă���ԁA�T�u�J�������A�N�e�B�u�ɂ���
        if (Input.GetKeyDown("space"))
        {
            if (mainCamera.activeSelf)
            {
                mainCamera.gameObject.SetActive(false);
                subCamera.gameObject.SetActive(true);
            }
            else
            {
                mainCamera.gameObject.SetActive(true);
                subCamera.gameObject.SetActive(false);
            }


        }
    }
}
