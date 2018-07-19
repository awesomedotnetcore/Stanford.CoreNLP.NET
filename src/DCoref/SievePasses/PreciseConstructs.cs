using Sharpen;

namespace Edu.Stanford.Nlp.Dcoref.Sievepasses
{
	public class PreciseConstructs : DeterministicCorefSieve
	{
		public PreciseConstructs()
			: base()
		{
			flags.UseIncompatibles = false;
			flags.UseApposition = true;
			flags.UsePredicatenominatives = true;
			flags.UseAcronym = true;
			flags.UseRelativepronoun = true;
			flags.UseRoleapposition = true;
			flags.UseDemonym = true;
		}
	}
}
