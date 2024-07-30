grammar Question3;

question3:
    'hello' (identifier|'hello')+ EOF
    ;
identifier :
    W (W|N)*;



W : [a-zA-Z$_] ;

N : [0-9] ;