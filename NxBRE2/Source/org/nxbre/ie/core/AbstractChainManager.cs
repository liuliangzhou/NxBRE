namespace org.nxbre.ie.core {
	using System;
	using System.Collections;
	
	using org.nxbre.ie.rule;

	///<summary>Abstract class for managing chains of implications engaged in relationships
	/// like in mutex or pre-conditions.</summary>
	/// <remarks>Core classes are not supposed to be used directly.</remarks>
	/// <author>David Dossot</author>
	internal abstract class AbstractChainManager {
		private string type;
		private ArrayList chains;
		private ImplicationBase ib;

		protected ArrayList Chains {
			get {
				return chains;
			}
			set {
				chains = value;
			}
		}

		protected ImplicationBase IB {
			get {
				return ib;
			}
		}

		protected AbstractChainManager(string type, ImplicationBase ib) {
			this.type = type;
			this.ib = ib;
		}

		public override string ToString() {
			string result = "";

			foreach(ArrayList chain in chains)
				result += (ChainToString(chain) + "\n");

			return result;
		}
		
		private string ChainToString(ArrayList chain) {
			string result = type + " chain: ";

			foreach(Implication implication in chain)
				result += (implication.Label + "[Weight: " + implication.Weight + "], ");

			return result;
		}
		
	}
	
}
