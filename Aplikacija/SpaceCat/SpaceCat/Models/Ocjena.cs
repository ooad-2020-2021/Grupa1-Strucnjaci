using System;
using System.ComponentModel.DataAnnotations;

namespace SpaceCat
{
	public enum Ocjena
	{
		[Display(Name = "Jedan")]
		JEDAN,
		[Display(Name = "Jedan i po")]
		JEDANIPO,
		[Display(Name = "Dva")]
		DVA,
		[Display(Name = "Dva i po")]
		DVAIPO,
		[Display(Name = "Tri")]
		TRI,
		[Display(Name = "Tri i po")]
		TRIIPO,
		[Display(Name = "Cetiri")]
		CETIRI,
		[Display(Name = "Cetiri i po")]
		CETIRIIPO,
		[Display(Name = "Pet")]
		PET
	}
}
