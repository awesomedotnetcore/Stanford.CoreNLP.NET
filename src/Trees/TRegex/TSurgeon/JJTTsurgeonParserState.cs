/* Generated By:JavaCC: Do not edit this line. JJTTsurgeonParserState.java Version 6.0_1 */
using System.Collections.Generic;
using Sharpen;

namespace Edu.Stanford.Nlp.Trees.Tregex.Tsurgeon
{
	public class JJTTsurgeonParserState
	{
		private IList<INode> nodes;

		private IList<int> marks;

		private int sp;

		private int mk;

		private bool node_created;

		public JJTTsurgeonParserState()
		{
			// number of nodes on stack
			// current mark
			nodes = new List<INode>();
			marks = new List<int>();
			sp = 0;
			mk = 0;
		}

		/* Determines whether the current node was actually closed and
		pushed.  This should only be called in the final user action of a
		node scope.  */
		public virtual bool NodeCreated()
		{
			return node_created;
		}

		/* Call this to reinitialize the node stack.  It is called
		automatically by the parser's ReInit() method. */
		public virtual void Reset()
		{
			nodes.Clear();
			marks.Clear();
			sp = 0;
			mk = 0;
		}

		/* Returns the root node of the AST.  It only makes sense to call
		this after a successful parse. */
		public virtual INode RootNode()
		{
			return nodes[0];
		}

		/* Pushes a node on to the stack. */
		public virtual void PushNode(INode n)
		{
			nodes.Add(n);
			++sp;
		}

		/* Returns the node on the top of the stack, and remove it from the
		stack.  */
		public virtual INode PopNode()
		{
			if (--sp < mk)
			{
				mk = marks.Remove(marks.Count - 1);
			}
			return nodes.Remove(nodes.Count - 1);
		}

		/* Returns the node currently on the top of the stack. */
		public virtual INode PeekNode()
		{
			return nodes[nodes.Count - 1];
		}

		/* Returns the number of children on the stack in the current node
		scope. */
		public virtual int NodeArity()
		{
			return sp - mk;
		}

		public virtual void ClearNodeScope(INode n)
		{
			while (sp > mk)
			{
				PopNode();
			}
			mk = marks.Remove(marks.Count - 1);
		}

		public virtual void OpenNodeScope(INode n)
		{
			marks.Add(mk);
			mk = sp;
			n.JjtOpen();
		}

		/* A definite node is constructed from a specified number of
		children.  That number of nodes are popped from the stack and
		made the children of the definite node.  Then the definite node
		is pushed on to the stack. */
		public virtual void CloseNodeScope(INode n, int num)
		{
			mk = marks.Remove(marks.Count - 1);
			while (num-- > 0)
			{
				INode c = PopNode();
				c.JjtSetParent(n);
				n.JjtAddChild(c, num);
			}
			n.JjtClose();
			PushNode(n);
			node_created = true;
		}

		/* A conditional node is constructed if its condition is true.  All
		the nodes that have been pushed since the node was opened are
		made children of the conditional node, which is then pushed
		on to the stack.  If the condition is false the node is not
		constructed and they are left on the stack. */
		public virtual void CloseNodeScope(INode n, bool condition)
		{
			if (condition)
			{
				int a = NodeArity();
				mk = marks.Remove(marks.Count - 1);
				while (a-- > 0)
				{
					INode c = PopNode();
					c.JjtSetParent(n);
					n.JjtAddChild(c, a);
				}
				n.JjtClose();
				PushNode(n);
				node_created = true;
			}
			else
			{
				mk = marks.Remove(marks.Count - 1);
				node_created = false;
			}
		}
	}
}
