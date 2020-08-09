using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinksButtons : MonoBehaviour
{
  public void Twitter()
  {
    Application.OpenURL("https://twitter.com/jeniffervaneg");
  }
  public void Github()
  {
    Application.OpenURL("https://github.com/Jeniffervp");
  }
  public void Email()
  {
    Application.OpenURL("mailto:jeniffervpinedo@gmail.com");
  }
  public void LinkedIn()
  {
    Application.OpenURL("https://www.linkedin.com/in/jeniffer-vanegas-pinedo/");
  }
}
