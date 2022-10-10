using Dodocker.Helpers;


namespace Dodocker.Models;

public class DkrImage
{
    public int ID { get; set; }

    public string Title { get; set; }
    public string Creator { get; set; }
    public string Description { get; set; }
    public string Logo { get; set; }

    public string ImageID { get; set; }

    public string Url { get; set; }
    public string Url_Github { get; set; }


    public bool IsOfficial { get; set; }
    public bool IsVerified { get; set; }


    public Version Version { get; set; }


    //public int VersionMajor { get; set; }
    //public int VersionMinor { get; set; }


    public int Size { get; set; }
    public int Size_Compressed { get; set; }

    public int Usage_RAM { get; set; } // MB
    public int Usage_CPU { get; set; } // 1 - 10

    //public List<V> Versions { get; set; }
    //public V VersionLatest => Versions?[0]; // ?


}
