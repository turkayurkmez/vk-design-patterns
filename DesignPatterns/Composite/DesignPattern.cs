using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /*
     * Problem:
     * 
     * Ağaç yapısı olarak iç içe geçebilen bir nesne yapısı oluşturmanız gerekiyor. Bunu nasıl sağlarsınız?
     * 
     */

    public class Category
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    public class CompositeType<T> where T:new()
    {
        public T Node { get; set; } = new T();
        public List<CompositeType<T>> Children { get; set;} = new List<CompositeType<T>>();

        public CompositeType<T> Add(T child)
        {
            CompositeType<T> composite = new CompositeType<T>() { Node = child };
            Children.Add(composite);
            return composite;
        }

        public static void Show(CompositeType<T> composite, TreeView treeView) {
            TreeNode treeNode = new TreeNode(composite.Node.ToString());
            addItemToNode(composite, treeNode);
            treeView.Nodes.Add(treeNode);
        }

        private static void addItemToNode(CompositeType<T> composite, TreeNode treeNode)
        {
            TreeNode child = treeNode.Nodes.Add(composite.Node.ToString());
            foreach (var item in composite.Children)
            {
                addItemToNode(item, child);
            }
        }
    }
}
