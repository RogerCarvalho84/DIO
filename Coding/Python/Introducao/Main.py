from conta_corrente import Conta

conta_do_roger = ContaCorrente(15)
print(conta_do_roger)

conta_do_roger.deposita(100)
print(conta_do_roger)

conta_da_mires = ContaCorrente(4289)
print(conta_da_mires)

conta_da_mires.deposita(500)
print(conta_da_mires)

contas = [conta_do_roger,conta_da_mires]
for conta in contas:
    print(conta)



'''
idade1 = 73
idade2 = 64
idade3 = 19
print(idade1)
print(idade2)
print(idade3)

idades = [73, 64, 19]
print(idades)

idades.append(16)
print(idades)

for qualquercoisa in idades:
    print(qualquercoisa)'''