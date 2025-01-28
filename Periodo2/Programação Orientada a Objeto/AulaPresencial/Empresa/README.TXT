## ENUNCIADO

Uma empresa possui diversos funcionário. Cada funcionário é 
remunerado da seguinte forma:
salario bruto - 13% de inss - 3% se usar vale transporte 
+ R$115,00 por filho, até o limite de 3 filhos. 
Se o cargo for de gerencia, ganha 10% do bruto.

Quanto ganha todos os funcionário da empresa.

classes:
*empresa: necessaria para saber quanto ganha todos os funcionarios da empresa
atributos: funcionarios, nome
metodos: totalSalarios

*funcionario:
atributos: nome, salarioBruto, filhos, usa_ValeTransporte, cargo(cargo nao eh classe pois eh necessario
saber apenas se eh ou nao gerente)
metodos: salarioLiq