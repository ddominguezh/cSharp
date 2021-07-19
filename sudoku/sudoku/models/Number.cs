using System;
using System.ComponentModel;

namespace usantatecla.sudoku.models
{
	public enum Number {
		[Description(" ")]
		EMPTY,

		[Description("1")]
		ONE,

		[Description("2")]
		TWO,

		[Description("3")]
		THREE,

		[Description("4")]
		FOUR,

		[Description("5")]
		FIVE,

		[Description("6")]
		SIX,

		[Description("7")]
		SEVEN,

		[Description("8")]
		EIGHT,

		[Description("9")]
		NINE,
	}

}