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
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;


[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class HelloParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		ID=10, No=11, WS=12, MUL=13, DIV=14, ADD=15, SUB=16;
	public const int
		RULE_sts = 0, RULE_st = 1, RULE_forst = 2, RULE_iFst = 3, RULE_block = 4, 
		RULE_ast = 5, RULE_e = 6, RULE_t = 7, RULE_f = 8;
	public static readonly string[] ruleNames = {
		"sts", "st", "forst", "iFst", "block", "ast", "e", "t", "f"
	};

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

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static HelloParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public HelloParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public HelloParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class StsContext : ParserRuleContext {
		public StContext[] st() {
			return GetRuleContexts<StContext>();
		}
		public StContext st(int i) {
			return GetRuleContext<StContext>(i);
		}
		public StsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_sts; } }
		public override void EnterRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.EnterSts(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.ExitSts(this);
		}
	}

	[RuleVersion(0)]
	public StsContext sts() {
		StsContext _localctx = new StsContext(Context, State);
		EnterRule(_localctx, 0, RULE_sts);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 21;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__4) | (1L << ID))) != 0)) {
				{
				{
				State = 18; st();
				}
				}
				State = 23;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StContext : ParserRuleContext {
		public AstContext ast() {
			return GetRuleContext<AstContext>(0);
		}
		public IFstContext iFst() {
			return GetRuleContext<IFstContext>(0);
		}
		public ForstContext forst() {
			return GetRuleContext<ForstContext>(0);
		}
		public StContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_st; } }
		public override void EnterRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.EnterSt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.ExitSt(this);
		}
	}

	[RuleVersion(0)]
	public StContext st() {
		StContext _localctx = new StContext(Context, State);
		EnterRule(_localctx, 2, RULE_st);
		try {
			State = 27;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ID:
				EnterOuterAlt(_localctx, 1);
				{
				State = 24; ast();
				}
				break;
			case T__4:
				EnterOuterAlt(_localctx, 2);
				{
				State = 25; iFst();
				}
				break;
			case T__0:
				EnterOuterAlt(_localctx, 3);
				{
				State = 26; forst();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ForstContext : ParserRuleContext {
		public AstContext[] ast() {
			return GetRuleContexts<AstContext>();
		}
		public AstContext ast(int i) {
			return GetRuleContext<AstContext>(i);
		}
		public EContext e() {
			return GetRuleContext<EContext>(0);
		}
		public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public ForstContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_forst; } }
		public override void EnterRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.EnterForst(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.ExitForst(this);
		}
	}

	[RuleVersion(0)]
	public ForstContext forst() {
		ForstContext _localctx = new ForstContext(Context, State);
		EnterRule(_localctx, 4, RULE_forst);
		try {
			EnterOuterAlt(_localctx, 1);
			{

			string LFor_condition = Fun.getLabel();
		string 	LFor_end = Fun.getLabel();
			string LFor_ast = Fun.getLabel();
			string LFor_block = Fun.getLabel();

			State = 30; Match(T__0);
			State = 31; Match(T__1);
			State = 32; ast();
			State = 33; Match(T__2);
				Fun.emitln(LFor_condition + ":");
			State = 35; e();

				string eval = Fun.PopTV();

			if (Fun.isTemp(eval)) {
				Fun.emitln(eval+"="+ eval+"==0");
				Fun.emitln("if not "+eval+" goto "+LFor_end);
				Fun.removeTemp();
			    }

			else {
			    string newTemp = Fun.getTemp();
			    Fun.emitln(newTemp+"="+ eval+"==0");
			    Fun.emitln("if not "+newTemp+" goto "+LFor_end);
				Fun.removeTemp();
			    }


				Fun.emitln("goto " + LFor_block);
			State = 38; Match(T__2);
				Fun.emitln(LFor_ast + ":");
			State = 40; ast();
				Fun.emitln("goto " + LFor_condition);
			State = 42; Match(T__3);
				Fun.emitln(LFor_block + ":");
			State = 44; block();
				Fun.emitln("goto " + LFor_ast);
				Fun.emitln(LFor_end + ":");
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IFstContext : ParserRuleContext {
		public EContext e() {
			return GetRuleContext<EContext>(0);
		}
		public BlockContext[] block() {
			return GetRuleContexts<BlockContext>();
		}
		public BlockContext block(int i) {
			return GetRuleContext<BlockContext>(i);
		}
		public IFstContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_iFst; } }
		public override void EnterRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.EnterIFst(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.ExitIFst(this);
		}
	}

	[RuleVersion(0)]
	public IFstContext iFst() {
		IFstContext _localctx = new IFstContext(Context, State);
		EnterRule(_localctx, 6, RULE_iFst);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 48; Match(T__4);
			State = 49; Match(T__1);
			State = 50; e();
			State = 51; Match(T__3);

				string Lend = Fun.getLabel();
				string eval = Fun.PopTV();
			if (Fun.isTemp(eval)){
					Fun.emitln(eval + "=" + eval + "==0");
					Fun.emitln("if not " + eval + " goto " + Lend);
					Fun.removeTemp();
			    }
			else {
			    string newTemp = Fun.getTemp();
			    Fun.emitln(newTemp+"="+ eval+"==0");
				Fun.emitln("if not "+newTemp+" goto "+Lend);
				Fun.removeTemp();
			    }


			State = 53; block();
			Boolean write = false;
			State = 60;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
			case 1:
				{

				string Lendelse = Fun.getLabel();
				Fun.emitln("goto "+Lendelse);
				Fun.emitln(Lend + ":");
				write = true;

				State = 56; Match(T__5);
				State = 57; block();
				Fun.emitln(Lendelse + ":");
				}
				break;
			}
			if (! write) Fun.emitln(Lend + ":");
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BlockContext : ParserRuleContext {
		public StsContext sts() {
			return GetRuleContext<StsContext>(0);
		}
		public StContext st() {
			return GetRuleContext<StContext>(0);
		}
		public BlockContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_block; } }
		public override void EnterRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.EnterBlock(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.ExitBlock(this);
		}
	}

	[RuleVersion(0)]
	public BlockContext block() {
		BlockContext _localctx = new BlockContext(Context, State);
		EnterRule(_localctx, 8, RULE_block);
		try {
			State = 69;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__6:
				EnterOuterAlt(_localctx, 1);
				{
				State = 64; Match(T__6);
				State = 65; sts();
				State = 66; Match(T__7);
				}
				break;
			case T__0:
			case T__4:
			case ID:
				EnterOuterAlt(_localctx, 2);
				{
				State = 68; st();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AstContext : ParserRuleContext {
		public IToken _ID;
		public ITerminalNode ID() { return GetToken(HelloParser.ID, 0); }
		public EContext e() {
			return GetRuleContext<EContext>(0);
		}
		public AstContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ast; } }
		public override void EnterRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.EnterAst(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.ExitAst(this);
		}
	}

	[RuleVersion(0)]
	public AstContext ast() {
		AstContext _localctx = new AstContext(Context, State);
		EnterRule(_localctx, 10, RULE_ast);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 71; _localctx._ID = Match(ID);
			State = 72; Match(T__8);
			State = 73; e();

			string eval = Fun.PopTV();
			Fun.emitln((_localctx._ID!=null?_localctx._ID.Text:null) + "=" + eval);
			if (Fun.isTemp(eval))
			    Fun.removeTemp();

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EContext : ParserRuleContext {
		public IToken _ADD;
		public IToken _SUB;
		public TContext t() {
			return GetRuleContext<TContext>(0);
		}
		public EContext e() {
			return GetRuleContext<EContext>(0);
		}
		public ITerminalNode ADD() { return GetToken(HelloParser.ADD, 0); }
		public ITerminalNode SUB() { return GetToken(HelloParser.SUB, 0); }
		public EContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_e; } }
		public override void EnterRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.EnterE(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.ExitE(this);
		}
	}

	[RuleVersion(0)]
	public EContext e() {
		EContext _localctx = new EContext(Context, State);
		EnterRule(_localctx, 12, RULE_e);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 76; t();
			State = 87;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==ADD || _la==SUB) {
				{
						string Op = "";
				State = 82;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case ADD:
					{
					State = 78; _localctx._ADD = Match(ADD);
									Op = (_localctx._ADD != null ? _localctx._ADD.Text : null);
					}
					break;
				case SUB:
					{
					State = 80; _localctx._SUB = Match(SUB);
									Op = (_localctx._SUB != null ? _localctx._SUB.Text : null);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 84; e();

				string eval = Fun.PopTV();
				string tval = Fun.PopTV();
				if (Fun.isTemp(tval)){
				    Fun.emitln(tval+"="+tval+Op+eval);
				    if (Fun.isTemp(eval))
				        Fun.removeTemp();
				    Fun.PushToken(tval);
				    }
				else{
				    if (Fun.isTemp(eval)){
				        Fun.emitln(eval + "=" + tval + Op + eval);
				        Fun.PushToken(eval);
				        }
				    else{
				        string newTemp = Fun.getTemp();
				        Fun.emitln(Convert.ToString(newTemp) + "=" + Convert.ToString(tval) + Op + Convert.ToString(eval));
				        Fun.PushToken(newTemp);
				        }
				     }

				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TContext : ParserRuleContext {
		public IToken _MUL;
		public IToken _DIV;
		public FContext f() {
			return GetRuleContext<FContext>(0);
		}
		public TContext t() {
			return GetRuleContext<TContext>(0);
		}
		public ITerminalNode MUL() { return GetToken(HelloParser.MUL, 0); }
		public ITerminalNode DIV() { return GetToken(HelloParser.DIV, 0); }
		public TContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_t; } }
		public override void EnterRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.EnterT(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.ExitT(this);
		}
	}

	[RuleVersion(0)]
	public TContext t() {
		TContext _localctx = new TContext(Context, State);
		EnterRule(_localctx, 14, RULE_t);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 89; f();
			State = 100;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==MUL || _la==DIV) {
				{
						string Op = "";
				State = 95;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case MUL:
					{
					State = 91; _localctx._MUL = Match(MUL);
									Op = (_localctx._MUL != null ? _localctx._MUL.Text : null);
					}
					break;
				case DIV:
					{
					State = 93; _localctx._DIV = Match(DIV);
									Op = (_localctx._DIV != null ? _localctx._DIV.Text : null);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 97; t();


				string tval = Fun.PopTV();
				string fval = Fun.PopTV();

				if (Fun.isTemp(fval)) {
				    Fun.emitln(fval + "=" + fval + Op + tval);
							if (Fun.isTemp(tval))
								Fun.removeTemp();
				    Fun.PushToken(fval);
				    }
				else{
				    if (Fun.isTemp(tval)) {
								Fun.emitln(tval + "=" + fval + Op + tval);

						Fun.PushToken(tval);
				        }
				    else
				    {
				        string newTemp = Fun.getTemp();
				        Fun.emitln(Convert.ToString(newTemp) + "=" + Convert.ToString(fval) + Op + Convert.ToString(tval));
				        Fun.PushToken(newTemp);
				        }
				  }

				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FContext : ParserRuleContext {
		public IToken _ID;
		public IToken _No;
		public ITerminalNode ID() { return GetToken(HelloParser.ID, 0); }
		public ITerminalNode No() { return GetToken(HelloParser.No, 0); }
		public EContext e() {
			return GetRuleContext<EContext>(0);
		}
		public FContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_f; } }
		public override void EnterRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.EnterF(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.ExitF(this);
		}
	}

	[RuleVersion(0)]
	public FContext f() {
		FContext _localctx = new FContext(Context, State);
		EnterRule(_localctx, 16, RULE_f);
		try {
			State = 110;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ID:
				EnterOuterAlt(_localctx, 1);
				{
				State = 102; _localctx._ID = Match(ID);
				Fun.PushToken(_localctx._ID);
				}
				break;
			case No:
				EnterOuterAlt(_localctx, 2);
				{
				State = 104; _localctx._No = Match(No);
				Fun.PushToken(_localctx._No);
				}
				break;
			case T__1:
				EnterOuterAlt(_localctx, 3);
				{
				State = 106; Match(T__1);
				State = 107; e();
				State = 108; Match(T__3);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x12', 's', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x3', '\x2', '\a', 
		'\x2', '\x16', '\n', '\x2', '\f', '\x2', '\xE', '\x2', '\x19', '\v', '\x2', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x5', '\x3', '\x1E', '\n', 
		'\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x5', '\x5', '?', '\n', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x5', '\x6', 'H', '\n', '\x6', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x5', '\b', 'U', '\n', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x5', '\b', 'Z', '\n', '\b', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x5', 
		'\t', '\x62', '\n', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x5', 
		'\t', 'g', '\n', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x5', '\n', 'q', 
		'\n', '\n', '\x3', '\n', '\x2', '\x2', '\v', '\x2', '\x4', '\x6', '\b', 
		'\n', '\f', '\xE', '\x10', '\x12', '\x2', '\x2', '\x2', 't', '\x2', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x4', '\x1D', '\x3', '\x2', '\x2', '\x2', 
		'\x6', '\x1F', '\x3', '\x2', '\x2', '\x2', '\b', '\x32', '\x3', '\x2', 
		'\x2', '\x2', '\n', 'G', '\x3', '\x2', '\x2', '\x2', '\f', 'I', '\x3', 
		'\x2', '\x2', '\x2', '\xE', 'N', '\x3', '\x2', '\x2', '\x2', '\x10', '[', 
		'\x3', '\x2', '\x2', '\x2', '\x12', 'p', '\x3', '\x2', '\x2', '\x2', '\x14', 
		'\x16', '\x5', '\x4', '\x3', '\x2', '\x15', '\x14', '\x3', '\x2', '\x2', 
		'\x2', '\x16', '\x19', '\x3', '\x2', '\x2', '\x2', '\x17', '\x15', '\x3', 
		'\x2', '\x2', '\x2', '\x17', '\x18', '\x3', '\x2', '\x2', '\x2', '\x18', 
		'\x3', '\x3', '\x2', '\x2', '\x2', '\x19', '\x17', '\x3', '\x2', '\x2', 
		'\x2', '\x1A', '\x1E', '\x5', '\f', '\a', '\x2', '\x1B', '\x1E', '\x5', 
		'\b', '\x5', '\x2', '\x1C', '\x1E', '\x5', '\x6', '\x4', '\x2', '\x1D', 
		'\x1A', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1B', '\x3', '\x2', '\x2', 
		'\x2', '\x1D', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x1E', '\x5', '\x3', 
		'\x2', '\x2', '\x2', '\x1F', ' ', '\b', '\x4', '\x1', '\x2', ' ', '!', 
		'\a', '\x3', '\x2', '\x2', '!', '\"', '\a', '\x4', '\x2', '\x2', '\"', 
		'#', '\x5', '\f', '\a', '\x2', '#', '$', '\a', '\x5', '\x2', '\x2', '$', 
		'%', '\b', '\x4', '\x1', '\x2', '%', '&', '\x5', '\xE', '\b', '\x2', '&', 
		'\'', '\b', '\x4', '\x1', '\x2', '\'', '(', '\b', '\x4', '\x1', '\x2', 
		'(', ')', '\a', '\x5', '\x2', '\x2', ')', '*', '\b', '\x4', '\x1', '\x2', 
		'*', '+', '\x5', '\f', '\a', '\x2', '+', ',', '\b', '\x4', '\x1', '\x2', 
		',', '-', '\a', '\x6', '\x2', '\x2', '-', '.', '\b', '\x4', '\x1', '\x2', 
		'.', '/', '\x5', '\n', '\x6', '\x2', '/', '\x30', '\b', '\x4', '\x1', 
		'\x2', '\x30', '\x31', '\b', '\x4', '\x1', '\x2', '\x31', '\a', '\x3', 
		'\x2', '\x2', '\x2', '\x32', '\x33', '\a', '\a', '\x2', '\x2', '\x33', 
		'\x34', '\a', '\x4', '\x2', '\x2', '\x34', '\x35', '\x5', '\xE', '\b', 
		'\x2', '\x35', '\x36', '\a', '\x6', '\x2', '\x2', '\x36', '\x37', '\b', 
		'\x5', '\x1', '\x2', '\x37', '\x38', '\x5', '\n', '\x6', '\x2', '\x38', 
		'>', '\b', '\x5', '\x1', '\x2', '\x39', ':', '\b', '\x5', '\x1', '\x2', 
		':', ';', '\a', '\b', '\x2', '\x2', ';', '<', '\x5', '\n', '\x6', '\x2', 
		'<', '=', '\b', '\x5', '\x1', '\x2', '=', '?', '\x3', '\x2', '\x2', '\x2', 
		'>', '\x39', '\x3', '\x2', '\x2', '\x2', '>', '?', '\x3', '\x2', '\x2', 
		'\x2', '?', '@', '\x3', '\x2', '\x2', '\x2', '@', '\x41', '\b', '\x5', 
		'\x1', '\x2', '\x41', '\t', '\x3', '\x2', '\x2', '\x2', '\x42', '\x43', 
		'\a', '\t', '\x2', '\x2', '\x43', '\x44', '\x5', '\x2', '\x2', '\x2', 
		'\x44', '\x45', '\a', '\n', '\x2', '\x2', '\x45', 'H', '\x3', '\x2', '\x2', 
		'\x2', '\x46', 'H', '\x5', '\x4', '\x3', '\x2', 'G', '\x42', '\x3', '\x2', 
		'\x2', '\x2', 'G', '\x46', '\x3', '\x2', '\x2', '\x2', 'H', '\v', '\x3', 
		'\x2', '\x2', '\x2', 'I', 'J', '\a', '\f', '\x2', '\x2', 'J', 'K', '\a', 
		'\v', '\x2', '\x2', 'K', 'L', '\x5', '\xE', '\b', '\x2', 'L', 'M', '\b', 
		'\a', '\x1', '\x2', 'M', '\r', '\x3', '\x2', '\x2', '\x2', 'N', 'Y', '\x5', 
		'\x10', '\t', '\x2', 'O', 'T', '\b', '\b', '\x1', '\x2', 'P', 'Q', '\a', 
		'\x11', '\x2', '\x2', 'Q', 'U', '\b', '\b', '\x1', '\x2', 'R', 'S', '\a', 
		'\x12', '\x2', '\x2', 'S', 'U', '\b', '\b', '\x1', '\x2', 'T', 'P', '\x3', 
		'\x2', '\x2', '\x2', 'T', 'R', '\x3', '\x2', '\x2', '\x2', 'U', 'V', '\x3', 
		'\x2', '\x2', '\x2', 'V', 'W', '\x5', '\xE', '\b', '\x2', 'W', 'X', '\b', 
		'\b', '\x1', '\x2', 'X', 'Z', '\x3', '\x2', '\x2', '\x2', 'Y', 'O', '\x3', 
		'\x2', '\x2', '\x2', 'Y', 'Z', '\x3', '\x2', '\x2', '\x2', 'Z', '\xF', 
		'\x3', '\x2', '\x2', '\x2', '[', '\x66', '\x5', '\x12', '\n', '\x2', '\\', 
		'\x61', '\b', '\t', '\x1', '\x2', ']', '^', '\a', '\xF', '\x2', '\x2', 
		'^', '\x62', '\b', '\t', '\x1', '\x2', '_', '`', '\a', '\x10', '\x2', 
		'\x2', '`', '\x62', '\b', '\t', '\x1', '\x2', '\x61', ']', '\x3', '\x2', 
		'\x2', '\x2', '\x61', '_', '\x3', '\x2', '\x2', '\x2', '\x62', '\x63', 
		'\x3', '\x2', '\x2', '\x2', '\x63', '\x64', '\x5', '\x10', '\t', '\x2', 
		'\x64', '\x65', '\b', '\t', '\x1', '\x2', '\x65', 'g', '\x3', '\x2', '\x2', 
		'\x2', '\x66', '\\', '\x3', '\x2', '\x2', '\x2', '\x66', 'g', '\x3', '\x2', 
		'\x2', '\x2', 'g', '\x11', '\x3', '\x2', '\x2', '\x2', 'h', 'i', '\a', 
		'\f', '\x2', '\x2', 'i', 'q', '\b', '\n', '\x1', '\x2', 'j', 'k', '\a', 
		'\r', '\x2', '\x2', 'k', 'q', '\b', '\n', '\x1', '\x2', 'l', 'm', '\a', 
		'\x4', '\x2', '\x2', 'm', 'n', '\x5', '\xE', '\b', '\x2', 'n', 'o', '\a', 
		'\x6', '\x2', '\x2', 'o', 'q', '\x3', '\x2', '\x2', '\x2', 'p', 'h', '\x3', 
		'\x2', '\x2', '\x2', 'p', 'j', '\x3', '\x2', '\x2', '\x2', 'p', 'l', '\x3', 
		'\x2', '\x2', '\x2', 'q', '\x13', '\x3', '\x2', '\x2', '\x2', '\v', '\x17', 
		'\x1D', '>', 'G', 'T', 'Y', '\x61', '\x66', 'p',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
