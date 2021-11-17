from abc import ABCMeta, abstractmethod

class Conta(metaclass=ABCMeta):
    def __init__(self, codigo):
        self._codigo = codigo
        self._saldo = 0

    def deposita(self, valor):
        self._saldo += valor

    @abstractmethod
    def passa_o_mes(self):
        pass

    def __str__(self):
        return "[>>Codigo {} Saldo {}<<]".format(self._codigo, self._saldo)

class ContaCorrente(Conta):
    def passa_o_mes(self):
        self._saldo -= 2

class ContaPoupanca(Conta):
    def passa_o_mes(self):
        self._saldo *= 1.01
        self._saldo -= 3


class ContaInvestimento(Conta):
    def passa_o_mes(self):
        self._saldo *= 1.05
        self._saldo -=2



conta16 = ContaCorrente(16)
conta16.deposita(1000)

conta20 = ContaPoupanca(20)
conta20.deposita(1000)

conta32 = ContaInvestimento(32)
conta32.deposita(1000)

contas = [conta16,conta20, conta32]

for conta in contas:
    conta.passa_o_mes()
    print(conta)


class ContaSalario:

    def __init__(self, codigo):
        self._codigo = codigo
        self._saldo = 0

    def __eq__(self, outro):
        if type(outro) != ContaSalario:
            return False

        return self._codigo == outro._codigo and self._saldo == outro._saldo

    def deposita(self, valor):
        self._saldo += valor

    def __str__(self):
        return "[>>Código {} Saldo {} <<]".format(self._codigo, self._saldo)

conta1 = ContaSalario(37)
print(conta1)
conta2 = ContaSalario(37)

conta1.deposita(100)

print(conta1 == conta2)

conta3 = ContaSalario(50)
conta4 = ContaCorrente(50)

print(conta3 == conta4)


print(isinstance(ContaCorrente(92), ContaCorrente))

print(isinstance(ContaCorrente(92), Conta))