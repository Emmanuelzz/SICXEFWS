grammar SICXE;

compileUnit
    :   programa EOF
    ;

programa
    :   (inicio FINL*)+ (fin2 | FINL | EOF)
    ;

inicio
    :   etiqueta 'START' NUM? (FINL | WS)*
    |   proposicion
    ;

fin2
    :   END (ID | CONSTCAD | etiqueta_con_espacios)?
    ;


entrada
    :   ID
    |   e
    ;

proposiciones
    :   (proposicion FINL*)+ proposicion
    ;

proposicion
    :   instruccion
    |   directiva
    ;

instruccion
    :   etiqueta formato2
    |   etiqueta formato1
    |   etiqueta formato3
    ;

formato1
    :   CODOPF1
    ;

formato2
    :   CODOPF2 (registro (',' registro)?)?
	|   INSTRN (registro (',' NUM)?)?
	|   INSTRUNIC ( NUM)?
    ;

formato3
    :   ('+'? CODOPF34) (ID | '#' NUM | '@' ID | '#' ID | '@' NUM | NUM ',' 'X' | ID ',' 'X')?
    |   'RSUB'
    ;


directiva
    :    etiqueta direc
    ;

direc
    :   (WS* 'BYTE' WS*) opdirectiva_byte (FINL | WS)* 
    |   tipodirectiva opdirectiva (FINL | WS)*
    ;


opdirectiva_byte
    :   CONSTCAD_TEXT
    |   CONSTCAD_HEX
    ;

CONSTCAD_TEXT
    :   'C' '\'' .*? '\'' 
    ;

CONSTCAD_HEX
    :   'X' '\'' [0-9A-Fa-f]+ '\''
    ;


tipodirectiva
    :   'BYTE'
    |   'WORD'
    |   'RESB'
    |   'RESW'
    |   'BASE'
    ;

etiqueta
    :   ID
    |   e
    ;

etiqueta_con_espacios
    :   ID WS+ ID
    ;

opdirectiva
    :   NUM
    |   CONSTHEX
    |   CONSTCAD
	|   ID
    ;

CODOPF1
    :   'FIX' | 'FLOAT' | 'HIO' | 'NORM' | 'SIO' | 'TIO'  
    ;

INSTRN
    :   'SHIFTL' |  'SHIFTR'
    ;

INSTRUNIC
    :   'SVC' 
    ;

CODOPF2
    :   'ADDR' | 'CLEAR' | 'DIVR' | 'RMO' | 'SUBR' | 'SVC' | 'TIXR' 
    ;

CODOPF34
    :   'LDA' | 'LDX' | 'LDB'  | 'TIX' | 'JLT' | 'STA' | 'ADD' 
	|	'RD' | 'MUL' | 'MULF'  | 'JSUB' | 'JGT' | 'WD' | 'LPS' |  'J'
    |	'STL' | 'COMP' | 'JEQ'  | 'LDL' | 'TD' | 'STCH' | 'STX' |  'LDCH' 
    ;

registro
    :   REG
    |   'X'
    |   'A'
    |   'L'
    |   'B'
    |   'S'
    |   'T'
    |   'F'
    ;


END
    :   'END'
    ;

ID
    :   [a-zA-Z][a-zA-Z0-9]+
    ;


NUM
    :   [0-9]+[h]*[H]*
    ;

CONSTHEX
    :   '0x' [0-9A-Fa-f]+
    ;

CONSTCAD
    :   '\'' .*? '\''
    ;

FINL
    :   '\n' | '\r\n'
    ;

WS
    :   [ \t]+ -> skip
    ;

e
    :   // Regla vacía
    ;

INVALID
    :   .   // Captura cualquier cosa que no sea un token válido
    ;


