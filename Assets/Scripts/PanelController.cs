using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    [SerializeField] Button prevButton;
    [SerializeField] Button nextButton;
    [SerializeField] GameObject pageParent;

    int currentPageNum = 0;
    GameObject[] pages;

    // 페이지들 자식 오브젝트 배열에 저장
    void Start()
    {
        pages = new GameObject[pageParent.transform.childCount];

        for(int i = 0; i < pageParent.transform.childCount; i++)
        {
            pages[i] = pageParent.transform.GetChild(i).gameObject;
        }
    }

    // 다음 버튼 누르면 현재 페이지 비활성화, 다음 페이지 활성화
    public void OnClickNextButton()
    {
        if(currentPageNum < pageParent.transform.childCount - 1)
        {
            pages[currentPageNum].SetActive(false);
            currentPageNum++;
            pages[currentPageNum].SetActive(true);
        }
    }

    // 이전 버튼 누르면 현재 페이지 비활성화, 이전 페이지 활성화
    public void OnClickPrevButton()
    {
        if(currentPageNum > 0)
        {
            pages[currentPageNum].SetActive(false);
            currentPageNum--;
            pages[currentPageNum].SetActive(true);
        }
    }

    // 클릭하면 웹사이트 열기
    public void OnClickWebSiteOpen(string homePageURL)
    {
        // 페이지 열기
        Application.OpenURL(homePageURL);
    }
}