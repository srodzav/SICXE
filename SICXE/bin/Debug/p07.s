EVALUA	START	12AFH
CAD	BYTE	C'PRUEBA'
	ADD	MIN
MAIN	RESB	250
SUBR	LDA	CAD,X
	STCH	AUX,X
MAIN	RESW	500
VALOR	BYTE	X'032FA1242'
	JQE	SUBR
MEM	WORD	400
LDX	WD	MEM,X
NUM	WORD	400
NUM	WORD	99
AUX	BYTE	C'ON'
MAIN	LDCH	TEXT,X
	CMP	NUM
	BYTE	H'32'
MAIN	LDX	NUM
	RESW	100
	LDCH	CAD,X
	END	SUBR
