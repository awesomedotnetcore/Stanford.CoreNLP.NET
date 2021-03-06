//TaggerFeature -- StanfordMaxEnt, A Maximum Entropy Toolkit
//Copyright (c) 2002-2008 Leland Stanford Junior University
//This program is free software; you can redistribute it and/or
//modify it under the terms of the GNU General Public License
//as published by the Free Software Foundation; either version 2
//of the License, or (at your option) any later version.
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//You should have received a copy of the GNU General Public License
//along with this program; if not, write to the Free Software
//Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//For more information, bug reports, fixes, contact:
//Christopher Manning
//Dept of Computer Science, Gates 1A
//Stanford CA 94305-9010
//USA
//    Support/Questions: java-nlp-user@lists.stanford.edu
//    Licensing: java-nlp-support@lists.stanford.edu
//http://www-nlp.stanford.edu/software/tagger.shtml
using Edu.Stanford.Nlp.Maxent;
using Sharpen;

namespace Edu.Stanford.Nlp.Tagger.Maxent
{
	/// <summary>Holds a Tagger Feature for the loglinear model.</summary>
	/// <remarks>
	/// Holds a Tagger Feature for the loglinear model.
	/// Tagger Features are binary valued, and indexed in a particular way.
	/// </remarks>
	/// <author>Kristina Toutanova</author>
	/// <version>1.0</version>
	public class TaggerFeature : Feature
	{
		private readonly int start;

		private readonly int end;

		private readonly FeatureKey key;

		private readonly int yTag;

		private readonly TaggerExperiments domain;

		protected internal TaggerFeature(int start, int end, FeatureKey key, int yTag, TaggerExperiments domain)
		{
			this.start = start;
			this.end = end;
			this.key = key;
			this.domain = domain;
			this.yTag = yTag;
		}

		public override double GetVal(int index)
		{
			return 1.0;
		}

		public override int GetY(int index)
		{
			return yTag;
		}

		public override int Len()
		{
			return end - start + 1;
		}

		public override int GetX(int index)
		{
			return domain.GetTaggerFeatures().xIndexed[start + index];
		}

		public virtual int GetYTag()
		{
			return yTag;
		}

		public override double GetVal(int x, int y)
		{
			int num = x * domain.ySize + y;
			if (!(GetYTag() == y))
			{
				return 0;
			}
			for (int i = 0; i < Len(); i++)
			{
				if (GetX(i) == num)
				{
					return 1;
				}
			}
			return 0;
		}

		public override double Ftilde()
		{
			double s = 0.0;
			int y = GetYTag();
			for (int example = start; example < end + 1; example++)
			{
				int x = domain.GetTaggerFeatures().xIndexed[example];
				s = s + domain.PtildeXY(x, y);
			}
			return s;
		}
	}
}
