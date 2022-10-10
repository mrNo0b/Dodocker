namespace Dodocker.Helpers;

public class Enums
{
}


public enum ARCH
{
    amd64, 
    arm32v6, 
    arm32v7, 
    arm64v8, 
    i386, 
    ppc64le,
    riscv64, 
    s390x,

    // amd64, arm32v5, arm32v7, arm64v8, i386, mips64le, ppc64le, riscv64, s390x, windows-amd64

}
public enum ARCHSpecific
{
    ARM,
    ARM64,
    IBM_POWER,
    IBM_Z,
    PowerPC_64_LE,
    x86,
    x86_64,

}


public enum Platform
{
    Windows,
    Linux,

}
public enum OSSpecific
{
    Windows7,
    Windows10,
    Windows11,
    Ubuntu,
    Fedora,
    Mint,

}


// TODO - sort
public enum Category
{
    Web = 1,
    CI,
    Cloud,
    FileSystem,
    IoT,
    Media,
    Database,
    Development,
    Docker,
    Messaging,
    Monitoring,
    Logging,
    OPS,
    ProjectManagment,
    SearchEngine,
    Storage,
    WebServer,
}


//public enum Ver
//{
//    Major,
//    Minor,
//}