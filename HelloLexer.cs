//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Hello.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using AntlrExample;
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class HelloLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		ID=10, No=11, WS=12, MUL=13, DIV=14, ADD=15, SUB=16;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"ID", "No", "WS", "MUL", "DIV", "ADD", "SUB"
	};


	public HelloLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public HelloLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'for'", "'('", "','", "')'", "'if'", "'else'", "'{'", "'}'", "'='", 
		null, null, null, "'*'", "'/'", "'+'", "'-'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, "ID", "No", 
		"WS", "MUL", "DIV", "ADD", "SUB"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Hello.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static HelloLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x12', 'S', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', 
		'\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', 
		'\v', '\x3', '\v', '\a', '\v', '>', '\n', '\v', '\f', '\v', '\xE', '\v', 
		'\x41', '\v', '\v', '\x3', '\f', '\x6', '\f', '\x44', '\n', '\f', '\r', 
		'\f', '\xE', '\f', '\x45', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x2', '\x2', '\x12', '\x3', 
		'\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', 
		'\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', 
		'\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '\x3', 
		'\x2', '\x5', '\x5', '\x2', '\x43', '\\', '\x61', '\x61', '\x63', '|', 
		'\x6', '\x2', '\x32', ';', '\x43', '\\', '\x61', '\x61', '\x63', '|', 
		'\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', 'T', '\x2', 
		'\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', 
		'\x2', '\x2', '\x3', '#', '\x3', '\x2', '\x2', '\x2', '\x5', '\'', '\x3', 
		'\x2', '\x2', '\x2', '\a', ')', '\x3', '\x2', '\x2', '\x2', '\t', '+', 
		'\x3', '\x2', '\x2', '\x2', '\v', '-', '\x3', '\x2', '\x2', '\x2', '\r', 
		'\x30', '\x3', '\x2', '\x2', '\x2', '\xF', '\x35', '\x3', '\x2', '\x2', 
		'\x2', '\x11', '\x37', '\x3', '\x2', '\x2', '\x2', '\x13', '\x39', '\x3', 
		'\x2', '\x2', '\x2', '\x15', ';', '\x3', '\x2', '\x2', '\x2', '\x17', 
		'\x43', '\x3', '\x2', '\x2', '\x2', '\x19', 'G', '\x3', '\x2', '\x2', 
		'\x2', '\x1B', 'K', '\x3', '\x2', '\x2', '\x2', '\x1D', 'M', '\x3', '\x2', 
		'\x2', '\x2', '\x1F', 'O', '\x3', '\x2', '\x2', '\x2', '!', 'Q', '\x3', 
		'\x2', '\x2', '\x2', '#', '$', '\a', 'h', '\x2', '\x2', '$', '%', '\a', 
		'q', '\x2', '\x2', '%', '&', '\a', 't', '\x2', '\x2', '&', '\x4', '\x3', 
		'\x2', '\x2', '\x2', '\'', '(', '\a', '*', '\x2', '\x2', '(', '\x6', '\x3', 
		'\x2', '\x2', '\x2', ')', '*', '\a', '.', '\x2', '\x2', '*', '\b', '\x3', 
		'\x2', '\x2', '\x2', '+', ',', '\a', '+', '\x2', '\x2', ',', '\n', '\x3', 
		'\x2', '\x2', '\x2', '-', '.', '\a', 'k', '\x2', '\x2', '.', '/', '\a', 
		'h', '\x2', '\x2', '/', '\f', '\x3', '\x2', '\x2', '\x2', '\x30', '\x31', 
		'\a', 'g', '\x2', '\x2', '\x31', '\x32', '\a', 'n', '\x2', '\x2', '\x32', 
		'\x33', '\a', 'u', '\x2', '\x2', '\x33', '\x34', '\a', 'g', '\x2', '\x2', 
		'\x34', '\xE', '\x3', '\x2', '\x2', '\x2', '\x35', '\x36', '\a', '}', 
		'\x2', '\x2', '\x36', '\x10', '\x3', '\x2', '\x2', '\x2', '\x37', '\x38', 
		'\a', '\x7F', '\x2', '\x2', '\x38', '\x12', '\x3', '\x2', '\x2', '\x2', 
		'\x39', ':', '\a', '?', '\x2', '\x2', ':', '\x14', '\x3', '\x2', '\x2', 
		'\x2', ';', '?', '\t', '\x2', '\x2', '\x2', '<', '>', '\t', '\x3', '\x2', 
		'\x2', '=', '<', '\x3', '\x2', '\x2', '\x2', '>', '\x41', '\x3', '\x2', 
		'\x2', '\x2', '?', '=', '\x3', '\x2', '\x2', '\x2', '?', '@', '\x3', '\x2', 
		'\x2', '\x2', '@', '\x16', '\x3', '\x2', '\x2', '\x2', '\x41', '?', '\x3', 
		'\x2', '\x2', '\x2', '\x42', '\x44', '\x4', '\x32', ';', '\x2', '\x43', 
		'\x42', '\x3', '\x2', '\x2', '\x2', '\x44', '\x45', '\x3', '\x2', '\x2', 
		'\x2', '\x45', '\x43', '\x3', '\x2', '\x2', '\x2', '\x45', '\x46', '\x3', 
		'\x2', '\x2', '\x2', '\x46', '\x18', '\x3', '\x2', '\x2', '\x2', 'G', 
		'H', '\t', '\x4', '\x2', '\x2', 'H', 'I', '\x3', '\x2', '\x2', '\x2', 
		'I', 'J', '\b', '\r', '\x2', '\x2', 'J', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', 'K', 'L', '\a', ',', '\x2', '\x2', 'L', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', 'M', 'N', '\a', '\x31', '\x2', '\x2', 'N', '\x1E', '\x3', '\x2', 
		'\x2', '\x2', 'O', 'P', '\a', '-', '\x2', '\x2', 'P', ' ', '\x3', '\x2', 
		'\x2', '\x2', 'Q', 'R', '\a', '/', '\x2', '\x2', 'R', '\"', '\x3', '\x2', 
		'\x2', '\x2', '\x5', '\x2', '?', '\x45', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}