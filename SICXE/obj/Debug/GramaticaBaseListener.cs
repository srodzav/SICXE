//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\CODE\LAB\Practica 05\SICXE\SICXE\Gramatica.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace SICXE {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IGramaticaListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class GramaticaBaseListener : IGramaticaListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProg([NotNull] GramaticaParser.ProgContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProg([NotNull] GramaticaParser.ProgContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStart([NotNull] GramaticaParser.StartContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStart([NotNull] GramaticaParser.StartContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.end"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnd([NotNull] GramaticaParser.EndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.end"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnd([NotNull] GramaticaParser.EndContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.input"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInput([NotNull] GramaticaParser.InputContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.input"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInput([NotNull] GramaticaParser.InputContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.propositions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPropositions([NotNull] GramaticaParser.PropositionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.propositions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPropositions([NotNull] GramaticaParser.PropositionsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.proposition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProposition([NotNull] GramaticaParser.PropositionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.proposition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProposition([NotNull] GramaticaParser.PropositionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.instruction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInstruction([NotNull] GramaticaParser.InstructionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.instruction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInstruction([NotNull] GramaticaParser.InstructionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.directive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDirective([NotNull] GramaticaParser.DirectiveContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.directive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDirective([NotNull] GramaticaParser.DirectiveContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabel([NotNull] GramaticaParser.LabelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabel([NotNull] GramaticaParser.LabelContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.instr_args"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInstr_args([NotNull] GramaticaParser.Instr_argsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.instr_args"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInstr_args([NotNull] GramaticaParser.Instr_argsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.instr_args2"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInstr_args2([NotNull] GramaticaParser.Instr_args2Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.instr_args2"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInstr_args2([NotNull] GramaticaParser.Instr_args2Context context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.directive_args"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDirective_args([NotNull] GramaticaParser.Directive_argsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.directive_args"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDirective_args([NotNull] GramaticaParser.Directive_argsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="GramaticaParser.compileUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompileUnit([NotNull] GramaticaParser.CompileUnitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GramaticaParser.compileUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompileUnit([NotNull] GramaticaParser.CompileUnitContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace SICXE
