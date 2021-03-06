using System.Collections.Generic;
using Sharpen;

namespace Edu.Stanford.Nlp.Ling
{
	/// <summary>Interface for Objects that have a label, whose label is an Object.</summary>
	/// <remarks>
	/// Interface for Objects that have a label, whose label is an Object.
	/// There are only two methods: Object label() and Collection labels().
	/// If there is only one label, labels() will return a collection of one label.
	/// If there are multiple labels, label() will return the primary label,
	/// or a consistent arbitrary label if there is not primary label.
	/// </remarks>
	/// <author>
	/// Sepandar Kamvar (sdkamvar@stanford.edu)
	/// Updated to take a specific type rather than just a blanket Object.  I'm hoping
	/// that it's true that the Collection will be of the same type as the primary label...
	/// </author>
	/// <author>Sarah Spikes (sdspikes@cs.stanford.edu)</author>
	public interface ILabeled<E>
	{
		/// <summary>Returns the primary label for this Object, or null if none have been set.</summary>
		E Label();

		/// <summary>Returns the complete list of labels for this Object, which may be empty.</summary>
		ICollection<E> Labels();
	}
}
