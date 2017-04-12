using System;
using System.IO;

namespace Test
{
  public class TestGitHub
  {
      private string s;
      List<int> l;
      
      public TestGitHub()
      {
        s = string.Empty;
      }
      
      public TestGitHub(string input)
      {
        s = input;
      }
    
      public List<int> GetList()
      {
        return l;
      }
    
      public void SetList(List<int> list)
      {
        l = list;
      }
    
      public void AddToList(int i)
      {
        l.Add(i);
      }
  }
}
