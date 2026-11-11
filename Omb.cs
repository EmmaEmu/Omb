using SapList;

namespace Omb;

public class Omb
{
    private Dictionary<Type, SapList<object>> _volatilePool = new();
    private List<object> _uniquePool = new();

    public void Spawn<T>(T node, bool isVolatile = false) where T: notnull
    {
            var storage = _uniquePool;

        if (isVolatile) {
            var nodeType = typeof(T);

            // Create a list to store this node type if one does not exist yet.
            if (!_volatilePool.ContainsKey(nodeType))
            {
                var list = new SapList<T>();
                //_volatilePool.Add(nodeType,);
            }
        }

        storage.Add(node);
    }
}
