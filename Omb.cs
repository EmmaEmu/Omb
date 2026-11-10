using SapList;

namespace Omb;

public class Omb
{
    private Dictionary<Type, nint> _volatilePool = new();
    private List<object> _uniquePool = new();

    public void Spawn<T>()
    {
        var nodeType = typeof(T);
        if (!_volatilePool.ContainsKey(nodeType))
        {
            _ = new SapList<T>(0);
        }
    }
}
