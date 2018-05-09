
namespace AlgorithmSearch
{
    class AlgorithmSearchTreeBinarySearchTree
    {

        public void Inorder(TreeNode node)
        {
            if (node == null) return;
            Inorder(node.Left);
            //print
            Inorder(node.Right);
        }

        public void Preorder(TreeNode node)
        {
            if (node == null) return;
            //print
            Preorder(node.Left);
            Preorder(node.Right);
        }

        public void Postorder(TreeNode node)
        {
            if (node == null) return;
            Postorder(node.Left);
            Postorder(node.Right);
            //print
        }

    }

    public class TreeNode
    {
        public int Data;
        public TreeNode Left;
        public TreeNode Right;

    }



    // inorder left root right
    // preorder root left right
    // postorder left right root
}
