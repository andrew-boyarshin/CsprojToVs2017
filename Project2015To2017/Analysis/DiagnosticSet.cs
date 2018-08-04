using System.Collections.Generic;
using Project2015To2017.Analysis.Diagnostics;

namespace Project2015To2017.Analysis
{
	public class DiagnosticSet : HashSet<DiagnosticBase>
	{
		public static readonly DiagnosticBase W001 = new W001IllegalProjectTypeDiagnostic();
		// W002 is not a real diagnostic
		public static readonly DiagnosticBase W010 = new W010ConfigurationsMismatchDiagnostic();
		public static readonly DiagnosticBase W020 = new W020MicrosoftCSharpDiagnostic();

		public static readonly DiagnosticSet AllDefault = new DiagnosticSet
		{
			W001,
			W010,
			W020,
		};

		public static readonly DiagnosticSet NoneDefault = new DiagnosticSet();
	}
}