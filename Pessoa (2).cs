namespace Batata {

public class program {



static list<string> itens =new list<string>();



static void main(){

int op=0;

do{

console.writeline("1-(c) criar um nome");

console.writeline("2-(r) criar um nome");

console.writeline("3-(u) criar um nome");

console.writeline("4-(d) criar um nome");

console.writeline ("5- para sair");


op = convert.toint32(console.readline());

switch (op){

case 1 :
criarnome(){

}
break;

case 2 :
lernomes(){

}
break;

case 3:
break;

case 4 :
break;

case 5:
console.writeline("tchau até mais.");
break;

default:
break;
 console.writeline("opção invalida.");




}while (op !=5);


}

static void criarnome(){
console.writeline("digite um nome :");
string nome = console.readline()?? "";

itens.ADD (nome);
console,writeline($"o nome:{nome}, foi adicionado com sucesso ");


}










}


}
{
    
}

















}
    