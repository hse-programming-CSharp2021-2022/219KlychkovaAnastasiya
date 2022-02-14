using System;

namespace BinaryTree
{
    class BinaryTree<ElemType> where ElemType : IComparable<ElemType>
    {
        enum Order
        {
            MLR,
            RML,
            LMR
        }
        BTnode<ElemType> _root; // корень дерева
        public BinaryTree() { _root = null; }   // конструктор

        // добавить значение или узел
        public void Insert(ElemType elem)
        {
            if (_root == null)
                _root = new BTnode<ElemType>(elem, null);
            else
                _root.InsertValue(elem);
        }
        public bool IsEmpty { get { return _root == null; } }

        // МЕТОДЫ
        private void PrintNode(BTnode<ElemType> pt, Order order)
        {
            if (pt == null)
                return;
            switch (order)
            {
                case Order.MLR:
                    Console.Write(pt._val + " ");
                    if (pt._lchild != null)
                        PrintNode(pt._lchild, Order.MLR);
                    if (pt._rchild != null)
                        PrintNode(pt._rchild, Order.MLR);
                    break;
                case Order.RML:
                    if (pt._rchild != null)
                        PrintNode(pt._rchild, Order.RML);
                    Console.Write(pt._val + " ");
                    if (pt._lchild != null)
                        PrintNode(pt._lchild, Order.RML);
                    break;
                case Order.LMR:
                    if (pt._lchild != null)
                        PrintNode(pt._lchild, Order.LMR);
                    Console.Write(pt._val + " ");
                    if (pt._rchild != null)
                        PrintNode(pt._rchild, Order.LMR);
                    break;
            }
        }
        public void Print()
        {
            Console.Write("Дерево: ");
            PrintNode(_root, Order.MLR);
            Console.WriteLine();
        }
        // Удаление элемента дерева
        public bool Delete(ElemType val)
        {
            BTnode<ElemType> node = Find(val);
            if (node == null)
            {
                return false;
            }
            BTnode<ElemType> curNode;
            if (node == _root)
            {
                if (node._rchild != null)
                {
                    curNode = node._rchild;
                }
                else curNode = node._lchild;
                while (curNode._lchild != null)
                {
                    curNode = curNode._lchild;
                }
                ElemType temp = curNode._val;
                Delete(temp);
                node._val = temp;
                return true;
            }
            if (node._lchild == null && node._rchild == null && node._parent != null)
            {
                if (node == node._parent._lchild)
                    node._parent._lchild = null;
                else
                {
                    node._parent._rchild = null;
                }
                return true;
            }
            if (node._lchild != null && node._rchild == null)
            {
                node._lchild._parent = node._parent;
                if (node == node._parent._lchild)
                {
                    node._parent._lchild = node._lchild;
                }
                else if (node == node._parent._rchild)
                {
                    node._parent._rchild = node._lchild;
                }
                return true;
            }
            if (node._lchild == null && node._rchild != null)
            {
                node._rchild._parent = node._parent;
                if (node == node._parent._lchild)
                {
                    node._parent._lchild = node._rchild;
                }
                else if (node == node._parent._rchild)
                {
                    node._parent._rchild = node._rchild;
                }
                return true;
            }
            if (node._rchild != null && node._lchild != null)
            {
                curNode = node._rchild;
                while (curNode._lchild != null)
                {
                    curNode = curNode._lchild;
                }
                if (curNode._parent == node)
                {
                    curNode._lchild = node._lchild;
                    node._lchild._parent = curNode;
                    curNode._parent = node._parent;
                    if (node == node._parent._lchild)
                    {
                        node._parent._lchild = curNode;
                    }
                    else if (node == node._parent._rchild)
                    {
                        node._parent._rchild = curNode;
                    }
                    return true;
                }
                else
                {
                    if (curNode._rchild != null)
                    {
                        curNode._rchild._parent = curNode._parent;
                    }
                    curNode._parent._lchild = curNode._rchild;
                    curNode._rchild = node._rchild;
                    curNode._lchild = node._lchild;
                    node._lchild._parent = curNode;
                    node._rchild._parent = curNode;
                    curNode._parent = node._parent;
                    if (node == node._parent._lchild)
                    {
                        node._parent._lchild = curNode;
                    }
                    else if (node == node._parent._rchild)
                    {
                        node._parent._rchild = curNode;
                    }
                    return true;
                }
            }
            return false;
        }
        public BTnode<ElemType> Find(ElemType value)
        {
            if (!IsEmpty)
                return _root.FindValue(value);
            else
                throw new NullReferenceException("Tree is empty");
        }
        public void InOrder()
        {
            Console.Write("Дерево справо-налево: ");
            PrintNode(_root, Order.RML);
            Console.WriteLine();
        }
        public void PostOrder()
        {
            Console.Write("Дерево симметрично: ");
            PrintNode(_root, Order.LMR);
            Console.WriteLine();
        }
        public void Clear()
        {
            _root = null;
        }
    }

    class BTnode<ValType> where ValType : IComparable<ValType>
    {
        public ValType _val;
        int _cnt;   // число вставок элементов


        public BTnode<ValType> _lchild;   // ссылка на левый потомок
        public BTnode<ValType> _rchild;   // ссылка на правый потомок
        public BTnode<ValType> _parent;

        public BTnode(ValType val, BTnode<ValType> parent)
        {
            // конструктор добавляет "лист"
            _val = val;
            _cnt = 1;
            _parent = parent;
            _lchild = _rchild = null;
        }

        // методы
        public void InsertValue(ValType val)
        {
            if (val.Equals(_val))
            {
                _cnt++;
                return;
            }
            if (val.CompareTo(_val) < 0)
            {
                if (_lchild == null)
                    _lchild = new BTnode<ValType>(val, this);
                else
                    _lchild.InsertValue(val);
            }
            else
            {
                if (_rchild == null)
                    _rchild = new BTnode<ValType>(val, this);
                else
                    _rchild.InsertValue(val);
            }
        }

        public BTnode<ValType> FindValue(ValType value)
        {
            if (value.Equals(_val))
                return this;
            if (value.CompareTo(_val) < 0 && _lchild != null)
                return _lchild.FindValue(value);
            else if (value.CompareTo(_val) > 0 && _rchild != null)
                return _rchild.FindValue(value);
            else return null;
        }
        public void ChangeNode(BTnode<ValType> newNode)
        {
            if (_parent._lchild.Equals(this))
                _parent._lchild = newNode;
            else if (_parent._rchild.Equals(this))
                _parent._rchild = newNode;
            if (newNode != null)
                newNode._parent = _parent;
        }
        public override string ToString()
        {
            return $"Value: {_val}\tAmount: {_cnt} Left:{_lchild._val}\tRight: {_rchild._val}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<string> bt = new BinaryTree<string>();
            bt.Insert("Me"); bt.Insert("Mom");
            bt.Insert("Dad"); bt.Insert("Dad\\’s dad");
            bt.Insert("Mom\\’s mom"); bt.Insert("Dad\\’s mom");
            bt.Insert("Mom\\’s dad");
            bt.Print();

            BinaryTree<int> bi = new BinaryTree<int>();
            bi.Insert(-4); bi.Insert(9);
            bi.Insert(3); bi.Insert(7);
            bi.Insert(-4); bi.Insert(9);
            bi.Print();

            Console.WriteLine("***");
            bi.Clear();
            bi.Insert(33); bi.Insert(35);
            bi.Insert(34); bi.Insert(99);
            bi.Insert(5); bi.Insert(1); 
            bi.Insert(4); bi.Insert(17);
            bi.Insert(18); bi.Insert(19);
            bi.PostOrder();

            bi.Delete(17);
            bi.Delete(35);
            bi.Delete(5);
            bi.PostOrder();

            bi.InOrder();

            Console.WriteLine("Для выхода нажмите любую клавишу!");
            Console.ReadKey(true);
        }
    }
}
