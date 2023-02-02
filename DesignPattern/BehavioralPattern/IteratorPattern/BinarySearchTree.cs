namespace DesignPattern.BehavioralPattern.IteratorPattern;

public class BinarySearchTree<T> : IAggregate<T> where T : IComparable<T>
{
    private class Node<T>
    {
        public T Value;
        public Node<T>? Left = null;
        public Node<T>? Right = null;

        public Node(T value) {
            Value = value;
        }
    }

    private Node<T>? _root = null;

    public bool Insert(T value) {
        var current = _root;
        if (current == null) {
            _root = new Node<T>(value);
            return true;
        }

        while (true) {
            var cmp = value.CompareTo(current.Value);
            if (cmp == 0) return false;
            if (cmp < 0) {
                if (current.Left == null) {
                    current.Left = new Node<T>(value);
                    return true;
                }

                current = current.Left;
            }
            else {
                if (current.Right == null) {
                    current.Right = new Node<T>(value);
                    return true;
                }

                current = current.Right;
            }
        }
    }

    public bool Search(T value) {
        var current = _root;
        while (current != null) {
            var cmp = value.CompareTo(current.Value);
            if (cmp == 0) return true;
            if (cmp < 0) current = current.Left;
            else current = current.Right;
        }

        return false;
    }


    public bool Delete(T value) {
        return DeleteNode(ref _root, value);
    }

    private bool DeleteNode(ref Node<T>? node, T value) {
        if (node == null) return false;
        var cmp = value.CompareTo(node.Value);
        if (cmp < 0) return DeleteNode(ref node.Left, value);
        if (cmp > 0) return DeleteNode(ref node.Right, value);
        if (node.Left == null) {
            node = node.Right;
            return true;
        }

        if (node.Right == null) {
            node = node.Left;
            return true;
        }

        var min = FindMin(node.Right);
        node.Value = min.Value;
        return DeleteNode(ref node.Right, min.Value);
    }

    private Node<T> FindMin(Node<T> node) {
        while (node.Left != null) node = node.Left;
        return node;
    }

    public IIterator<T> CreateIterator() {
        return new MidOrderIterator(_root);
    }

    private class MidOrderIterator : IIterator<T>
    {
        private readonly Node<T>? _root;
        private Node<T>? _current;
        private readonly Stack<Node<T>> _stack = new();
        private bool _isFirst = true;

        public MidOrderIterator(Node<T>? root) {
            _root = root;
            _current = null;
        }

        /// <summary>
        /// if not call MoveNext() before call Current, it will return the root value
        /// </summary>
        public T Current {
            get {
                if (_current == null) throw new InvalidOperationException();
                return _current.Value;
            }
        }

        public bool MoveNext() {
            if (_isFirst) {
                _isFirst = false;
                _current = _root;
            }
            else _current = _current?.Right;


            while (_current != null) {
                _stack.Push(_current);
                _current = _current.Left;
            }

            if (_stack.Count == 0) return false;
            _current = _stack.Pop();
            return true;
        }

        public void Reset() {
            _current = _root;
            _stack.Clear();
        }
    }
}