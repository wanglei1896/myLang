// Signature file for parser generated by fsyacc
module CPar
type token = 
  | EOF
  | LPAR
  | RPAR
  | LBRACE
  | RBRACE
  | LBRACK
  | RBRACK
  | COLON
  | QUES
  | SEMI
  | COMMA
  | ASSIGN
  | AMP
  | NOT
  | SEQOR
  | SEQAND
  | EQ
  | NE
  | GT
  | LT
  | GE
  | LE
  | PLUS
  | MINUS
  | TIMES
  | DIV
  | MOD
  | BREAK
  | CASE
  | CHAR
  | DO
  | ELSE
  | FOR
  | IF
  | INT
  | NULL
  | PRINT
  | PRINTC
  | PRINTS
  | PRINTLN
  | RETURN
  | SWITCH
  | VOID
  | WHILE
  | CSTSTRING of (string)
  | NAME of (string)
  | CSTINT of (int)
  | CSTBOOL of (int)
type tokenId = 
    | TOKEN_EOF
    | TOKEN_LPAR
    | TOKEN_RPAR
    | TOKEN_LBRACE
    | TOKEN_RBRACE
    | TOKEN_LBRACK
    | TOKEN_RBRACK
    | TOKEN_COLON
    | TOKEN_QUES
    | TOKEN_SEMI
    | TOKEN_COMMA
    | TOKEN_ASSIGN
    | TOKEN_AMP
    | TOKEN_NOT
    | TOKEN_SEQOR
    | TOKEN_SEQAND
    | TOKEN_EQ
    | TOKEN_NE
    | TOKEN_GT
    | TOKEN_LT
    | TOKEN_GE
    | TOKEN_LE
    | TOKEN_PLUS
    | TOKEN_MINUS
    | TOKEN_TIMES
    | TOKEN_DIV
    | TOKEN_MOD
    | TOKEN_BREAK
    | TOKEN_CASE
    | TOKEN_CHAR
    | TOKEN_DO
    | TOKEN_ELSE
    | TOKEN_FOR
    | TOKEN_IF
    | TOKEN_INT
    | TOKEN_NULL
    | TOKEN_PRINT
    | TOKEN_PRINTC
    | TOKEN_PRINTS
    | TOKEN_PRINTLN
    | TOKEN_RETURN
    | TOKEN_SWITCH
    | TOKEN_VOID
    | TOKEN_WHILE
    | TOKEN_CSTSTRING
    | TOKEN_NAME
    | TOKEN_CSTINT
    | TOKEN_CSTBOOL
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startMain
    | NONTERM_Main
    | NONTERM_Topdecs
    | NONTERM_Topdec
    | NONTERM_Vardec
    | NONTERM_Vardesc
    | NONTERM_Fundec
    | NONTERM_Paramdecs
    | NONTERM_Paramdecs1
    | NONTERM_Block
    | NONTERM_StmtOrDecSeq
    | NONTERM_Stmt
    | NONTERM_StmtM
    | NONTERM_SwitchC
    | NONTERM_StmtU
    | NONTERM_Expr
    | NONTERM_ExprNotAccess
    | NONTERM_AtExprNotAccess
    | NONTERM_Access
    | NONTERM_Exprs
    | NONTERM_Exprs1
    | NONTERM_Const
    | NONTERM_Type
/// This function maps integers indexes to symbolic token ids
val tagOfToken: token -> int

/// This function maps integers indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val Main : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> (Absyn.program) 
