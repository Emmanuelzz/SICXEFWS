//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\emman\OneDrive\Documentos\Semestre 8\LABFWS\SICXEFWS\SICXE\analizadorLS.g4 by ANTLR 4.6.6

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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="analizadorLSParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IanalizadorLSListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="analizadorLSParser.programa"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrograma([NotNull] analizadorLSParser.ProgramaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="analizadorLSParser.programa"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrograma([NotNull] analizadorLSParser.ProgramaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="analizadorLSParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInicio([NotNull] analizadorLSParser.InicioContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="analizadorLSParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInicio([NotNull] analizadorLSParser.InicioContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="analizadorLSParser.proposicion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProposicion([NotNull] analizadorLSParser.ProposicionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="analizadorLSParser.proposicion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProposicion([NotNull] analizadorLSParser.ProposicionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="analizadorLSParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstruccion([NotNull] analizadorLSParser.InstruccionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="analizadorLSParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstruccion([NotNull] analizadorLSParser.InstruccionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="analizadorLSParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDirectiva([NotNull] analizadorLSParser.DirectivaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="analizadorLSParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDirectiva([NotNull] analizadorLSParser.DirectivaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="analizadorLSParser.opinstruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpinstruccion([NotNull] analizadorLSParser.OpinstruccionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="analizadorLSParser.opinstruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpinstruccion([NotNull] analizadorLSParser.OpinstruccionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="analizadorLSParser.tipodirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTipodirectiva([NotNull] analizadorLSParser.TipodirectivaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="analizadorLSParser.tipodirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTipodirectiva([NotNull] analizadorLSParser.TipodirectivaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="analizadorLSParser.opvalor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpvalor([NotNull] analizadorLSParser.OpvalorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="analizadorLSParser.opvalor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpvalor([NotNull] analizadorLSParser.OpvalorContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="analizadorLSParser.fin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFin([NotNull] analizadorLSParser.FinContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="analizadorLSParser.fin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFin([NotNull] analizadorLSParser.FinContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="analizadorLSParser.etiqueta"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEtiqueta([NotNull] analizadorLSParser.EtiquetaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="analizadorLSParser.etiqueta"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEtiqueta([NotNull] analizadorLSParser.EtiquetaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="analizadorLSParser.formato"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormato([NotNull] analizadorLSParser.FormatoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="analizadorLSParser.formato"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormato([NotNull] analizadorLSParser.FormatoContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="analizadorLSParser.f1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterF1([NotNull] analizadorLSParser.F1Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="analizadorLSParser.f1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitF1([NotNull] analizadorLSParser.F1Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="analizadorLSParser.f2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterF2([NotNull] analizadorLSParser.F2Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="analizadorLSParser.f2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitF2([NotNull] analizadorLSParser.F2Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="analizadorLSParser.f3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterF3([NotNull] analizadorLSParser.F3Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="analizadorLSParser.f3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitF3([NotNull] analizadorLSParser.F3Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="analizadorLSParser.f4"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterF4([NotNull] analizadorLSParser.F4Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="analizadorLSParser.f4"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitF4([NotNull] analizadorLSParser.F4Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="analizadorLSParser.simple3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimple3([NotNull] analizadorLSParser.Simple3Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="analizadorLSParser.simple3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimple3([NotNull] analizadorLSParser.Simple3Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="analizadorLSParser.indirecto3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndirecto3([NotNull] analizadorLSParser.Indirecto3Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="analizadorLSParser.indirecto3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndirecto3([NotNull] analizadorLSParser.Indirecto3Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="analizadorLSParser.inmediato3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInmediato3([NotNull] analizadorLSParser.Inmediato3Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="analizadorLSParser.inmediato3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInmediato3([NotNull] analizadorLSParser.Inmediato3Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="analizadorLSParser.opdirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpdirectiva([NotNull] analizadorLSParser.OpdirectivaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="analizadorLSParser.opdirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpdirectiva([NotNull] analizadorLSParser.OpdirectivaContext context);
}
} // namespace SICXE
