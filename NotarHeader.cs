namespace Notar1;

class NotarHeader
{
    const ulong MAGIC = 0x6e6f746172313730;
    const ushort HeaderSize = 1;
    const byte VersionMajor = 1;
    const byte VersionMinor = 1;
    const uint FileLayoutVersion = 1;
    const ulong FeatureFlags = 0;
    public ushort DirectoryCount;
    public ushort FileCount;
    public ushort FileListSize;
    public ushort PayloadOffset;
    public ulong PayloadSize;
    public ulong PayLoadHash;
    public ulong Padding;
}