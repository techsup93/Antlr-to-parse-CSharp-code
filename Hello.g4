//grammar Hello;            // Define a grammar called Hello
//r  : 'hello' ID {print("hello " + $ID.text)} ;         // match keyword hello followed by an identifier
//ID : [a-z]+ ;             // match lower-case identifiers
//WS : [ \t\r\n]+ -> skip; // skip spaces, tabs, newlines, \r (Windows)
grammar Hello;
@header {using AntlrExample;}


sts : st*;

st: ast | iFst | forst;

forst: {
LFor_condition = Fun.getLabel();
LFor_end = Fun.getLabel();
LFor_ast = Fun.getLabel();
LFor_block = Fun.getLabel();
}
'for'
'('
ast ',' {Fun.emitln(LFor_condition+":")} e
{
eval = Fun.PopTV()

if (Fun.isTemp(eval)) {
	Fun.emitln(eval+"="+ eval+"==0");
	Fun.emitln("if not "+eval+" goto "+LFor_end);
	Fun.removeTemp();
    }

else {
    newTemp = Fun.getTemp();
    Fun.emitln(newTemp+"="+ eval+"==0");
    Fun.emitln("if not "+newTemp+" goto "+LFor_end);
	Fun.removeTemp();
    }

} {Fun.emitln("goto "+ LFor_block)}

',' {Fun.emitln(LFor_ast+":")} ast {Fun.emitln("goto "+ LFor_condition)}
 ')' {Fun.emitln(LFor_block+":")} block {Fun.emitln("goto "+ LFor_ast)}
{Fun.emitln(LFor_end+":")};

iFst: 'if' '(' e ')' {
Lend = Fun.getLabel()
eval = Fun.PopTV()
if (Fun.isTemp(eval)){
	Fun.emitln(eval+"="+ eval+"==0")
	Fun.emitln("if not "+eval+" goto "+Lend)
	Fun.removeTemp()
    }
else {
    newTemp = Fun.getTemp();
    Fun.emitln(newTemp+"="+ eval+"==0");
	Fun.emitln("if not "+newTemp+" goto "+Lend);
	Fun.removeTemp();
    }

}  block {write = False;}(
{
Lendelse = Fun.getLabel();
Fun.emitln("goto "+Lendelse);
Fun.emitln(Lend + ":");
write = True;
}
'else' block  {Fun.emitln(Lendelse + ":");})? {if not write: Fun.emitln(Lend + ":");};

block: '{' sts '}' | st;

ast : ID '=' e {
eval = Fun.PopTV();
Fun.emitln($ID.text + "=" + eval);
if (Fun.isTemp(eval))
    Fun.removeTemp();
};

//r  : 'hello' ID {print("hello " + $ID.text)} ;         // match keyword hello followed by an identifier
e : t ({Op = ""} (ADD{Op = $ADD.text}|SUB{Op = $SUB.text}) e{
eval = Fun.PopTV();
tval = Fun.PopTV();
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
        newTemp = Fun.getTemp();
        Fun.emitln(str(newTemp) + "=" + str(tval) + Op + str(eval));
        Fun.PushToken(newTemp);
        }
     }
})?;
t : f ({Op = ""} (MUL{Op = $MUL.text}|DIV{Op = $DIV.text}) t{

tval = Fun.PopTV();
fval = Fun.PopTV();

if (Fun.isTemp(fval)) {
    Fun.emitln(fval + "=" + fval + Op + tval);
    if (Fun.isTemp(tval))
        Fun.removeTemp()
    Fun.PushToken(fval);
    }
else{
    if (Fun.isTemp(tval)) {
        Fun.emitln(tval + "=" + fval + Op + tval)
        Fun.PushToken(tval)
        }
    else
    {
        newTemp = Fun.getTemp();
        Fun.emitln(str(newTemp) + "=" + str(fval) + Op + str(tval));
        Fun.PushToken(newTemp);
        }
  }
})?;
f : ID {Fun.PushToken($ID);} | No {Fun.PushToken($No);} | '('e')';

ID  :('a'..'z'|'A'..'Z'|'_')
       ('a'..'z'|'A'..'Z'|'0'..'9'|'_')* ;

No :	'0'..'9'+ ;

WS  :   ( ' '| '\t' | '\r' | '\n') ->skip;

MUL  : '*';
DIV  : '/';
ADD  : '+';
SUB  : '-';