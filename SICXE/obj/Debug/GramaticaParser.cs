//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Cesar\Documents\GitHub\SICXE\SICXE\Gramatica.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace SICXE {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class GramaticaParser : Parser {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, INSTR1=12, INSTR2=13, INSTR3=14, REG=15, DIRECTIVE=16, 
		START=17, END=18, LABEL=19, NUM=20, NUM_CHAR=21, EMPTY=22, ENDL=23, WS=24;
	public const int
		RULE_prog = 0, RULE_start = 1, RULE_end = 2, RULE_input = 3, RULE_propositions = 4, 
		RULE_proposition = 5, RULE_instruction = 6, RULE_directive = 7, RULE_label = 8, 
		RULE_instr_args = 9, RULE_instr_args2 = 10, RULE_directive_args = 11, 
		RULE_compileUnit = 12;
	public static readonly string[] ruleNames = {
		"prog", "start", "end", "input", "propositions", "proposition", "instruction", 
		"directive", "label", "instr_args", "instr_args2", "directive_args", "compileUnit"
	};

	private static readonly string[] _LiteralNames = {
		null, "'+'", "'BASE'", "', X'", "',X'", "', '", "','", "'@'", "'#'", "'X''", 
		"'''", "'C''", null, null, null, null, null, "'START'", "'END'", null, 
		null, null, "' '", "'\n'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		"INSTR1", "INSTR2", "INSTR3", "REG", "DIRECTIVE", "START", "END", "LABEL", 
		"NUM", "NUM_CHAR", "EMPTY", "ENDL", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Gramatica.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public GramaticaParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class ProgContext : ParserRuleContext {
		public StartContext start() {
			return GetRuleContext<StartContext>(0);
		}
		public PropositionsContext propositions() {
			return GetRuleContext<PropositionsContext>(0);
		}
		public EndContext end() {
			return GetRuleContext<EndContext>(0);
		}
		public ProgContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_prog; } }
		public override void EnterRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.EnterProg(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.ExitProg(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGramaticaVisitor<TResult> typedVisitor = visitor as IGramaticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProg(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgContext prog() {
		ProgContext _localctx = new ProgContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_prog);
		try {
			State = 29;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,0,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 26; start();
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 27; propositions(0);
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 28; end();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StartContext : ParserRuleContext {
		public LabelContext label() {
			return GetRuleContext<LabelContext>(0);
		}
		public ITerminalNode START() { return GetToken(GramaticaParser.START, 0); }
		public ITerminalNode NUM() { return GetToken(GramaticaParser.NUM, 0); }
		public ITerminalNode ENDL() { return GetToken(GramaticaParser.ENDL, 0); }
		public PropositionContext proposition() {
			return GetRuleContext<PropositionContext>(0);
		}
		public StartContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_start; } }
		public override void EnterRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.EnterStart(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.ExitStart(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGramaticaVisitor<TResult> typedVisitor = visitor as IGramaticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStart(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StartContext start() {
		StartContext _localctx = new StartContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_start);
		try {
			State = 37;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,1,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 31; label();
				State = 32; Match(START);
				State = 33; Match(NUM);
				State = 34; Match(ENDL);
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 36; proposition();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EndContext : ParserRuleContext {
		public ITerminalNode END() { return GetToken(GramaticaParser.END, 0); }
		public InputContext input() {
			return GetRuleContext<InputContext>(0);
		}
		public ITerminalNode ENDL() { return GetToken(GramaticaParser.ENDL, 0); }
		public EndContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_end; } }
		public override void EnterRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.EnterEnd(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.ExitEnd(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGramaticaVisitor<TResult> typedVisitor = visitor as IGramaticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitEnd(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public EndContext end() {
		EndContext _localctx = new EndContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_end);
		try {
			State = 45;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,2,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 39; Match(END);
				State = 40; input();
				State = 41; Match(ENDL);
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 43; Match(END);
				State = 44; input();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InputContext : ParserRuleContext {
		public ITerminalNode LABEL() { return GetToken(GramaticaParser.LABEL, 0); }
		public InputContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_input; } }
		public override void EnterRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.EnterInput(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.ExitInput(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGramaticaVisitor<TResult> typedVisitor = visitor as IGramaticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInput(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public InputContext input() {
		InputContext _localctx = new InputContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_input);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 48;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==LABEL) {
				{
				State = 47; Match(LABEL);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PropositionsContext : ParserRuleContext {
		public PropositionsContext propositions() {
			return GetRuleContext<PropositionsContext>(0);
		}
		public PropositionContext proposition() {
			return GetRuleContext<PropositionContext>(0);
		}
		public PropositionsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_propositions; } }
		public override void EnterRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.EnterPropositions(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.ExitPropositions(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGramaticaVisitor<TResult> typedVisitor = visitor as IGramaticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPropositions(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PropositionsContext propositions() {
		return propositions(0);
	}

	private PropositionsContext propositions(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		PropositionsContext _localctx = new PropositionsContext(_ctx, _parentState);
		PropositionsContext _prevctx = _localctx;
		int _startState = 8;
		EnterRecursionRule(_localctx, 8, RULE_propositions, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 51; proposition();
			}
			_ctx.stop = _input.Lt(-1);
			State = 57;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,4,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new PropositionsContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_propositions);
					State = 53;
					if (!(Precpred(_ctx, 2))) throw new FailedPredicateException(this, "Precpred(_ctx, 2)");
					State = 54; proposition();
					}
					} 
				}
				State = 59;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,4,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class PropositionContext : ParserRuleContext {
		public InstructionContext instruction() {
			return GetRuleContext<InstructionContext>(0);
		}
		public DirectiveContext directive() {
			return GetRuleContext<DirectiveContext>(0);
		}
		public PropositionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_proposition; } }
		public override void EnterRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.EnterProposition(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.ExitProposition(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGramaticaVisitor<TResult> typedVisitor = visitor as IGramaticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProposition(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PropositionContext proposition() {
		PropositionContext _localctx = new PropositionContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_proposition);
		try {
			State = 62;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,5,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 60; instruction();
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 61; directive();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InstructionContext : ParserRuleContext {
		public LabelContext[] label() {
			return GetRuleContexts<LabelContext>();
		}
		public LabelContext label(int i) {
			return GetRuleContext<LabelContext>(i);
		}
		public ITerminalNode INSTR3() { return GetToken(GramaticaParser.INSTR3, 0); }
		public Instr_argsContext instr_args() {
			return GetRuleContext<Instr_argsContext>(0);
		}
		public ITerminalNode ENDL() { return GetToken(GramaticaParser.ENDL, 0); }
		public ITerminalNode INSTR2() { return GetToken(GramaticaParser.INSTR2, 0); }
		public Instr_args2Context instr_args2() {
			return GetRuleContext<Instr_args2Context>(0);
		}
		public ITerminalNode INSTR1() { return GetToken(GramaticaParser.INSTR1, 0); }
		public InstructionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_instruction; } }
		public override void EnterRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.EnterInstruction(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.ExitInstruction(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGramaticaVisitor<TResult> typedVisitor = visitor as IGramaticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInstruction(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public InstructionContext instruction() {
		InstructionContext _localctx = new InstructionContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_instruction);
		try {
			State = 99;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,6,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 64; label();
				State = 65; Match(INSTR3);
				State = 66; instr_args();
				State = 67; Match(ENDL);
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 69; Match(T__0);
				State = 70; Match(INSTR3);
				State = 71; instr_args();
				State = 72; Match(ENDL);
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 74; Match(INSTR3);
				State = 75; instr_args();
				}
				break;

			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 76; Match(INSTR2);
				State = 77; instr_args2();
				}
				break;

			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 78; Match(INSTR1);
				}
				break;

			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 79; label();
				State = 80; Match(T__0);
				State = 81; Match(INSTR3);
				State = 82; instr_args();
				State = 83; Match(ENDL);
				}
				break;

			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 85; label();
				State = 86; Match(INSTR2);
				State = 87; instr_args2();
				}
				break;

			case 8:
				EnterOuterAlt(_localctx, 8);
				{
				State = 89; label();
				State = 90; Match(INSTR2);
				}
				break;

			case 9:
				EnterOuterAlt(_localctx, 9);
				{
				State = 92; label();
				State = 93; Match(INSTR2);
				State = 94; label();
				}
				break;

			case 10:
				EnterOuterAlt(_localctx, 10);
				{
				State = 96; label();
				State = 97; Match(INSTR1);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DirectiveContext : ParserRuleContext {
		public LabelContext[] label() {
			return GetRuleContexts<LabelContext>();
		}
		public LabelContext label(int i) {
			return GetRuleContext<LabelContext>(i);
		}
		public ITerminalNode DIRECTIVE() { return GetToken(GramaticaParser.DIRECTIVE, 0); }
		public Directive_argsContext directive_args() {
			return GetRuleContext<Directive_argsContext>(0);
		}
		public ITerminalNode LABEL() { return GetToken(GramaticaParser.LABEL, 0); }
		public ITerminalNode ENDL() { return GetToken(GramaticaParser.ENDL, 0); }
		public DirectiveContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_directive; } }
		public override void EnterRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.EnterDirective(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.ExitDirective(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGramaticaVisitor<TResult> typedVisitor = visitor as IGramaticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDirective(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DirectiveContext directive() {
		DirectiveContext _localctx = new DirectiveContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_directive);
		try {
			State = 113;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,7,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 101; label();
				State = 102; Match(DIRECTIVE);
				State = 103; directive_args();
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 105; Match(T__1);
				State = 106; Match(LABEL);
				State = 107; Match(ENDL);
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 108; label();
				State = 109; Match(T__1);
				State = 110; label();
				State = 111; Match(ENDL);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LabelContext : ParserRuleContext {
		public ITerminalNode LABEL() { return GetToken(GramaticaParser.LABEL, 0); }
		public LabelContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_label; } }
		public override void EnterRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.EnterLabel(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.ExitLabel(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGramaticaVisitor<TResult> typedVisitor = visitor as IGramaticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLabel(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LabelContext label() {
		LabelContext _localctx = new LabelContext(_ctx, State);
		EnterRule(_localctx, 16, RULE_label);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 116;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,8,_ctx) ) {
			case 1:
				{
				State = 115; Match(LABEL);
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Instr_argsContext : ParserRuleContext {
		public ITerminalNode LABEL() { return GetToken(GramaticaParser.LABEL, 0); }
		public ITerminalNode NUM() { return GetToken(GramaticaParser.NUM, 0); }
		public Instr_argsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_instr_args; } }
		public override void EnterRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.EnterInstr_args(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.ExitInstr_args(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGramaticaVisitor<TResult> typedVisitor = visitor as IGramaticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInstr_args(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Instr_argsContext instr_args() {
		Instr_argsContext _localctx = new Instr_argsContext(_ctx, State);
		EnterRule(_localctx, 18, RULE_instr_args);
		try {
			State = 144;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,10,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 118; Match(LABEL);
				State = 119; Match(T__2);
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 120; Match(LABEL);
				State = 121; Match(T__3);
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 122; Match(LABEL);
				State = 123; Match(T__4);
				State = 124; Match(NUM);
				}
				break;

			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 125; Match(LABEL);
				State = 126; Match(T__5);
				State = 127; Match(NUM);
				}
				break;

			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 128; Match(T__6);
				State = 129; Match(LABEL);
				}
				break;

			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 130; Match(T__7);
				State = 131; Match(LABEL);
				}
				break;

			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 132; Match(NUM);
				}
				break;

			case 8:
				EnterOuterAlt(_localctx, 8);
				{
				State = 133; Match(T__6);
				State = 134; Match(NUM);
				}
				break;

			case 9:
				EnterOuterAlt(_localctx, 9);
				{
				State = 135; Match(T__7);
				State = 136; Match(NUM);
				}
				break;

			case 10:
				EnterOuterAlt(_localctx, 10);
				{
				State = 138;
				_errHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(_input,9,_ctx) ) {
				case 1:
					{
					State = 137; Match(LABEL);
					}
					break;
				}
				}
				break;

			case 11:
				EnterOuterAlt(_localctx, 11);
				{
				State = 140; Match(NUM);
				State = 141; Match(T__3);
				}
				break;

			case 12:
				EnterOuterAlt(_localctx, 12);
				{
				State = 142; Match(NUM);
				State = 143; Match(T__2);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Instr_args2Context : ParserRuleContext {
		public ITerminalNode[] REG() { return GetTokens(GramaticaParser.REG); }
		public ITerminalNode REG(int i) {
			return GetToken(GramaticaParser.REG, i);
		}
		public ITerminalNode NUM() { return GetToken(GramaticaParser.NUM, 0); }
		public Instr_args2Context(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_instr_args2; } }
		public override void EnterRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.EnterInstr_args2(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.ExitInstr_args2(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGramaticaVisitor<TResult> typedVisitor = visitor as IGramaticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInstr_args2(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Instr_args2Context instr_args2() {
		Instr_args2Context _localctx = new Instr_args2Context(_ctx, State);
		EnterRule(_localctx, 20, RULE_instr_args2);
		try {
			State = 159;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,11,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 146; Match(REG);
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 147; Match(REG);
				State = 148; Match(T__4);
				State = 149; Match(REG);
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 150; Match(REG);
				State = 151; Match(T__5);
				State = 152; Match(REG);
				}
				break;

			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 153; Match(REG);
				State = 154; Match(T__4);
				State = 155; Match(NUM);
				}
				break;

			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 156; Match(REG);
				State = 157; Match(T__5);
				State = 158; Match(NUM);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Directive_argsContext : ParserRuleContext {
		public ITerminalNode NUM() { return GetToken(GramaticaParser.NUM, 0); }
		public ITerminalNode LABEL() { return GetToken(GramaticaParser.LABEL, 0); }
		public Directive_argsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_directive_args; } }
		public override void EnterRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.EnterDirective_args(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.ExitDirective_args(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGramaticaVisitor<TResult> typedVisitor = visitor as IGramaticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDirective_args(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Directive_argsContext directive_args() {
		Directive_argsContext _localctx = new Directive_argsContext(_ctx, State);
		EnterRule(_localctx, 22, RULE_directive_args);
		try {
			State = 168;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case NUM:
				EnterOuterAlt(_localctx, 1);
				{
				State = 161; Match(NUM);
				}
				break;
			case T__8:
				EnterOuterAlt(_localctx, 2);
				{
				State = 162; Match(T__8);
				State = 163; Match(NUM);
				State = 164; Match(T__9);
				}
				break;
			case T__10:
				EnterOuterAlt(_localctx, 3);
				{
				State = 165; Match(T__10);
				State = 166; Match(LABEL);
				State = 167; Match(T__9);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CompileUnitContext : ParserRuleContext {
		public ITerminalNode Eof() { return GetToken(GramaticaParser.Eof, 0); }
		public CompileUnitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compileUnit; } }
		public override void EnterRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.EnterCompileUnit(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGramaticaListener typedListener = listener as IGramaticaListener;
			if (typedListener != null) typedListener.ExitCompileUnit(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGramaticaVisitor<TResult> typedVisitor = visitor as IGramaticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCompileUnit(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CompileUnitContext compileUnit() {
		CompileUnitContext _localctx = new CompileUnitContext(_ctx, State);
		EnterRule(_localctx, 24, RULE_compileUnit);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 170; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 4: return propositions_sempred((PropositionsContext)_localctx, predIndex);
		}
		return true;
	}
	private bool propositions_sempred(PropositionsContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(_ctx, 2);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x1A\xAF\x4\x2\t"+
		"\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t"+
		"\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x3\x2\x3\x2\x3\x2"+
		"\x5\x2 \n\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x5\x3(\n\x3\x3\x4\x3"+
		"\x4\x3\x4\x3\x4\x3\x4\x3\x4\x5\x4\x30\n\x4\x3\x5\x5\x5\x33\n\x5\x3\x6"+
		"\x3\x6\x3\x6\x3\x6\x3\x6\a\x6:\n\x6\f\x6\xE\x6=\v\x6\x3\a\x3\a\x5\a\x41"+
		"\n\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b"+
		"\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b"+
		"\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x5\b\x66\n\b\x3\t\x3\t\x3\t\x3"+
		"\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x5\tt\n\t\x3\n\x5\nw\n\n\x3"+
		"\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3"+
		"\v\x3\v\x3\v\x3\v\x3\v\x3\v\x5\v\x8D\n\v\x3\v\x3\v\x3\v\x3\v\x5\v\x93"+
		"\n\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f"+
		"\x5\f\xA2\n\f\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r\x5\r\xAB\n\r\x3\xE\x3"+
		"\xE\x3\xE\x2\x2\x3\n\xF\x2\x2\x4\x2\x6\x2\b\x2\n\x2\f\x2\xE\x2\x10\x2"+
		"\x12\x2\x14\x2\x16\x2\x18\x2\x1A\x2\x2\x2\xC6\x2\x1F\x3\x2\x2\x2\x4\'"+
		"\x3\x2\x2\x2\x6/\x3\x2\x2\x2\b\x32\x3\x2\x2\x2\n\x34\x3\x2\x2\x2\f@\x3"+
		"\x2\x2\x2\xE\x65\x3\x2\x2\x2\x10s\x3\x2\x2\x2\x12v\x3\x2\x2\x2\x14\x92"+
		"\x3\x2\x2\x2\x16\xA1\x3\x2\x2\x2\x18\xAA\x3\x2\x2\x2\x1A\xAC\x3\x2\x2"+
		"\x2\x1C \x5\x4\x3\x2\x1D \x5\n\x6\x2\x1E \x5\x6\x4\x2\x1F\x1C\x3\x2\x2"+
		"\x2\x1F\x1D\x3\x2\x2\x2\x1F\x1E\x3\x2\x2\x2 \x3\x3\x2\x2\x2!\"\x5\x12"+
		"\n\x2\"#\a\x13\x2\x2#$\a\x16\x2\x2$%\a\x19\x2\x2%(\x3\x2\x2\x2&(\x5\f"+
		"\a\x2\'!\x3\x2\x2\x2\'&\x3\x2\x2\x2(\x5\x3\x2\x2\x2)*\a\x14\x2\x2*+\x5"+
		"\b\x5\x2+,\a\x19\x2\x2,\x30\x3\x2\x2\x2-.\a\x14\x2\x2.\x30\x5\b\x5\x2"+
		"/)\x3\x2\x2\x2/-\x3\x2\x2\x2\x30\a\x3\x2\x2\x2\x31\x33\a\x15\x2\x2\x32"+
		"\x31\x3\x2\x2\x2\x32\x33\x3\x2\x2\x2\x33\t\x3\x2\x2\x2\x34\x35\b\x6\x1"+
		"\x2\x35\x36\x5\f\a\x2\x36;\x3\x2\x2\x2\x37\x38\f\x4\x2\x2\x38:\x5\f\a"+
		"\x2\x39\x37\x3\x2\x2\x2:=\x3\x2\x2\x2;\x39\x3\x2\x2\x2;<\x3\x2\x2\x2<"+
		"\v\x3\x2\x2\x2=;\x3\x2\x2\x2>\x41\x5\xE\b\x2?\x41\x5\x10\t\x2@>\x3\x2"+
		"\x2\x2@?\x3\x2\x2\x2\x41\r\x3\x2\x2\x2\x42\x43\x5\x12\n\x2\x43\x44\a\x10"+
		"\x2\x2\x44\x45\x5\x14\v\x2\x45\x46\a\x19\x2\x2\x46\x66\x3\x2\x2\x2GH\a"+
		"\x3\x2\x2HI\a\x10\x2\x2IJ\x5\x14\v\x2JK\a\x19\x2\x2K\x66\x3\x2\x2\x2L"+
		"M\a\x10\x2\x2M\x66\x5\x14\v\x2NO\a\xF\x2\x2O\x66\x5\x16\f\x2P\x66\a\xE"+
		"\x2\x2QR\x5\x12\n\x2RS\a\x3\x2\x2ST\a\x10\x2\x2TU\x5\x14\v\x2UV\a\x19"+
		"\x2\x2V\x66\x3\x2\x2\x2WX\x5\x12\n\x2XY\a\xF\x2\x2YZ\x5\x16\f\x2Z\x66"+
		"\x3\x2\x2\x2[\\\x5\x12\n\x2\\]\a\xF\x2\x2]\x66\x3\x2\x2\x2^_\x5\x12\n"+
		"\x2_`\a\xF\x2\x2`\x61\x5\x12\n\x2\x61\x66\x3\x2\x2\x2\x62\x63\x5\x12\n"+
		"\x2\x63\x64\a\xE\x2\x2\x64\x66\x3\x2\x2\x2\x65\x42\x3\x2\x2\x2\x65G\x3"+
		"\x2\x2\x2\x65L\x3\x2\x2\x2\x65N\x3\x2\x2\x2\x65P\x3\x2\x2\x2\x65Q\x3\x2"+
		"\x2\x2\x65W\x3\x2\x2\x2\x65[\x3\x2\x2\x2\x65^\x3\x2\x2\x2\x65\x62\x3\x2"+
		"\x2\x2\x66\xF\x3\x2\x2\x2gh\x5\x12\n\x2hi\a\x12\x2\x2ij\x5\x18\r\x2jt"+
		"\x3\x2\x2\x2kl\a\x4\x2\x2lm\a\x15\x2\x2mt\a\x19\x2\x2no\x5\x12\n\x2op"+
		"\a\x4\x2\x2pq\x5\x12\n\x2qr\a\x19\x2\x2rt\x3\x2\x2\x2sg\x3\x2\x2\x2sk"+
		"\x3\x2\x2\x2sn\x3\x2\x2\x2t\x11\x3\x2\x2\x2uw\a\x15\x2\x2vu\x3\x2\x2\x2"+
		"vw\x3\x2\x2\x2w\x13\x3\x2\x2\x2xy\a\x15\x2\x2y\x93\a\x5\x2\x2z{\a\x15"+
		"\x2\x2{\x93\a\x6\x2\x2|}\a\x15\x2\x2}~\a\a\x2\x2~\x93\a\x16\x2\x2\x7F"+
		"\x80\a\x15\x2\x2\x80\x81\a\b\x2\x2\x81\x93\a\x16\x2\x2\x82\x83\a\t\x2"+
		"\x2\x83\x93\a\x15\x2\x2\x84\x85\a\n\x2\x2\x85\x93\a\x15\x2\x2\x86\x93"+
		"\a\x16\x2\x2\x87\x88\a\t\x2\x2\x88\x93\a\x16\x2\x2\x89\x8A\a\n\x2\x2\x8A"+
		"\x93\a\x16\x2\x2\x8B\x8D\a\x15\x2\x2\x8C\x8B\x3\x2\x2\x2\x8C\x8D\x3\x2"+
		"\x2\x2\x8D\x93\x3\x2\x2\x2\x8E\x8F\a\x16\x2\x2\x8F\x93\a\x6\x2\x2\x90"+
		"\x91\a\x16\x2\x2\x91\x93\a\x5\x2\x2\x92x\x3\x2\x2\x2\x92z\x3\x2\x2\x2"+
		"\x92|\x3\x2\x2\x2\x92\x7F\x3\x2\x2\x2\x92\x82\x3\x2\x2\x2\x92\x84\x3\x2"+
		"\x2\x2\x92\x86\x3\x2\x2\x2\x92\x87\x3\x2\x2\x2\x92\x89\x3\x2\x2\x2\x92"+
		"\x8C\x3\x2\x2\x2\x92\x8E\x3\x2\x2\x2\x92\x90\x3\x2\x2\x2\x93\x15\x3\x2"+
		"\x2\x2\x94\xA2\a\x11\x2\x2\x95\x96\a\x11\x2\x2\x96\x97\a\a\x2\x2\x97\xA2"+
		"\a\x11\x2\x2\x98\x99\a\x11\x2\x2\x99\x9A\a\b\x2\x2\x9A\xA2\a\x11\x2\x2"+
		"\x9B\x9C\a\x11\x2\x2\x9C\x9D\a\a\x2\x2\x9D\xA2\a\x16\x2\x2\x9E\x9F\a\x11"+
		"\x2\x2\x9F\xA0\a\b\x2\x2\xA0\xA2\a\x16\x2\x2\xA1\x94\x3\x2\x2\x2\xA1\x95"+
		"\x3\x2\x2\x2\xA1\x98\x3\x2\x2\x2\xA1\x9B\x3\x2\x2\x2\xA1\x9E\x3\x2\x2"+
		"\x2\xA2\x17\x3\x2\x2\x2\xA3\xAB\a\x16\x2\x2\xA4\xA5\a\v\x2\x2\xA5\xA6"+
		"\a\x16\x2\x2\xA6\xAB\a\f\x2\x2\xA7\xA8\a\r\x2\x2\xA8\xA9\a\x15\x2\x2\xA9"+
		"\xAB\a\f\x2\x2\xAA\xA3\x3\x2\x2\x2\xAA\xA4\x3\x2\x2\x2\xAA\xA7\x3\x2\x2"+
		"\x2\xAB\x19\x3\x2\x2\x2\xAC\xAD\a\x2\x2\x3\xAD\x1B\x3\x2\x2\x2\xF\x1F"+
		"\'/\x32;@\x65sv\x8C\x92\xA1\xAA";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace SICXE
